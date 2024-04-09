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
/// MatchScoreBreakdown2016Alliance
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="MatchScoreBreakdown2016Alliance" /> class.
/// </remarks>
/// <param name="autoPoints">autoPoints.</param>
/// <param name="teleopPoints">teleopPoints.</param>
/// <param name="breachPoints">breachPoints.</param>
/// <param name="foulPoints">foulPoints.</param>
/// <param name="capturePoints">capturePoints.</param>
/// <param name="adjustPoints">adjustPoints.</param>
/// <param name="totalPoints">totalPoints.</param>
/// <param name="robot1Auto">robot1Auto.</param>
/// <param name="robot2Auto">robot2Auto.</param>
/// <param name="robot3Auto">robot3Auto.</param>
/// <param name="autoReachPoints">autoReachPoints.</param>
/// <param name="autoCrossingPoints">autoCrossingPoints.</param>
/// <param name="autoBouldersLow">autoBouldersLow.</param>
/// <param name="autoBouldersHigh">autoBouldersHigh.</param>
/// <param name="autoBoulderPoints">autoBoulderPoints.</param>
/// <param name="teleopCrossingPoints">teleopCrossingPoints.</param>
/// <param name="teleopBouldersLow">teleopBouldersLow.</param>
/// <param name="teleopBouldersHigh">teleopBouldersHigh.</param>
/// <param name="teleopBoulderPoints">teleopBoulderPoints.</param>
/// <param name="teleopDefensesBreached">teleopDefensesBreached.</param>
/// <param name="teleopChallengePoints">teleopChallengePoints.</param>
/// <param name="teleopScalePoints">teleopScalePoints.</param>
/// <param name="teleopTowerCaptured">teleopTowerCaptured.</param>
/// <param name="towerFaceA">towerFaceA.</param>
/// <param name="towerFaceB">towerFaceB.</param>
/// <param name="towerFaceC">towerFaceC.</param>
/// <param name="towerEndStrength">towerEndStrength.</param>
/// <param name="techFoulCount">techFoulCount.</param>
/// <param name="foulCount">foulCount.</param>
/// <param name="position2">position2.</param>
/// <param name="position3">position3.</param>
/// <param name="position4">position4.</param>
/// <param name="position5">position5.</param>
/// <param name="position1crossings">position1crossings.</param>
/// <param name="position2crossings">position2crossings.</param>
/// <param name="position3crossings">position3crossings.</param>
/// <param name="position4crossings">position4crossings.</param>
/// <param name="position5crossings">position5crossings.</param>
[DataContract]
public partial class MatchScoreBreakdown2016Alliance(int autoPoints = default, int teleopPoints = default, int breachPoints = default, int foulPoints = default, int capturePoints = default, int adjustPoints = default, int totalPoints = default, MatchScoreBreakdown2016Alliance.Robot1AutoEnum? robot1Auto = default, MatchScoreBreakdown2016Alliance.Robot2AutoEnum? robot2Auto = default, MatchScoreBreakdown2016Alliance.Robot3AutoEnum? robot3Auto = default, int autoReachPoints = default, int autoCrossingPoints = default, int autoBouldersLow = default, int autoBouldersHigh = default, int autoBoulderPoints = default, int teleopCrossingPoints = default, int teleopBouldersLow = default, int teleopBouldersHigh = default, int teleopBoulderPoints = default, bool teleopDefensesBreached = default, int teleopChallengePoints = default, int teleopScalePoints = default, int teleopTowerCaptured = default, string towerFaceA = default, string towerFaceB = default, string towerFaceC = default, int towerEndStrength = default, int techFoulCount = default, int foulCount = default, string position2 = default, string position3 = default, string position4 = default, string position5 = default, int position1crossings = default, int position2crossings = default, int position3crossings = default, int position4crossings = default, int position5crossings = default) : IEquatable<MatchScoreBreakdown2016Alliance>, IValidatableObject
{
    /// <summary>
    /// Defines Robot1Auto
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Robot1AutoEnum
    {
        /// <summary>
        /// Enum Crossed for value: Crossed
        /// </summary>
        [EnumMember(Value = "Crossed")]
        Crossed = 1,

        /// <summary>
        /// Enum Reached for value: Reached
        /// </summary>
        [EnumMember(Value = "Reached")]
        Reached = 2,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 3

    }

