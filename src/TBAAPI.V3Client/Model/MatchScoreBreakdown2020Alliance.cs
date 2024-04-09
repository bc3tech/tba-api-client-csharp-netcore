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
/// MatchScoreBreakdown2020Alliance
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="MatchScoreBreakdown2020Alliance" /> class.
/// </remarks>
/// <param name="initLineRobot1">initLineRobot1.</param>
/// <param name="endgameRobot1">endgameRobot1.</param>
/// <param name="initLineRobot2">initLineRobot2.</param>
/// <param name="endgameRobot2">endgameRobot2.</param>
/// <param name="initLineRobot3">initLineRobot3.</param>
/// <param name="endgameRobot3">endgameRobot3.</param>
/// <param name="autoCellsBottom">autoCellsBottom.</param>
/// <param name="autoCellsOuter">autoCellsOuter.</param>
/// <param name="autoCellsInner">autoCellsInner.</param>
/// <param name="teleopCellsBottom">teleopCellsBottom.</param>
/// <param name="teleopCellsOuter">teleopCellsOuter.</param>
/// <param name="teleopCellsInner">teleopCellsInner.</param>
/// <param name="stage1Activated">stage1Activated.</param>
/// <param name="stage2Activated">stage2Activated.</param>
/// <param name="stage3Activated">stage3Activated.</param>
/// <param name="stage3TargetColor">stage3TargetColor.</param>
/// <param name="endgameRungIsLevel">endgameRungIsLevel.</param>
/// <param name="autoInitLinePoints">autoInitLinePoints.</param>
/// <param name="autoCellPoints">autoCellPoints.</param>
/// <param name="autoPoints">autoPoints.</param>
/// <param name="teleopCellPoints">teleopCellPoints.</param>
/// <param name="controlPanelPoints">controlPanelPoints.</param>
/// <param name="endgamePoints">endgamePoints.</param>
/// <param name="teleopPoints">teleopPoints.</param>
/// <param name="shieldOperationalRankingPoint">shieldOperationalRankingPoint.</param>
/// <param name="shieldEnergizedRankingPoint">shieldEnergizedRankingPoint.</param>
/// <param name="tbaShieldEnergizedRankingPointFromFoul">Unofficial TBA-computed value that indicates whether the shieldEnergizedRankingPoint was earned normally or awarded due to a foul..</param>
/// <param name="tbaNumRobotsHanging">Unofficial TBA-computed value that counts the number of robots who were hanging at the end of the match..</param>
/// <param name="foulCount">foulCount.</param>
/// <param name="techFoulCount">techFoulCount.</param>
/// <param name="adjustPoints">adjustPoints.</param>
/// <param name="foulPoints">foulPoints.</param>
/// <param name="rp">rp.</param>
/// <param name="totalPoints">totalPoints.</param>
[DataContract]
public partial class MatchScoreBreakdown2020Alliance(string? initLineRobot1 = default, string? endgameRobot1 = default, string? initLineRobot2 = default, string? endgameRobot2 = default, string? initLineRobot3 = default, string? endgameRobot3 = default, int autoCellsBottom = default, int autoCellsOuter = default, int autoCellsInner = default, int teleopCellsBottom = default, int teleopCellsOuter = default, int teleopCellsInner = default, bool stage1Activated = default, bool stage2Activated = default, bool stage3Activated = default, string? stage3TargetColor = default, string? endgameRungIsLevel = default, int autoInitLinePoints = default, int autoCellPoints = default, int autoPoints = default, int teleopCellPoints = default, int controlPanelPoints = default, int endgamePoints = default, int teleopPoints = default, bool shieldOperationalRankingPoint = default, bool shieldEnergizedRankingPoint = default, bool tbaShieldEnergizedRankingPointFromFoul = default, int tbaNumRobotsHanging = default, int foulCount = default, int techFoulCount = default, int adjustPoints = default, int foulPoints = default, int rp = default, int totalPoints = default) : IEquatable<MatchScoreBreakdown2020Alliance>, IValidatableObject
{

    /// <summary>
    /// Gets or Sets InitLineRobot1
    /// </summary>
    [DataMember(Name = "initLineRobot1", EmitDefaultValue = false), JsonPropertyName("initLineRobot1")]
    public string? InitLineRobot1 { get; set; } = initLineRobot1;

    /// <summary>
    /// Gets or Sets EndgameRobot1
    /// </summary>
    [DataMember(Name = "endgameRobot1", EmitDefaultValue = false), JsonPropertyName("endgameRobot1")]
    public string? EndgameRobot1 { get; set; } = endgameRobot1;

