/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace TBAAPI.V3Client.Model;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
/// <summary>
/// See the 2018 FMS API documentation for a description of each value. https://frcevents2.docs.apiary.io/#/reference/match-results/score-details
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="MatchScoreBreakdown2018" /> class.
/// </remarks>
[DataContract]
public partial record MatchScoreBreakdown2018 : IValidatableObject
{

    /// <summary>
    /// Gets or Sets Blue
    /// </summary>
    [DataMember(Name = "blue", EmitDefaultValue = false), JsonPropertyName("blue")]
    public MatchScoreBreakdown2018Alliance? Blue { get; set; }

    /// <summary>
    /// Gets or Sets Red
    /// </summary>
    [DataMember(Name = "red", EmitDefaultValue = false), JsonPropertyName("red")]
    public MatchScoreBreakdown2018Alliance? Red { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchScoreBreakdown2018 {\n");
        sb.Append("  Blue: ").Append(this.Blue).Append('\n');
        sb.Append("  Red: ").Append(this.Red).Append('\n');
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson() => JsonSerializer.Serialize(this, GetType());

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            var hashCode = 41;
            if (this.Blue is not null)
            {
                hashCode = (hashCode * 59) + this.Blue.GetHashCode();
            }

            if (this.Red is not null)
            {
                hashCode = (hashCode * 59) + this.Red.GetHashCode();
            }

            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext) => [];
}
