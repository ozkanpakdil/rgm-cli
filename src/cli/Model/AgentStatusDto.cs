/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = cli.Client.OpenAPIDateConverter;

namespace cli.Model
{
    /// <summary>
    /// AgentStatusDto
    /// </summary>
    [DataContract(Name = "AgentStatusDto")]
    public partial class AgentStatusDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public PlatformDto Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentStatusDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatusDto" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="lastMessageReceived">lastMessageReceived (required).</param>
        /// <param name="isOnline">isOnline (required).</param>
        /// <param name="varVersion">varVersion (required).</param>
        /// <param name="userRunningAs">userRunningAs (required).</param>
        /// <param name="domain">domain (required).</param>
        /// <param name="platform">platform (required).</param>
        public AgentStatusDto(string name = default(string), DateTime lastMessageReceived = default(DateTime), bool isOnline = default(bool), string varVersion = default(string), string userRunningAs = default(string), string domain = default(string), PlatformDto platform = default(PlatformDto))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AgentStatusDto and cannot be null");
            }
            this.Name = name;
            this.LastMessageReceived = lastMessageReceived;
            this.IsOnline = isOnline;
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for AgentStatusDto and cannot be null");
            }
            this.VarVersion = varVersion;
            // to ensure "userRunningAs" is required (not null)
            if (userRunningAs == null)
            {
                throw new ArgumentNullException("userRunningAs is a required property for AgentStatusDto and cannot be null");
            }
            this.UserRunningAs = userRunningAs;
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for AgentStatusDto and cannot be null");
            }
            this.Domain = domain;
            this.Platform = platform;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LastMessageReceived
        /// </summary>
        [DataMember(Name = "lastMessageReceived", IsRequired = true, EmitDefaultValue = true)]
        public DateTime LastMessageReceived { get; set; }

        /// <summary>
        /// Gets or Sets IsOnline
        /// </summary>
        [DataMember(Name = "isOnline", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOnline { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets UserRunningAs
        /// </summary>
        [DataMember(Name = "userRunningAs", IsRequired = true, EmitDefaultValue = true)]
        public string UserRunningAs { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgentStatusDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LastMessageReceived: ").Append(LastMessageReceived).Append("\n");
            sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  UserRunningAs: ").Append(UserRunningAs).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
