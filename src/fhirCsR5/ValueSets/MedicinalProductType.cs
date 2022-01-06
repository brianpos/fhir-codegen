// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Overall defining type of this Medicinal Product.
  /// </summary>
  public static class MedicinalProductTypeCodes
  {
    /// <summary>
    /// An investigational medicinal product.
    /// </summary>
    public static readonly Coding InvestigationalMedicinalProduct = new Coding
    {
      Code = "InvestigationalProduct",
      Display = "Investigational Medicinal Product",
      System = "http://hl7.org/fhir/medicinal-product-type"
    };
    /// <summary>
    /// A standard medicinal product.
    /// </summary>
    public static readonly Coding MedicinalProduct = new Coding
    {
      Code = "MedicinalProduct",
      Display = "Medicinal Product",
      System = "http://hl7.org/fhir/medicinal-product-type"
    };

    /// <summary>
    /// Literal for code: InvestigationalMedicinalProduct
    /// </summary>
    public const string LiteralInvestigationalMedicinalProduct = "InvestigationalProduct";

    /// <summary>
    /// Literal for code: MedicinalProduct
    /// </summary>
    public const string LiteralMedicinalProduct = "MedicinalProduct";
  };
}