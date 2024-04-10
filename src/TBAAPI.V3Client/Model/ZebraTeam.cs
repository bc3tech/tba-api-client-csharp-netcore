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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// ZebraTeam
/// </summary>
[DataContract]
public partial record ZebraTeam: IValidatableObject
{
    /// <summary>
    /// The TBA team key for the Zebra MotionWorks data.
    /// </summary>
    /// <value>The TBA team key for the Zebra MotionWorks data.</value>
    [DataMember(Name = "team_key", EmitDefaultValue = false), JsonPropertyName("team_key")]
    public string? TeamKey { get; set; }

    /// <summary>
    /// A list containing doubles and nulls representing a teams X position in feet at the corresponding timestamp. A null value represents no tracking data for a given timestamp.
    /// </summary>
    /// <value>A list containing doubles and nulls representing a teams X position in feet at the corresponding timestamp. A null value represents no tracking data for a given timestamp.</value>
    [DataMember(Name = "xs", EmitDefaultValue = false), JsonPropertyName("xs")]
    public IList<double>? Xs { get; set; }

    /// <summary>
    /// A list containing doubles and nulls representing a teams Y position in feet at the corresponding timestamp. A null value represents no tracking data for a given timestamp.
    /// </summary>
    /// <value>A list containing doubles and nulls representing a teams Y position in feet at the corresponding timestamp. A null value represents no tracking data for a given timestamp.</value>
    [DataMember(Name = "ys", EmitDefaultValue = false), JsonPropertyName("ys")]
    public IList<double>? Ys { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ZebraTeam {\n");
        sb.Append("  TeamKey: ").Append(this.TeamKey).Append('\n');
        sb.Append("  Xs: ").Append(this.Xs).Append('\n');
        sb.Append("  Ys: ").Append(this.Ys).Append('\n');
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
            if (this.TeamKey is not null)
            {
                hashCode = (hashCode * 59) + this.TeamKey.GetHashCode();
            }

            if (this.Xs is not null)
            {
                hashCode = (hashCode * 59) + this.Xs.GetHashCode();
            }

            if (this.Ys is not null)
            {
                hashCode = (hashCode * 59) + this.Ys.GetHashCode();
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
