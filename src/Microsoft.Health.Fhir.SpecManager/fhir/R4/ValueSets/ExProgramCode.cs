// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Program Reason Span codes.
  /// </summary>
  public static class ExProgramCodeCodes
  {
    /// <summary>
    /// Child Asthma Program
    /// </summary>
    public static readonly Coding ChildAsthma = new Coding
    {
      Code = "as",
      Display = "Child Asthma",
      System = "http://terminology.hl7.org/CodeSystem/ex-programcode"
    };
    /// <summary>
    /// Autism Screening Program.
    /// </summary>
    public static readonly Coding AutismScreening = new Coding
    {
      Code = "auscr",
      Display = "Autism Screening",
      System = "http://terminology.hl7.org/CodeSystem/ex-programcode"
    };
    /// <summary>
    /// Hemodialysis Program.
    /// </summary>
    public static readonly Coding Hemodialysis = new Coding
    {
      Code = "hd",
      Display = "Hemodialysis",
      System = "http://terminology.hl7.org/CodeSystem/ex-programcode"
    };
    /// <summary>
    /// No program code applies.
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "none",
      Display = "None",
      System = "http://terminology.hl7.org/CodeSystem/ex-programcode"
    };
  };
}