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
/// EventDistrictPointsPoints
/// </summary>
[DataContract]
public partial record EventDistrictPointsPoints: IValidatableObject
{
    /// <summary>
    /// Total points awarded at this event.
    /// </summary>
    /// <value>Total points awarded at this event.</value>
    [DataMember(Name = "total", EmitDefaultValue = false), JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// Points awarded for alliance selection
    /// </summary>
    /// <value>Points awarded for alliance selection</value>
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
        sb.Append("class EventDistrictPointsPoints {\n");
        sb.Append("  Total: ").Append(this.Total).Append('\n');
        sb.Append("  AlliancePoints: ").Append(this.AlliancePoints).Append('\n');
        sb.Append("  ElimPoints: ").Append(this.ElimPoints).Append('\n');
        sb.Append("  AwardPoints: ").Append(this.AwardPoints).Append('\n');
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
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode() => HashCode.Combine(this.Total, this.AlliancePoints, this.ElimPoints, this.AwardPoints, this.QualPoints);

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext) => [];
}
