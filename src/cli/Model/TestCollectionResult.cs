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
    /// TestCollectionResult
    /// </summary>
    [DataContract(Name = "TestCollectionResult")]
    public partial class TestCollectionResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestCollectionResult" /> class.
        /// </summary>
        /// <param name="databaseCir">databaseCir.</param>
        /// <param name="isError">isError.</param>
        /// <param name="result">result.</param>
        /// <param name="duration">duration.</param>
        public TestCollectionResult(string databaseCir = default(string), bool isError = default(bool), string result = default(string), string duration = default(string))
        {
            this.DatabaseCir = databaseCir;
            this.IsError = isError;
            this.Result = result;
            this.Duration = duration;
        }

        /// <summary>
        /// Gets or Sets DatabaseCir
        /// </summary>
        [DataMember(Name = "databaseCir", EmitDefaultValue = true)]
        public string DatabaseCir { get; set; }

        /// <summary>
        /// Gets or Sets IsError
        /// </summary>
        [DataMember(Name = "isError", EmitDefaultValue = true)]
        public bool IsError { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public string Result { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public string Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestCollectionResult {\n");
            sb.Append("  DatabaseCir: ").Append(DatabaseCir).Append("\n");
            sb.Append("  IsError: ").Append(IsError).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
