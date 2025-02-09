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
    /// PostgresTopQueriesDto
    /// </summary>
    [DataContract(Name = "PostgresTopQueriesDto")]
    public partial class PostgresTopQueriesDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresTopQueriesDto" /> class.
        /// </summary>
        /// <param name="topQueries">topQueries.</param>
        public PostgresTopQueriesDto(List<PostgresTopQueryDto> topQueries = default(List<PostgresTopQueryDto>))
        {
            this.TopQueries = topQueries;
        }

        /// <summary>
        /// Gets or Sets TopQueries
        /// </summary>
        [DataMember(Name = "topQueries", EmitDefaultValue = true)]
        public List<PostgresTopQueryDto> TopQueries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostgresTopQueriesDto {\n");
            sb.Append("  TopQueries: ").Append(TopQueries).Append("\n");
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
