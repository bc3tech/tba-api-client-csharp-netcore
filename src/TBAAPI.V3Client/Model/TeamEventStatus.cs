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
/// TeamEventStatus
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TeamEventStatus" /> class.
/// </remarks>
/// <param name="qual">qual.</param>
/// <param name="alliance">alliance.</param>
/// <param name="playoff">playoff.</param>
/// <param name="allianceStatusStr">An HTML formatted string suitable for display to the user containing the team&#39;s alliance pick status..</param>
/// <param name="playoffStatusStr">An HTML formatter string suitable for display to the user containing the team&#39;s playoff status..</param>
/// <param name="overallStatusStr">An HTML formatted string suitable for display to the user containing the team&#39;s overall status summary of the event..</param>
/// <param name="nextMatchKey">TBA match key for the next match the team is scheduled to play in at this event, or null..</param>
/// <param name="lastMatchKey">TBA match key for the last match the team played in at this event, or null..</param>
[DataContract]
public partial class TeamEventStatus(TeamEventStatusRank? qual = default, TeamEventStatusAlliance? alliance = default, TeamEventStatusPlayoff? playoff = default, string? allianceStatusStr = default, string? playoffStatusStr = default, string? overallStatusStr = default, string? nextMatchKey = default, string? lastMatchKey = default) : IEquatable<TeamEventStatus>, IValidatableObject
{

    /// <summary>
    /// Gets or Sets Qual
    /// </summary>
    [DataMember(Name = "qual", EmitDefaultValue = false), JsonPropertyName("qual")]
    public TeamEventStatusRank? Qual { get; set; } = qual;

    /// <summary>
    /// Gets or Sets Alliance
    /// </summary>
    [DataMember(Name = "alliance", EmitDefaultValue = false), JsonPropertyName("alliance")]
    public TeamEventStatusAlliance? Alliance { get; set; } = alliance;

    /// <summary>
    /// Gets or Sets Playoff
    /// </summary>
    [DataMember(Name = "playoff", EmitDefaultValue = false), JsonPropertyName("playoff")]
    public TeamEventStatusPlayoff? Playoff { get; set; } = playoff;

    /// <summary>
    /// An HTML formatted string suitable for display to the user containing the team&#39;s alliance pick status.
    /// </summary>
    /// <value>An HTML formatted string suitable for display to the user containing the team&#39;s alliance pick status.</value>
    [DataMember(Name = "alliance_status_str", EmitDefaultValue = false), JsonPropertyName("alliance_status_str")]
    public string? AllianceStatusStr { get; set; } = allianceStatusStr;

    /// <summary>
    /// An HTML formatter string suitable for display to the user containing the team&#39;s playoff status.
    /// </summary>
    /// <value>An HTML formatter string suitable for display to the user containing the team&#39;s playoff status.</value>
    [DataMember(Name = "playoff_status_str", EmitDefaultValue = false), JsonPropertyName("playoff_status_str")]
    public string? PlayoffStatusStr { get; set; } = playoffStatusStr;

    /// <summary>
    /// An HTML formatted string suitable for display to the user containing the team&#39;s overall status summary of the event.
    /// </summary>
    /// <value>An HTML formatted string suitable for display to the user containing the team&#39;s overall status summary of the event.</value>
    [DataMember(Name = "overall_status_str", EmitDefaultValue = false), JsonPropertyName("overall_status_str")]
    public string? OverallStatusStr { get; set; } = overallStatusStr;

    /// <summary>
    /// TBA match key for the next match the team is scheduled to play in at this event, or null.
    /// </summary>
    /// <value>TBA match key for the next match the team is scheduled to play in at this event, or null.</value>
    [DataMember(Name = "next_match_key", EmitDefaultValue = false), JsonPropertyName("next_match_key")]
    public string? NextMatchKey { get; set; } = nextMatchKey;

