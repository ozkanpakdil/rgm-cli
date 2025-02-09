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
    /// MySqlCredentialsModel
    /// </summary>
    [DataContract(Name = "MySqlCredentialsModel")]
    public partial class MySqlCredentialsModel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthenticationMode
        /// </summary>
        [DataMember(Name = "authenticationMode", EmitDefaultValue = false)]
        public MySqlAuthenticationMode? AuthenticationMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlCredentialsModel" /> class.
        /// </summary>
        /// <param name="userName">userName.</param>
        /// <param name="password">password.</param>
        /// <param name="decryptionFailed">decryptionFailed.</param>
        /// <param name="authenticationMode">authenticationMode.</param>
        public MySqlCredentialsModel(string userName = default(string), string password = default(string), bool decryptionFailed = default(bool), MySqlAuthenticationMode? authenticationMode = default(MySqlAuthenticationMode?))
        {
            this.UserName = userName;
            this.Password = password;
            this.DecryptionFailed = decryptionFailed;
            this.AuthenticationMode = authenticationMode;
        }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets DecryptionFailed
        /// </summary>
        [DataMember(Name = "decryptionFailed", EmitDefaultValue = true)]
        public bool DecryptionFailed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MySqlCredentialsModel {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DecryptionFailed: ").Append(DecryptionFailed).Append("\n");
            sb.Append("  AuthenticationMode: ").Append(AuthenticationMode).Append("\n");
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
