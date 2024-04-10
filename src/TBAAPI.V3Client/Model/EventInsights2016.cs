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
/// Insights for FIRST Stronghold qualification and elimination matches.
/// </summary>
[DataContract]
public partial record EventInsights2016 : IValidatableObject
{
    /// <summary>
    /// For the Low Bar - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Low Bar - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "LowBar", EmitDefaultValue = false), JsonPropertyName("LowBar")]
    public IList<float>? LowBar { get; set; }

    /// <summary>
    /// For the Cheval De Frise - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Cheval De Frise - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "A_ChevalDeFrise", EmitDefaultValue = false), JsonPropertyName("A_ChevalDeFrise")]
    public IList<float>? AChevalDeFrise { get; set; }

    /// <summary>
    /// For the Portcullis - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Portcullis - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "A_Portcullis", EmitDefaultValue = false), JsonPropertyName("A_Portcullis")]
    public IList<float>? APortcullis { get; set; }

    /// <summary>
    /// For the Ramparts - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Ramparts - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "B_Ramparts", EmitDefaultValue = false), JsonPropertyName("B_Ramparts")]
    public IList<float>? BRamparts { get; set; }

    /// <summary>
    /// For the Moat - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Moat - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "B_Moat", EmitDefaultValue = false), JsonPropertyName("B_Moat")]
    public IList<float>? BMoat { get; set; }

    /// <summary>
    /// For the Sally Port - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Sally Port - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "C_SallyPort", EmitDefaultValue = false), JsonPropertyName("C_SallyPort")]
    public IList<float>? CSallyPort { get; set; }

    /// <summary>
    /// For the Drawbridge - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Drawbridge - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "C_Drawbridge", EmitDefaultValue = false), JsonPropertyName("C_Drawbridge")]
    public IList<float>? CDrawbridge { get; set; }

    /// <summary>
    /// For the Rough Terrain - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Rough Terrain - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "D_RoughTerrain", EmitDefaultValue = false), JsonPropertyName("D_RoughTerrain")]
    public IList<float>? DRoughTerrain { get; set; }

    /// <summary>
    /// For the Rock Wall - An array with three values, number of times damaged, number of opportunities to damage, and percentage.
    /// </summary>
    /// <value>For the Rock Wall - An array with three values, number of times damaged, number of opportunities to damage, and percentage.</value>
    [DataMember(Name = "D_RockWall", EmitDefaultValue = false), JsonPropertyName("D_RockWall")]
    public IList<float>? DRockWall { get; set; }

    /// <summary>
    /// Average number of high goals scored.
    /// </summary>
    /// <value>Average number of high goals scored.</value>
    [DataMember(Name = "average_high_goals", EmitDefaultValue = false), JsonPropertyName("average_high_goals")]
    public float AverageHighGoals { get; set; }

    /// <summary>
    /// Average number of low goals scored.
    /// </summary>
    /// <value>Average number of low goals scored.</value>
    [DataMember(Name = "average_low_goals", EmitDefaultValue = false), JsonPropertyName("average_low_goals")]
    public float AverageLowGoals { get; set; }

    /// <summary>
    /// An array with three values, number of times breached, number of opportunities to breach, and percentage.
    /// </summary>
    /// <value>An array with three values, number of times breached, number of opportunities to breach, and percentage.</value>
    [DataMember(Name = "breaches", EmitDefaultValue = false), JsonPropertyName("breaches")]
    public IList<float>? Breaches { get; set; }

    /// <summary>
    /// An array with three values, number of times scaled, number of opportunities to scale, and percentage.
    /// </summary>
    /// <value>An array with three values, number of times scaled, number of opportunities to scale, and percentage.</value>
    [DataMember(Name = "scales", EmitDefaultValue = false), JsonPropertyName("scales")]
    public IList<float>? Scales { get; set; }

    /// <summary>
    /// An array with three values, number of times challenged, number of opportunities to challenge, and percentage.
    /// </summary>
    /// <value>An array with three values, number of times challenged, number of opportunities to challenge, and percentage.</value>
    [DataMember(Name = "challenges", EmitDefaultValue = false), JsonPropertyName("challenges")]
    public IList<float>? Challenges { get; set; }

    /// <summary>
    /// An array with three values, number of times captured, number of opportunities to capture, and percentage.
    /// </summary>
    /// <value>An array with three values, number of times captured, number of opportunities to capture, and percentage.</value>
    [DataMember(Name = "captures", EmitDefaultValue = false), JsonPropertyName("captures")]
    public IList<float>? Captures { get; set; }

    /// <summary>
    /// Average winning score.
    /// </summary>
    /// <value>Average winning score.</value>
    [DataMember(Name = "average_win_score", EmitDefaultValue = false), JsonPropertyName("average_win_score")]
    public float AverageWinScore { get; set; }

    /// <summary>
    /// Average margin of victory.
    /// </summary>
    /// <value>Average margin of victory.</value>
    [DataMember(Name = "average_win_margin", EmitDefaultValue = false), JsonPropertyName("average_win_margin")]
    public float AverageWinMargin { get; set; }

    /// <summary>
    /// Average total score.
    /// </summary>
    /// <value>Average total score.</value>
    [DataMember(Name = "average_score", EmitDefaultValue = false), JsonPropertyName("average_score")]
    public float AverageScore { get; set; }

    /// <summary>
    /// Average autonomous score.
    /// </summary>
    /// <value>Average autonomous score.</value>
    [DataMember(Name = "average_auto_score", EmitDefaultValue = false), JsonPropertyName("average_auto_score")]
    public float AverageAutoScore { get; set; }

