/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace TBAAPI.V3Client.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// APIStatusAppVersion
    /// </summary>
    [DataContract]
    public partial class APIStatusAppVersion : IEquatable<APIStatusAppVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIStatusAppVersion" /> class.
        /// </summary>
        [JsonConstructor]
        protected APIStatusAppVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIStatusAppVersion" /> class.
        /// </summary>
        /// <param name="minAppVersion">Internal use - Minimum application version required to correctly connect and process data. (required).</param>
        /// <param name="latestAppVersion">Internal use - Latest application version available. (required).</param>
        public APIStatusAppVersion(int minAppVersion = default, int latestAppVersion = default)
        {
            this.MinAppVersion = minAppVersion;
            this.LatestAppVersion = latestAppVersion;
        }

        /// <summary>
        /// Internal use - Minimum application version required to correctly connect and process data.
        /// </summary>
        /// <value>Internal use - Minimum application version required to correctly connect and process data.</value>
        [DataMember(Name = "min_app_version", EmitDefaultValue = false)]
        public int MinAppVersion { get; set; }

        /// <summary>
        /// Internal use - Latest application version available.
        /// </summary>
        /// <value>Internal use - Latest application version available.</value>
        [DataMember(Name = "latest_app_version", EmitDefaultValue = false)]
        public int LatestAppVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIStatusAppVersion {\n");
            sb.Append("  MinAppVersion: ").Append(MinAppVersion).Append("\n");
            sb.Append("  LatestAppVersion: ").Append(LatestAppVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, this.GetType());
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as APIStatusAppVersion);
        }

        /// <summary>
        /// Returns true if APIStatusAppVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of APIStatusAppVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIStatusAppVersion input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MinAppVersion == input.MinAppVersion ||
                    this.MinAppVersion.Equals(input.MinAppVersion)
                ) &&
                (
                    this.LatestAppVersion == input.LatestAppVersion ||
                    this.LatestAppVersion.Equals(input.LatestAppVersion)
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
                int hashCode = 41;
                hashCode = hashCode * 59 + this.MinAppVersion.GetHashCode();
                hashCode = hashCode * 59 + this.LatestAppVersion.GetHashCode();
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
}
