// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Aggregation method for a measure (e.g. sum, average, median, minimum, maximum, count)
  /// </summary>
  public static class MeasureAggregateMethodCodes
  {
    /// <summary>
    /// The measure score is determined by taking the average of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Average = new Coding
    {
      Code = "average",
      Display = "Average",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined as the number of observations derived from the measure population.
    /// </summary>
    public static readonly Coding Count = new Coding
    {
      Code = "count",
      Display = "Count",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by taking the maximum of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Maximum = new Coding
    {
      Code = "maximum",
      Display = "Maximum",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by taking the median of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Median = new Coding
    {
      Code = "median",
      Display = "Median",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by taking the minimum of the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Minimum = new Coding
    {
      Code = "minimum",
      Display = "Minimum",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
    /// <summary>
    /// The measure score is determined by adding together the observations derived from the measure population.
    /// </summary>
    public static readonly Coding Sum = new Coding
    {
      Code = "sum",
      Display = "Sum",
      System = "http://hl7.org/fhir/CodeSystem/measure-aggregate-method"
    };
  };
}