    /// <summary>
    /// Gets or Sets Robot1Auto
    /// </summary>
    [DataMember(Name = "robot1Auto", EmitDefaultValue = false), JsonPropertyName("robot1Auto")]
    public Robot1AutoEnum? Robot1Auto { get; set; } = robot1Auto;
    /// <summary>
    /// Defines Robot2Auto
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Robot2AutoEnum
    {
        /// <summary>
        /// Enum Crossed for value: Crossed
        /// </summary>
        [EnumMember(Value = "Crossed")]
        Crossed = 1,

        /// <summary>
        /// Enum Reached for value: Reached
        /// </summary>
        [EnumMember(Value = "Reached")]
        Reached = 2,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 3

    }

    /// <summary>
    /// Gets or Sets Robot2Auto
    /// </summary>
    [DataMember(Name = "robot2Auto", EmitDefaultValue = false), JsonPropertyName("robot2Auto")]
    public Robot2AutoEnum? Robot2Auto { get; set; } = robot2Auto;
    /// <summary>
    /// Defines Robot3Auto
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Robot3AutoEnum
    {
        /// <summary>
        /// Enum Crossed for value: Crossed
        /// </summary>
        [EnumMember(Value = "Crossed")]
        Crossed = 1,

        /// <summary>
        /// Enum Reached for value: Reached
        /// </summary>
        [EnumMember(Value = "Reached")]
        Reached = 2,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 3

    }

    /// <summary>
    /// Gets or Sets Robot3Auto
    /// </summary>
    [DataMember(Name = "robot3Auto", EmitDefaultValue = false), JsonPropertyName("robot3Auto")]
    public Robot3AutoEnum? Robot3Auto { get; set; } = robot3Auto;

    /// <summary>
    /// Gets or Sets AutoPoints
    /// </summary>
    [DataMember(Name = "autoPoints", EmitDefaultValue = false), JsonPropertyName("autoPoints")]
    public int AutoPoints { get; set; } = autoPoints;

    /// <summary>
    /// Gets or Sets TeleopPoints
    /// </summary>
    [DataMember(Name = "teleopPoints", EmitDefaultValue = false), JsonPropertyName("teleopPoints")]
    public int TeleopPoints { get; set; } = teleopPoints;

    /// <summary>
    /// Gets or Sets BreachPoints
    /// </summary>
    [DataMember(Name = "breachPoints", EmitDefaultValue = false), JsonPropertyName("breachPoints")]
    public int BreachPoints { get; set; } = breachPoints;

    /// <summary>
    /// Gets or Sets FoulPoints
    /// </summary>
    [DataMember(Name = "foulPoints", EmitDefaultValue = false), JsonPropertyName("foulPoints")]
    public int FoulPoints { get; set; } = foulPoints;

    /// <summary>
    /// Gets or Sets CapturePoints
    /// </summary>
    [DataMember(Name = "capturePoints", EmitDefaultValue = false), JsonPropertyName("capturePoints")]
    public int CapturePoints { get; set; } = capturePoints;

    /// <summary>
    /// Gets or Sets AdjustPoints
    /// </summary>
    [DataMember(Name = "adjustPoints", EmitDefaultValue = false), JsonPropertyName("adjustPoints")]
    public int AdjustPoints { get; set; } = adjustPoints;

    /// <summary>
    /// Gets or Sets TotalPoints
    /// </summary>
    [DataMember(Name = "totalPoints", EmitDefaultValue = false), JsonPropertyName("totalPoints")]
    public int TotalPoints { get; set; } = totalPoints;

