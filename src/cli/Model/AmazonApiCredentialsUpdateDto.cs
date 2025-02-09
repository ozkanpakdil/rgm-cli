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
    /// AmazonApiCredentialsUpdateDto
    /// </summary>
    [DataContract(Name = "AmazonApiCredentialsUpdateDto")]
    public partial class AmazonApiCredentialsUpdateDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthenticationMode
        /// </summary>
        [DataMember(Name = "authenticationMode", EmitDefaultValue = false)]
        public AmazonAwsCredentialOptions? AuthenticationMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonApiCredentialsUpdateDto" /> class.
        /// </summary>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="region">region.</param>
        /// <param name="dbIdentifier">dbIdentifier.</param>
        /// <param name="decryptionFailed">decryptionFailed.</param>
        /// <param name="authenticationMode">authenticationMode.</param>
        /// <param name="roleArn">roleArn.</param>
        public AmazonApiCredentialsUpdateDto(string accessKey = default(string), string secretKey = default(string), string region = default(string), string dbIdentifier = default(string), bool decryptionFailed = default(bool), AmazonAwsCredentialOptions? authenticationMode = default(AmazonAwsCredentialOptions?), string roleArn = default(string))
        {
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.Region = region;
            this.DbIdentifier = dbIdentifier;
            this.DecryptionFailed = decryptionFailed;
            this.AuthenticationMode = authenticationMode;
            this.RoleArn = roleArn;
        }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "accessKey", EmitDefaultValue = true)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name = "secretKey", EmitDefaultValue = true)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets DbIdentifier
        /// </summary>
        [DataMember(Name = "dbIdentifier", EmitDefaultValue = true)]
        public string DbIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets DecryptionFailed
        /// </summary>
        [DataMember(Name = "decryptionFailed", EmitDefaultValue = true)]
        public bool DecryptionFailed { get; set; }

        /// <summary>
        /// Gets or Sets RoleArn
        /// </summary>
        [DataMember(Name = "roleArn", EmitDefaultValue = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AmazonApiCredentialsUpdateDto {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  DbIdentifier: ").Append(DbIdentifier).Append("\n");
            sb.Append("  DecryptionFailed: ").Append(DecryptionFailed).Append("\n");
            sb.Append("  AuthenticationMode: ").Append(AuthenticationMode).Append("\n");
            sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
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
