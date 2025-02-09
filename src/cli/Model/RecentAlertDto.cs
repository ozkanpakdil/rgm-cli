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
    /// RecentAlertDto
    /// </summary>
    [DataContract(Name = "RecentAlertDto")]
    public partial class RecentAlertDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets WorstLevel
        /// </summary>
        [DataMember(Name = "worstLevel", EmitDefaultValue = false)]
        public Severity? WorstLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentAlertDto" /> class.
        /// </summary>
        /// <param name="alertId">alertId.</param>
        /// <param name="status">status.</param>
        /// <param name="text">text.</param>
        /// <param name="cleared">cleared.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="worstLevel">worstLevel.</param>
        /// <param name="cir">cir.</param>
        /// <param name="owner">owner.</param>
        /// <param name="alertState">alertState.</param>
        /// <param name="alertTime">alertTime.</param>
        /// <param name="subText">subText.</param>
        public RecentAlertDto(IntegerIdentifier alertId = default(IntegerIdentifier), string status = default(string), string text = default(string), bool cleared = default(bool), long startTime = default(long), long? endTime = default(long?), Severity? worstLevel = default(Severity?), string cir = default(string), string owner = default(string), string alertState = default(string), long alertTime = default(long), string subText = default(string))
        {
            this.AlertId = alertId;
            this.Status = status;
            this.Text = text;
            this.Cleared = cleared;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.WorstLevel = worstLevel;
            this.Cir = cir;
            this.Owner = owner;
            this.AlertState = alertState;
            this.AlertTime = alertTime;
            this.SubText = subText;
        }

        /// <summary>
        /// Gets or Sets AlertId
        /// </summary>
        [DataMember(Name = "alertId", EmitDefaultValue = false)]
        public IntegerIdentifier AlertId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Cleared
        /// </summary>
        [DataMember(Name = "cleared", EmitDefaultValue = true)]
        public bool Cleared { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public long StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Cir
        /// </summary>
        [DataMember(Name = "cir", EmitDefaultValue = true)]
        public string Cir { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets AlertState
        /// </summary>
        [DataMember(Name = "alertState", EmitDefaultValue = true)]
        public string AlertState { get; set; }

        /// <summary>
        /// Gets or Sets AlertTime
        /// </summary>
        [DataMember(Name = "alertTime", EmitDefaultValue = false)]
        public long AlertTime { get; set; }

        /// <summary>
        /// Gets or Sets SubText
        /// </summary>
        [DataMember(Name = "subText", EmitDefaultValue = true)]
        public string SubText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecentAlertDto {\n");
            sb.Append("  AlertId: ").Append(AlertId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Cleared: ").Append(Cleared).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  WorstLevel: ").Append(WorstLevel).Append("\n");
            sb.Append("  Cir: ").Append(Cir).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  AlertState: ").Append(AlertState).Append("\n");
            sb.Append("  AlertTime: ").Append(AlertTime).Append("\n");
            sb.Append("  SubText: ").Append(SubText).Append("\n");
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
