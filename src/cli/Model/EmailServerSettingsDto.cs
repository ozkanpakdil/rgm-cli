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
    /// EmailServerSettingsDto
    /// </summary>
    [DataContract(Name = "EmailServerSettingsDto")]
    public partial class EmailServerSettingsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ConnectionSecurityMode
        /// </summary>
        [DataMember(Name = "connectionSecurityMode", EmitDefaultValue = false)]
        public ConnectionSecurityMode? ConnectionSecurityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailServerSettingsDto" /> class.
        /// </summary>
        /// <param name="server">server.</param>
        /// <param name="port">port.</param>
        /// <param name="connectionSecurityMode">connectionSecurityMode.</param>
        /// <param name="useAuthentication">useAuthentication.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="emailFrom">emailFrom.</param>
        /// <param name="ignoreSslErrors">ignoreSslErrors.</param>
        /// <param name="hasDecryptionError">hasDecryptionError.</param>
        /// <param name="secureConnectionSecurity">secureConnectionSecurity.</param>
        public EmailServerSettingsDto(string server = default(string), int port = default(int), ConnectionSecurityMode? connectionSecurityMode = default(ConnectionSecurityMode?), bool useAuthentication = default(bool), string username = default(string), string password = default(string), string emailFrom = default(string), bool ignoreSslErrors = default(bool), bool hasDecryptionError = default(bool), bool secureConnectionSecurity = default(bool))
        {
            this.Server = server;
            this.Port = port;
            this.ConnectionSecurityMode = connectionSecurityMode;
            this.UseAuthentication = useAuthentication;
            this.Username = username;
            this.Password = password;
            this.EmailFrom = emailFrom;
            this.IgnoreSslErrors = ignoreSslErrors;
            this.HasDecryptionError = hasDecryptionError;
            this.SecureConnectionSecurity = secureConnectionSecurity;
        }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name = "server", EmitDefaultValue = true)]
        public string Server { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets UseAuthentication
        /// </summary>
        [DataMember(Name = "useAuthentication", EmitDefaultValue = true)]
        public bool UseAuthentication { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets EmailFrom
        /// </summary>
        [DataMember(Name = "emailFrom", EmitDefaultValue = true)]
        public string EmailFrom { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreSslErrors
        /// </summary>
        [DataMember(Name = "ignoreSslErrors", EmitDefaultValue = true)]
        public bool IgnoreSslErrors { get; set; }

        /// <summary>
        /// Gets or Sets HasDecryptionError
        /// </summary>
        [DataMember(Name = "hasDecryptionError", EmitDefaultValue = true)]
        public bool HasDecryptionError { get; set; }

        /// <summary>
        /// Gets or Sets SecureConnectionSecurity
        /// </summary>
        [DataMember(Name = "secureConnectionSecurity", EmitDefaultValue = true)]
        public bool SecureConnectionSecurity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailServerSettingsDto {\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  ConnectionSecurityMode: ").Append(ConnectionSecurityMode).Append("\n");
            sb.Append("  UseAuthentication: ").Append(UseAuthentication).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  EmailFrom: ").Append(EmailFrom).Append("\n");
            sb.Append("  IgnoreSslErrors: ").Append(IgnoreSslErrors).Append("\n");
            sb.Append("  HasDecryptionError: ").Append(HasDecryptionError).Append("\n");
            sb.Append("  SecureConnectionSecurity: ").Append(SecureConnectionSecurity).Append("\n");
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