    /// <summary>
    /// Gets or Sets InitLineRobot2
    /// </summary>
    [DataMember(Name = "initLineRobot2", EmitDefaultValue = false), JsonPropertyName("initLineRobot2")]
    public string? InitLineRobot2 { get; set; } = initLineRobot2;

    /// <summary>
    /// Gets or Sets EndgameRobot2
    /// </summary>
    [DataMember(Name = "endgameRobot2", EmitDefaultValue = false), JsonPropertyName("endgameRobot2")]
    public string? EndgameRobot2 { get; set; } = endgameRobot2;

    /// <summary>
    /// Gets or Sets InitLineRobot3
    /// </summary>
    [DataMember(Name = "initLineRobot3", EmitDefaultValue = false), JsonPropertyName("initLineRobot3")]
    public string? InitLineRobot3 { get; set; } = initLineRobot3;

    /// <summary>
    /// Gets or Sets EndgameRobot3
    /// </summary>
    [DataMember(Name = "endgameRobot3", EmitDefaultValue = false), JsonPropertyName("endgameRobot3")]
    public string? EndgameRobot3 { get; set; } = endgameRobot3;

    /// <summary>
    /// Gets or Sets AutoCellsBottom
    /// </summary>
    [DataMember(Name = "autoCellsBottom", EmitDefaultValue = false), JsonPropertyName("autoCellsBottom")]
    public int AutoCellsBottom { get; set; } = autoCellsBottom;

    /// <summary>
    /// Gets or Sets AutoCellsOuter
    /// </summary>
    [DataMember(Name = "autoCellsOuter", EmitDefaultValue = false), JsonPropertyName("autoCellsOuter")]
    public int AutoCellsOuter { get; set; } = autoCellsOuter;

    /// <summary>
    /// Gets or Sets AutoCellsInner
    /// </summary>
    [DataMember(Name = "autoCellsInner", EmitDefaultValue = false), JsonPropertyName("autoCellsInner")]
    public int AutoCellsInner { get; set; } = autoCellsInner;

    /// <summary>
    /// Gets or Sets TeleopCellsBottom
    /// </summary>
    [DataMember(Name = "teleopCellsBottom", EmitDefaultValue = false), JsonPropertyName("teleopCellsBottom")]
    public int TeleopCellsBottom { get; set; } = teleopCellsBottom;

    /// <summary>
    /// Gets or Sets TeleopCellsOuter
    /// </summary>
    [DataMember(Name = "teleopCellsOuter", EmitDefaultValue = false), JsonPropertyName("teleopCellsOuter")]
    public int TeleopCellsOuter { get; set; } = teleopCellsOuter;

    /// <summary>
    /// Gets or Sets TeleopCellsInner
    /// </summary>
    [DataMember(Name = "teleopCellsInner", EmitDefaultValue = false), JsonPropertyName("teleopCellsInner")]
    public int TeleopCellsInner { get; set; } = teleopCellsInner;

    /// <summary>
    /// Gets or Sets Stage1Activated
    /// </summary>
    [DataMember(Name = "stage1Activated", EmitDefaultValue = false), JsonPropertyName("stage1Activated")]
    public bool Stage1Activated { get; set; } = stage1Activated;

    /// <summary>
    /// Gets or Sets Stage2Activated
    /// </summary>
    [DataMember(Name = "stage2Activated", EmitDefaultValue = false), JsonPropertyName("stage2Activated")]
    public bool Stage2Activated { get; set; } = stage2Activated;

    /// <summary>
    /// Gets or Sets Stage3Activated
    /// </summary>
    [DataMember(Name = "stage3Activated", EmitDefaultValue = false), JsonPropertyName("stage3Activated")]
    public bool Stage3Activated { get; set; } = stage3Activated;

    /// <summary>
    /// Gets or Sets Stage3TargetColor
    /// </summary>
    [DataMember(Name = "stage3TargetColor", EmitDefaultValue = false), JsonPropertyName("stage3TargetColor")]
    public string? Stage3TargetColor { get; set; } = stage3TargetColor;

    /// <summary>
    /// Gets or Sets EndgameRungIsLevel
    /// </summary>
    [DataMember(Name = "endgameRungIsLevel", EmitDefaultValue = false), JsonPropertyName("endgameRungIsLevel")]
    public string? EndgameRungIsLevel { get; set; } = endgameRungIsLevel;

