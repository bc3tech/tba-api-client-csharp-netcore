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
/// Webcast
/// </summary>
[DataContract]
public partial class Webcast : IEquatable<Webcast>, IValidatableObject
{
    /// <summary>
    /// Type of webcast, typically descriptive of the streaming provider.
    /// </summary>
    /// <value>Type of webcast, typically descriptive of the streaming provider.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Enum Youtube for value: youtube
        /// </summary>
        [EnumMember(Value = "youtube")]
        Youtube = 1,

        /// <summary>
        /// Enum Twitch for value: twitch
        /// </summary>
        [EnumMember(Value = "twitch")]
        Twitch = 2,

        /// <summary>
        /// Enum Ustream for value: ustream
        /// </summary>
        [EnumMember(Value = "ustream")]
        Ustream = 3,

        /// <summary>
        /// Enum Iframe for value: iframe
        /// </summary>
        [EnumMember(Value = "iframe")]
        Iframe = 4,

        /// <summary>
        /// Enum Html5 for value: html5
        /// </summary>
        [EnumMember(Value = "html5")]
        Html5 = 5,

        /// <summary>
        /// Enum Rtmp for value: rtmp
        /// </summary>
        [EnumMember(Value = "rtmp")]
        Rtmp = 6,

        /// <summary>
        /// Enum Livestream for value: livestream
        /// </summary>
        [EnumMember(Value = "livestream")]
        Livestream = 7,

        /// <summary>
        /// Enum Directlink for value: direct_link
        /// </summary>
        [EnumMember(Value = "direct_link")]
        Directlink = 8,

        /// <summary>
        /// Enum Mms for value: mms
        /// </summary>
        [EnumMember(Value = "mms")]
        Mms = 9,

        /// <summary>
        /// Enum Justin for value: justin
        /// </summary>
        [EnumMember(Value = "justin")]
        Justin = 10,

        /// <summary>
        /// Enum Stemtv for value: stemtv
        /// </summary>
        [EnumMember(Value = "stemtv")]
        Stemtv = 11,

        /// <summary>
        /// Enum Dacast for value: dacast
        /// </summary>
        [EnumMember(Value = "dacast")]
        Dacast = 12

    }

    /// <summary>
    /// Type of webcast, typically descriptive of the streaming provider.
    /// </summary>
    /// <value>Type of webcast, typically descriptive of the streaming provider.</value>
    [DataMember(Name = "type", EmitDefaultValue = false), JsonPropertyName("type")]
    public TypeEnum Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Webcast" /> class.
    /// </summary>
    [JsonConstructor]
    protected Webcast() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Webcast" /> class.
    /// </summary>
    /// <param name="type">Type of webcast, typically descriptive of the streaming provider. (required).</param>
    /// <param name="channel">Type specific channel information. May be the YouTube stream, or Twitch channel name. In the case of iframe types, contains HTML to embed the stream in an HTML iframe. (required).</param>
    /// <param name="date">The date for the webcast in &#x60;yyyy-mm-dd&#x60; format. May be null..</param>
    /// <param name="file">File identification as may be required for some types. May be null..</param>
    public Webcast(TypeEnum type = default, string? channel = default, string? date = default, string? file = default)
    {
        this.Type = type;
        // to ensure "channel" is required (not null)
        this.Channel = channel ?? throw new ArgumentNullException(nameof(channel));
        this.Date = date;
        this.File = file;
    }

    /// <summary>
    /// Type specific channel information. May be the YouTube stream, or Twitch channel name. In the case of iframe types, contains HTML to embed the stream in an HTML iframe.
    /// </summary>
    /// <value>Type specific channel information. May be the YouTube stream, or Twitch channel name. In the case of iframe types, contains HTML to embed the stream in an HTML iframe.</value>
    [DataMember(Name = "channel", EmitDefaultValue = false), JsonPropertyName("channel")]
    public string Channel { get; set; }

    /// <summary>
    /// The date for the webcast in &#x60;yyyy-mm-dd&#x60; format. May be null.
    /// </summary>
    /// <value>The date for the webcast in &#x60;yyyy-mm-dd&#x60; format. May be null.</value>
    [DataMember(Name = "date", EmitDefaultValue = false), JsonPropertyName("date")]
    public string Date { get; set; }

    /// <summary>
    /// File identification as may be required for some types. May be null.
    /// </summary>
    /// <value>File identification as may be required for some types. May be null.</value>
    [DataMember(Name = "file", EmitDefaultValue = false), JsonPropertyName("file")]
    public string File { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Webcast {\n");
        sb.Append("  Type: ").Append(this.Type).Append('\n');
        sb.Append("  Channel: ").Append(this.Channel).Append('\n');
        sb.Append("  Date: ").Append(this.Date).Append('\n');
        sb.Append("  File: ").Append(this.File).Append('\n');
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
    public override bool Equals(object? input) => Equals(input as Webcast);

    /// <summary>
    /// Returns true if Webcast instances are equal
    /// </summary>
    /// <param name="input">Instance of Webcast to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Webcast? input)
    {
        return input is not null
&& (
                this.Type == input.Type ||
                this.Type.Equals(input.Type)
            ) &&
            (
                this.Channel == input.Channel ||
                (this.Channel is not null &&
                this.Channel.Equals(input.Channel))
            ) &&
            (
                this.Date == input.Date ||
                (this.Date is not null &&
                this.Date.Equals(input.Date))
            ) &&
            (
                this.File == input.File ||
                (this.File is not null &&
                this.File.Equals(input.File))
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
            hashCode = (hashCode * 59) + this.Type.GetHashCode();
            if (this.Channel is not null)
            {
                hashCode = (hashCode * 59) + this.Channel.GetHashCode();
            }

            if (this.Date is not null)
            {
                hashCode = (hashCode * 59) + this.Date.GetHashCode();
            }

            if (this.File is not null)
            {
                hashCode = (hashCode * 59) + this.File.GetHashCode();
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
