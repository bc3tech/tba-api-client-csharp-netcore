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
/// TeamSimple
/// </summary>
[DataContract]
public partial class TeamSimple : IEquatable<TeamSimple>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamSimple" /> class.
    /// </summary>
    [JsonConstructor]
    protected TeamSimple() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TeamSimple" /> class.
    /// </summary>
    /// <param name="key">TBA team key with the format &#x60;frcXXXX&#x60; with &#x60;XXXX&#x60; representing the team number. (required).</param>
    /// <param name="teamNumber">Official team number issued by FIRST. (required).</param>
    /// <param name="nickname">Team nickname provided by FIRST..</param>
    /// <param name="name">Official long name registered with FIRST. (required).</param>
    /// <param name="city">City of team derived from parsing the address registered with FIRST..</param>
    /// <param name="stateProv">State of team derived from parsing the address registered with FIRST..</param>
    /// <param name="country">Country of team derived from parsing the address registered with FIRST..</param>
    public TeamSimple(string key = default, int teamNumber = default, string nickname = default, string name = default, string city = default, string stateProv = default, string country = default)
    {
        // to ensure "key" is required (not null)
        this.Key = key ?? throw new ArgumentNullException(nameof(key));
        this.TeamNumber = teamNumber;
        // to ensure "name" is required (not null)
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
        this.Nickname = nickname;
        this.City = city;
        this.StateProv = stateProv;
        this.Country = country;
    }

    /// <summary>
    /// TBA team key with the format &#x60;frcXXXX&#x60; with &#x60;XXXX&#x60; representing the team number.
    /// </summary>
    /// <value>TBA team key with the format &#x60;frcXXXX&#x60; with &#x60;XXXX&#x60; representing the team number.</value>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public string Key { get; set; }

    /// <summary>
    /// Official team number issued by FIRST.
    /// </summary>
    /// <value>Official team number issued by FIRST.</value>
    [DataMember(Name = "team_number", EmitDefaultValue = false)]
    public int TeamNumber { get; set; }

    /// <summary>
    /// Team nickname provided by FIRST.
    /// </summary>
    /// <value>Team nickname provided by FIRST.</value>
    [DataMember(Name = "nickname", EmitDefaultValue = false)]
    public string Nickname { get; set; }

    /// <summary>
    /// Official long name registered with FIRST.
    /// </summary>
    /// <value>Official long name registered with FIRST.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    /// City of team derived from parsing the address registered with FIRST.
    /// </summary>
    /// <value>City of team derived from parsing the address registered with FIRST.</value>
    [DataMember(Name = "city", EmitDefaultValue = false)]
    public string City { get; set; }

    /// <summary>
    /// State of team derived from parsing the address registered with FIRST.
    /// </summary>
    /// <value>State of team derived from parsing the address registered with FIRST.</value>
    [DataMember(Name = "state_prov", EmitDefaultValue = false)]
    public string StateProv { get; set; }

    /// <summary>
    /// Country of team derived from parsing the address registered with FIRST.
    /// </summary>
    /// <value>Country of team derived from parsing the address registered with FIRST.</value>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    public string Country { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TeamSimple {\n");
        sb.Append("  Key: ").Append(this.Key).Append('\n');
        sb.Append("  TeamNumber: ").Append(this.TeamNumber).Append('\n');
        sb.Append("  Nickname: ").Append(this.Nickname).Append('\n');
        sb.Append("  Name: ").Append(this.Name).Append('\n');
        sb.Append("  City: ").Append(this.City).Append('\n');
        sb.Append("  StateProv: ").Append(this.StateProv).Append('\n');
        sb.Append("  Country: ").Append(this.Country).Append('\n');
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
    public override bool Equals(object input) => Equals(input as TeamSimple);

    /// <summary>
    /// Returns true if TeamSimple instances are equal
    /// </summary>
    /// <param name="input">Instance of TeamSimple to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TeamSimple input)
    {
        return input != null
&& (
                this.Key == input.Key ||
                (this.Key != null &&
                this.Key.Equals(input.Key))
            ) &&
            (
                this.TeamNumber == input.TeamNumber ||
                this.TeamNumber.Equals(input.TeamNumber)
            ) &&
            (
                this.Nickname == input.Nickname ||
                (this.Nickname != null &&
                this.Nickname.Equals(input.Nickname))
            ) &&
            (
                this.Name == input.Name ||
                (this.Name != null &&
                this.Name.Equals(input.Name))
            ) &&
            (
                this.City == input.City ||
                (this.City != null &&
                this.City.Equals(input.City))
            ) &&
            (
                this.StateProv == input.StateProv ||
                (this.StateProv != null &&
                this.StateProv.Equals(input.StateProv))
            ) &&
            (
                this.Country == input.Country ||
                (this.Country != null &&
                this.Country.Equals(input.Country))
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

            hashCode = (hashCode * 59) + this.TeamNumber.GetHashCode();
            if (this.Nickname != null)
            {
                hashCode = (hashCode * 59) + this.Nickname.GetHashCode();
            }

            if (this.Name != null)
            {
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
            }

            if (this.City != null)
            {
                hashCode = (hashCode * 59) + this.City.GetHashCode();
            }

            if (this.StateProv != null)
            {
                hashCode = (hashCode * 59) + this.StateProv.GetHashCode();
            }

            if (this.Country != null)
            {
                hashCode = (hashCode * 59) + this.Country.GetHashCode();
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
