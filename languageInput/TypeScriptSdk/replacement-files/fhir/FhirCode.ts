// Minimum TypeScript Version: 3.7
// FHIR Primitive: code

import * as fhir from '../fhir.js';

/**
 * A string which has at least one character and no leading or trailing whitespace and where there is no whitespace other than single spaces in the contents
 */
export interface FhirCodeArgs<CodeType extends string = string> extends fhir.FhirPrimitiveArgs {
  /**
   * A string which has at least one character and no leading or trailing whitespace and where there is no whitespace other than single spaces in the contents
   */
  value?:FhirCode<CodeType>|CodeType|string|undefined|null;
}

/**
 * A string which has at least one character and no leading or trailing whitespace and where there is no whitespace other than single spaces in the contents
 */
export class FhirCode<CodeType extends string = string> extends fhir.FhirPrimitive {
  /**
   * Mapping of this datatype to a FHIR equivalent
   */
  public static override readonly _fts_dataType:string = 'Code';
  /**
   * Mapping of this datatype to a JSON equivalent
   */
  public static override readonly _fts_jsonType:string = 'string';
  // published regex: [^\s]+(\s[^\s]+)*
  public static override readonly _fts_regex:RegExp = /^[^\s]+(\s[^\s]+)*$/
  /**
   * A code value, represented as a JS string
   */
  declare value?:CodeType|string|null|undefined;
  /**
     * Create a FhirCode
     * @param value A string which has at least one character and no leading or trailing whitespace and where there is no whitespace other than single spaces in the contents
     * @param id Unique id for inter-element referencing (uncommon on primitives)
     * @param extension Additional content defined by implementations
     * @param options Options to pass to extension constructors
  */
  constructor(source:Partial<FhirCodeArgs> = {}, options:fhir.FhirConstructorOptions = { } ) {
    super(source, options);
  }
  /**
   * Function to perform basic model validation (e.g., check if required elements are present).
   */
  public override doModelValidation(exp:string = ''):fhir.FtsIssue[] {
    let iss:fhir.FtsIssue[] = super.doModelValidation(exp);
    if ((this.value !== undefined) && (this.value !== null) && ((this.value === '') || (typeof this.value !== 'string') || (!FhirCode._fts_regex.test(this.value)))) {
      iss.push({ severity: 'error', code: 'invalid', details: { text: 'Invalid value in primitive type code' }, expression: [exp]});
    }
    return iss;
  }

  /**
   * Test whether this code contains a specific value.
   * @returns True if this concept contains the specified coding, false if it does not.
   */
   public hasCodingFromValidationObj(vsValidation:Readonly<string[]>):boolean {
    if (!this.value) {
      return false;
    }

    return vsValidation.includes(this.value);
  }

  /**
   * Test whether this code contains a specific value.
   * @returns True if this concept contains the specified coding, false if it does not.
   */
   public hasCodingFromValidationHash(vsValidation:Readonly<number[]>):boolean {
    if (!this.value) {
      return false;
    }

    return vsValidation.includes(fhir.FhirBase._hash52_1a_fast(this.value));
  }

