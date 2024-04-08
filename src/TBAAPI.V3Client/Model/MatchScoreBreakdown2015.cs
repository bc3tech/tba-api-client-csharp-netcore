/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace TBAAPI.V3Client.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// See the 2015 FMS API documentation for a description of each value
    /// </summary>
    [DataContract]
    public partial class MatchScoreBreakdown2015 : IEquatable<MatchScoreBreakdown2015>, IValidatableObject
    {
        /// <summary>
        /// Defines Coopertition
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum CoopertitionEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 2,

            /// <summary>
            /// Enum Stack for value: Stack
            /// </summary>
            [EnumMember(Value = "Stack")]
            Stack = 3

        }

        /// <summary>
        /// Gets or Sets Coopertition
        /// </summary>
        [DataMember(Name = "coopertition", EmitDefaultValue = false)]
        public CoopertitionEnum? Coopertition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchScoreBreakdown2015" /> class.
        /// </summary>
        /// <param name="blue">blue.</param>
        /// <param name="red">red.</param>
        /// <param name="coopertition">coopertition.</param>
        /// <param name="coopertitionPoints">coopertitionPoints.</param>
        public MatchScoreBreakdown2015(MatchScoreBreakdown2015Alliance blue = default, MatchScoreBreakdown2015Alliance red = default, CoopertitionEnum? coopertition = default, int coopertitionPoints = default)
        {
            this.Blue = blue;
            this.Red = red;
            this.Coopertition = coopertition;
            this.CoopertitionPoints = coopertitionPoints;
        }

        /// <summary>
        /// Gets or Sets Blue
        /// </summary>
        [DataMember(Name = "blue", EmitDefaultValue = false)]
        public MatchScoreBreakdown2015Alliance Blue { get; set; }

        /// <summary>
        /// Gets or Sets Red
        /// </summary>
        [DataMember(Name = "red", EmitDefaultValue = false)]
        public MatchScoreBreakdown2015Alliance Red { get; set; }

        /// <summary>
        /// Gets or Sets CoopertitionPoints
        /// </summary>
        [DataMember(Name = "coopertition_points", EmitDefaultValue = false)]
        public int CoopertitionPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchScoreBreakdown2015 {\n");
            sb.Append("  Blue: ").Append(Blue).Append("\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
            sb.Append("  Coopertition: ").Append(Coopertition).Append("\n");
            sb.Append("  CoopertitionPoints: ").Append(CoopertitionPoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, this.GetType());
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MatchScoreBreakdown2015);
        }

        /// <summary>
        /// Returns true if MatchScoreBreakdown2015 instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchScoreBreakdown2015 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchScoreBreakdown2015 input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Blue == input.Blue ||
                    (this.Blue != null &&
                    this.Blue.Equals(input.Blue))
                ) &&
                (
                    this.Red == input.Red ||
                    (this.Red != null &&
                    this.Red.Equals(input.Red))
                ) &&
                (
                    this.Coopertition == input.Coopertition ||
                    this.Coopertition.Equals(input.Coopertition)
                ) &&
                (
                    this.CoopertitionPoints == input.CoopertitionPoints ||
                    this.CoopertitionPoints.Equals(input.CoopertitionPoints)
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
                if (this.Blue != null)
                    hashCode = hashCode * 59 + this.Blue.GetHashCode();
                if (this.Red != null)
                    hashCode = hashCode * 59 + this.Red.GetHashCode();
                hashCode = hashCode * 59 + this.Coopertition.GetHashCode();
                hashCode = hashCode * 59 + this.CoopertitionPoints.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
