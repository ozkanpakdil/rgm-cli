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
    /// ActualPlanRuntimeMetricsPostDto
    /// </summary>
    [DataContract(Name = "ActualPlanRuntimeMetricsPostDto")]
    public partial class ActualPlanRuntimeMetricsPostDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActualPlanRuntimeMetricsPostDto" /> class.
        /// </summary>
        /// <param name="channelInstanceRef">channelInstanceRef.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="snippet">snippet.</param>
        /// <param name="queryHash">queryHash.</param>
        /// <param name="databaseName">databaseName.</param>
        public ActualPlanRuntimeMetricsPostDto(ChannelInstanceRef channelInstanceRef = default(ChannelInstanceRef), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), string snippet = default(string), string queryHash = default(string), string databaseName = default(string))
        {
            this.ChannelInstanceRef = channelInstanceRef;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Snippet = snippet;
            this.QueryHash = queryHash;
            this.DatabaseName = databaseName;
        }

        /// <summary>
        /// Gets or Sets ChannelInstanceRef
        /// </summary>
        [DataMember(Name = "channelInstanceRef", EmitDefaultValue = true)]
        public ChannelInstanceRef ChannelInstanceRef { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Snippet
        /// </summary>
        [DataMember(Name = "snippet", EmitDefaultValue = true)]
        public string Snippet { get; set; }

        /// <summary>
        /// Gets or Sets QueryHash
        /// </summary>
        [DataMember(Name = "queryHash", EmitDefaultValue = true)]
        public string QueryHash { get; set; }

        /// <summary>
        /// Gets or Sets DatabaseName
        /// </summary>
        [DataMember(Name = "databaseName", EmitDefaultValue = true)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActualPlanRuntimeMetricsPostDto {\n");
            sb.Append("  ChannelInstanceRef: ").Append(ChannelInstanceRef).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Snippet: ").Append(Snippet).Append("\n");
            sb.Append("  QueryHash: ").Append(QueryHash).Append("\n");
            sb.Append("  DatabaseName: ").Append(DatabaseName).Append("\n");
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