    /// <summary>
    /// Gets or Sets AutoInitLinePoints
    /// </summary>
    [DataMember(Name = "autoInitLinePoints", EmitDefaultValue = false), JsonPropertyName("autoInitLinePoints")]
    public int AutoInitLinePoints { get; set; } = autoInitLinePoints;

    /// <summary>
    /// Gets or Sets AutoCellPoints
    /// </summary>
    [DataMember(Name = "autoCellPoints", EmitDefaultValue = false), JsonPropertyName("autoCellPoints")]
    public int AutoCellPoints { get; set; } = autoCellPoints;

    /// <summary>
    /// Gets or Sets AutoPoints
    /// </summary>
    [DataMember(Name = "autoPoints", EmitDefaultValue = false), JsonPropertyName("autoPoints")]
    public int AutoPoints { get; set; } = autoPoints;

    /// <summary>
    /// Gets or Sets TeleopCellPoints
    /// </summary>
    [DataMember(Name = "teleopCellPoints", EmitDefaultValue = false), JsonPropertyName("teleopCellPoints")]
    public int TeleopCellPoints { get; set; } = teleopCellPoints;

    /// <summary>
    /// Gets or Sets ControlPanelPoints
    /// </summary>
    [DataMember(Name = "controlPanelPoints", EmitDefaultValue = false), JsonPropertyName("controlPanelPoints")]
    public int ControlPanelPoints { get; set; } = controlPanelPoints;

    /// <summary>
    /// Gets or Sets EndgamePoints
    /// </summary>
    [DataMember(Name = "endgamePoints", EmitDefaultValue = false), JsonPropertyName("endgamePoints")]
    public int EndgamePoints { get; set; } = endgamePoints;

    /// <summary>
    /// Gets or Sets TeleopPoints
    /// </summary>
    [DataMember(Name = "teleopPoints", EmitDefaultValue = false), JsonPropertyName("teleopPoints")]
    public int TeleopPoints { get; set; } = teleopPoints;

    /// <summary>
    /// Gets or Sets ShieldOperationalRankingPoint
    /// </summary>
    [DataMember(Name = "shieldOperationalRankingPoint", EmitDefaultValue = false), JsonPropertyName("shieldOperationalRankingPoint")]
    public bool ShieldOperationalRankingPoint { get; set; } = shieldOperationalRankingPoint;

    /// <summary>
    /// Gets or Sets ShieldEnergizedRankingPoint
    /// </summary>
    [DataMember(Name = "shieldEnergizedRankingPoint", EmitDefaultValue = false), JsonPropertyName("shieldEnergizedRankingPoint")]
    public bool ShieldEnergizedRankingPoint { get; set; } = shieldEnergizedRankingPoint;

    /// <summary>
    /// Unofficial TBA-computed value that indicates whether the shieldEnergizedRankingPoint was earned normally or awarded due to a foul.
    /// </summary>
    /// <value>Unofficial TBA-computed value that indicates whether the shieldEnergizedRankingPoint was earned normally or awarded due to a foul.</value>
    [DataMember(Name = "tba_shieldEnergizedRankingPointFromFoul", EmitDefaultValue = false), JsonPropertyName("tba_shieldEnergizedRankingPointFromFoul")]
    public bool TbaShieldEnergizedRankingPointFromFoul { get; set; } = tbaShieldEnergizedRankingPointFromFoul;

    /// <summary>
    /// Unofficial TBA-computed value that counts the number of robots who were hanging at the end of the match.
    /// </summary>
    /// <value>Unofficial TBA-computed value that counts the number of robots who were hanging at the end of the match.</value>
    [DataMember(Name = "tba_numRobotsHanging", EmitDefaultValue = false), JsonPropertyName("tba_numRobotsHanging")]
    public int TbaNumRobotsHanging { get; set; } = tbaNumRobotsHanging;

    /// <summary>
    /// Gets or Sets FoulCount
    /// </summary>
    [DataMember(Name = "foulCount", EmitDefaultValue = false), JsonPropertyName("foulCount")]
    public int FoulCount { get; set; } = foulCount;

    /// <summary>
    /// Gets or Sets TechFoulCount
    /// </summary>
    [DataMember(Name = "techFoulCount", EmitDefaultValue = false), JsonPropertyName("techFoulCount")]
    public int TechFoulCount { get; set; } = techFoulCount;