    /// <summary>
    /// Gets or Sets AutoReachPoints
    /// </summary>
    [DataMember(Name = "autoReachPoints", EmitDefaultValue = false), JsonPropertyName("autoReachPoints")]
    public int AutoReachPoints { get; set; } = autoReachPoints;

    /// <summary>
    /// Gets or Sets AutoCrossingPoints
    /// </summary>
    [DataMember(Name = "autoCrossingPoints", EmitDefaultValue = false), JsonPropertyName("autoCrossingPoints")]
    public int AutoCrossingPoints { get; set; } = autoCrossingPoints;

    /// <summary>
    /// Gets or Sets AutoBouldersLow
    /// </summary>
    [DataMember(Name = "autoBouldersLow", EmitDefaultValue = false), JsonPropertyName("autoBouldersLow")]
    public int AutoBouldersLow { get; set; } = autoBouldersLow;

    /// <summary>
    /// Gets or Sets AutoBouldersHigh
    /// </summary>
    [DataMember(Name = "autoBouldersHigh", EmitDefaultValue = false), JsonPropertyName("autoBouldersHigh")]
    public int AutoBouldersHigh { get; set; } = autoBouldersHigh;

    /// <summary>
    /// Gets or Sets AutoBoulderPoints
    /// </summary>
    [DataMember(Name = "autoBoulderPoints", EmitDefaultValue = false), JsonPropertyName("autoBoulderPoints")]
    public int AutoBoulderPoints { get; set; } = autoBoulderPoints;

    /// <summary>
    /// Gets or Sets TeleopCrossingPoints
    /// </summary>
    [DataMember(Name = "teleopCrossingPoints", EmitDefaultValue = false), JsonPropertyName("teleopCrossingPoints")]
    public int TeleopCrossingPoints { get; set; } = teleopCrossingPoints;

    /// <summary>
    /// Gets or Sets TeleopBouldersLow
    /// </summary>
    [DataMember(Name = "teleopBouldersLow", EmitDefaultValue = false), JsonPropertyName("teleopBouldersLow")]
    public int TeleopBouldersLow { get; set; } = teleopBouldersLow;

    /// <summary>
    /// Gets or Sets TeleopBouldersHigh
    /// </summary>
    [DataMember(Name = "teleopBouldersHigh", EmitDefaultValue = false), JsonPropertyName("teleopBouldersHigh")]
    public int TeleopBouldersHigh { get; set; } = teleopBouldersHigh;

    /// <summary>
    /// Gets or Sets TeleopBoulderPoints
    /// </summary>
    [DataMember(Name = "teleopBoulderPoints", EmitDefaultValue = false), JsonPropertyName("teleopBoulderPoints")]
    public int TeleopBoulderPoints { get; set; } = teleopBoulderPoints;

    /// <summary>
    /// Gets or Sets TeleopDefensesBreached
    /// </summary>
    [DataMember(Name = "teleopDefensesBreached", EmitDefaultValue = false), JsonPropertyName("teleopDefensesBreached")]
    public bool TeleopDefensesBreached { get; set; } = teleopDefensesBreached;

    /// <summary>
    /// Gets or Sets TeleopChallengePoints
    /// </summary>
    [DataMember(Name = "teleopChallengePoints", EmitDefaultValue = false), JsonPropertyName("teleopChallengePoints")]
    public int TeleopChallengePoints { get; set; } = teleopChallengePoints;

    /// <summary>
    /// Gets or Sets TeleopScalePoints
    /// </summary>
    [DataMember(Name = "teleopScalePoints", EmitDefaultValue = false), JsonPropertyName("teleopScalePoints")]
    public int TeleopScalePoints { get; set; } = teleopScalePoints;

    /// <summary>
    /// Gets or Sets TeleopTowerCaptured
    /// </summary>
    [DataMember(Name = "teleopTowerCaptured", EmitDefaultValue = false), JsonPropertyName("teleopTowerCaptured")]
    public int TeleopTowerCaptured { get; set; } = teleopTowerCaptured;

