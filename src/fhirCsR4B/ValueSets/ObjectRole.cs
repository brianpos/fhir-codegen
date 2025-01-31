// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Code representing the role the entity played in the audit event.
  /// </summary>
  public static class ObjectRoleCodes
  {
    /// <summary>
    /// This object is the patient that is the subject of care related to this event.  It is identifiable by patient ID or equivalent.  The patient may be either human or animal.
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "1",
      Display = "Patient",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// Insurance company, or any other organization who accepts responsibility for paying for the healthcare event.
    /// </summary>
    public static readonly Coding Guarantor = new Coding
    {
      Code = "10",
      Display = "Guarantor",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A person or active system object involved in the event with a security role.
    /// </summary>
    public static readonly Coding SecurityUserEntity = new Coding
    {
      Code = "11",
      Display = "Security User Entity",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A person or system object involved in the event with the authority to modify security roles of other objects.
    /// </summary>
    public static readonly Coding SecurityUserGroup = new Coding
    {
      Code = "12",
      Display = "Security User Group",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A passive object, such as a role table, that is relevant to the event.
    /// </summary>
    public static readonly Coding SecurityResource = new Coding
    {
      Code = "13",
      Display = "Security Resource",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// (deprecated)  Relevant to certain RBAC security methodologies.
    /// </summary>
    public static readonly Coding SecurityGranularityDefinition = new Coding
    {
      Code = "14",
      Display = "Security Granularity Definition",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// Any person or organization responsible for providing care.  This encompasses all forms of care, licensed or otherwise, and all sorts of teams and care groups. Note the distinction between practitioner and the doctor that actually provided the care to the patient.
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "15",
      Display = "Practitioner",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// The source or destination for data transfer, when it does not match some other role.
    /// </summary>
    public static readonly Coding DataDestination = new Coding
    {
      Code = "16",
      Display = "Data Destination",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A source or destination for data transfer that acts as an archive, database, or similar role.
    /// </summary>
    public static readonly Coding DataRepository = new Coding
    {
      Code = "17",
      Display = "Data Repository",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// An object that holds schedule information.  This could be an appointment book, availability information, etc.
    /// </summary>
    public static readonly Coding Schedule = new Coding
    {
      Code = "18",
      Display = "Schedule",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// An organization or person that is the recipient of services.  This could be an organization that is buying services for a patient, or a person that is buying services for an animal.
    /// </summary>
    public static readonly Coding Customer = new Coding
    {
      Code = "19",
      Display = "Customer",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// This is a location identified as related to the event.  This is usually the location where the event took place.  Note that for shipping, the usual events are arrival at a location or departure from a location.
    /// </summary>
    public static readonly Coding Location = new Coding
    {
      Code = "2",
      Display = "Location",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// An order, task, work item, procedure step, or other description of work to be performed; e.g. a particular instance of an MPPS.
    /// </summary>
    public static readonly Coding Job = new Coding
    {
      Code = "20",
      Display = "Job",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A list of jobs or a system that provides lists of jobs; e.g. an MWL SCP.
    /// </summary>
    public static readonly Coding JobStream = new Coding
    {
      Code = "21",
      Display = "Job Stream",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// (Deprecated).
    /// </summary>
    public static readonly Coding Table = new Coding
    {
      Code = "22",
      Display = "Table",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// An object that specifies or controls the routing or delivery of items.  For example, a distribution list is the routing criteria for mail.  The items delivered may be documents, jobs, or other objects.
    /// </summary>
    public static readonly Coding RoutingCriteria = new Coding
    {
      Code = "23",
      Display = "Routing Criteria",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// The contents of a query.  This is used to capture the contents of any kind of query.  For security surveillance purposes knowing the queries being made is very important.
    /// </summary>
    public static readonly Coding Query = new Coding
    {
      Code = "24",
      Display = "Query",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// This object is any kind of persistent document created as a result of the event.  This could be a paper report, film, electronic report, DICOM Study, etc.  Issues related to medical records life cycle management are conveyed elsewhere.
    /// </summary>
    public static readonly Coding Report = new Coding
    {
      Code = "3",
      Display = "Report",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A logical object related to a health record event.  This is any healthcare  specific resource (object) not restricted to FHIR defined Resources.
    /// </summary>
    public static readonly Coding DomainResource = new Coding
    {
      Code = "4",
      Display = "Domain Resource",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// This is any configurable file used to control creation of documents.  Examples include the objects maintained by the HL7 Master File transactions, Value Sets, etc.
    /// </summary>
    public static readonly Coding MasterFile = new Coding
    {
      Code = "5",
      Display = "Master file",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A human participant not otherwise identified by some other category.
    /// </summary>
    public static readonly Coding User = new Coding
    {
      Code = "6",
      Display = "User",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// (deprecated).
    /// </summary>
    public static readonly Coding List = new Coding
    {
      Code = "7",
      Display = "List",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// Typically, a licensed person who is providing or performing care related to the event, generally a physician.   The key distinction between doctor and practitioner is with regards to their role, not the licensing.  The doctor is the human who actually performed the work.  The practitioner is the human or organization that is responsible for the work.
    /// </summary>
    public static readonly Coding Doctor = new Coding
    {
      Code = "8",
      Display = "Doctor",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };
    /// <summary>
    /// A person or system that is being notified as part of the event.  This is relevant in situations where automated systems provide notifications to other parties when an event took place.
    /// </summary>
    public static readonly Coding Subscriber = new Coding
    {
      Code = "9",
      Display = "Subscriber",
      System = "http://terminology.hl7.org/CodeSystem/object-role"
    };

    /// <summary>
    /// Literal for code: Patient
    /// </summary>
    public const string LiteralPatient = "1";

    /// <summary>
    /// Literal for code: ObjectRolePatient
    /// </summary>
    public const string LiteralObjectRolePatient = "http://terminology.hl7.org/CodeSystem/object-role#1";

    /// <summary>
    /// Literal for code: Guarantor
    /// </summary>
    public const string LiteralGuarantor = "10";

    /// <summary>
    /// Literal for code: ObjectRoleGuarantor
    /// </summary>
    public const string LiteralObjectRoleGuarantor = "http://terminology.hl7.org/CodeSystem/object-role#10";

    /// <summary>
    /// Literal for code: SecurityUserEntity
    /// </summary>
    public const string LiteralSecurityUserEntity = "11";

    /// <summary>
    /// Literal for code: ObjectRoleSecurityUserEntity
    /// </summary>
    public const string LiteralObjectRoleSecurityUserEntity = "http://terminology.hl7.org/CodeSystem/object-role#11";

    /// <summary>
    /// Literal for code: SecurityUserGroup
    /// </summary>
    public const string LiteralSecurityUserGroup = "12";

    /// <summary>
    /// Literal for code: ObjectRoleSecurityUserGroup
    /// </summary>
    public const string LiteralObjectRoleSecurityUserGroup = "http://terminology.hl7.org/CodeSystem/object-role#12";

    /// <summary>
    /// Literal for code: SecurityResource
    /// </summary>
    public const string LiteralSecurityResource = "13";

    /// <summary>
    /// Literal for code: ObjectRoleSecurityResource
    /// </summary>
    public const string LiteralObjectRoleSecurityResource = "http://terminology.hl7.org/CodeSystem/object-role#13";

    /// <summary>
    /// Literal for code: SecurityGranularityDefinition
    /// </summary>
    public const string LiteralSecurityGranularityDefinition = "14";

    /// <summary>
    /// Literal for code: ObjectRoleSecurityGranularityDefinition
    /// </summary>
    public const string LiteralObjectRoleSecurityGranularityDefinition = "http://terminology.hl7.org/CodeSystem/object-role#14";

    /// <summary>
    /// Literal for code: Practitioner
    /// </summary>
    public const string LiteralPractitioner = "15";

    /// <summary>
    /// Literal for code: ObjectRolePractitioner
    /// </summary>
    public const string LiteralObjectRolePractitioner = "http://terminology.hl7.org/CodeSystem/object-role#15";

    /// <summary>
    /// Literal for code: DataDestination
    /// </summary>
    public const string LiteralDataDestination = "16";

    /// <summary>
    /// Literal for code: ObjectRoleDataDestination
    /// </summary>
    public const string LiteralObjectRoleDataDestination = "http://terminology.hl7.org/CodeSystem/object-role#16";

    /// <summary>
    /// Literal for code: DataRepository
    /// </summary>
    public const string LiteralDataRepository = "17";

    /// <summary>
    /// Literal for code: ObjectRoleDataRepository
    /// </summary>
    public const string LiteralObjectRoleDataRepository = "http://terminology.hl7.org/CodeSystem/object-role#17";

    /// <summary>
    /// Literal for code: Schedule
    /// </summary>
    public const string LiteralSchedule = "18";

    /// <summary>
    /// Literal for code: ObjectRoleSchedule
    /// </summary>
    public const string LiteralObjectRoleSchedule = "http://terminology.hl7.org/CodeSystem/object-role#18";

    /// <summary>
    /// Literal for code: Customer
    /// </summary>
    public const string LiteralCustomer = "19";

    /// <summary>
    /// Literal for code: ObjectRoleCustomer
    /// </summary>
    public const string LiteralObjectRoleCustomer = "http://terminology.hl7.org/CodeSystem/object-role#19";

    /// <summary>
    /// Literal for code: Location
    /// </summary>
    public const string LiteralLocation = "2";

    /// <summary>
    /// Literal for code: ObjectRoleLocation
    /// </summary>
    public const string LiteralObjectRoleLocation = "http://terminology.hl7.org/CodeSystem/object-role#2";

    /// <summary>
    /// Literal for code: Job
    /// </summary>
    public const string LiteralJob = "20";

    /// <summary>
    /// Literal for code: ObjectRoleJob
    /// </summary>
    public const string LiteralObjectRoleJob = "http://terminology.hl7.org/CodeSystem/object-role#20";

    /// <summary>
    /// Literal for code: JobStream
    /// </summary>
    public const string LiteralJobStream = "21";

    /// <summary>
    /// Literal for code: ObjectRoleJobStream
    /// </summary>
    public const string LiteralObjectRoleJobStream = "http://terminology.hl7.org/CodeSystem/object-role#21";

    /// <summary>
    /// Literal for code: Table
    /// </summary>
    public const string LiteralTable = "22";

    /// <summary>
    /// Literal for code: ObjectRoleTable
    /// </summary>
    public const string LiteralObjectRoleTable = "http://terminology.hl7.org/CodeSystem/object-role#22";

    /// <summary>
    /// Literal for code: RoutingCriteria
    /// </summary>
    public const string LiteralRoutingCriteria = "23";

    /// <summary>
    /// Literal for code: ObjectRoleRoutingCriteria
    /// </summary>
    public const string LiteralObjectRoleRoutingCriteria = "http://terminology.hl7.org/CodeSystem/object-role#23";

    /// <summary>
    /// Literal for code: Query
    /// </summary>
    public const string LiteralQuery = "24";

    /// <summary>
    /// Literal for code: ObjectRoleQuery
    /// </summary>
    public const string LiteralObjectRoleQuery = "http://terminology.hl7.org/CodeSystem/object-role#24";

    /// <summary>
    /// Literal for code: Report
    /// </summary>
    public const string LiteralReport = "3";

    /// <summary>
    /// Literal for code: ObjectRoleReport
    /// </summary>
    public const string LiteralObjectRoleReport = "http://terminology.hl7.org/CodeSystem/object-role#3";

    /// <summary>
    /// Literal for code: DomainResource
    /// </summary>
    public const string LiteralDomainResource = "4";

    /// <summary>
    /// Literal for code: ObjectRoleDomainResource
    /// </summary>
    public const string LiteralObjectRoleDomainResource = "http://terminology.hl7.org/CodeSystem/object-role#4";

    /// <summary>
    /// Literal for code: MasterFile
    /// </summary>
    public const string LiteralMasterFile = "5";

    /// <summary>
    /// Literal for code: ObjectRoleMasterFile
    /// </summary>
    public const string LiteralObjectRoleMasterFile = "http://terminology.hl7.org/CodeSystem/object-role#5";

    /// <summary>
    /// Literal for code: User
    /// </summary>
    public const string LiteralUser = "6";

    /// <summary>
    /// Literal for code: ObjectRoleUser
    /// </summary>
    public const string LiteralObjectRoleUser = "http://terminology.hl7.org/CodeSystem/object-role#6";

    /// <summary>
    /// Literal for code: List
    /// </summary>
    public const string LiteralList = "7";

    /// <summary>
    /// Literal for code: ObjectRoleList
    /// </summary>
    public const string LiteralObjectRoleList = "http://terminology.hl7.org/CodeSystem/object-role#7";

    /// <summary>
    /// Literal for code: Doctor
    /// </summary>
    public const string LiteralDoctor = "8";

    /// <summary>
    /// Literal for code: ObjectRoleDoctor
    /// </summary>
    public const string LiteralObjectRoleDoctor = "http://terminology.hl7.org/CodeSystem/object-role#8";

    /// <summary>
    /// Literal for code: Subscriber
    /// </summary>
    public const string LiteralSubscriber = "9";

    /// <summary>
    /// Literal for code: ObjectRoleSubscriber
    /// </summary>
    public const string LiteralObjectRoleSubscriber = "http://terminology.hl7.org/CodeSystem/object-role#9";

    /// <summary>
    /// Dictionary for looking up ObjectRole Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "1", Patient }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#1", Patient }, 
      { "10", Guarantor }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#10", Guarantor }, 
      { "11", SecurityUserEntity }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#11", SecurityUserEntity }, 
      { "12", SecurityUserGroup }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#12", SecurityUserGroup }, 
      { "13", SecurityResource }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#13", SecurityResource }, 
      { "14", SecurityGranularityDefinition }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#14", SecurityGranularityDefinition }, 
      { "15", Practitioner }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#15", Practitioner }, 
      { "16", DataDestination }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#16", DataDestination }, 
      { "17", DataRepository }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#17", DataRepository }, 
      { "18", Schedule }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#18", Schedule }, 
      { "19", Customer }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#19", Customer }, 
      { "2", Location }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#2", Location }, 
      { "20", Job }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#20", Job }, 
      { "21", JobStream }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#21", JobStream }, 
      { "22", Table }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#22", Table }, 
      { "23", RoutingCriteria }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#23", RoutingCriteria }, 
      { "24", Query }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#24", Query }, 
      { "3", Report }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#3", Report }, 
      { "4", DomainResource }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#4", DomainResource }, 
      { "5", MasterFile }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#5", MasterFile }, 
      { "6", User }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#6", User }, 
      { "7", List }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#7", List }, 
      { "8", Doctor }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#8", Doctor }, 
      { "9", Subscriber }, 
      { "http://terminology.hl7.org/CodeSystem/object-role#9", Subscriber }, 
    };
  };
}
