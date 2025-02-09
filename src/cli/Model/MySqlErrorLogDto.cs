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
    /// MySqlErrorLogDto
    /// </summary>
    [DataContract(Name = "MySqlErrorLogDto")]
    public partial class MySqlErrorLogDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlErrorLogDto" /> class.
        /// </summary>
        /// <param name="logged">logged.</param>
        /// <param name="threadId">threadId.</param>
        /// <param name="priority">priority.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="subSystem">subSystem.</param>
        /// <param name="errorText">errorText.</param>
        public MySqlErrorLogDto(DateTime logged = default(DateTime), string threadId = default(string), string priority = default(string), string errorCode = default(string), string subSystem = default(string), string errorText = default(string))
        {
            this.Logged = logged;
            this.ThreadId = threadId;
            this.Priority = priority;
            this.ErrorCode = errorCode;
            this.SubSystem = subSystem;
            this.ErrorText = errorText;
        }

        /// <summary>
        /// Gets or Sets Logged
        /// </summary>
        [DataMember(Name = "logged", EmitDefaultValue = false)]
        public DateTime Logged { get; set; }

        /// <summary>
        /// Gets or Sets ThreadId
        /// </summary>
        [DataMember(Name = "threadId", EmitDefaultValue = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets SubSystem
        /// </summary>
        [DataMember(Name = "subSystem", EmitDefaultValue = true)]
        public string SubSystem { get; set; }

        /// <summary>
        /// Gets or Sets ErrorText
        /// </summary>
        [DataMember(Name = "errorText", EmitDefaultValue = true)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MySqlErrorLogDto {\n");
            sb.Append("  Logged: ").Append(Logged).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  SubSystem: ").Append(SubSystem).Append("\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
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
