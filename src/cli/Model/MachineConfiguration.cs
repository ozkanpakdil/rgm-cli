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
    /// MachineConfiguration
    /// </summary>
    [DataContract(Name = "MachineConfiguration")]
    public partial class MachineConfiguration : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SshAuthenticationType
        /// </summary>
        [DataMember(Name = "sshAuthenticationType", EmitDefaultValue = false)]
        public SshAuthenticationTypeDto? SshAuthenticationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MachineConfiguration" /> class.
        /// </summary>
        /// <param name="windowsConnectionProperties">windowsConnectionProperties.</param>
        /// <param name="useBaseMonitorServiceAccount">useBaseMonitorServiceAccount.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="sshAuthenticationType">sshAuthenticationType.</param>
        /// <param name="sshPrivateKeyId">sshPrivateKeyId.</param>
        public MachineConfiguration(WindowsConnectionPropertiesModel windowsConnectionProperties = default(WindowsConnectionPropertiesModel), bool useBaseMonitorServiceAccount = default(bool), CredentialsDto credentials = default(CredentialsDto), SshAuthenticationTypeDto? sshAuthenticationType = default(SshAuthenticationTypeDto?), string sshPrivateKeyId = default(string))
        {
            this.WindowsConnectionProperties = windowsConnectionProperties;
            this.UseBaseMonitorServiceAccount = useBaseMonitorServiceAccount;
            this.Credentials = credentials;
            this.SshAuthenticationType = sshAuthenticationType;
            this.SshPrivateKeyId = sshPrivateKeyId;
        }

        /// <summary>
        /// Gets or Sets WindowsConnectionProperties
        /// </summary>
        [DataMember(Name = "windowsConnectionProperties", EmitDefaultValue = false)]
        public WindowsConnectionPropertiesModel WindowsConnectionProperties { get; set; }

        /// <summary>
        /// Gets or Sets UseBaseMonitorServiceAccount
        /// </summary>
        [DataMember(Name = "useBaseMonitorServiceAccount", EmitDefaultValue = true)]
        public bool UseBaseMonitorServiceAccount { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public CredentialsDto Credentials { get; set; }

        /// <summary>
        /// Gets or Sets SshPrivateKeyId
        /// </summary>
        [DataMember(Name = "sshPrivateKeyId", EmitDefaultValue = true)]
        public string SshPrivateKeyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MachineConfiguration {\n");
            sb.Append("  WindowsConnectionProperties: ").Append(WindowsConnectionProperties).Append("\n");
            sb.Append("  UseBaseMonitorServiceAccount: ").Append(UseBaseMonitorServiceAccount).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  SshAuthenticationType: ").Append(SshAuthenticationType).Append("\n");
            sb.Append("  SshPrivateKeyId: ").Append(SshPrivateKeyId).Append("\n");
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
