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
using System.Text.Json;
using System.Runtime.Serialization;
using System.Text;

/// <summary>
/// A year-specific event insight object expressed as a JSON string, separated in to &#x60;qual&#x60; and &#x60;playoff&#x60; fields. See also Event_Insights_2016, Event_Insights_2017, etc.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="EventInsights" /> class.
/// </remarks>
/// <param name="qual">Inights for the qualification round of an event.</param>
/// <param name="playoff">Insights for the playoff round of an event.</param>
[DataContract]
public partial class EventInsights(object qual = default, object playoff = default) : IEquatable<EventInsights>, IValidatableObject
{

    /// <summary>
    /// Inights for the qualification round of an event
    /// </summary>
    /// <value>Inights for the qualification round of an event</value>
    [DataMember(Name = "qual", EmitDefaultValue = false)]
    public object Qual { get; set; } = qual;

    /// <summary>
    /// Insights for the playoff round of an event
    /// </summary>
    /// <value>Insights for the playoff round of an event</value>
    [DataMember(Name = "playoff", EmitDefaultValue = false)]
    public object Playoff { get; set; } = playoff;

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventInsights {\n");
        sb.Append("  Qual: ").Append(this.Qual).Append('\n');
        sb.Append("  Playoff: ").Append(this.Playoff).Append('\n');
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
    public override bool Equals(object input) => Equals(input as EventInsights);

    /// <summary>
    /// Returns true if EventInsights instances are equal
    /// </summary>
    /// <param name="input">Instance of EventInsights to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventInsights input)
    {
        return input != null
&& (
                this.Qual == input.Qual ||
                (this.Qual != null &&
                this.Qual.Equals(input.Qual))
            ) &&
            (
                this.Playoff == input.Playoff ||
                (this.Playoff != null &&
                this.Playoff.Equals(input.Playoff))
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
            if (this.Qual != null)
            {
                hashCode = (hashCode * 59) + this.Qual.GetHashCode();
            }

            if (this.Playoff != null)
            {
                hashCode = (hashCode * 59) + this.Playoff.GetHashCode();
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
