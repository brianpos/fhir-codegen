// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Describes the operational status of the DeviceMetric.
  /// </summary>
  public static class MetricOperationalStatusCodes
  {
    /// <summary>
    /// The DeviceMetric was entered in error.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/metric-operational-status"
    };
    /// <summary>
    /// The DeviceMetric is not operating.
    /// </summary>
    public static readonly Coding Off = new Coding
    {
      Code = "off",
      Display = "Off",
      System = "http://hl7.org/fhir/metric-operational-status"
    };
    /// <summary>
    /// The DeviceMetric is operating and will generate DeviceObservations.
    /// </summary>
    public static readonly Coding On = new Coding
    {
      Code = "on",
      Display = "On",
      System = "http://hl7.org/fhir/metric-operational-status"
    };
    /// <summary>
    /// The DeviceMetric is operating, but will not generate any DeviceObservations.
    /// </summary>
    public static readonly Coding Standby = new Coding
    {
      Code = "standby",
      Display = "Standby",
      System = "http://hl7.org/fhir/metric-operational-status"
    };
  };
}