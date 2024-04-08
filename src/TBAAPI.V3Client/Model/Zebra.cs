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
/// Zebra
/// </summary>
[DataContract]
public partial class Zebra : IEquatable<Zebra>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Zebra" /> class.
    /// </summary>
    [JsonConstructor]
    protected Zebra() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Zebra" /> class.
    /// </summary>
    /// <param name="key">TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may be appended to the competition level if more than one match in required per set. (required).</param>
    /// <param name="times">A list of relative timestamps for each data point. Each timestamp will correspond to the X and Y value at the same index in a team xs and ys arrays. &#x60;times&#x60;, all teams &#x60;xs&#x60; and all teams &#x60;ys&#x60; are guarenteed to be the same length. (required).</param>
    /// <param name="alliances">alliances (required).</param>
    public Zebra(string key = default, List<double> times = default, ZebraAlliances alliances = default)
    {
        // to ensure "key" is required (not null)
        this.Key = key ?? throw new ArgumentNullException(nameof(key));
        // to ensure "times" is required (not null)
        this.Times = times ?? throw new ArgumentNullException(nameof(times));
        // to ensure "alliances" is required (not null)
        this.Alliances = alliances ?? throw new ArgumentNullException(nameof(alliances));
    }

    /// <summary>
    /// TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may be appended to the competition level if more than one match in required per set.
    /// </summary>
    /// <value>TBA match key with the format &#x60;yyyy[EVENT_CODE]_[COMP_LEVEL]m[MATCH_NUMBER]&#x60;, where &#x60;yyyy&#x60; is the year, and &#x60;EVENT_CODE&#x60; is the event code of the event, &#x60;COMP_LEVEL&#x60; is (qm, ef, qf, sf, f), and &#x60;MATCH_NUMBER&#x60; is the match number in the competition level. A set number may be appended to the competition level if more than one match in required per set.</value>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public string Key { get; set; }

    /// <summary>
    /// A list of relative timestamps for each data point. Each timestamp will correspond to the X and Y value at the same index in a team xs and ys arrays. &#x60;times&#x60;, all teams &#x60;xs&#x60; and all teams &#x60;ys&#x60; are guarenteed to be the same length.
    /// </summary>
    /// <value>A list of relative timestamps for each data point. Each timestamp will correspond to the X and Y value at the same index in a team xs and ys arrays. &#x60;times&#x60;, all teams &#x60;xs&#x60; and all teams &#x60;ys&#x60; are guarenteed to be the same length.</value>
    [DataMember(Name = "times", EmitDefaultValue = false)]
    public List<double> Times { get; set; }

    /// <summary>
    /// Gets or Sets Alliances
    /// </summary>
    [DataMember(Name = "alliances", EmitDefaultValue = false)]
    public ZebraAlliances Alliances { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Zebra {\n");
        sb.Append("  Key: ").Append(this.Key).Append('\n');
        sb.Append("  Times: ").Append(this.Times).Append('\n');
        sb.Append("  Alliances: ").Append(this.Alliances).Append('\n');
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
    public override bool Equals(object input) => Equals(input as Zebra);

    /// <summary>
    /// Returns true if Zebra instances are equal
    /// </summary>
    /// <param name="input">Instance of Zebra to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Zebra input)
    {
        return input != null
&& (
                this.Key == input.Key ||
                (this.Key != null &&
                this.Key.Equals(input.Key))
            ) &&
            (
                this.Times == input.Times ||
                (this.Times != null &&
                input.Times != null &&
                this.Times.SequenceEqual(input.Times))
            ) &&
            (
                this.Alliances == input.Alliances ||
                (this.Alliances != null &&
                this.Alliances.Equals(input.Alliances))
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
            if (this.Key != null)
            {
                hashCode = (hashCode * 59) + this.Key.GetHashCode();
            }

            if (this.Times != null)
            {
                hashCode = (hashCode * 59) + this.Times.GetHashCode();
            }

            if (this.Alliances != null)
            {
                hashCode = (hashCode * 59) + this.Alliances.GetHashCode();
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
