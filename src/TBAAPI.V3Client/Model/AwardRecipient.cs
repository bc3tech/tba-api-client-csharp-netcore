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
/// An &#x60;Award_Recipient&#x60; object represents the team and/or person who received an award at an event.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="AwardRecipient" /> class.
/// </remarks>
/// <param name="teamKey">The TBA team key for the team that was given the award. May be null..</param>
/// <param name="awardee">The name of the individual given the award. May be null..</param>
[DataContract]
public partial class AwardRecipient(string? teamKey = default, string? awardee = default) : IEquatable<AwardRecipient>, IValidatableObject
{

    /// <summary>
    /// The TBA team key for the team that was given the award. May be null.
    /// </summary>
    /// <value>The TBA team key for the team that was given the award. May be null.</value>
    [DataMember(Name = "team_key", EmitDefaultValue = false), JsonPropertyName("team_key")]
    public string? TeamKey { get; set; } = teamKey;

    /// <summary>
    /// The name of the individual given the award. May be null.
    /// </summary>
    /// <value>The name of the individual given the award. May be null.</value>
    [DataMember(Name = "awardee", EmitDefaultValue = false), JsonPropertyName("awardee")]
    public string? Awardee { get; set; } = awardee;

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AwardRecipient {\n");
        sb.Append("  TeamKey: ").Append(this.TeamKey).Append('\n');
        sb.Append("  Awardee: ").Append(this.Awardee).Append('\n');
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson() => JsonSerializer.Serialize(this, GetType());

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object? input) => Equals(input as AwardRecipient);

    /// <summary>
    /// Returns true if AwardRecipient instances are equal
    /// </summary>
    /// <param name="input">Instance of AwardRecipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AwardRecipient? input)
    {
        return input is not null
&& (
                this.TeamKey == input.TeamKey ||
                (this.TeamKey is not null &&
                this.TeamKey.Equals(input.TeamKey))
            ) &&
            (
                this.Awardee == input.Awardee ||
                (this.Awardee is not null &&
                this.Awardee.Equals(input.Awardee))
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
            var hashCode = 41;
            if (this.TeamKey is not null)
            {
                hashCode = (hashCode * 59) + this.TeamKey.GetHashCode();
            }

            if (this.Awardee is not null)
            {
                hashCode = (hashCode * 59) + this.Awardee.GetHashCode();
            }

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
