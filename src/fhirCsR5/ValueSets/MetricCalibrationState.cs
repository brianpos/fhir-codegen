// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Describes the state of a metric calibration.
  /// </summary>
  public static class MetricCalibrationStateCodes
  {
    /// <summary>
    /// The metric has been calibrated.
    /// </summary>
    public static readonly Coding Calibrated = new Coding
    {
      Code = "calibrated",
      Display = "Calibrated",
      System = "http://hl7.org/fhir/metric-calibration-state"
    };
    /// <summary>
    /// The metric needs to be calibrated.
    /// </summary>
    public static readonly Coding CalibrationRequired = new Coding
    {
      Code = "calibration-required",
      Display = "Calibration Required",
      System = "http://hl7.org/fhir/metric-calibration-state"
    };
    /// <summary>
    /// The metric has not been calibrated.
    /// </summary>
    public static readonly Coding NotCalibrated = new Coding
    {
      Code = "not-calibrated",
      Display = "Not Calibrated",
      System = "http://hl7.org/fhir/metric-calibration-state"
    };
    /// <summary>
    /// The state of calibration of this metric is unspecified.
    /// </summary>
    public static readonly Coding Unspecified = new Coding
    {
      Code = "unspecified",
      Display = "Unspecified",
      System = "http://hl7.org/fhir/metric-calibration-state"
    };

    /// <summary>
    /// Literal for code: Calibrated
    /// </summary>
    public const string LiteralCalibrated = "calibrated";

    /// <summary>
    /// Literal for code: CalibrationRequired
    /// </summary>
    public const string LiteralCalibrationRequired = "calibration-required";

    /// <summary>
    /// Literal for code: NotCalibrated
    /// </summary>
    public const string LiteralNotCalibrated = "not-calibrated";

    /// <summary>
    /// Literal for code: Unspecified
    /// </summary>
    public const string LiteralUnspecified = "unspecified";
  };
}