    /// <summary>
    /// Gets or Sets AdjustPoints
    /// </summary>
    [DataMember(Name = "adjustPoints", EmitDefaultValue = false), JsonPropertyName("adjustPoints")]
    public int AdjustPoints { get; set; } = adjustPoints;

    /// <summary>
    /// Gets or Sets FoulPoints
    /// </summary>
    [DataMember(Name = "foulPoints", EmitDefaultValue = false), JsonPropertyName("foulPoints")]
    public int FoulPoints { get; set; } = foulPoints;

    /// <summary>
    /// Gets or Sets Rp
    /// </summary>
    [DataMember(Name = "rp", EmitDefaultValue = false), JsonPropertyName("rp")]
    public int Rp { get; set; } = rp;

    /// <summary>
    /// Gets or Sets TotalPoints
    /// </summary>
    [DataMember(Name = "totalPoints", EmitDefaultValue = false), JsonPropertyName("totalPoints")]
    public int TotalPoints { get; set; } = totalPoints;

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchScoreBreakdown2020Alliance {\n");
        sb.Append("  InitLineRobot1: ").Append(this.InitLineRobot1).Append('\n');
        sb.Append("  EndgameRobot1: ").Append(this.EndgameRobot1).Append('\n');
        sb.Append("  InitLineRobot2: ").Append(this.InitLineRobot2).Append('\n');
        sb.Append("  EndgameRobot2: ").Append(this.EndgameRobot2).Append('\n');
        sb.Append("  InitLineRobot3: ").Append(this.InitLineRobot3).Append('\n');
        sb.Append("  EndgameRobot3: ").Append(this.EndgameRobot3).Append('\n');
        sb.Append("  AutoCellsBottom: ").Append(this.AutoCellsBottom).Append('\n');
        sb.Append("  AutoCellsOuter: ").Append(this.AutoCellsOuter).Append('\n');
        sb.Append("  AutoCellsInner: ").Append(this.AutoCellsInner).Append('\n');
        sb.Append("  TeleopCellsBottom: ").Append(this.TeleopCellsBottom).Append('\n');
        sb.Append("  TeleopCellsOuter: ").Append(this.TeleopCellsOuter).Append('\n');
        sb.Append("  TeleopCellsInner: ").Append(this.TeleopCellsInner).Append('\n');
        sb.Append("  Stage1Activated: ").Append(this.Stage1Activated).Append('\n');
        sb.Append("  Stage2Activated: ").Append(this.Stage2Activated).Append('\n');
        sb.Append("  Stage3Activated: ").Append(this.Stage3Activated).Append('\n');
        sb.Append("  Stage3TargetColor: ").Append(this.Stage3TargetColor).Append('\n');
        sb.Append("  EndgameRungIsLevel: ").Append(this.EndgameRungIsLevel).Append('\n');
        sb.Append("  AutoInitLinePoints: ").Append(this.AutoInitLinePoints).Append('\n');
        sb.Append("  AutoCellPoints: ").Append(this.AutoCellPoints).Append('\n');
        sb.Append("  AutoPoints: ").Append(this.AutoPoints).Append('\n');
        sb.Append("  TeleopCellPoints: ").Append(this.TeleopCellPoints).Append('\n');
        sb.Append("  ControlPanelPoints: ").Append(this.ControlPanelPoints).Append('\n');
        sb.Append("  EndgamePoints: ").Append(this.EndgamePoints).Append('\n');
        sb.Append("  TeleopPoints: ").Append(this.TeleopPoints).Append('\n');
        sb.Append("  ShieldOperationalRankingPoint: ").Append(this.ShieldOperationalRankingPoint).Append('\n');
        sb.Append("  ShieldEnergizedRankingPoint: ").Append(this.ShieldEnergizedRankingPoint).Append('\n');
        sb.Append("  TbaShieldEnergizedRankingPointFromFoul: ").Append(this.TbaShieldEnergizedRankingPointFromFoul).Append('\n');
        sb.Append("  TbaNumRobotsHanging: ").Append(this.TbaNumRobotsHanging).Append('\n');
        sb.Append("  FoulCount: ").Append(this.FoulCount).Append('\n');
        sb.Append("  TechFoulCount: ").Append(this.TechFoulCount).Append('\n');
        sb.Append("  AdjustPoints: ").Append(this.AdjustPoints).Append('\n');
        sb.Append("  FoulPoints: ").Append(this.FoulPoints).Append('\n');
        sb.Append("  Rp: ").Append(this.Rp).Append('\n');
        sb.Append("  TotalPoints: ").Append(this.TotalPoints).Append('\n');
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
    public override bool Equals(object? input) => Equals(input as MatchScoreBreakdown2020Alliance);

    /// <summary>
    /// Returns true if MatchScoreBreakdown2020Alliance instances are equal
    /// </summary>
    /// <param name="input">Instance of MatchScoreBreakdown2020Alliance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MatchScoreBreakdown2020Alliance? input)
    {
        return input is not null &&
            (
                this.InitLineRobot1 == input.InitLineRobot1 ||
                (this.InitLineRobot1 is not null &&
                this.InitLineRobot1.Equals(input.InitLineRobot1))
            ) &&
            (
                this.EndgameRobot1 == input.EndgameRobot1 ||
                (this.EndgameRobot1 is not null &&
                this.EndgameRobot1.Equals(input.EndgameRobot1))
            ) &&
            (
                this.InitLineRobot2 == input.InitLineRobot2 ||
                (this.InitLineRobot2 is not null &&
                this.InitLineRobot2.Equals(input.InitLineRobot2))
            ) &&
            (
                this.EndgameRobot2 == input.EndgameRobot2 ||
                (this.EndgameRobot2 is not null &&
                this.EndgameRobot2.Equals(input.EndgameRobot2))
            ) &&
            (
                this.InitLineRobot3 == input.InitLineRobot3 ||
                (this.InitLineRobot3 is not null &&
                this.InitLineRobot3.Equals(input.InitLineRobot3))
            ) &&
            (
                this.EndgameRobot3 == input.EndgameRobot3 ||
                (this.EndgameRobot3 is not null &&
                this.EndgameRobot3.Equals(input.EndgameRobot3))
            ) &&
            (
                this.AutoCellsBottom == input.AutoCellsBottom ||
                this.AutoCellsBottom.Equals(input.AutoCellsBottom)
            ) &&
            (
                this.AutoCellsOuter == input.AutoCellsOuter ||
                this.AutoCellsOuter.Equals(input.AutoCellsOuter)
            ) &&
            (
                this.AutoCellsInner == input.AutoCellsInner ||
                this.AutoCellsInner.Equals(input.AutoCellsInner)
            ) &&
            (
                this.TeleopCellsBottom == input.TeleopCellsBottom ||
                this.TeleopCellsBottom.Equals(input.TeleopCellsBottom)
            ) &&
            (
                this.TeleopCellsOuter == input.TeleopCellsOuter ||
                this.TeleopCellsOuter.Equals(input.TeleopCellsOuter)
            ) &&
            (
                this.TeleopCellsInner == input.TeleopCellsInner ||
                this.TeleopCellsInner.Equals(input.TeleopCellsInner)
            ) &&
            (
                this.Stage1Activated == input.Stage1Activated ||
                this.Stage1Activated.Equals(input.Stage1Activated)
            ) &&
            (
                this.Stage2Activated == input.Stage2Activated ||
                this.Stage2Activated.Equals(input.Stage2Activated)
            ) &&
            (
                this.Stage3Activated == input.Stage3Activated ||
                this.Stage3Activated.Equals(input.Stage3Activated)
            ) &&
            (
                this.Stage3TargetColor == input.Stage3TargetColor ||
                (this.Stage3TargetColor is not null &&
                this.Stage3TargetColor.Equals(input.Stage3TargetColor))
            ) &&
            (
                this.EndgameRungIsLevel == input.EndgameRungIsLevel ||
                (this.EndgameRungIsLevel is not null &&
                this.EndgameRungIsLevel.Equals(input.EndgameRungIsLevel))
            ) &&
            (
                this.AutoInitLinePoints == input.AutoInitLinePoints ||
                this.AutoInitLinePoints.Equals(input.AutoInitLinePoints)
            ) &&
            (
                this.AutoCellPoints == input.AutoCellPoints ||
                this.AutoCellPoints.Equals(input.AutoCellPoints)
            ) &&
            (
                this.AutoPoints == input.AutoPoints ||
                this.AutoPoints.Equals(input.AutoPoints)
            ) &&
            (
                this.TeleopCellPoints == input.TeleopCellPoints ||
                this.TeleopCellPoints.Equals(input.TeleopCellPoints)
            ) &&
            (
                this.ControlPanelPoints == input.ControlPanelPoints ||
                this.ControlPanelPoints.Equals(input.ControlPanelPoints)
            ) &&
            (
                this.EndgamePoints == input.EndgamePoints ||
                this.EndgamePoints.Equals(input.EndgamePoints)
            ) &&
            (
                this.TeleopPoints == input.TeleopPoints ||
                this.TeleopPoints.Equals(input.TeleopPoints)
            ) &&
            (
                this.ShieldOperationalRankingPoint == input.ShieldOperationalRankingPoint ||
                this.ShieldOperationalRankingPoint.Equals(input.ShieldOperationalRankingPoint)
            ) &&
            (
                this.ShieldEnergizedRankingPoint == input.ShieldEnergizedRankingPoint ||
                this.ShieldEnergizedRankingPoint.Equals(input.ShieldEnergizedRankingPoint)
            ) &&
            (
                this.TbaShieldEnergizedRankingPointFromFoul == input.TbaShieldEnergizedRankingPointFromFoul ||
                this.TbaShieldEnergizedRankingPointFromFoul.Equals(input.TbaShieldEnergizedRankingPointFromFoul)
            ) &&
            (
                this.TbaNumRobotsHanging == input.TbaNumRobotsHanging ||
                this.TbaNumRobotsHanging.Equals(input.TbaNumRobotsHanging)
            ) &&
            (
                this.FoulCount == input.FoulCount ||
                this.FoulCount.Equals(input.FoulCount)
            ) &&
            (
                this.TechFoulCount == input.TechFoulCount ||
                this.TechFoulCount.Equals(input.TechFoulCount)
            ) &&
            (
                this.AdjustPoints == input.AdjustPoints ||
                this.AdjustPoints.Equals(input.AdjustPoints)
            ) &&
            (
                this.FoulPoints == input.FoulPoints ||
                this.FoulPoints.Equals(input.FoulPoints)
            ) &&
            (
                this.Rp == input.Rp ||
                this.Rp.Equals(input.Rp)
            ) &&
            (
                this.TotalPoints == input.TotalPoints ||
                this.TotalPoints.Equals(input.TotalPoints)
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
            if (this.InitLineRobot1 is not null)
            {
                hashCode = (hashCode * 59) + this.InitLineRobot1.GetHashCode();
            }

            if (this.EndgameRobot1 is not null)
            {
                hashCode = (hashCode * 59) + this.EndgameRobot1.GetHashCode();
            }

            if (this.InitLineRobot2 is not null)
            {
                hashCode = (hashCode * 59) + this.InitLineRobot2.GetHashCode();
            }

            if (this.EndgameRobot2 is not null)
            {
                hashCode = (hashCode * 59) + this.EndgameRobot2.GetHashCode();
            }

            if (this.InitLineRobot3 is not null)
            {
                hashCode = (hashCode * 59) + this.InitLineRobot3.GetHashCode();
            }

            if (this.EndgameRobot3 is not null)
            {
                hashCode = (hashCode * 59) + this.EndgameRobot3.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.AutoCellsBottom.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoCellsOuter.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoCellsInner.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopCellsBottom.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopCellsOuter.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopCellsInner.GetHashCode();
            hashCode = (hashCode * 59) + this.Stage1Activated.GetHashCode();
            hashCode = (hashCode * 59) + this.Stage2Activated.GetHashCode();
            hashCode = (hashCode * 59) + this.Stage3Activated.GetHashCode();
            if (this.Stage3TargetColor is not null)
            {
                hashCode = (hashCode * 59) + this.Stage3TargetColor.GetHashCode();
            }

            if (this.EndgameRungIsLevel is not null)
            {
                hashCode = (hashCode * 59) + this.EndgameRungIsLevel.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.AutoInitLinePoints.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoCellPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopCellPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.ControlPanelPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.EndgamePoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.ShieldOperationalRankingPoint.GetHashCode();
            hashCode = (hashCode * 59) + this.ShieldEnergizedRankingPoint.GetHashCode();
            hashCode = (hashCode * 59) + this.TbaShieldEnergizedRankingPointFromFoul.GetHashCode();
            hashCode = (hashCode * 59) + this.TbaNumRobotsHanging.GetHashCode();
            hashCode = (hashCode * 59) + this.FoulCount.GetHashCode();
            hashCode = (hashCode * 59) + this.TechFoulCount.GetHashCode();
            hashCode = (hashCode * 59) + this.AdjustPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.FoulPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.Rp.GetHashCode();
            hashCode = (hashCode * 59) + this.TotalPoints.GetHashCode();
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