    /// <summary>
    /// Gets or Sets TowerFaceA
    /// </summary>
    [DataMember(Name = "towerFaceA", EmitDefaultValue = false), JsonPropertyName("towerFaceA")]
    public string TowerFaceA { get; set; } = towerFaceA;

    /// <summary>
    /// Gets or Sets TowerFaceB
    /// </summary>
    [DataMember(Name = "towerFaceB", EmitDefaultValue = false), JsonPropertyName("towerFaceB")]
    public string TowerFaceB { get; set; } = towerFaceB;

    /// <summary>
    /// Gets or Sets TowerFaceC
    /// </summary>
    [DataMember(Name = "towerFaceC", EmitDefaultValue = false), JsonPropertyName("towerFaceC")]
    public string TowerFaceC { get; set; } = towerFaceC;

    /// <summary>
    /// Gets or Sets TowerEndStrength
    /// </summary>
    [DataMember(Name = "towerEndStrength", EmitDefaultValue = false), JsonPropertyName("towerEndStrength")]
    public int TowerEndStrength { get; set; } = towerEndStrength;

    /// <summary>
    /// Gets or Sets TechFoulCount
    /// </summary>
    [DataMember(Name = "techFoulCount", EmitDefaultValue = false), JsonPropertyName("techFoulCount")]
    public int TechFoulCount { get; set; } = techFoulCount;

    /// <summary>
    /// Gets or Sets FoulCount
    /// </summary>
    [DataMember(Name = "foulCount", EmitDefaultValue = false), JsonPropertyName("foulCount")]
    public int FoulCount { get; set; } = foulCount;

    /// <summary>
    /// Gets or Sets Position2
    /// </summary>
    [DataMember(Name = "position2", EmitDefaultValue = false), JsonPropertyName("position2")]
    public string Position2 { get; set; } = position2;

    /// <summary>
    /// Gets or Sets Position3
    /// </summary>
    [DataMember(Name = "position3", EmitDefaultValue = false), JsonPropertyName("position3")]
    public string Position3 { get; set; } = position3;

    /// <summary>
    /// Gets or Sets Position4
    /// </summary>
    [DataMember(Name = "position4", EmitDefaultValue = false), JsonPropertyName("position4")]
    public string Position4 { get; set; } = position4;

    /// <summary>
    /// Gets or Sets Position5
    /// </summary>
    [DataMember(Name = "position5", EmitDefaultValue = false), JsonPropertyName("position5")]
    public string Position5 { get; set; } = position5;

    /// <summary>
    /// Gets or Sets Position1crossings
    /// </summary>
    [DataMember(Name = "position1crossings", EmitDefaultValue = false), JsonPropertyName("position1crossings")]
    public int Position1crossings { get; set; } = position1crossings;

    /// <summary>
    /// Gets or Sets Position2crossings
    /// </summary>
    [DataMember(Name = "position2crossings", EmitDefaultValue = false), JsonPropertyName("position2crossings")]
    public int Position2crossings { get; set; } = position2crossings;

    /// <summary>
    /// Gets or Sets Position3crossings
    /// </summary>
    [DataMember(Name = "position3crossings", EmitDefaultValue = false), JsonPropertyName("position3crossings")]
    public int Position3crossings { get; set; } = position3crossings;

    /// <summary>
    /// Gets or Sets Position4crossings
    /// </summary>
    [DataMember(Name = "position4crossings", EmitDefaultValue = false), JsonPropertyName("position4crossings")]
    public int Position4crossings { get; set; } = position4crossings;

