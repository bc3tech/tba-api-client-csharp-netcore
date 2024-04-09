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
/// EventRanking
/// </summary>
[DataContract]
public partial class EventRanking : IEquatable<EventRanking>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EventRanking" /> class.
    /// </summary>
    [JsonConstructor]
    protected EventRanking() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventRanking" /> class.
    /// </summary>
    /// <param name="rankings">List of rankings at the event. (required).</param>
    /// <param name="extraStatsInfo">List of special TBA-generated values provided in the &#x60;extra_stats&#x60; array for each item..</param>
    /// <param name="sortOrderInfo">List of year-specific values provided in the &#x60;sort_orders&#x60; array for each team. (required).</param>
    public EventRanking(List<EventRankingRankings>? rankings = default, List<EventRankingExtraStatsInfo>? extraStatsInfo = default, List<EventRankingSortOrderInfo>? sortOrderInfo = default)
    {
        // to ensure "rankings" is required (not null)
        this.Rankings = rankings ?? throw new ArgumentNullException(nameof(rankings));
        // to ensure "sortOrderInfo" is required (not null)
        this.SortOrderInfo = sortOrderInfo ?? throw new ArgumentNullException(nameof(sortOrderInfo));
        this.ExtraStatsInfo = extraStatsInfo;
    }

    /// <summary>
    /// List of rankings at the event.
    /// </summary>
    /// <value>List of rankings at the event.</value>
    [DataMember(Name = "rankings", EmitDefaultValue = false), JsonPropertyName("rankings")]
    public IList<EventRankingRankings>? Rankings { get; set; }

    /// <summary>
    /// List of special TBA-generated values provided in the &#x60;extra_stats&#x60; array for each item.
    /// </summary>
    /// <value>List of special TBA-generated values provided in the &#x60;extra_stats&#x60; array for each item.</value>
    [DataMember(Name = "extra_stats_info", EmitDefaultValue = false), JsonPropertyName("extra_stats_info")]
    public IList<EventRankingExtraStatsInfo>? ExtraStatsInfo { get; set; }

    /// <summary>
    /// List of year-specific values provided in the &#x60;sort_orders&#x60; array for each team.
    /// </summary>
    /// <value>List of year-specific values provided in the &#x60;sort_orders&#x60; array for each team.</value>
    [DataMember(Name = "sort_order_info", EmitDefaultValue = false), JsonPropertyName("sort_order_info")]
    public IList<EventRankingSortOrderInfo>? SortOrderInfo { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventRanking {\n");
        sb.Append("  Rankings: ").Append(this.Rankings).Append('\n');
        sb.Append("  ExtraStatsInfo: ").Append(this.ExtraStatsInfo).Append('\n');
        sb.Append("  SortOrderInfo: ").Append(this.SortOrderInfo).Append('\n');
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
    public override bool Equals(object? input) => Equals(input as EventRanking);

    /// <summary>
    /// Returns true if EventRanking instances are equal
    /// </summary>
    /// <param name="input">Instance of EventRanking to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventRanking? input)
    {
        return input is not null
&& (
                this.Rankings == input.Rankings ||
                (this.Rankings is not null &&
                input.Rankings is not null &&
                this.Rankings.SequenceEqual(input.Rankings))
            ) &&
            (
                this.ExtraStatsInfo == input.ExtraStatsInfo ||
                (this.ExtraStatsInfo is not null &&
                input.ExtraStatsInfo is not null &&
                this.ExtraStatsInfo.SequenceEqual(input.ExtraStatsInfo))
            ) &&
            (
                this.SortOrderInfo == input.SortOrderInfo ||
                (this.SortOrderInfo is not null &&
                input.SortOrderInfo is not null &&
                this.SortOrderInfo.SequenceEqual(input.SortOrderInfo))
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
            if (this.Rankings is not null)
            {
                hashCode = (hashCode * 59) + this.Rankings.GetHashCode();
            }

            if (this.ExtraStatsInfo is not null)
            {
                hashCode = (hashCode * 59) + this.ExtraStatsInfo.GetHashCode();
            }

            if (this.SortOrderInfo is not null)
            {
                hashCode = (hashCode * 59) + this.SortOrderInfo.GetHashCode();
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