    /// <summary>
    /// Average crossing score.
    /// </summary>
    /// <value>Average crossing score.</value>
    [DataMember(Name = "average_crossing_score", EmitDefaultValue = false), JsonPropertyName("average_crossing_score")]
    public float AverageCrossingScore { get; set; }

    /// <summary>
    /// Average boulder score.
    /// </summary>
    /// <value>Average boulder score.</value>
    [DataMember(Name = "average_boulder_score", EmitDefaultValue = false), JsonPropertyName("average_boulder_score")]
    public float AverageBoulderScore { get; set; }

    /// <summary>
    /// Average tower score.
    /// </summary>
    /// <value>Average tower score.</value>
    [DataMember(Name = "average_tower_score", EmitDefaultValue = false), JsonPropertyName("average_tower_score")]
    public float AverageTowerScore { get; set; }

    /// <summary>
    /// Average foul score.
    /// </summary>
    /// <value>Average foul score.</value>
    [DataMember(Name = "average_foul_score", EmitDefaultValue = false), JsonPropertyName("average_foul_score")]
    public float AverageFoulScore { get; set; }

    /// <summary>
    /// An array with three values, high score, match key from the match with the high score, and the name of the match.
    /// </summary>
    /// <value>An array with three values, high score, match key from the match with the high score, and the name of the match.</value>
    [DataMember(Name = "high_score", EmitDefaultValue = false), JsonPropertyName("high_score")]
    public IList<string>? HighScore { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventInsights2016 {\n");
        sb.Append("  LowBar: ").Append(this.LowBar).Append('\n');
        sb.Append("  AChevalDeFrise: ").Append(this.AChevalDeFrise).Append('\n');
        sb.Append("  APortcullis: ").Append(this.APortcullis).Append('\n');
        sb.Append("  BRamparts: ").Append(this.BRamparts).Append('\n');
        sb.Append("  BMoat: ").Append(this.BMoat).Append('\n');
        sb.Append("  CSallyPort: ").Append(this.CSallyPort).Append('\n');
        sb.Append("  CDrawbridge: ").Append(this.CDrawbridge).Append('\n');
        sb.Append("  DRoughTerrain: ").Append(this.DRoughTerrain).Append('\n');
        sb.Append("  DRockWall: ").Append(this.DRockWall).Append('\n');
        sb.Append("  AverageHighGoals: ").Append(this.AverageHighGoals).Append('\n');
        sb.Append("  AverageLowGoals: ").Append(this.AverageLowGoals).Append('\n');
        sb.Append("  Breaches: ").Append(this.Breaches).Append('\n');
        sb.Append("  Scales: ").Append(this.Scales).Append('\n');
        sb.Append("  Challenges: ").Append(this.Challenges).Append('\n');
        sb.Append("  Captures: ").Append(this.Captures).Append('\n');
        sb.Append("  AverageWinScore: ").Append(this.AverageWinScore).Append('\n');
        sb.Append("  AverageWinMargin: ").Append(this.AverageWinMargin).Append('\n');
        sb.Append("  AverageScore: ").Append(this.AverageScore).Append('\n');
        sb.Append("  AverageAutoScore: ").Append(this.AverageAutoScore).Append('\n');
        sb.Append("  AverageCrossingScore: ").Append(this.AverageCrossingScore).Append('\n');
        sb.Append("  AverageBoulderScore: ").Append(this.AverageBoulderScore).Append('\n');
        sb.Append("  AverageTowerScore: ").Append(this.AverageTowerScore).Append('\n');
        sb.Append("  AverageFoulScore: ").Append(this.AverageFoulScore).Append('\n');
        sb.Append("  HighScore: ").Append(this.HighScore).Append('\n');
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
            if (this.LowBar is not null)
            {
                hashCode = (hashCode * 59) + this.LowBar.GetHashCode();
            }

            if (this.AChevalDeFrise is not null)
            {
                hashCode = (hashCode * 59) + this.AChevalDeFrise.GetHashCode();
            }

            if (this.APortcullis is not null)
            {
                hashCode = (hashCode * 59) + this.APortcullis.GetHashCode();
            }

            if (this.BRamparts is not null)
            {
                hashCode = (hashCode * 59) + this.BRamparts.GetHashCode();
            }

            if (this.BMoat is not null)
            {
                hashCode = (hashCode * 59) + this.BMoat.GetHashCode();
            }

            if (this.CSallyPort is not null)
            {
                hashCode = (hashCode * 59) + this.CSallyPort.GetHashCode();
            }

            if (this.CDrawbridge is not null)
            {
                hashCode = (hashCode * 59) + this.CDrawbridge.GetHashCode();
            }

            if (this.DRoughTerrain is not null)
            {
                hashCode = (hashCode * 59) + this.DRoughTerrain.GetHashCode();
            }

            if (this.DRockWall is not null)
            {
                hashCode = (hashCode * 59) + this.DRockWall.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.AverageHighGoals.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageLowGoals.GetHashCode();
            if (this.Breaches is not null)
            {
                hashCode = (hashCode * 59) + this.Breaches.GetHashCode();
            }

            if (this.Scales is not null)
            {
                hashCode = (hashCode * 59) + this.Scales.GetHashCode();
            }

            if (this.Challenges is not null)
            {
                hashCode = (hashCode * 59) + this.Challenges.GetHashCode();
            }

            if (this.Captures is not null)
            {
                hashCode = (hashCode * 59) + this.Captures.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.AverageWinScore.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageWinMargin.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageScore.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageAutoScore.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageCrossingScore.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageBoulderScore.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageTowerScore.GetHashCode();
            hashCode = (hashCode * 59) + this.AverageFoulScore.GetHashCode();
            if (this.HighScore is not null)
            {
                hashCode = (hashCode * 59) + this.HighScore.GetHashCode();
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
