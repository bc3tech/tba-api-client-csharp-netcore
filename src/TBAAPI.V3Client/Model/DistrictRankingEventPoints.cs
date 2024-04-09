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
/// DistrictRankingEventPoints
/// </summary>
[DataContract]
public partial class DistrictRankingEventPoints : IEquatable<DistrictRankingEventPoints>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DistrictRankingEventPoints" /> class.
    /// </summary>
    [JsonConstructor]
    protected DistrictRankingEventPoints() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DistrictRankingEventPoints" /> class.
    /// </summary>
    /// <param name="districtCmp">&#x60;true&#x60; if this event is a District Championship event. (required).</param>
    /// <param name="total">Total points awarded at this event. (required).</param>
    /// <param name="alliancePoints">Points awarded for alliance selection. (required).</param>
    /// <param name="elimPoints">Points awarded for elimination match performance. (required).</param>
    /// <param name="awardPoints">Points awarded for event awards. (required).</param>
    /// <param name="eventKey">TBA Event key for this event. (required).</param>
    /// <param name="qualPoints">Points awarded for qualification match performance. (required).</param>
    public DistrictRankingEventPoints(bool districtCmp = default, int total = default, int alliancePoints = default, int elimPoints = default, int awardPoints = default, string? eventKey = default, int qualPoints = default)
    {
        this.DistrictCmp = districtCmp;
        this.Total = total;
        this.AlliancePoints = alliancePoints;
        this.ElimPoints = elimPoints;
        this.AwardPoints = awardPoints;
        // to ensure "eventKey" is required (not null)
        this.EventKey = eventKey ?? throw new ArgumentNullException(nameof(eventKey));
        this.QualPoints = qualPoints;
    }

    /// <summary>
    /// &#x60;true&#x60; if this event is a District Championship event.
    /// </summary>
    /// <value>&#x60;true&#x60; if this event is a District Championship event.</value>
    [DataMember(Name = "district_cmp", EmitDefaultValue = false), JsonPropertyName("district_cmp")]
    public bool DistrictCmp { get; set; }

    /// <summary>
    /// Total points awarded at this event.
    /// </summary>
    /// <value>Total points awarded at this event.</value>
    [DataMember(Name = "total", EmitDefaultValue = false), JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// Points awarded for alliance selection.
    /// </summary>
    /// <value>Points awarded for alliance selection.</value>
    [DataMember(Name = "alliance_points", EmitDefaultValue = false), JsonPropertyName("alliance_points")]
    public int AlliancePoints { get; set; }

    /// <summary>
    /// Points awarded for elimination match performance.
    /// </summary>
    /// <value>Points awarded for elimination match performance.</value>
    [DataMember(Name = "elim_points", EmitDefaultValue = false), JsonPropertyName("elim_points")]
    public int ElimPoints { get; set; }

    /// <summary>
    /// Points awarded for event awards.
    /// </summary>
    /// <value>Points awarded for event awards.</value>
    [DataMember(Name = "award_points", EmitDefaultValue = false), JsonPropertyName("award_points")]
    public int AwardPoints { get; set; }

    /// <summary>
    /// TBA Event key for this event.
    /// </summary>
    /// <value>TBA Event key for this event.</value>
    [DataMember(Name = "event_key", EmitDefaultValue = false), JsonPropertyName("event_key")]
    public string EventKey { get; set; }

    /// <summary>
    /// Points awarded for qualification match performance.
    /// </summary>
    /// <value>Points awarded for qualification match performance.</value>
    [DataMember(Name = "qual_points", EmitDefaultValue = false), JsonPropertyName("qual_points")]
    public int QualPoints { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DistrictRankingEventPoints {\n");
        sb.Append("  DistrictCmp: ").Append(this.DistrictCmp).Append('\n');
        sb.Append("  Total: ").Append(this.Total).Append('\n');
        sb.Append("  AlliancePoints: ").Append(this.AlliancePoints).Append('\n');
        sb.Append("  ElimPoints: ").Append(this.ElimPoints).Append('\n');
        sb.Append("  AwardPoints: ").Append(this.AwardPoints).Append('\n');
        sb.Append("  EventKey: ").Append(this.EventKey).Append('\n');
        sb.Append("  QualPoints: ").Append(this.QualPoints).Append('\n');
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
    public override bool Equals(object? input) => Equals(input as DistrictRankingEventPoints);

    /// <summary>
    /// Returns true if DistrictRankingEventPoints instances are equal
    /// </summary>
    /// <param name="input">Instance of DistrictRankingEventPoints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DistrictRankingEventPoints? input)
    {
        return input is not null
&& (
                this.DistrictCmp == input.DistrictCmp ||
                this.DistrictCmp.Equals(input.DistrictCmp)
            ) &&
            (
                this.Total == input.Total ||
                this.Total.Equals(input.Total)
            ) &&
            (
                this.AlliancePoints == input.AlliancePoints ||
                this.AlliancePoints.Equals(input.AlliancePoints)
            ) &&
            (
                this.ElimPoints == input.ElimPoints ||
                this.ElimPoints.Equals(input.ElimPoints)
            ) &&
            (
                this.AwardPoints == input.AwardPoints ||
                this.AwardPoints.Equals(input.AwardPoints)
            ) &&
            (
                this.EventKey == input.EventKey ||
                (this.EventKey is not null &&
                this.EventKey.Equals(input.EventKey))
            ) &&
            (
                this.QualPoints == input.QualPoints ||
                this.QualPoints.Equals(input.QualPoints)
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
            hashCode = (hashCode * 59) + this.DistrictCmp.GetHashCode();
            hashCode = (hashCode * 59) + this.Total.GetHashCode();
            hashCode = (hashCode * 59) + this.AlliancePoints.GetHashCode();
            hashCode = (hashCode * 59) + this.ElimPoints.GetHashCode();
            hashCode = (hashCode * 59) + this.AwardPoints.GetHashCode();
            if (this.EventKey is not null)
            {
                hashCode = (hashCode * 59) + this.EventKey.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.QualPoints.GetHashCode();
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
