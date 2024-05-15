﻿// <copyright file="FmlParseVisitor.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CA = System.Diagnostics.CodeAnalysis;

using static FmlMappingParser;
using static Microsoft.Health.Fhir.MappingLanguage.VisitorUtilities;
using Antlr4.Runtime;
using Microsoft.Health.Fhir.CodeGenCommon.FhirExtensions;
using Hl7.Fhir.Model;
using System.Diagnostics.Metrics;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Microsoft.Health.Fhir.CodeGenCommon.Extensions;
using System.Globalization;
using System.Collections;

namespace Microsoft.Health.Fhir.MappingLanguage;

public class FmlParseVisitor : FmlMappingBaseVisitor<object>
{
    private Dictionary<int, ParsedCommentNode> _comments;
    private int _lastStopIndex = -1;

    private Dictionary<string, MetadataDeclaration> _metaByPath = [];
    private Dictionary<string, EmbeddedConceptMapDeclaration> _embeddedConceptMapsByUrl = [];
    private MapDeclaration? _mapDirective = null;
    private Dictionary<string, StructureDeclaration> _structuresByUrl = [];
    private Dictionary<string, ImportDeclaration> _importsByUrl = [];
    private Dictionary<string, ConstantDeclaration> _constantsByName = [];
    private Dictionary<string, GroupDeclaration> _groupsByName = [];

    public FmlParseVisitor(Dictionary<int, ParsedCommentNode>? comments = null)
    {
        _comments = comments ?? [];
    }

    public FhirStructureMap GetCurrentMap()
    {
        return new FhirStructureMap()
        {
            MetadataByPath = _metaByPath,
            EmbeddedConceptMapsByUrl = _embeddedConceptMapsByUrl,
            MapDirective = _mapDirective,
            StructuresByUrl = _structuresByUrl,
            ImportsByUrl = _importsByUrl,
            ConstantsByName = _constantsByName,
            GroupsByName = _groupsByName,
        };
    }
    
    public override object VisitStructureMap([NotNull] StructureMapContext ctx)
    {
        // reset top level data structures
        _metaByPath = [];
        _mapDirective = null;
        _structuresByUrl = [];
        _importsByUrl = [];
        _constantsByName = [];
        _groupsByName = [];

        return base.VisitStructureMap(ctx);
    }

    private List<string> GetPrefixComments(ParserRuleContext ctx)
    {
        return VisitorUtilities.GetPrefixComments(ctx, _comments);
    }

    private List<string> GetPostfixComments(ParserRuleContext ctx)
    {
        return VisitorUtilities.GetPostfixComments(ctx, _comments);
    }

    public override object VisitMetadataDeclaration([NotNull] MetadataDeclarationContext context)
    {
        MetadataDeclaration value = new()
        {
            ElementPath = GetString(context.qualifiedIdentifier())!,
            Literal = GetLiteral(context.literal(), _comments),
            MarkdownValue = GetString(context.markdownLiteral()),

            RawText = context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(context),
            PostfixComments = GetPostfixComments(context),
            Line = context.Start.Line,
            Column = context.Start.Column,
            StartIndex = context.Start.StartIndex,
            StopIndex = context.Stop.StopIndex,
        };

        if (!string.IsNullOrEmpty(value.ElementPath))
        {
            _metaByPath[value.ElementPath] = value;
        }

        return base.VisitMetadataDeclaration(context);
    }

