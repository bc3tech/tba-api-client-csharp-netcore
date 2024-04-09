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
/// Playoff status for this team, may be null if the team did not make playoffs, or playoffs have not begun.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TeamEventStatusPlayoff" /> class.
/// </remarks>
/// <param name="level">The highest playoff level the team reached..</param>
/// <param name="currentLevelRecord">currentLevelRecord.</param>
/// <param name="record">record.</param>
/// <param name="status">Current competition status for the playoffs..</param>
/// <param name="playoffAverage">The average match score during playoffs. Year specific. May be null if not relevant for a given year..</param>
[DataContract]
public partial class TeamEventStatusPlayoff(TeamEventStatusPlayoff.LevelEnum? level = default, WLTRecord currentLevelRecord = default, WLTRecord record = default, TeamEventStatusPlayoff.StatusEnum? status = default, int playoffAverage = default) : IEquatable<TeamEventStatusPlayoff>, IValidatableObject
{
    /// <summary>
    /// The highest playoff level the team reached.
    /// </summary>
    /// <value>The highest playoff level the team reached.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LevelEnum
    {
        /// <summary>
        /// Enum Qm for value: qm
        /// </summary>
        [EnumMember(Value = "qm")]
        Qm = 1,

        /// <summary>
        /// Enum Ef for value: ef
        /// </summary>
        [EnumMember(Value = "ef")]
        Ef = 2,

        /// <summary>
        /// Enum Qf for value: qf
        /// </summary>
        [EnumMember(Value = "qf")]
        Qf = 3,

        /// <summary>
        /// Enum Sf for value: sf
        /// </summary>
        [EnumMember(Value = "sf")]
        Sf = 4,

        /// <summary>
        /// Enum F for value: f
        /// </summary>
        [EnumMember(Value = "f")]
        F = 5

    }

    /// <summary>
    /// The highest playoff level the team reached.
    /// </summary>
    /// <value>The highest playoff level the team reached.</value>
    [DataMember(Name = "level", EmitDefaultValue = false), JsonPropertyName("level")]
    public LevelEnum? Level { get; set; } = level;
    /// <summary>
    /// Current competition status for the playoffs.
    /// </summary>
    /// <value>Current competition status for the playoffs.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Enum Won for value: won
        /// </summary>
        [EnumMember(Value = "won")]
        Won = 1,

        /// <summary>
        /// Enum Eliminated for value: eliminated
        /// </summary>
        [EnumMember(Value = "eliminated")]
        Eliminated = 2,

        /// <summary>
        /// Enum Playing for value: playing
        /// </summary>
        [EnumMember(Value = "playing")]
        Playing = 3

    }

    /// <summary>
    /// Current competition status for the playoffs.
    /// </summary>
    /// <value>Current competition status for the playoffs.</value>
    [DataMember(Name = "status", EmitDefaultValue = false), JsonPropertyName("status")]
    public StatusEnum? Status { get; set; } = status;

    /// <summary>
    /// Gets or Sets CurrentLevelRecord
    /// </summary>
    [DataMember(Name = "current_level_record", EmitDefaultValue = false), JsonPropertyName("current_level_record")]
    public WLTRecord CurrentLevelRecord { get; set; } = currentLevelRecord;

    /// <summary>
    /// Gets or Sets Record
    /// </summary>
    [DataMember(Name = "record", EmitDefaultValue = false), JsonPropertyName("record")]
    public WLTRecord Record { get; set; } = record;

    /// <summary>
    /// The average match score during playoffs. Year specific. May be null if not relevant for a given year.
    /// </summary>
    /// <value>The average match score during playoffs. Year specific. May be null if not relevant for a given year.</value>
    [DataMember(Name = "playoff_average", EmitDefaultValue = false), JsonPropertyName("playoff_average")]
    public int PlayoffAverage { get; set; } = playoffAverage;

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamEventStatusPlayoff {\n");
        sb.Append("  Level: ").Append(this.Level).Append('\n');
        sb.Append("  CurrentLevelRecord: ").Append(this.CurrentLevelRecord).Append('\n');
        sb.Append("  Record: ").Append(this.Record).Append('\n');
        sb.Append("  Status: ").Append(this.Status).Append('\n');
        sb.Append("  PlayoffAverage: ").Append(this.PlayoffAverage).Append('\n');
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
    public override bool Equals(object input) => Equals(input as TeamEventStatusPlayoff);

    /// <summary>
    /// Returns true if TeamEventStatusPlayoff instances are equal
    /// </summary>
    /// <param name="input">Instance of TeamEventStatusPlayoff to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TeamEventStatusPlayoff input)
    {
        return input != null
&& (
                this.Level == input.Level ||
                this.Level.Equals(input.Level)
            ) &&
            (
                this.CurrentLevelRecord == input.CurrentLevelRecord ||
                (this.CurrentLevelRecord != null &&
                this.CurrentLevelRecord.Equals(input.CurrentLevelRecord))
            ) &&
            (
                this.Record == input.Record ||
                (this.Record != null &&
                this.Record.Equals(input.Record))
            ) &&
            (
                this.Status == input.Status ||
                this.Status.Equals(input.Status)
            ) &&
            (
                this.PlayoffAverage == input.PlayoffAverage ||
                this.PlayoffAverage.Equals(input.PlayoffAverage)
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
            hashCode = (hashCode * 59) + this.Level.GetHashCode();
            if (this.CurrentLevelRecord != null)
            {
                hashCode = (hashCode * 59) + this.CurrentLevelRecord.GetHashCode();
            }

            if (this.Record != null)
            {
                hashCode = (hashCode * 59) + this.Record.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.Status.GetHashCode();
            hashCode = (hashCode * 59) + this.PlayoffAverage.GetHashCode();
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
