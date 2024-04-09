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

using TBAAPI.V3Client.Client;

/// <summary>
/// MatchSimple
/// </summary>
[DataContract]public partial record MatchSimple : IValidatableObject
{
    /// <summary>
    /// The competition level the match was played at.
    /// </summary>
    /// <value>The competition level the match was played at.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CompLevelEnum
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
    /// The competition level the match was played at.
    /// </summary>
    /// <value>The competition level the match was played at.</value>
    [DataMember(Name = "comp_level", EmitDefaultValue = false), JsonPropertyName("comp_level")]
    public CompLevelEnum CompLevel { get; set; }
    /// <summary>
    /// The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.
    /// </summary>
    /// <value>The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WinningAllianceEnum
    {
        /// <summary>
        /// Enum Red for value: red
        /// </summary>
        [EnumMember(Value = "red")]
        Red = 1,

        /// <summary>
        /// Enum Blue for value: blue
        /// </summary>
        [EnumMember(Value = "blue")]
        Blue = 2,

        /// <summary>
        /// Enum Empty for value: 
        /// </summary>
        [EnumMember(Value = "")]
        Empty = 3

    }

    /// <summary>
    /// The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.
    /// </summary>
    /// <value>The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie.</value>
    [DataMember(Name = "winning_alliance", EmitDefaultValue = false), JsonPropertyName("winning_alliance"), JsonConverter(typeof(OpenAPIEnumConverter<WinningAllianceEnum>))]
    public WinningAllianceEnum? WinningAlliance { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MatchSimple" /> class.
    /// </summary>
    [JsonConstructor]
    protected MatchSimple() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MatchSimple" /> class.
    /// </summary>
    /// <param name="key">TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may append the competition level if more than one match in required per set. (required).</param>
    /// <param name="compLevel">The competition level the match was played at. (required).</param>
    /// <param name="setNumber">The set number in a series of matches where more than one match is required in the match series. (required).</param>
    /// <param name="matchNumber">The match number of the match in the competition level. (required).</param>
    /// <param name="alliances">alliances.</param>
    /// <param name="winningAlliance">The color (red/blue) of the winning alliance. Will contain an empty string in the event of no winner, or a tie..</param>
    /// <param name="eventKey">Event key of the event the match was played at. (required).</param>
    /// <param name="time">UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the scheduled match time, as taken from the published schedule..</param>
    /// <param name="predictedTime">UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the TBA predicted match start time..</param>
    /// <param name="actualTime">UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of actual match start time..</param>
    public MatchSimple(string? key = default, CompLevelEnum compLevel = default, int setNumber = default, int matchNumber = default, MatchSimpleAlliances? alliances = default, WinningAllianceEnum? winningAlliance = default, string? eventKey = default, long time = default, long predictedTime = default, long actualTime = default)
    {
        // to ensure "key" is required (not null)
        this.Key = key ?? throw new ArgumentNullException(nameof(key));
        this.CompLevel = compLevel;
        this.SetNumber = setNumber;
        this.MatchNumber = matchNumber;
        // to ensure "eventKey" is required (not null)
        this.EventKey = eventKey ?? throw new ArgumentNullException(nameof(eventKey));
        this.Alliances = alliances;
        this.WinningAlliance = winningAlliance;
        this.Time = time;
        this.PredictedTime = predictedTime;
        this.ActualTime = actualTime;
    }

    /// <summary>
    /// TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may append the competition level if more than one match in required per set.
    /// </summary>
    /// <value>TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may append the competition level if more than one match in required per set.</value>
    [DataMember(Name = "key", EmitDefaultValue = false), JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>
    /// The set number in a series of matches where more than one match is required in the match series.
    /// </summary>
    /// <value>The set number in a series of matches where more than one match is required in the match series.</value>
    [DataMember(Name = "set_number", EmitDefaultValue = false), JsonPropertyName("set_number")]
    public int SetNumber { get; set; }

    /// <summary>
    /// The match number of the match in the competition level.
    /// </summary>
    /// <value>The match number of the match in the competition level.</value>
    [DataMember(Name = "match_number", EmitDefaultValue = false), JsonPropertyName("match_number")]
    public int MatchNumber { get; set; }

    /// <summary>
    /// Gets or Sets Alliances
    /// </summary>
    [DataMember(Name = "alliances", EmitDefaultValue = false), JsonPropertyName("alliances")]
    public MatchSimpleAlliances Alliances { get; set; }

    /// <summary>
    /// Event key of the event the match was played at.
    /// </summary>
    /// <value>Event key of the event the match was played at.</value>
    [DataMember(Name = "event_key", EmitDefaultValue = false), JsonPropertyName("event_key")]
    public string EventKey { get; set; }

    /// <summary>
    /// UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the scheduled match time, as taken from the published schedule.
    /// </summary>
    /// <value>UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the scheduled match time, as taken from the published schedule.</value>
    [DataMember(Name = "time", EmitDefaultValue = false), JsonPropertyName("time")]
    public long Time { get; set; }

    /// <summary>
    /// UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the TBA predicted match start time.
    /// </summary>
    /// <value>UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of the TBA predicted match start time.</value>
    [DataMember(Name = "predicted_time", EmitDefaultValue = false), JsonPropertyName("predicted_time")]
    public long PredictedTime { get; set; }

    /// <summary>
    /// UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of actual match start time.
    /// </summary>
    /// <value>UNIX timestamp (seconds since 1-Jan-1970 00:00:00) of actual match start time.</value>
    [DataMember(Name = "actual_time", EmitDefaultValue = false), JsonPropertyName("actual_time")]
    public long ActualTime { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchSimple {\n");
        sb.Append("  Key: ").Append(this.Key).Append('\n');
        sb.Append("  CompLevel: ").Append(this.CompLevel).Append('\n');
        sb.Append("  SetNumber: ").Append(this.SetNumber).Append('\n');
        sb.Append("  MatchNumber: ").Append(this.MatchNumber).Append('\n');
        sb.Append("  Alliances: ").Append(this.Alliances).Append('\n');
        sb.Append("  WinningAlliance: ").Append(this.WinningAlliance).Append('\n');
        sb.Append("  EventKey: ").Append(this.EventKey).Append('\n');
        sb.Append("  Time: ").Append(this.Time).Append('\n');
        sb.Append("  PredictedTime: ").Append(this.PredictedTime).Append('\n');
        sb.Append("  ActualTime: ").Append(this.ActualTime).Append('\n');
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
    public override bool Equals(object? input) => Equals(input as MatchSimple);

    /// <summary>
    /// Returns true if MatchSimple instances are equal
    /// </summary>
    /// <param name="input">Instance of MatchSimple to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MatchSimple? input)
    {
        return input is not null
&& (
                this.Key == input.Key ||
                (this.Key is not null &&
                this.Key.Equals(input.Key))
            ) &&
            (
                this.CompLevel == input.CompLevel ||
                this.CompLevel.Equals(input.CompLevel)
            ) &&
            (
                this.SetNumber == input.SetNumber ||
                this.SetNumber.Equals(input.SetNumber)
            ) &&
            (
                this.MatchNumber == input.MatchNumber ||
                this.MatchNumber.Equals(input.MatchNumber)
            ) &&
            (
                this.Alliances == input.Alliances ||
                (this.Alliances is not null &&
                this.Alliances.Equals(input.Alliances))
            ) &&
            (
                this.WinningAlliance == input.WinningAlliance ||
                this.WinningAlliance.Equals(input.WinningAlliance)
            ) &&
            (
                this.EventKey == input.EventKey ||
                (this.EventKey is not null &&
                this.EventKey.Equals(input.EventKey))
            ) &&
            (
                this.Time == input.Time ||
                this.Time.Equals(input.Time)
            ) &&
            (
                this.PredictedTime == input.PredictedTime ||
                this.PredictedTime.Equals(input.PredictedTime)
            ) &&
            (
                this.ActualTime == input.ActualTime ||
                this.ActualTime.Equals(input.ActualTime)
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
            if (this.Key is not null)
            {
                hashCode = (hashCode * 59) + this.Key.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.CompLevel.GetHashCode();
            hashCode = (hashCode * 59) + this.SetNumber.GetHashCode();
            hashCode = (hashCode * 59) + this.MatchNumber.GetHashCode();
            if (this.Alliances is not null)
            {
                hashCode = (hashCode * 59) + this.Alliances.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.WinningAlliance.GetHashCode();
            if (this.EventKey is not null)
            {
                hashCode = (hashCode * 59) + this.EventKey.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.Time.GetHashCode();
            hashCode = (hashCode * 59) + this.PredictedTime.GetHashCode();
            hashCode = (hashCode * 59) + this.ActualTime.GetHashCode();
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
