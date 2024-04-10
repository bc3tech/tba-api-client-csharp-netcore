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
/// Backup team called in, may be null.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="EliminationAllianceBackup" /> class.
/// </remarks>
[DataContract]
public partial record EliminationAllianceBackup : IValidatableObject
{

    /// <summary>
    /// Team key that was called in as the backup.
    /// </summary>
    /// <value>Team key that was called in as the backup.</value>
    [DataMember(Name = "in", EmitDefaultValue = false), JsonPropertyName("in")]
    public string? In { get; set; }

    /// <summary>
    /// Team key that was replaced by the backup team.
    /// </summary>
    /// <value>Team key that was replaced by the backup team.</value>
    [DataMember(Name = "out", EmitDefaultValue = false), JsonPropertyName("out")]
    public string? Out { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EliminationAllianceBackup {\n");
        sb.Append("  In: ").Append(this.In).Append('\n');
        sb.Append("  Out: ").Append(this.Out).Append('\n');
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
    public override int GetHashCode() => HashCode.Combine(this.In, this.Out);

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext) => [];
}
