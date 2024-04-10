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
/// TeamEventStatusRankRanking
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="TeamEventStatusRankRanking" /> class.
/// </remarks>
[DataContract]
public partial record TeamEventStatusRankRanking : IValidatableObject
{

    /// <summary>
    /// Number of matches played.
    /// </summary>
    /// <value>Number of matches played.</value>
    [DataMember(Name = "matches_played", EmitDefaultValue = false), JsonPropertyName("matches_played")]
    public int MatchesPlayed { get; set; }

    /// <summary>
    /// For some years, average qualification score. Can be null.
    /// </summary>
    /// <value>For some years, average qualification score. Can be null.</value>
    [DataMember(Name = "qual_average", EmitDefaultValue = false), JsonPropertyName("qual_average")]
    public double QualAverage { get; set; }

    /// <summary>
    /// Ordered list of values used to determine the rank. See the &#x60;sort_order_info&#x60; property for the name of each value.
    /// </summary>
    /// <value>Ordered list of values used to determine the rank. See the &#x60;sort_order_info&#x60; property for the name of each value.</value>
    [DataMember(Name = "sort_orders", EmitDefaultValue = false), JsonPropertyName("sort_orders")]
    public IList<decimal>? SortOrders { get; set; }

    /// <summary>
    /// Gets or Sets Record
    /// </summary>
    [DataMember(Name = "record", EmitDefaultValue = false), JsonPropertyName("record")]
    public WLTRecord? Record { get; set; }

    /// <summary>
    /// Relative rank of this team.
    /// </summary>
    /// <value>Relative rank of this team.</value>
    [DataMember(Name = "rank", EmitDefaultValue = false), JsonPropertyName("rank")]
    public int Rank { get; set; }

    /// <summary>
    /// Number of matches the team was disqualified for.
    /// </summary>
    /// <value>Number of matches the team was disqualified for.</value>
    [DataMember(Name = "dq", EmitDefaultValue = false), JsonPropertyName("dq")]
    public int Dq { get; set; }

    /// <summary>
    /// TBA team key for this rank.
    /// </summary>
    /// <value>TBA team key for this rank.</value>
    [DataMember(Name = "team_key", EmitDefaultValue = false), JsonPropertyName("team_key")]
    public string? TeamKey { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamEventStatusRankRanking {\n");
        sb.Append("  MatchesPlayed: ").Append(this.MatchesPlayed).Append('\n');
        sb.Append("  QualAverage: ").Append(this.QualAverage).Append('\n');
        sb.Append("  SortOrders: ").Append(this.SortOrders).Append('\n');
        sb.Append("  Record: ").Append(this.Record).Append('\n');
        sb.Append("  Rank: ").Append(this.Rank).Append('\n');
        sb.Append("  Dq: ").Append(this.Dq).Append('\n');
        sb.Append("  TeamKey: ").Append(this.TeamKey).Append('\n');
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
            hashCode = (hashCode * 59) + this.MatchesPlayed.GetHashCode();
            hashCode = (hashCode * 59) + this.QualAverage.GetHashCode();
            if (this.SortOrders is not null)
            {
                hashCode = (hashCode * 59) + this.SortOrders.GetHashCode();
            }

            if (this.Record is not null)
            {
                hashCode = (hashCode * 59) + this.Record.GetHashCode();
            }

            hashCode = (hashCode * 59) + this.Rank.GetHashCode();
            hashCode = (hashCode * 59) + this.Dq.GetHashCode();
            if (this.TeamKey is not null)
            {
                hashCode = (hashCode * 59) + this.TeamKey.GetHashCode();
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
