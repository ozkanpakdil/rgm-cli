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
    /// MySqlTopQueryDto
    /// </summary>
    [DataContract(Name = "MySqlTopQueryDto")]
    public partial class MySqlTopQueryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlTopQueryDto" /> class.
        /// </summary>
        /// <param name="channelInstanceRef">channelInstanceRef.</param>
        /// <param name="schema">schema.</param>
        /// <param name="queryHash">queryHash.</param>
        /// <param name="queryText">queryText.</param>
        /// <param name="duration">duration.</param>
        /// <param name="executionCount">executionCount.</param>
        /// <param name="cpuTime">cpuTime.</param>
        /// <param name="rowsReads">rowsReads.</param>
        /// <param name="rowsWritten">rowsWritten.</param>
        /// <param name="maxMemory">maxMemory.</param>
        /// <param name="errorCount">errorCount.</param>
        public MySqlTopQueryDto(ChannelInstanceRef channelInstanceRef = default(ChannelInstanceRef), string schema = default(string), string queryHash = default(string), string queryText = default(string), long duration = default(long), long executionCount = default(long), long cpuTime = default(long), long rowsReads = default(long), long rowsWritten = default(long), long maxMemory = default(long), long errorCount = default(long))
        {
            this.ChannelInstanceRef = channelInstanceRef;
            this.Schema = schema;
            this.QueryHash = queryHash;
            this.QueryText = queryText;
            this.Duration = duration;
            this.ExecutionCount = executionCount;
            this.CpuTime = cpuTime;
            this.RowsReads = rowsReads;
            this.RowsWritten = rowsWritten;
            this.MaxMemory = maxMemory;
            this.ErrorCount = errorCount;
        }

        /// <summary>
        /// Gets or Sets ChannelInstanceRef
        /// </summary>
        [DataMember(Name = "channelInstanceRef", EmitDefaultValue = true)]
        public ChannelInstanceRef ChannelInstanceRef { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = true)]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or Sets QueryHash
        /// </summary>
        [DataMember(Name = "queryHash", EmitDefaultValue = true)]
        public string QueryHash { get; set; }

        /// <summary>
        /// Gets or Sets QueryText
        /// </summary>
        [DataMember(Name = "queryText", EmitDefaultValue = true)]
        public string QueryText { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public long Duration { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionCount
        /// </summary>
        [DataMember(Name = "executionCount", EmitDefaultValue = false)]
        public long ExecutionCount { get; set; }

        /// <summary>
        /// Gets or Sets CpuTime
        /// </summary>
        [DataMember(Name = "cpuTime", EmitDefaultValue = false)]
        public long CpuTime { get; set; }

        /// <summary>
        /// Gets or Sets RowsReads
        /// </summary>
        [DataMember(Name = "rowsReads", EmitDefaultValue = false)]
        public long RowsReads { get; set; }

        /// <summary>
        /// Gets or Sets RowsWritten
        /// </summary>
        [DataMember(Name = "rowsWritten", EmitDefaultValue = false)]
        public long RowsWritten { get; set; }

        /// <summary>
        /// Gets or Sets MaxMemory
        /// </summary>
        [DataMember(Name = "maxMemory", EmitDefaultValue = false)]
        public long MaxMemory { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCount
        /// </summary>
        [DataMember(Name = "errorCount", EmitDefaultValue = false)]
        public long ErrorCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MySqlTopQueryDto {\n");
            sb.Append("  ChannelInstanceRef: ").Append(ChannelInstanceRef).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  QueryHash: ").Append(QueryHash).Append("\n");
            sb.Append("  QueryText: ").Append(QueryText).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ExecutionCount: ").Append(ExecutionCount).Append("\n");
            sb.Append("  CpuTime: ").Append(CpuTime).Append("\n");
            sb.Append("  RowsReads: ").Append(RowsReads).Append("\n");
            sb.Append("  RowsWritten: ").Append(RowsWritten).Append("\n");
            sb.Append("  MaxMemory: ").Append(MaxMemory).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
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
