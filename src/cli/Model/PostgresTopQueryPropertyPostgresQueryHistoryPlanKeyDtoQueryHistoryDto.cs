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
    /// PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDto
    /// </summary>
    [DataContract(Name = "PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDto")]
    public partial class PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDto" /> class.
        /// </summary>
        /// <param name="minTime">minTime.</param>
        /// <param name="maxTime">maxTime.</param>
        /// <param name="queryHistorySeries">queryHistorySeries.</param>
        /// <param name="planChanges">planChanges.</param>
        public PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDto(DateTime minTime = default(DateTime), DateTime maxTime = default(DateTime), List<PostgresTopQueryPropertyQueryHistorySeriesDto> queryHistorySeries = default(List<PostgresTopQueryPropertyQueryHistorySeriesDto>), List<PostgresQueryHistoryPlanKeyDtoQueryHistoryPlanChangePointDto> planChanges = default(List<PostgresQueryHistoryPlanKeyDtoQueryHistoryPlanChangePointDto>))
        {
            this.MinTime = minTime;
            this.MaxTime = maxTime;
            this.QueryHistorySeries = queryHistorySeries;
            this.PlanChanges = planChanges;
        }

        /// <summary>
        /// Gets or Sets MinTime
        /// </summary>
        [DataMember(Name = "minTime", EmitDefaultValue = false)]
        public DateTime MinTime { get; set; }

        /// <summary>
        /// Gets or Sets MaxTime
        /// </summary>
        [DataMember(Name = "maxTime", EmitDefaultValue = false)]
        public DateTime MaxTime { get; set; }

        /// <summary>
        /// Gets or Sets QueryHistorySeries
        /// </summary>
        [DataMember(Name = "queryHistorySeries", EmitDefaultValue = false)]
        public List<PostgresTopQueryPropertyQueryHistorySeriesDto> QueryHistorySeries { get; set; }

        /// <summary>
        /// Gets or Sets PlanChanges
        /// </summary>
        [DataMember(Name = "planChanges", EmitDefaultValue = true)]
        public List<PostgresQueryHistoryPlanKeyDtoQueryHistoryPlanChangePointDto> PlanChanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDto {\n");
            sb.Append("  MinTime: ").Append(MinTime).Append("\n");
            sb.Append("  MaxTime: ").Append(MaxTime).Append("\n");
            sb.Append("  QueryHistorySeries: ").Append(QueryHistorySeries).Append("\n");
            sb.Append("  PlanChanges: ").Append(PlanChanges).Append("\n");
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
