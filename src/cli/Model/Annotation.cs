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
    /// Annotation
    /// </summary>
    [DataContract(Name = "Annotation")]
    public partial class Annotation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Annotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="instanceName">instanceName (required).</param>
        /// <param name="utcDate">utcDate (required).</param>
        /// <param name="description">description.</param>
        /// <param name="url">url.</param>
        /// <param name="source">source.</param>
        /// <param name="databaseName">databaseName.</param>
        /// <param name="specificInfo">specificInfo.</param>
        public Annotation(string instanceName = default(string), DateTime utcDate = default(DateTime), string description = default(string), string url = default(string), string source = default(string), string databaseName = default(string), string specificInfo = default(string))
        {
            // to ensure "instanceName" is required (not null)
            if (instanceName == null)
            {
                throw new ArgumentNullException("instanceName is a required property for Annotation and cannot be null");
            }
            this.InstanceName = instanceName;
            this.UtcDate = utcDate;
            this.Description = description;
            this.Url = url;
            this.Source = source;
            this.DatabaseName = databaseName;
            this.SpecificInfo = specificInfo;
        }

        /// <summary>
        /// Gets or Sets InstanceName
        /// </summary>
        [DataMember(Name = "instanceName", IsRequired = true, EmitDefaultValue = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or Sets UtcDate
        /// </summary>
        [DataMember(Name = "utcDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UtcDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseName
        /// </summary>
        [DataMember(Name = "databaseName", EmitDefaultValue = true)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or Sets SpecificInfo
        /// </summary>
        [DataMember(Name = "specificInfo", EmitDefaultValue = true)]
        public string SpecificInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Annotation {\n");
            sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  UtcDate: ").Append(UtcDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  DatabaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  SpecificInfo: ").Append(SpecificInfo).Append("\n");
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
            // InstanceName (string) minLength
            if (this.InstanceName != null && this.InstanceName.Length < 1)
            {
                yield return new ValidationResult("Invalid value for InstanceName, length must be greater than 1.", new [] { "InstanceName" });
            }

            yield break;
        }
    }

}