    /// <summary>
    /// Gets or Sets Position5crossings
    /// </summary>
    [DataMember(Name = "position5crossings", EmitDefaultValue = false), JsonPropertyName("position5crossings")]
    public int Position5crossings { get; set; } = position5crossings;

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchScoreBreakdown2016Alliance {\n");
        sb.Append("  AutoPoints: ").Append(this.AutoPoints).Append('\n');
        sb.Append("  TeleopPoints: ").Append(this.TeleopPoints).Append('\n');
        sb.Append("  BreachPoints: ").Append(this.BreachPoints).Append('\n');
        sb.Append("  FoulPoints: ").Append(this.FoulPoints).Append('\n');
        sb.Append("  CapturePoints: ").Append(this.CapturePoints).Append('\n');
        sb.Append("  AdjustPoints: ").Append(this.AdjustPoints).Append('\n');
        sb.Append("  TotalPoints: ").Append(this.TotalPoints).Append('\n');
        sb.Append("  Robot1Auto: ").Append(this.Robot1Auto).Append('\n');
        sb.Append("  Robot2Auto: ").Append(this.Robot2Auto).Append('\n');
        sb.Append("  Robot3Auto: ").Append(this.Robot3Auto).Append('\n');
        sb.Append("  AutoReachPoints: ").Append(this.AutoReachPoints).Append('\n');
        sb.Append("  AutoCrossingPoints: ").Append(this.AutoCrossingPoints).Append('\n');
        sb.Append("  AutoBouldersLow: ").Append(this.AutoBouldersLow).Append('\n');
        sb.Append("  AutoBouldersHigh: ").Append(this.AutoBouldersHigh).Append('\n');
        sb.Append("  AutoBoulderPoints: ").Append(this.AutoBoulderPoints).Append('\n');
        sb.Append("  TeleopCrossingPoints: ").Append(this.TeleopCrossingPoints).Append('\n');
        sb.Append("  TeleopBouldersLow: ").Append(this.TeleopBouldersLow).Append('\n');
        sb.Append("  TeleopBouldersHigh: ").Append(this.TeleopBouldersHigh).Append('\n');
        sb.Append("  TeleopBoulderPoints: ").Append(this.TeleopBoulderPoints).Append('\n');
        sb.Append("  TeleopDefensesBreached: ").Append(this.TeleopDefensesBreached).Append('\n');
        sb.Append("  TeleopChallengePoints: ").Append(this.TeleopChallengePoints).Append('\n');
        sb.Append("  TeleopScalePoints: ").Append(this.TeleopScalePoints).Append('\n');
        sb.Append("  TeleopTowerCaptured: ").Append(this.TeleopTowerCaptured).Append('\n');
        sb.Append("  TowerFaceA: ").Append(this.TowerFaceA).Append('\n');
        sb.Append("  TowerFaceB: ").Append(this.TowerFaceB).Append('\n');
        sb.Append("  TowerFaceC: ").Append(this.TowerFaceC).Append('\n');
        sb.Append("  TowerEndStrength: ").Append(this.TowerEndStrength).Append('\n');
        sb.Append("  TechFoulCount: ").Append(this.TechFoulCount).Append('\n');
        sb.Append("  FoulCount: ").Append(this.FoulCount).Append('\n');
        sb.Append("  Position2: ").Append(this.Position2).Append('\n');
        sb.Append("  Position3: ").Append(this.Position3).Append('\n');
        sb.Append("  Position4: ").Append(this.Position4).Append('\n');
        sb.Append("  Position5: ").Append(this.Position5).Append('\n');
        sb.Append("  Position1crossings: ").Append(this.Position1crossings).Append('\n');
        sb.Append("  Position2crossings: ").Append(this.Position2crossings).Append('\n');
        sb.Append("  Position3crossings: ").Append(this.Position3crossings).Append('\n');
        sb.Append("  Position4crossings: ").Append(this.Position4crossings).Append('\n');
        sb.Append("  Position5crossings: ").Append(this.Position5crossings).Append('\n');
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
    public override bool Equals(object input) => Equals(input as MatchScoreBreakdown2016Alliance);

    /// <summary>
    /// Returns true if MatchScoreBreakdown2016Alliance instances are equal
    /// </summary>
    /// <param name="input">Instance of MatchScoreBreakdown2016Alliance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MatchScoreBreakdown2016Alliance input)
    {
        return input != null
&& (
                this.AutoPoints == input.AutoPoints ||
                this.AutoPoints.Equals(input.AutoPoints)
            ) &&
            (
                this.TeleopPoints == input.TeleopPoints ||
                this.TeleopPoints.Equals(input.TeleopPoints)
            ) &&
            (
                this.BreachPoints == input.BreachPoints ||
                this.BreachPoints.Equals(input.BreachPoints)
            ) &&
            (
                this.FoulPoints == input.FoulPoints ||
                this.FoulPoints.Equals(input.FoulPoints)
            ) &&
            (
                this.CapturePoints == input.CapturePoints ||
                this.CapturePoints.Equals(input.CapturePoints)
            ) &&
            (
                this.AdjustPoints == input.AdjustPoints ||
                this.AdjustPoints.Equals(input.AdjustPoints)
            ) &&
            (
                this.TotalPoints == input.TotalPoints ||
                this.TotalPoints.Equals(input.TotalPoints)
            ) &&
            (
                this.Robot1Auto == input.Robot1Auto ||
                this.Robot1Auto.Equals(input.Robot1Auto)
            ) &&
            (
                this.Robot2Auto == input.Robot2Auto ||
                this.Robot2Auto.Equals(input.Robot2Auto)
            ) &&
            (
                this.Robot3Auto == input.Robot3Auto ||
                this.Robot3Auto.Equals(input.Robot3Auto)
            ) &&
            (
                this.AutoReachPoints == input.AutoReachPoints ||
                this.AutoReachPoints.Equals(input.AutoReachPoints)
            ) &&
            (
                this.AutoCrossingPoints == input.AutoCrossingPoints ||
                this.AutoCrossingPoints.Equals(input.AutoCrossingPoints)
            ) &&
            (
                this.AutoBouldersLow == input.AutoBouldersLow ||
                this.AutoBouldersLow.Equals(input.AutoBouldersLow)
            ) &&
            (
                this.AutoBouldersHigh == input.AutoBouldersHigh ||
                this.AutoBouldersHigh.Equals(input.AutoBouldersHigh)
            ) &&
            (
                this.AutoBoulderPoints == input.AutoBoulderPoints ||
                this.AutoBoulderPoints.Equals(input.AutoBoulderPoints)
            ) &&
            (
                this.TeleopCrossingPoints == input.TeleopCrossingPoints ||
                this.TeleopCrossingPoints.Equals(input.TeleopCrossingPoints)
            ) &&
            (
                this.TeleopBouldersLow == input.TeleopBouldersLow ||
                this.TeleopBouldersLow.Equals(input.TeleopBouldersLow)
            ) &&
            (
                this.TeleopBouldersHigh == input.TeleopBouldersHigh ||
                this.TeleopBouldersHigh.Equals(input.TeleopBouldersHigh)
            ) &&
            (
                this.TeleopBoulderPoints == input.TeleopBoulderPoints ||
                this.TeleopBoulderPoints.Equals(input.TeleopBoulderPoints)
            ) &&
            (
                this.TeleopDefensesBreached == input.TeleopDefensesBreached ||
                this.TeleopDefensesBreached.Equals(input.TeleopDefensesBreached)
            ) &&
            (
                this.TeleopChallengePoints == input.TeleopChallengePoints ||
                this.TeleopChallengePoints.Equals(input.TeleopChallengePoints)
            ) &&
            (
                this.TeleopScalePoints == input.TeleopScalePoints ||
                this.TeleopScalePoints.Equals(input.TeleopScalePoints)
            ) &&
            (
                this.TeleopTowerCaptured == input.TeleopTowerCaptured ||
                this.TeleopTowerCaptured.Equals(input.TeleopTowerCaptured)
            ) &&
            (
                this.TowerFaceA == input.TowerFaceA ||
                (this.TowerFaceA != null &&
                this.TowerFaceA.Equals(input.TowerFaceA))
            ) &&
            (
                this.TowerFaceB == input.TowerFaceB ||
                (this.TowerFaceB != null &&
                this.TowerFaceB.Equals(input.TowerFaceB))
            ) &&
            (
                this.TowerFaceC == input.TowerFaceC ||
                (this.TowerFaceC != null &&
                this.TowerFaceC.Equals(input.TowerFaceC))
            ) &&
            (
                this.TowerEndStrength == input.TowerEndStrength ||
                this.TowerEndStrength.Equals(input.TowerEndStrength)
            ) &&
            (
                this.TechFoulCount == input.TechFoulCount ||
                this.TechFoulCount.Equals(input.TechFoulCount)
            ) &&
            (
                this.FoulCount == input.FoulCount ||
                this.FoulCount.Equals(input.FoulCount)
            ) &&
            (
                this.Position2 == input.Position2 ||
                (this.Position2 != null &&
                this.Position2.Equals(input.Position2))
            ) &&
            (
                this.Position3 == input.Position3 ||
                (this.Position3 != null &&
                this.Position3.Equals(input.Position3))
            ) &&
            (
                this.Position4 == input.Position4 ||
                (this.Position4 != null &&
                this.Position4.Equals(input.Position4))
            ) &&
            (
                this.Position5 == input.Position5 ||
                (this.Position5 != null &&
                this.Position5.Equals(input.Position5))
            ) &&
            (
                this.Position1crossings == input.Position1crossings ||
                this.Position1crossings.Equals(input.Position1crossings)
            ) &&
            (
                this.Position2crossings == input.Position2crossings ||
                this.Position2crossings.Equals(input.Position2crossings)
            ) &&
            (
                this.Position3crossings == input.Position3crossings ||
                this.Position3crossings.Equals(input.Position3crossings)
            ) &&
            (
                this.Position4crossings == input.Position4crossings ||
                this.Position4crossings.Equals(input.Position4crossings)
            ) &&
            (
                this.Position5crossings == input.Position5crossings ||
                this.Position5crossings.Equals(input.Position5crossings)
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
            hashCode = (hashCode * 59) + this.AutoPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.BreachPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.FoulPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.CapturePoints.GetHashCode();
            hashCode = (hashCode * 59) + this.AdjustPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TotalPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.Robot1Auto.GetHashCode();
            hashCode = (hashCode * 59) + this.Robot2Auto.GetHashCode();
            hashCode = (hashCode * 59) + this.Robot3Auto.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoReachPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoCrossingPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoBouldersLow.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoBouldersHigh.GetHashCode();
            hashCode = (hashCode * 59) + this.AutoBoulderPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopCrossingPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopBouldersLow.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopBouldersHigh.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopBoulderPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopDefensesBreached.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopChallengePoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopScalePoints.GetHashCode();
            hashCode = (hashCode * 59) + this.TeleopTowerCaptured.GetHashCode();
            if (this.TowerFaceA != null)
            {
                hashCode = (hashCode * 59) + this.TowerFaceA.GetHashCode();
            }

            if (this.TowerFaceB != null)
            {
                hashCode = (hashCode * 59) + this.TowerFaceB.GetHashCode();
            }

            if (this.TowerFaceC != null)
            {
                hashCode = (hashCode * 59) + this.TowerFaceC.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.TowerEndStrength.GetHashCode();
            hashCode = (hashCode * 59) + this.TechFoulCount.GetHashCode();
            hashCode = (hashCode * 59) + this.FoulCount.GetHashCode();
            if (this.Position2 != null)
            {
                hashCode = (hashCode * 59) + this.Position2.GetHashCode();
            }

            if (this.Position3 != null)
            {
                hashCode = (hashCode * 59) + this.Position3.GetHashCode();
            }

            if (this.Position4 != null)
            {
                hashCode = (hashCode * 59) + this.Position4.GetHashCode();
            }

            if (this.Position5 != null)
            {
                hashCode = (hashCode * 59) + this.Position5.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.Position1crossings.GetHashCode();
            hashCode = (hashCode * 59) + this.Position2crossings.GetHashCode();
            hashCode = (hashCode * 59) + this.Position3crossings.GetHashCode();
            hashCode = (hashCode * 59) + this.Position4crossings.GetHashCode();
            hashCode = (hashCode * 59) + this.Position5crossings.GetHashCode();
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
