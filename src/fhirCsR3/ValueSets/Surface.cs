// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of FDI tooth surface codes.
  /// </summary>
  public static class SurfaceCodes
  {
    /// <summary>
    /// The surface of a posterior tooth facing the cheeks.
    /// </summary>
    public static readonly Coding Buccal = new Coding
    {
      Code = "B",
      Display = "Buccal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The surface of a tooth that faces away from the midline of the face.
    /// </summary>
    public static readonly Coding Distal = new Coding
    {
      Code = "D",
      Display = "Distal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The Distoincisal surfaces of a tooth.
    /// </summary>
    public static readonly Coding Distoincisal = new Coding
    {
      Code = "DI",
      Display = "Distoincisal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The Distoclusal surfaces of a tooth.
    /// </summary>
    public static readonly Coding Distoclusal = new Coding
    {
      Code = "DO",
      Display = "Distoclusal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The biting edge of anterior teeth.
    /// </summary>
    public static readonly Coding Incisal = new Coding
    {
      Code = "I",
      Display = "Incisal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The surface of a tooth facing the tongue.
    /// </summary>
    public static readonly Coding Lingual = new Coding
    {
      Code = "L",
      Display = "Lingual",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The surface of a tooth that is closest to the midline (middle) of the face.
    /// </summary>
    public static readonly Coding Mesial = new Coding
    {
      Code = "M",
      Display = "Mesial",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The Mesioclusal surfaces of a tooth.
    /// </summary>
    public static readonly Coding Mesioclusal = new Coding
    {
      Code = "MO",
      Display = "Mesioclusal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The Mesioclusodistal surfaces of a tooth.
    /// </summary>
    public static readonly Coding Mesioclusodistal = new Coding
    {
      Code = "MOD",
      Display = "Mesioclusodistal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The chewing surface of posterior teeth.
    /// </summary>
    public static readonly Coding Occlusal = new Coding
    {
      Code = "O",
      Display = "Occlusal",
      System = "http://hl7.org/fhir/FDI-surface"
    };
    /// <summary>
    /// The surface of a tooth facing the lips.
    /// </summary>
    public static readonly Coding Ventral = new Coding
    {
      Code = "V",
      Display = "Ventral",
      System = "http://hl7.org/fhir/FDI-surface"
    };

    /// <summary>
    /// Literal for code: Buccal
    /// </summary>
    public const string LiteralBuccal = "B";

    /// <summary>
    /// Literal for code: SurfaceBuccal
    /// </summary>
    public const string LiteralSurfaceBuccal = "http://hl7.org/fhir/FDI-surface#B";

    /// <summary>
    /// Literal for code: Distal
    /// </summary>
    public const string LiteralDistal = "D";

    /// <summary>
    /// Literal for code: SurfaceDistal
    /// </summary>
    public const string LiteralSurfaceDistal = "http://hl7.org/fhir/FDI-surface#D";

    /// <summary>
    /// Literal for code: Distoincisal
    /// </summary>
    public const string LiteralDistoincisal = "DI";

    /// <summary>
    /// Literal for code: SurfaceDistoincisal
    /// </summary>
    public const string LiteralSurfaceDistoincisal = "http://hl7.org/fhir/FDI-surface#DI";

    /// <summary>
    /// Literal for code: Distoclusal
    /// </summary>
    public const string LiteralDistoclusal = "DO";

    /// <summary>
    /// Literal for code: SurfaceDistoclusal
    /// </summary>
    public const string LiteralSurfaceDistoclusal = "http://hl7.org/fhir/FDI-surface#DO";

    /// <summary>
    /// Literal for code: Incisal
    /// </summary>
    public const string LiteralIncisal = "I";

    /// <summary>
    /// Literal for code: SurfaceIncisal
    /// </summary>
    public const string LiteralSurfaceIncisal = "http://hl7.org/fhir/FDI-surface#I";

    /// <summary>
    /// Literal for code: Lingual
    /// </summary>
    public const string LiteralLingual = "L";

    /// <summary>
    /// Literal for code: SurfaceLingual
    /// </summary>
    public const string LiteralSurfaceLingual = "http://hl7.org/fhir/FDI-surface#L";

    /// <summary>
    /// Literal for code: Mesial
    /// </summary>
    public const string LiteralMesial = "M";

    /// <summary>
    /// Literal for code: SurfaceMesial
    /// </summary>
    public const string LiteralSurfaceMesial = "http://hl7.org/fhir/FDI-surface#M";

    /// <summary>
    /// Literal for code: Mesioclusal
    /// </summary>
    public const string LiteralMesioclusal = "MO";

    /// <summary>
    /// Literal for code: SurfaceMesioclusal
    /// </summary>
    public const string LiteralSurfaceMesioclusal = "http://hl7.org/fhir/FDI-surface#MO";

    /// <summary>
    /// Literal for code: Mesioclusodistal
    /// </summary>
    public const string LiteralMesioclusodistal = "MOD";

    /// <summary>
    /// Literal for code: SurfaceMesioclusodistal
    /// </summary>
    public const string LiteralSurfaceMesioclusodistal = "http://hl7.org/fhir/FDI-surface#MOD";

    /// <summary>
    /// Literal for code: Occlusal
    /// </summary>
    public const string LiteralOcclusal = "O";

    /// <summary>
    /// Literal for code: SurfaceOcclusal
    /// </summary>
    public const string LiteralSurfaceOcclusal = "http://hl7.org/fhir/FDI-surface#O";

    /// <summary>
    /// Literal for code: Ventral
    /// </summary>
    public const string LiteralVentral = "V";

    /// <summary>
    /// Literal for code: SurfaceVentral
    /// </summary>
    public const string LiteralSurfaceVentral = "http://hl7.org/fhir/FDI-surface#V";

    /// <summary>
    /// Dictionary for looking up Surface Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "B", Buccal }, 
      { "http://hl7.org/fhir/FDI-surface#B", Buccal }, 
      { "D", Distal }, 
      { "http://hl7.org/fhir/FDI-surface#D", Distal }, 
      { "DI", Distoincisal }, 
      { "http://hl7.org/fhir/FDI-surface#DI", Distoincisal }, 
      { "DO", Distoclusal }, 
      { "http://hl7.org/fhir/FDI-surface#DO", Distoclusal }, 
      { "I", Incisal }, 
      { "http://hl7.org/fhir/FDI-surface#I", Incisal }, 
      { "L", Lingual }, 
      { "http://hl7.org/fhir/FDI-surface#L", Lingual }, 
      { "M", Mesial }, 
      { "http://hl7.org/fhir/FDI-surface#M", Mesial }, 
      { "MO", Mesioclusal }, 
      { "http://hl7.org/fhir/FDI-surface#MO", Mesioclusal }, 
      { "MOD", Mesioclusodistal }, 
      { "http://hl7.org/fhir/FDI-surface#MOD", Mesioclusodistal }, 
      { "O", Occlusal }, 
      { "http://hl7.org/fhir/FDI-surface#O", Occlusal }, 
      { "V", Ventral }, 
      { "http://hl7.org/fhir/FDI-surface#V", Ventral }, 
    };
  };
}