  /**
   * Returns a string representation of a string.
   */
   public override toString():string { return (this.value ?? '').toString(); }
   /**
    * Returns the character at the specified index.
    * @param pos The zero-based index of the desired character.
    */
   public charAt(pos: number):string { return (this.value ?? '').charAt(pos); }
   /**
    * Returns the Unicode value of the character at the specified location.
    * @param index The zero-based index of the desired character. If there is no character at the specified index, NaN is returned.
    */
   public charCodeAt(index: number):number { return (this.value ?? '').charCodeAt(index); }
   /**
    * Returns a string that contains the concatenation of two or more strings.
    * @param strings The strings to append to the end of the string.
    */
   public concat(...strings: string[]):string { return (this.value ?? '').concat(...strings); }
   /**
    * Returns the position of the first occurrence of a substring.
    * @param searchString The substring to search for in the string
    * @param position The index at which to begin searching the String object. If omitted, search starts at the beginning of the string.
    */
   public indexOf(searchString: string, position?: number):number { return (this.value ?? '').indexOf(searchString, position); }
   /**
    * Returns the last occurrence of a substring in the string.
    * @param searchString The substring to search for.
    * @param position The index at which to begin searching. If omitted, the search begins at the end of the string.
    */
   public lastIndexOf(searchString: string, position?: number):number { return (this.value ?? '').lastIndexOf(searchString, position); }
   /**
    * Determines whether two strings are equivalent in the current locale.
    * @param that String to compare to target string
    */
   public localeCompare(that: string):number { return (this.value ?? '').localeCompare(that); }
   /**
    * Matches a string with a regular expression, and returns an array containing the results of that search.
    * @param regexp A variable name or string literal containing the regular expression pattern and flags.
    */
   public match(regexp: string|RegExp):RegExpMatchArray|null { return (this.value ?? '').match(regexp); }
   /**
    * Replaces text in a string, using a regular expression or search string.
    * @param searchValue A string to search for.
    * @param replaceValue A string containing the text to replace for every successful match of searchValue in this string.
    */
   public replace(searchValue:string|RegExp, replaceValue:string):string { return (this.value ?? '').replace(searchValue, replaceValue); }
   /**
    * Finds the first substring match in a regular expression search.
    * @param regexp The regular expression pattern and applicable flags.
    */
   public search(regexp:string|RegExp):number { return (this.value ?? '').search(regexp); }
   /**
    * Returns a section of a string.
    * @param start The index to the beginning of the specified portion of stringObj.
    * @param end The index to the end of the specified portion of stringObj. The substring includes the characters up to, but not including, the character indicated by end.
    * If this value is not specified, the substring continues to the end of stringObj.
    */
   public slice(start?:number, end?:number):string { return (this.value ?? '').slice(start, end); }
   /**
    * Split a string into substrings using the specified separator and return them as an array.
    * @param separator A string that identifies character or characters to use in separating the string. If omitted, a single-element array containing the entire string is returned.
    * @param limit A value used to limit the number of elements returned in the array.
    */
   public split(separator:string|RegExp, limit?:number):string[] { return (this.value ?? '').split(separator, limit); }
   /**
    * Returns the substring at the specified location within a String object.
    * @param start The zero-based index number indicating the beginning of the substring.
    * @param end Zero-based index number indicating the end of the substring. The substring includes the characters up to, but not including, the character indicated by end.
    * If end is omitted, the characters from start through the end of the original string are returned.
    */
   public substring(start:number, end?:number):string { return (this.value ?? '').substring(start, end); }
   /**
    * Converts all the alphabetic characters in a string to lowercase.
    */
   public toLowerCase():string { return (this.value ?? '').toLowerCase(); }
   /**
    * Converts all alphabetic characters to lowercase, taking into account the host environment's current locale.
    */
   public toLocaleLowerCase(locales?:string|string[]):string { return (this.value ?? '').toLocaleLowerCase(locales); }
   /**
    * Converts all the alphabetic characters in a string to uppercase.
    */
   public toUpperCase():string { return (this.value ?? '').toUpperCase(); }
   /**
    * Returns a string where all alphabetic characters have been converted to uppercase, taking into account the host environment's current locale.
    */
   public toLocaleUpperCase(locales?:string|string[]):string { return (this.value ?? '').toLocaleUpperCase(locales); }
   /**
    * Removes the leading and trailing white space and line terminator characters from a string.
    */
   public trim():string { return (this.value ?? '').trim(); }
   /**
    * Returns the length of a String object.
    */
   public get length():number { return this.value?.length ?? 0 };
   /**
    * Returns the primitive value of the specified object.
    */
   public override valueOf():string { return this.value ?? ''; }
 }
