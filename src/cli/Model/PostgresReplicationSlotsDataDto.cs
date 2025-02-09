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
    /// PostgresReplicationSlotsDataDto
    /// </summary>
    [DataContract(Name = "PostgresReplicationSlotsDataDto")]
    public partial class PostgresReplicationSlotsDataDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostgresReplicationSlotsDataDto" /> class.
        /// </summary>
        /// <param name="maxSlotWalKeepSize">maxSlotWalKeepSize.</param>
        /// <param name="replicationSlots">replicationSlots.</param>
        public PostgresReplicationSlotsDataDto(long maxSlotWalKeepSize = default(long), List<PostgresReplicationSlotDto> replicationSlots = default(List<PostgresReplicationSlotDto>))
        {
            this.MaxSlotWalKeepSize = maxSlotWalKeepSize;
            this.ReplicationSlots = replicationSlots;
        }

        /// <summary>
        /// Gets or Sets MaxSlotWalKeepSize
        /// </summary>
        [DataMember(Name = "maxSlotWalKeepSize", EmitDefaultValue = false)]
        public long MaxSlotWalKeepSize { get; set; }

        /// <summary>
        /// Gets or Sets ReplicationSlots
        /// </summary>
        [DataMember(Name = "replicationSlots", EmitDefaultValue = true)]
        public List<PostgresReplicationSlotDto> ReplicationSlots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostgresReplicationSlotsDataDto {\n");
            sb.Append("  MaxSlotWalKeepSize: ").Append(MaxSlotWalKeepSize).Append("\n");
            sb.Append("  ReplicationSlots: ").Append(ReplicationSlots).Append("\n");
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
