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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
/// <summary>
/// OPR, DPR, and CCWM for teams at the event.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="EventOPRs" /> class.
/// </remarks>
/// <param name="oprs">A key-value pair with team key (eg &#x60;frc254&#x60;) as key and OPR as value..</param>
/// <param name="dprs">A key-value pair with team key (eg &#x60;frc254&#x60;) as key and DPR as value..</param>
/// <param name="ccwms">A key-value pair with team key (eg &#x60;frc254&#x60;) as key and CCWM as value..</param>
[DataContract]
public partial class EventOPRs(Dictionary<string, float> oprs = default, Dictionary<string, float> dprs = default, Dictionary<string, float> ccwms = default) : IEquatable<EventOPRs>, IValidatableObject
{

    /// <summary>
    /// A key-value pair with team key (eg &#x60;frc254&#x60;) as key and OPR as value.
    /// </summary>
    /// <value>A key-value pair with team key (eg &#x60;frc254&#x60;) as key and OPR as value.</value>
    [DataMember(Name = "oprs", EmitDefaultValue = false), JsonPropertyName("oprs")]
    public Dictionary<string, float> Oprs { get; set; } = oprs;

    /// <summary>
    /// A key-value pair with team key (eg &#x60;frc254&#x60;) as key and DPR as value.
    /// </summary>
    /// <value>A key-value pair with team key (eg &#x60;frc254&#x60;) as key and DPR as value.</value>
    [DataMember(Name = "dprs", EmitDefaultValue = false), JsonPropertyName("dprs")]
    public Dictionary<string, float> Dprs { get; set; } = dprs;

    /// <summary>
    /// A key-value pair with team key (eg &#x60;frc254&#x60;) as key and CCWM as value.
    /// </summary>
    /// <value>A key-value pair with team key (eg &#x60;frc254&#x60;) as key and CCWM as value.</value>
    [DataMember(Name = "ccwms", EmitDefaultValue = false), JsonPropertyName("ccwms")]
    public Dictionary<string, float> Ccwms { get; set; } = ccwms;

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventOPRs {\n");
        sb.Append("  Oprs: ").Append(this.Oprs).Append('\n');
        sb.Append("  Dprs: ").Append(this.Dprs).Append('\n');
        sb.Append("  Ccwms: ").Append(this.Ccwms).Append('\n');
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
    public override bool Equals(object input) => Equals(input as EventOPRs);

    /// <summary>
    /// Returns true if EventOPRs instances are equal
    /// </summary>
    /// <param name="input">Instance of EventOPRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventOPRs input)
    {
        return input != null
&& (
                this.Oprs == input.Oprs ||
                (this.Oprs != null &&
                input.Oprs != null &&
                this.Oprs.SequenceEqual(input.Oprs))
            ) &&
            (
                this.Dprs == input.Dprs ||
                (this.Dprs != null &&
                input.Dprs != null &&
                this.Dprs.SequenceEqual(input.Dprs))
            ) &&
            (
                this.Ccwms == input.Ccwms ||
                (this.Ccwms != null &&
                input.Ccwms != null &&
                this.Ccwms.SequenceEqual(input.Ccwms))
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
            if (this.Oprs != null)
            {
                hashCode = (hashCode * 59) + this.Oprs.GetHashCode();
            }

            if (this.Dprs != null)
            {
                hashCode = (hashCode * 59) + this.Dprs.GetHashCode();
            }

            if (this.Ccwms != null)
            {
                hashCode = (hashCode * 59) + this.Ccwms.GetHashCode();
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