    /// <summary>
    /// TBA match key for the last match the team played in at this event, or null.
    /// </summary>
    /// <value>TBA match key for the last match the team played in at this event, or null.</value>
    [DataMember(Name = "last_match_key", EmitDefaultValue = false), JsonPropertyName("last_match_key")]
    public string? LastMatchKey { get; set; } = lastMatchKey;

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamEventStatus {\n");
        sb.Append("  Qual: ").Append(this.Qual).Append('\n');
        sb.Append("  Alliance: ").Append(this.Alliance).Append('\n');
        sb.Append("  Playoff: ").Append(this.Playoff).Append('\n');
        sb.Append("  AllianceStatusStr: ").Append(this.AllianceStatusStr).Append('\n');
        sb.Append("  PlayoffStatusStr: ").Append(this.PlayoffStatusStr).Append('\n');
        sb.Append("  OverallStatusStr: ").Append(this.OverallStatusStr).Append('\n');
        sb.Append("  NextMatchKey: ").Append(this.NextMatchKey).Append('\n');
        sb.Append("  LastMatchKey: ").Append(this.LastMatchKey).Append('\n');
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
    public override bool Equals(object? input) => Equals(input as TeamEventStatus);

    /// <summary>
    /// Returns true if TeamEventStatus instances are equal
    /// </summary>
    /// <param name="input">Instance of TeamEventStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TeamEventStatus? input)
    {
        return input is not null &&
            (
                this.Qual == input.Qual ||
                (this.Qual is not null &&
                this.Qual.Equals(input.Qual))
            ) &&
            (
                this.Alliance == input.Alliance ||
                (this.Alliance is not null &&
                this.Alliance.Equals(input.Alliance))
            ) &&
            (
                this.Playoff == input.Playoff ||
                (this.Playoff is not null &&
                this.Playoff.Equals(input.Playoff))
            ) &&
            (
                this.AllianceStatusStr == input.AllianceStatusStr ||
                (this.AllianceStatusStr is not null &&
                this.AllianceStatusStr.Equals(input.AllianceStatusStr))
            ) &&
            (
                this.PlayoffStatusStr == input.PlayoffStatusStr ||
                (this.PlayoffStatusStr is not null &&
                this.PlayoffStatusStr.Equals(input.PlayoffStatusStr))
            ) &&
            (
                this.OverallStatusStr == input.OverallStatusStr ||
                (this.OverallStatusStr is not null &&
                this.OverallStatusStr.Equals(input.OverallStatusStr))
            ) &&
            (
                this.NextMatchKey == input.NextMatchKey ||
                (this.NextMatchKey is not null &&
                this.NextMatchKey.Equals(input.NextMatchKey))
            ) &&
            (
                this.LastMatchKey == input.LastMatchKey ||
                (this.LastMatchKey is not null &&
                this.LastMatchKey.Equals(input.LastMatchKey))
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
            if (this.Qual is not null)
            {
                hashCode = (hashCode * 59) + this.Qual.GetHashCode();
            }

            if (this.Alliance is not null)
            {
                hashCode = (hashCode * 59) + this.Alliance.GetHashCode();
            }

            if (this.Playoff is not null)
            {
                hashCode = (hashCode * 59) + this.Playoff.GetHashCode();
            }

            if (this.AllianceStatusStr is not null)
            {
                hashCode = (hashCode * 59) + this.AllianceStatusStr.GetHashCode();
            }

            if (this.PlayoffStatusStr is not null)
            {
                hashCode = (hashCode * 59) + this.PlayoffStatusStr.GetHashCode();
            }

            if (this.OverallStatusStr is not null)
            {
                hashCode = (hashCode * 59) + this.OverallStatusStr.GetHashCode();
            }

            if (this.NextMatchKey is not null)
            {
                hashCode = (hashCode * 59) + this.NextMatchKey.GetHashCode();
            }

            if (this.LastMatchKey is not null)
            {
                hashCode = (hashCode * 59) + this.LastMatchKey.GetHashCode();
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
