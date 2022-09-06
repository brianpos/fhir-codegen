// Minimum TypeScript Version: 3.7
// FHIR Primitive: integer64

import * as fhir from '../fhir.js';

/**
 * A signed integer in the range -9,223,372,036,854,775,808 to +9,223,372,036,854,775,807 (64-bit).
 * This type is defined to allow for record/time counters that can get very large
 */
export interface FhirInteger64Args extends fhir.FhirPrimitiveArgs {
  /**
 * A signed integer in the range -9,223,372,036,854,775,808 to +9,223,372,036,854,775,807 (64-bit).
 * This type is defined to allow for record/time counters that can get very large
   */
  value?:FhirInteger64|string|undefined|null;
}

/**
 * A signed integer in the range -9,223,372,036,854,775,808 to +9,223,372,036,854,775,807 (64-bit).
 * This type is defined to allow for record/time counters that can get very large
 */
export class FhirInteger64 extends fhir.FhirPrimitive {
  /**
   * Mapping of this datatype to a FHIR equivalent
   */
  public static override readonly _fts_dataType:string = 'Integer64';
  /**
   * Mapping of this datatype to a JSON equivalent
   */
  public static override readonly _fts_jsonType:string = 'string';
  // published regex: -?([0]|([1-9][0-9]*))
  public static override readonly _fts_regex:RegExp = /^-?([0]|([1-9][0-9]*))$/
  /**
   * A integer64 value, represented as a JS number
   */
  declare value?:bigint|null|undefined;
  /**
     * Create a FhirInteger64
     * @param value  A signed integer in the range -9,223,372,036,854,775,808 to +9,223,372,036,854,775,807 (64-bit). This type is defined to allow for record/time counters that can get very large
     * @param id Unique id for inter-element referencing (uncommon on primitives)
     * @param extension Additional content defined by implementations
     * @param options Options to pass to extension constructors
  */
  constructor(source:Partial<FhirInteger64Args> = {}, options:fhir.FhirConstructorOptions = { } ) {
    super(source, options);
  }
  /**
   * Function to perform basic model validation (e.g., check if required elements are present).
   */
  public override doModelValidation(exp:string = ''):fhir.FtsIssue[] {
    let iss:fhir.FtsIssue[] = super.doModelValidation(exp);
    if ((this.value !== undefined) && (this.value !== null) && ((typeof this.value !== 'string') || (!FhirInteger64._fts_regex.test(this.value)))) {
      iss.push({ severity: 'error', code: 'invalid', details: { text: 'Invalid value in primitive type unsignedInt' }, expression: [exp]});
    }
    return iss;
  }
}
