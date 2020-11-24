/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.5.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// TaxSettings
    /// </summary>
    [DataContract]
    public partial class TaxSettings :  IEquatable<TaxSettings>, IValidatableObject
    {
        /// <summary>
        /// The type of period (\&quot;weeks\&quot; or \&quot;months\&quot;)
        /// </summary>
        /// <value>The type of period (\&quot;weeks\&quot; or \&quot;months\&quot;)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodTypeEnum
        {
            /// <summary>
            /// Enum Weeks for value: weeks
            /// </summary>
            [EnumMember(Value = "weeks")]
            Weeks = 1,

            /// <summary>
            /// Enum Months for value: months
            /// </summary>
            [EnumMember(Value = "months")]
            Months = 2

        }

        /// <summary>
        /// The type of period (\&quot;weeks\&quot; or \&quot;months\&quot;)
        /// </summary>
        /// <value>The type of period (\&quot;weeks\&quot; or \&quot;months\&quot;)</value>
        [DataMember(Name="periodType", EmitDefaultValue=false)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// Gets or Sets TaxCode
        /// </summary>
        [DataMember(Name="taxCode", EmitDefaultValue=false)]
        public TaxCode TaxCode { get; set; }
        
        /// <summary>
        /// The number of units for the period type
        /// </summary>
        /// <value>The number of units for the period type</value>
        [DataMember(Name="periodUnits", EmitDefaultValue=false)]
        public decimal? PeriodUnits { get; set; }

        /// <summary>
        /// Tax rate for STC and WT
        /// </summary>
        /// <value>Tax rate for STC and WT</value>
        [DataMember(Name="specialTaxRate", EmitDefaultValue=false)]
        public string SpecialTaxRate { get; set; }

        /// <summary>
        /// Tax code for a lump sum amount
        /// </summary>
        /// <value>Tax code for a lump sum amount</value>
        [DataMember(Name="lumpSumTaxCode", EmitDefaultValue=false)]
        public string LumpSumTaxCode { get; set; }

        /// <summary>
        /// The total of the lump sum amount
        /// </summary>
        /// <value>The total of the lump sum amount</value>
        [DataMember(Name="lumpSumAmount", EmitDefaultValue=false)]
        public string LumpSumAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxSettings {\n");
            sb.Append("  PeriodUnits: ").Append(PeriodUnits).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  SpecialTaxRate: ").Append(SpecialTaxRate).Append("\n");
            sb.Append("  LumpSumTaxCode: ").Append(LumpSumTaxCode).Append("\n");
            sb.Append("  LumpSumAmount: ").Append(LumpSumAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaxSettings);
        }

        /// <summary>
        /// Returns true if TaxSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodUnits == input.PeriodUnits ||
                    this.PeriodUnits.Equals(input.PeriodUnits)
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    this.PeriodType.Equals(input.PeriodType)
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    this.TaxCode.Equals(input.TaxCode)
                ) && 
                (
                    this.SpecialTaxRate == input.SpecialTaxRate ||
                    (this.SpecialTaxRate != null &&
                    this.SpecialTaxRate.Equals(input.SpecialTaxRate))
                ) && 
                (
                    this.LumpSumTaxCode == input.LumpSumTaxCode ||
                    (this.LumpSumTaxCode != null &&
                    this.LumpSumTaxCode.Equals(input.LumpSumTaxCode))
                ) && 
                (
                    this.LumpSumAmount == input.LumpSumAmount ||
                    (this.LumpSumAmount != null &&
                    this.LumpSumAmount.Equals(input.LumpSumAmount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.PeriodUnits.GetHashCode();
                hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                hashCode = hashCode * 59 + this.TaxCode.GetHashCode();
                if (this.SpecialTaxRate != null)
                    hashCode = hashCode * 59 + this.SpecialTaxRate.GetHashCode();
                if (this.LumpSumTaxCode != null)
                    hashCode = hashCode * 59 + this.LumpSumTaxCode.GetHashCode();
                if (this.LumpSumAmount != null)
                    hashCode = hashCode * 59 + this.LumpSumAmount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
