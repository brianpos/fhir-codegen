// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Possible types of subjects.
  /// </summary>
  public static class SubjectTypeCodes
  {
    /// <summary>
    /// This resource describes the properties (regulated, has real time clock, etc.), adminstrative (manufacturer name, model number, serial number, firmware, etc), and type (knee replacement, blood pressure cuff, MRI, etc.) of a physical unit (these values do not change much within a given module, for example the serail number, manufacturer name, and model number). An actual unit may consist of several modules in a distinct hierarchy and these are represented by multiple Device resources and bound through the 'parent' element.
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "Device",
      Display = "Device",
      System = "http://hl7.org/fhir/resource-types"
    };
    /// <summary>
    /// Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated.
    /// </summary>
    public static readonly Coding Location = new Coding
    {
      Code = "Location",
      Display = "Location",
      System = "http://hl7.org/fhir/resource-types"
    };
    /// <summary>
    /// A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action.  Includes companies, institutions, corporations, departments, community groups, healthcare practice groups, payer/insurer, etc.
    /// </summary>
    public static readonly Coding Organization = new Coding
    {
      Code = "Organization",
      Display = "Organization",
      System = "http://hl7.org/fhir/resource-types"
    };
    /// <summary>
    /// Demographics and other administrative information about an individual or animal receiving care or other health-related services.
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "Patient",
      Display = "Patient",
      System = "http://hl7.org/fhir/resource-types"
    };
    /// <summary>
    /// A person who is directly or indirectly involved in the provisioning of healthcare.
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "Practitioner",
      Display = "Practitioner",
      System = "http://hl7.org/fhir/resource-types"
    };

    /// <summary>
    /// Literal for code: Device
    /// </summary>
    public const string LiteralDevice = "Device";

    /// <summary>
    /// Literal for code: ResourceTypesDevice
    /// </summary>
    public const string LiteralResourceTypesDevice = "http://hl7.org/fhir/resource-types#Device";

    /// <summary>
    /// Literal for code: Location
    /// </summary>
    public const string LiteralLocation = "Location";

    /// <summary>
    /// Literal for code: ResourceTypesLocation
    /// </summary>
    public const string LiteralResourceTypesLocation = "http://hl7.org/fhir/resource-types#Location";

    /// <summary>
    /// Literal for code: Organization
    /// </summary>
    public const string LiteralOrganization = "Organization";

    /// <summary>
    /// Literal for code: ResourceTypesOrganization
    /// </summary>
    public const string LiteralResourceTypesOrganization = "http://hl7.org/fhir/resource-types#Organization";

    /// <summary>
    /// Literal for code: Patient
    /// </summary>
    public const string LiteralPatient = "Patient";

    /// <summary>
    /// Literal for code: ResourceTypesPatient
    /// </summary>
    public const string LiteralResourceTypesPatient = "http://hl7.org/fhir/resource-types#Patient";

    /// <summary>
    /// Literal for code: Practitioner
    /// </summary>
    public const string LiteralPractitioner = "Practitioner";

    /// <summary>
    /// Literal for code: ResourceTypesPractitioner
    /// </summary>
    public const string LiteralResourceTypesPractitioner = "http://hl7.org/fhir/resource-types#Practitioner";

    /// <summary>
    /// Dictionary for looking up SubjectType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "Device", Device }, 
      { "http://hl7.org/fhir/resource-types#Device", Device }, 
      { "Location", Location }, 
      { "http://hl7.org/fhir/resource-types#Location", Location }, 
      { "Organization", Organization }, 
      { "http://hl7.org/fhir/resource-types#Organization", Organization }, 
      { "Patient", Patient }, 
      { "http://hl7.org/fhir/resource-types#Patient", Patient }, 
      { "Practitioner", Practitioner }, 
      { "http://hl7.org/fhir/resource-types#Practitioner", Practitioner }, 
    };
  };
}
