/* 
 * Maps Booking Partners API
 *
 * # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// Тексты на разных языках
    /// </summary>
    [DataContract]
        public partial class LocalizedText :  IEquatable<LocalizedText>, IValidatableObject, OneOfFeedCompanyName, OneOfResourceTitle, OneOfResourceDescription, OneOfResourceInformation, OneOfServiceTitle, OneOfServiceDescription, OneOfServiceCategory 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedText" /> class.
        /// </summary>
        /// <param name="text">Текст на русском языке (required).</param>
        /// <param name="localizedText">localizedText.</param>
        public LocalizedText(string text = default(string), List<LocalizedTextLocalizedText> localizedText = default(List<LocalizedTextLocalizedText>))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for LocalizedText and cannot be null");
            }
            else
            {
                this.Text = text;
            }
            this._LocalizedText = localizedText;
        }
        
        /// <summary>
        /// Текст на русском языке
        /// </summary>
        /// <value>Текст на русском языке</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets _LocalizedText
        /// </summary>
        [DataMember(Name="localizedText", EmitDefaultValue=false)]
        public List<LocalizedTextLocalizedText> _LocalizedText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalizedText {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  _LocalizedText: ").Append(_LocalizedText).Append("\n");
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
            return this.Equals(input as LocalizedText);
        }

        /// <summary>
        /// Returns true if LocalizedText instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalizedText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalizedText input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this._LocalizedText == input._LocalizedText ||
                    this._LocalizedText != null &&
                    input._LocalizedText != null &&
                    this._LocalizedText.SequenceEqual(input._LocalizedText)
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this._LocalizedText != null)
                    hashCode = hashCode * 59 + this._LocalizedText.GetHashCode();
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
