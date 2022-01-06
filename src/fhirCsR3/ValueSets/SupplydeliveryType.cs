// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value sets refers to a specific supply item.
  /// </summary>
  public static class SupplydeliveryTypeCodes
  {
    /// <summary>
    /// What is supplied (or requested) is a device.
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "device",
      Display = "Device",
      System = "http://hl7.org/fhir/supply-item-type"
    };
    /// <summary>
    /// Supply is a kind of medication.
    /// </summary>
    public static readonly Coding Medication = new Coding
    {
      Code = "medication",
      Display = "Medication",
      System = "http://hl7.org/fhir/supply-item-type"
    };

    /// <summary>
    /// Literal for code: Device
    /// </summary>
    public const string LiteralDevice = "device";

    /// <summary>
    /// Literal for code: Medication
    /// </summary>
    public const string LiteralMedication = "medication";
  };
}