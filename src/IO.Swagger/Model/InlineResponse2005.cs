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
    /// InlineResponse2005
    /// </summary>
    [DataContract]
        public partial class InlineResponse2005 :  IEquatable<InlineResponse2005>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2005" /> class.
        /// </summary>
        /// <param name="availableTimeSlots">availableTimeSlots (required).</param>
        public InlineResponse2005(List<AvailableTimeSlot> availableTimeSlots = default(List<AvailableTimeSlot>))
        {
            // to ensure "availableTimeSlots" is required (not null)
            if (availableTimeSlots == null)
            {
                throw new InvalidDataException("availableTimeSlots is a required property for InlineResponse2005 and cannot be null");
            }
            else
            {
                this.AvailableTimeSlots = availableTimeSlots;
            }
        }
        
        /// <summary>
        /// Gets or Sets AvailableTimeSlots
        /// </summary>
        [DataMember(Name="availableTimeSlots", EmitDefaultValue=false)]
        public List<AvailableTimeSlot> AvailableTimeSlots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2005 {\n");
            sb.Append("  AvailableTimeSlots: ").Append(AvailableTimeSlots).Append("\n");
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
            return this.Equals(input as InlineResponse2005);
        }

        /// <summary>
        /// Returns true if InlineResponse2005 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2005 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableTimeSlots == input.AvailableTimeSlots ||
                    this.AvailableTimeSlots != null &&
                    input.AvailableTimeSlots != null &&
                    this.AvailableTimeSlots.SequenceEqual(input.AvailableTimeSlots)
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
                if (this.AvailableTimeSlots != null)
                    hashCode = hashCode * 59 + this.AvailableTimeSlots.GetHashCode();
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