    public override object VisitConceptMapDeclaration([NotNull] ConceptMapDeclarationContext context)
    {
        Dictionary<string, EmbeddedConceptMapPrefix> prefixes = [];

        foreach (ConceptMapPrefixContext prefixContext in context.conceptMapPrefix())
        {
            string id = GetString(prefixContext.ID())!;
            prefixes.Add(id, new EmbeddedConceptMapPrefix
            {
                Prefix = id,
                Url = GetString(prefixContext.url()) ?? throw new Exception($"Embedded concept maps require a URL ({context.url().GetText()}:{prefixContext.ID().GetText()})"),

                RawText = prefixContext.Start.InputStream.GetText(new Interval(prefixContext.Start.StartIndex, prefixContext.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(prefixContext),
                PostfixComments = GetPostfixComments(prefixContext),
                Line = prefixContext.Start.Line,
                Column = prefixContext.Start.Column,
                StartIndex = prefixContext.Start.StartIndex,
                StopIndex = prefixContext.Stop.StopIndex,
            });
        }

        List<EmbeddedConceptMapCodeMap> codeMaps = [];

        foreach (ConceptMapCodeMapContext codeMapContext in context.conceptMapCodeMap())
        {
            codeMaps.Add(new()
            {
                SourcePrefix = GetString(codeMapContext.conceptMapSource().ID())!,
                SourceCode = GetString(codeMapContext.conceptMapSource().code())!,
                TargetPrefix = GetString(codeMapContext.conceptMapTarget().ID())!,
                TargetCode = GetString(codeMapContext.conceptMapTarget().code())!,

                RawText = codeMapContext.Start.InputStream.GetText(new Interval(codeMapContext.Start.StartIndex, codeMapContext.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(codeMapContext),
                PostfixComments = GetPostfixComments(codeMapContext),
                Line = codeMapContext.Start.Line,
                Column = codeMapContext.Start.Column,
                StartIndex = codeMapContext.Start.StartIndex,
                StopIndex = codeMapContext.Stop.StopIndex,
            });
        }

        string url = context.url().GetText();

        _embeddedConceptMapsByUrl.Add(url, new()
        {
            Url = url,
            Prefixes = prefixes,
            CodeMaps = codeMaps,

            RawText = context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(context),
            PostfixComments = GetPostfixComments(context),
            Line = context.Start.Line,
            Column = context.Start.Column,
            StartIndex = context.Start.StartIndex,
            StopIndex = context.Stop.StopIndex,
        });

        return base.VisitConceptMapDeclaration(context);
    }

    public override object VisitMapDeclaration([NotNull] MapDeclarationContext context)
    {
        _mapDirective = new()
        {
            Url = context.url().GetText(),
            Identifier = context.identifier().GetText(),
            IdentifierTokenType = (FmlTokenTypeCodes)context.identifier().Stop.Type,

            RawText = context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(context),
            PostfixComments = GetPostfixComments(context),
            Line = context.Start.Line,
            Column = context.Start.Column,
            StartIndex = context.Start.StartIndex,
            StopIndex = context.Stop.StopIndex,
        };

        return base.VisitMapDeclaration(context);
    }

    public override object VisitStructureDeclaration([NotNull] StructureDeclarationContext context)
    {
        StructureDeclaration value = new()
        {
            Url = context.url().GetText(),
            Alias = context.structureAlias()?.GetText(),
            ModelModeLiteral = context.modelMode().GetText(),
            ModelMode = GetEnum<StructureMap.StructureMapModelMode>(context.modelMode().GetText()),

            RawText = context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(context),
            PostfixComments = GetPostfixComments(context),
            Line = context.Start.Line,
            Column = context.Start.Column,
            StartIndex = context.Start.StartIndex,
            StopIndex = context.Stop.StopIndex,
        };

        _structuresByUrl.Add(value.Url, value);

        return base.VisitStructureDeclaration(context);
    }

    public override object VisitImportDeclaration([NotNull] ImportDeclarationContext context)
    {
        ImportDeclaration value = new()
        {
            Url = context.url().GetText(),

            RawText = context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(context),
            PostfixComments = GetPostfixComments(context),
            Line = context.Start.Line,
            Column = context.Start.Column,
            StartIndex = context.Start.StartIndex,
            StopIndex = context.Stop.StopIndex,
        };

        _importsByUrl.Add(value.Url, value);

        return base.VisitImportDeclaration(context);
    }

    public override object VisitConstantDeclaration([NotNull] ConstantDeclarationContext context)
    {
        ConstantDeclaration value = new()
        {
            Name = context.ID().GetText(),
            Value = ExtractFpExpression(context.fpExpression())!,

            RawText = context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(context),
            PostfixComments = GetPostfixComments(context),
            Line = context.Start.Line,
            Column = context.Start.Column,
            StartIndex = context.Start.StartIndex,
            StopIndex = context.Stop.StopIndex,
        };

        _constantsByName.Add(value.Name, value);

        return base.VisitConstantDeclaration(context);
    }

    public override object VisitGroupDeclaration([NotNull] GroupDeclarationContext context)
    {
        List<GroupParameter> parameters = [];

        foreach (ParameterContext parameterContext in context.parameters().parameter())
        {
            parameters.Add(new GroupParameter
            {
                InputModeLiteral = GetString(parameterContext.inputMode())!,
                InputMode = GetEnum<StructureMap.StructureMapInputMode>(GetString(parameterContext.inputMode())!),
                Identifier = GetString(parameterContext.ID())!,
                TypeIdentifier = GetString(parameterContext.typeIdentifier()?.identifier())!,

                RawText = parameterContext.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(parameterContext),
                PostfixComments = GetPostfixComments(parameterContext),
                Line = parameterContext.Start.Line,
                Column = parameterContext.Start.Column,
                StartIndex = parameterContext.Start.StartIndex,
                StopIndex = parameterContext.Stop.StopIndex,
            });
        }

        List<GroupExpression> expressions = [];

        foreach (ExpressionContext expressionContext in context.groupExpressions().expression())
        {
            expressions.Add(ExtractGroupExpression(expressionContext) ?? throw new Exception("Failed to parse expression!"));
        }

        GroupDeclaration value = new()
        {
            Name = context.ID().GetText(),
            Parameters = parameters,
            ExtendsIdentifier = GetString(context.extends()),
            TypeModeLiteral = GetString(context.typeMode()),
            TypeMode = GetTypeMode(GetString(context.typeMode())),              // note this is handled differently because the FML values are different than the FHIR values
            Expressions = expressions,

            RawText = context.Start.InputStream.GetText(new Interval(context.Start.StartIndex, context.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(context),
            PostfixComments = GetPostfixComments(context),
            Line = context.Start.Line,
            Column = context.Start.Column,
            StartIndex = context.Start.StartIndex,
            StopIndex = context.Stop.StopIndex,
        };

        _groupsByName.Add(value.Name, value);

        return base.VisitGroupDeclaration(context);

        StructureMap.StructureMapGroupTypeMode? GetTypeMode(string? value) => value switch
        {
            "type+" => StructureMap.StructureMapGroupTypeMode.TypeAndTypes,
            "<<type+>>" => StructureMap.StructureMapGroupTypeMode.TypeAndTypes,
            "type-and-types" => StructureMap.StructureMapGroupTypeMode.TypeAndTypes,
            "<<type-and-types>>" => StructureMap.StructureMapGroupTypeMode.TypeAndTypes,
            "type" => StructureMap.StructureMapGroupTypeMode.Types,
            "<<type>>" => StructureMap.StructureMapGroupTypeMode.Types,
            _ => null,
        };
    }

    private GroupExpression? ExtractGroupExpression(ExpressionContext? ctx)
    {
        if (ctx == null)
        {
            return null;
        }

        switch (ctx)
        {
            case MapSimpleCopyContext mapSimpleCopy:
                {
                    if (mapSimpleCopy.qualifiedIdentifier() == null || mapSimpleCopy.qualifiedIdentifier().Length != 2)
                    {
                        throw new Exception("MapSimpleCopyContext missing required source and target");
                    }

                    return new GroupExpression
                    {
                        SimpleCopyExpression = new()
                        {
                            Source = GetString(mapSimpleCopy.qualifiedIdentifier()[0])!,
                            Target = GetString(mapSimpleCopy.qualifiedIdentifier()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case MapFhirPathContext mapFhirPath:
                return new GroupExpression
                {
                    FhirPathExpression = ExtractFpExpression(mapFhirPath.fpExpression()),

                    RawText = mapFhirPath.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(mapFhirPath),
                    PostfixComments = GetPostfixComments(mapFhirPath),
                    Line = mapFhirPath.Start.Line,
                    Column = mapFhirPath.Start.Column,
                    StartIndex = mapFhirPath.Start.StartIndex,
                    StopIndex = mapFhirPath.Stop.StopIndex,
                };

            case MapFhirMarkupContext mapFhirMarkup:
                return new GroupExpression
                {
                    MappingExpression = ExtractFmlMappingExpression(mapFhirMarkup.mapExpression()),

                    RawText = mapFhirMarkup.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(mapFhirMarkup),
                    PostfixComments = GetPostfixComments(mapFhirMarkup),
                    Line = mapFhirMarkup.Start.Line,
                    Column = mapFhirMarkup.Start.Column,
                    StartIndex = mapFhirMarkup.Start.StartIndex,
                    StopIndex = mapFhirMarkup.Stop.StopIndex,
                };
        }

        throw new Exception("Unhandled GroupExpression type");
    }

    private FmlGroupExpression? ExtractFmlMappingExpression(MapExpressionContext? ctx)
    {
        if (ctx == null)
        {
            return null;
        }

        List<FmlExpressionSource> sources = [];
        foreach (MapExpressionSourceContext sourceContext in ctx.mapExpressionSource())
        {
            sources.Add(new()
            {
                Identifier = GetString(sourceContext.qualifiedIdentifier())!,
                TypeIdentifier = GetString(sourceContext.typeIdentifier()?.identifier())!,
                Cardinality = GetString(sourceContext.sourceCardinality())!,
                DefaultExpression = ExtractFpExpression(sourceContext.sourceDefault()?.fpExpression()),
                ListModeLiteral = GetString(sourceContext.sourceListMode()),
                ListMode = GetEnum<StructureMap.StructureMapSourceListMode>(GetString(sourceContext.sourceListMode())),
                Alias = GetString(sourceContext.alias()),
                WhereClause = ExtractFpExpression(sourceContext.whereClause()?.fpExpression()),
                CheckClause = ExtractFpExpression(sourceContext.checkClause()?.fpExpression()),
                LogExpression = ExtractFpExpression(sourceContext.log()?.fpExpression()),

                RawText = sourceContext.Start.InputStream.GetText(new Interval(sourceContext.Start.StartIndex, sourceContext.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(sourceContext),
                PostfixComments = GetPostfixComments(sourceContext),
                Line = sourceContext.Start.Line,
                Column = sourceContext.Start.Column,
                StartIndex = sourceContext.Start.StartIndex,
                StopIndex = sourceContext.Stop.StopIndex,
            });
        }

        List<FmlExpressionTarget> targets = [];
        foreach (MapLineTargetContext targetContext in ctx.mapExpressionTarget()?.mapLineTarget() ?? [])
        {
            targets.Add(new()
            {
                Identifier = GetString(targetContext.qualifiedIdentifier())!,
                Transform = targetContext.transform() == null ? null : new FmlTargetTransform()
                {
                    Literal = GetLiteral(targetContext.transform()?.literal(), _comments),
                    Identifier = GetString(targetContext.transform()?.qualifiedIdentifier()),
                    Invocation = ExtractInvocation(targetContext.transform()?.invocation()),

                    RawText = targetContext.transform().Start.InputStream.GetText(new Interval(targetContext.transform().Start.StartIndex, targetContext.transform().Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(targetContext.transform()),
                    PostfixComments = GetPostfixComments(targetContext.transform()),
                    Line = targetContext.transform().Start.Line,
                    Column = targetContext.transform().Start.Column,
                    StartIndex = targetContext.transform().Start.StartIndex,
                    StopIndex = targetContext.transform().Stop.StopIndex,
                },
                Invocation = ExtractInvocation(targetContext.invocation()),
                Alias = GetString(targetContext.alias()),
                TargetListModeLiteral = GetString(targetContext.targetListMode()),
                TargetListMode = GetEnum<StructureMap.StructureMapTargetListMode>(GetString(targetContext.targetListMode())),

                RawText = targetContext.Start.InputStream.GetText(new Interval(targetContext.Start.StartIndex, targetContext.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(targetContext),
                PostfixComments = GetPostfixComments(targetContext),
                Line = targetContext.Start.Line,
                Column = targetContext.Start.Column,
                StartIndex = targetContext.Start.StartIndex,
                StopIndex = targetContext.Stop.StopIndex,
            });
        }

        return new FmlGroupExpression()
        {
            Sources = sources,
            Targets = targets,
            DependentExpression = ExtractDependentExpression(ctx.dependentExpression()),
            Name = GetString(ctx.mapExpressionName()),

            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
            PrefixComments = GetPrefixComments(ctx),
            PostfixComments = GetPostfixComments(ctx),
            Line = ctx.Start.Line,
            Column = ctx.Start.Column,
            StartIndex = ctx.Start.StartIndex,
            StopIndex = ctx.Stop.StopIndex,
        };

        FmlDependentExpression? ExtractDependentExpression(DependentExpressionContext? ctx)
        {
            if (ctx == null)
            {
                return null;
            }

            List<FmlInvocation> invocations = [];
            foreach (InvocationContext invocationContext in ctx.invocation())
            {
                invocations.Add(ExtractInvocation(invocationContext)!);
            }

            List<GroupExpression> expressions = [];
            foreach (ExpressionContext expressionContext in ctx.groupExpressions()?.expression() ?? Array.Empty<ExpressionContext>())
            {
                expressions.Add(ExtractGroupExpression(expressionContext) ?? throw new Exception("Failed to parse expression!"));
            }

            return new FmlDependentExpression
            {
                Invocations = invocations,
                Expressions = expressions,

                RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(ctx),
                PostfixComments = GetPostfixComments(ctx),
                Line = ctx.Start.Line,
                Column = ctx.Start.Column,
                StartIndex = ctx.Start.StartIndex,
                StopIndex = ctx.Stop.StopIndex,
            };
        }

        FmlInvocation? ExtractInvocation(InvocationContext? ctx)
        {
            if (ctx == null)
            {
                return null;
            }

            List<FmlInvocationParam> p = [];
            foreach (ParamContext param in ctx.paramList().param())
            {
                p.Add(new()
                {
                    Identifier = GetString(param.ID())!,
                    Literal = GetLiteral(param.literal(), _comments),

                    RawText = param.Start.InputStream.GetText(new Interval(param.Start.StartIndex, param.Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(param),
                    PostfixComments = GetPostfixComments(param),
                    Line = param.Start.Line,
                    Column = param.Start.Column,
                    StartIndex = param.Start.StartIndex,
                    StopIndex = param.Stop.StopIndex,
                });
            }

            return new FmlInvocation
            {
                Identifier = GetString(ctx.identifier())!,
                Parameters = p,

                RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(ctx),
                PostfixComments = GetPostfixComments(ctx),
                Line = ctx.Start.Line,
                Column = ctx.Start.Column,
                StartIndex = ctx.Start.StartIndex,
                StopIndex = ctx.Stop.StopIndex,
            };
        }
    }

    private FpExpression? ExtractFpExpression(FpExpressionContext? ctx)
    {
        if (ctx == null)
        {
            return null;
        }

        switch (ctx)
        {
            case TermExpressionContext termContext:
                return new FpExpression
                {
                    Expression = ctx.GetText(),
                    ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                    TermExpression = extractFpTerm(termContext.fpTerm()),

                    RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(ctx),
                    PostfixComments = GetPostfixComments(ctx),
                    Line = ctx.Start.Line,
                    Column = ctx.Start.Column,
                    StartIndex = ctx.Start.StartIndex,
                    StopIndex = ctx.Stop.StopIndex,
                };

            case InvocationExpressionContext invocationContext:
                return new FpExpression
                {
                    Expression = ctx.GetText(),
                    ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                    InvocationExpression = new()
                    {
                        Expression = ExtractFpExpression(invocationContext.fpExpression()) ?? throw new Exception("InvocationExpression missing required Expression"),
                        Invocation = extractFpInvocation(invocationContext.fpInvocation()) ?? throw new Exception("InvocationExpression missing required Invocation"),

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    },

                    RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(ctx),
                    PostfixComments = GetPostfixComments(ctx),
                    Line = ctx.Start.Line,
                    Column = ctx.Start.Column,
                    StartIndex = ctx.Start.StartIndex,
                    StopIndex = ctx.Stop.StopIndex,
                };

            case IndexerExpressionContext indexerContext:
                {
                    if (indexerContext.fpExpression() == null || indexerContext.fpExpression().Length != 2)
                    {
                        throw new Exception("IndexerExpression missing required Expression and Indexer");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        IndexerExpression = new()
                        {
                            Expression = ExtractFpExpression(indexerContext.fpExpression()[0])!,
                            Index = ExtractFpExpression(indexerContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case PolarityExpressionContext polarityContext:
                return new FpExpression
                {
                    Expression = ctx.GetText(),
                    ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                    PolarityExpression = new()
                    {
                        Expression = ExtractFpExpression(polarityContext.fpExpression())!,
                        Polarity = (FmlPolarityCodes)polarityContext.fpPolarityLiteral().Stop.Type,
                        Literal = polarityContext.fpPolarityLiteral().GetText(),
                        IsPositive = polarityContext.Start.TokenIndex == (int)FmlPolarityCodes.Positive,

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    },

                    RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(ctx),
                    PostfixComments = GetPostfixComments(ctx),
                    Line = ctx.Start.Line,
                    Column = ctx.Start.Column,
                    StartIndex = ctx.Start.StartIndex,
                    StopIndex = ctx.Stop.StopIndex,
                };

            case MultiplicativeExpressionContext multiplicativeContext:
                {
                    if (multiplicativeContext.fpExpression() == null || multiplicativeContext.fpExpression().Length != 2)
                    {
                        throw new Exception("MultiplicativeExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        MultiplicativeExpression = new()
                        {
                            Left = ExtractFpExpression(multiplicativeContext.fpExpression()[0])!,
                            OperatorLiteral = multiplicativeContext.fpMultiplicativeLiteral().GetText(),
                            Operator = (FmlMultiplicativeOpCodes)multiplicativeContext.fpMultiplicativeLiteral().Stop.Type,
                            Right = ExtractFpExpression(multiplicativeContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case AdditiveExpressionContext additiveContext:
                {
                    if (additiveContext.fpExpression() == null || additiveContext.fpExpression().Length != 2)
                    {
                        throw new Exception("AdditiveExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        AdditiveExpression = new()
                        {
                            Left = ExtractFpExpression(additiveContext.fpExpression()[0])!,
                            OperatorLiteral = additiveContext.fpAdditiveLiteral().GetText(),
                            Operator = (FmlAdditiveOpCodes)additiveContext.fpAdditiveLiteral().Stop.Type,
                            Right = ExtractFpExpression(additiveContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case TypeExpressionContext typeContext:
                return new FpExpression
                {
                    Expression = ctx.GetText(),
                    ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                    TypeExpression = new()
                    {
                        Expression = ExtractFpExpression(typeContext.fpExpression())!,
                        TypeAssignmentLiteral = typeContext.fpTypeAssertionLiteral().GetText(),
                        TypeIdentifier = GetString(typeContext.fpTypeSpecifier()) ?? throw new Exception("TypeExpression missing required Type Identifier"),

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    },

                    RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                    PrefixComments = GetPrefixComments(ctx),
                    PostfixComments = GetPostfixComments(ctx),
                    Line = ctx.Start.Line,
                    Column = ctx.Start.Column,
                    StartIndex = ctx.Start.StartIndex,
                    StopIndex = ctx.Stop.StopIndex,
                };

            case UnionExpressionContext unionContext:
                {
                    if (unionContext.fpExpression() == null || unionContext.fpExpression().Length != 2)
                    {
                        throw new Exception("UnionExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        UnionExpression = new()
                        {
                            Left = ExtractFpExpression(unionContext.fpExpression()[0])!,
                            OperatorLiteral = unionContext.fpUnionLiteral().GetText(),
                            Operator = (FmlUnionOpCodes)unionContext.fpUnionLiteral().Stop.Type,
                            Right = ExtractFpExpression(unionContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case InequalityExpressionContext inequalityContext:
                {
                    if (inequalityContext.fpExpression() == null || inequalityContext.fpExpression().Length != 2)
                    {
                        throw new Exception("InequalityExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        InequalityExpression = new()
                        {
                            Left = ExtractFpExpression(inequalityContext.fpExpression()[0])!,
                            OperatorLiteral = inequalityContext.fpInequalityLiteral().GetText(),
                            Operator = (FmlInequalityOpCodes)inequalityContext.fpInequalityLiteral().Stop.Type,
                            Right = ExtractFpExpression(inequalityContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case EqualityExpressionContext equalityContext:
                {
                    if (equalityContext.fpExpression() == null || equalityContext.fpExpression().Length != 2)
                    {
                        throw new Exception("EqualityExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        EqualityExpression = new()
                        {
                            Left = ExtractFpExpression(equalityContext.fpExpression()[0])!,
                            OperatorLiteral = equalityContext.fpEqualityLiteral().GetText(),
                            Operator = (FmlEqualityOpCodes)equalityContext.fpEqualityLiteral().Stop.Type,
                            Right = ExtractFpExpression(equalityContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case MembershipExpressionContext membershipContext:
                {
                    if (membershipContext.fpExpression() == null || membershipContext.fpExpression().Length != 2)
                    {
                        throw new Exception("MembershipExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        MembershipExpression = new()
                        {
                            Left = ExtractFpExpression(membershipContext.fpExpression()[0])!,
                            OperatorLiteral = membershipContext.fpMembershipLiteral().GetText(),
                            Operator = (FmlMembershipOpCodes)membershipContext.fpMembershipLiteral().Stop.Type,
                            Right = ExtractFpExpression(membershipContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case AndExpressionContext andContext:
                {
                    if (andContext.fpExpression() == null || andContext.fpExpression().Length != 2)
                    {
                        throw new Exception("AndExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        AndExpression = new()
                        {
                            Left = ExtractFpExpression(andContext.fpExpression()[0])!,
                            OperatorLiteral = andContext.fpAndLiteral().GetText(),
                            Operator = (FmlAndOpCodes)andContext.fpAndLiteral().Stop.Type,
                            Right = ExtractFpExpression(andContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case OrExpressionContext orContext:
                {
                    if (orContext.fpExpression() == null || orContext.fpExpression().Length != 2)
                    {
                        throw new Exception("OrExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        OrExpression = new()
                        {
                            Left = ExtractFpExpression(orContext.fpExpression()[0])!,
                            OperatorLiteral = orContext.fpOrLiteral().GetText(),
                            Operator = (FmlOrOpCodes)orContext.fpOrLiteral().Stop.Type,
                            Right = ExtractFpExpression(orContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }

            case ImpliesExpressionContext impliesContext:
                {
                    if (impliesContext.fpExpression() == null || impliesContext.fpExpression().Length != 2)
                    {
                        throw new Exception("ImpliesExpression missing required Left and Right");
                    }

                    return new FpExpression
                    {
                        Expression = ctx.GetText(),
                        ExpressionRule = (FmlRuleCodes)ctx.RuleIndex,
                        ImpliesExpression = new()
                        {
                            Left = ExtractFpExpression(impliesContext.fpExpression()[0])!,
                            OperatorLiteral = impliesContext.fpImpliesLiteral().GetText(),
                            Operator = (FmlImpliesOpCodes)impliesContext.fpImpliesLiteral().Stop.Type,
                            Right = ExtractFpExpression(impliesContext.fpExpression()[1])!,

                            RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                            PrefixComments = GetPrefixComments(ctx),
                            PostfixComments = GetPostfixComments(ctx),
                            Line = ctx.Start.Line,
                            Column = ctx.Start.Column,
                            StartIndex = ctx.Start.StartIndex,
                            StopIndex = ctx.Stop.StopIndex,
                        },

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
                }
        }

        throw new Exception("Unhandled FHIRPath expression type");


        FpTerm? extractFpTerm(FpTermContext? ctx)
        {
            if (ctx == null)
            {
                return null;
            }

            switch (ctx)
            {
                case InvocationTermContext invocation:
                    return new FpTerm
                    {
                        InvocationTerm = extractFpInvocation(invocation.fpInvocation()),

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };

                case LiteralTermContext literal:
                    return new FpTerm
                    {
                        LiteralTerm = GetLiteral(literal.literal(), _comments),

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };

                case ExternalConstantTermContext external:
                    return new FpTerm
                    {
                        ExternalConstantTerm = external.fpExternalConstant().identifier().GetText(),
                        ExternalConstantTokenType = (FmlTokenTypeCodes)external.fpExternalConstant().identifier().Stop.Type,

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };

                case ParenthesizedTermContext parenthesized:
                    return new FpTerm
                    {
                        ParenthesizedTerm = ExtractFpExpression(parenthesized.fpExpression()),

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
            }

            throw new InvalidOperationException($"Unexpected term type: {ctx.GetType()}");
        }

        FpInvocation? extractFpInvocation(FpInvocationContext? ctx)
        {
            if (ctx == null)
            {
                return null;
            }

            switch (ctx)
            {
                case FunctionInvocationContext functionInvocation:
                    return new FpInvocation
                    {
                        FunctionInvocation = extractFpFunction(functionInvocation.fpFunction()),

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };

                case MemberInvocationContext memberInvocation:
                    return new FpInvocation
                    {
                        MemberInvocation = memberInvocation.identifier().GetText(),
                        MemberInvocationTokenType = (FmlTokenTypeCodes?)memberInvocation.identifier()?.Stop.Type,

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };

                case ThisInvocationContext thisInvocation:
                    return new FpInvocation
                    {
                        ThisInvocation = true,

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };

                case IndexInvocationContext indexInvocation:
                    return new FpInvocation
                    {
                        IndexInvocation = true,

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };

                case TotalInvocationContext totalInvocation:
                    return new FpInvocation
                    {
                        TotalInvocation = true,

                        RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                        PrefixComments = GetPrefixComments(ctx),
                        PostfixComments = GetPostfixComments(ctx),
                        Line = ctx.Start.Line,
                        Column = ctx.Start.Column,
                        StartIndex = ctx.Start.StartIndex,
                        StopIndex = ctx.Stop.StopIndex,
                    };
            }

            throw new InvalidOperationException($"Unexpected invocation type: {ctx.GetType()}");
        }

        FpFunction? extractFpFunction(FpFunctionContext? ctx)
        {
            if (ctx == null)
            {
                return null;
            }

            return new FpFunction
            {
                Identifier = ctx.identifier().GetText(),
                IdentifierTokenType = (FmlTokenTypeCodes)ctx.identifier().Stop.Type,
                Parameters = ctx.fpParamList()?.fpExpression()?.Select(ExtractFpExpression).ToList() ?? [],

                RawText = ctx.Start.InputStream.GetText(new Interval(ctx.Start.StartIndex, ctx.Stop.StopIndex)),
                PrefixComments = GetPrefixComments(ctx),
                PostfixComments = GetPostfixComments(ctx),
                Line = ctx.Start.Line,
                Column = ctx.Start.Column,
                StartIndex = ctx.Start.StartIndex,
                StopIndex = ctx.Stop.StopIndex,
            };
        }
    }
}