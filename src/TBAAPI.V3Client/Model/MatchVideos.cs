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
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
/// <summary>
/// MatchVideos
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="MatchVideos" /> class.
/// </remarks>
[DataContract]
public partial record MatchVideos : IValidatableObject
{

    /// <summary>
    /// Can be one of &#39;youtube&#39; or &#39;tba&#39;
    /// </summary>
    /// <value>Can be one of &#39;youtube&#39; or &#39;tba&#39;</value>
    [DataMember(Name = "type", EmitDefaultValue = false), JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Unique key representing this video
    /// </summary>
    /// <value>Unique key representing this video</value>
    [DataMember(Name = "key", EmitDefaultValue = false), JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchVideos {\n");
        sb.Append("  Type: ").Append(this.Type).Append('\n');
        sb.Append("  Key: ").Append(this.Key).Append('\n');
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
            if (this.Type is not null)
            {
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
            }

            if (this.Key is not null)
            {
                hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
