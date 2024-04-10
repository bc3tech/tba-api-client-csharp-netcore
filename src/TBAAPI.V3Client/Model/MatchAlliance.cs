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
/// MatchAlliance
/// </summary>
[DataContract]
public partial record MatchAlliance : IValidatableObject
{
    /// <summary>
    /// Score for this alliance. Will be null or -1 for an unplayed match.
    /// </summary>
    /// <value>Score for this alliance. Will be null or -1 for an unplayed match.</value>
    [DataMember(Name = "score", EmitDefaultValue = false), JsonPropertyName("score")]
    public int Score { get; set; }

    /// <summary>
    /// Gets or Sets TeamKeys
    /// </summary>
    [DataMember(Name = "team_keys", EmitDefaultValue = false), JsonPropertyName("team_keys")]
    public IList<string>? TeamKeys { get; set; }

    /// <summary>
    /// TBA team keys (eg &#x60;frc254&#x60;) of any teams playing as a surrogate.
    /// </summary>
    /// <value>TBA team keys (eg &#x60;frc254&#x60;) of any teams playing as a surrogate.</value>
    [DataMember(Name = "surrogate_team_keys", EmitDefaultValue = false), JsonPropertyName("surrogate_team_keys")]
    public IList<string>? SurrogateTeamKeys { get; set; }

    /// <summary>
    /// TBA team keys (eg &#x60;frc254&#x60;) of any disqualified teams.
    /// </summary>
    /// <value>TBA team keys (eg &#x60;frc254&#x60;) of any disqualified teams.</value>
    [DataMember(Name = "dq_team_keys", EmitDefaultValue = false), JsonPropertyName("dq_team_keys")]
    public IList<string>? DqTeamKeys { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchAlliance {\n");
        sb.Append("  Score: ").Append(this.Score).Append('\n');
        sb.Append("  TeamKeys: ").Append(this.TeamKeys).Append('\n');
        sb.Append("  SurrogateTeamKeys: ").Append(this.SurrogateTeamKeys).Append('\n');
        sb.Append("  DqTeamKeys: ").Append(this.DqTeamKeys).Append('\n');
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
            hashCode = (hashCode * 59) + this.Score.GetHashCode();
            if (this.TeamKeys is not null)
            {
                hashCode = (hashCode * 59) + this.TeamKeys.GetHashCode();
            }

            if (this.SurrogateTeamKeys is not null)
            {
                hashCode = (hashCode * 59) + this.SurrogateTeamKeys.GetHashCode();
            }

            if (this.DqTeamKeys is not null)
            {
                hashCode = (hashCode * 59) + this.DqTeamKeys.GetHashCode();
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
