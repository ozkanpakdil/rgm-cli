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
    /// AlertSummaryDto
    /// </summary>
    [DataContract(Name = "AlertSummaryDto")]
    public partial class AlertSummaryDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets HighestSeverity
        /// </summary>
        [DataMember(Name = "highestSeverity", EmitDefaultValue = false)]
        public AlertSeverityDto? HighestSeverity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertSummaryDto" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="alertType">alertType.</param>
        /// <param name="subType">subType.</param>
        /// <param name="priority">priority.</param>
        /// <param name="highCount">highCount.</param>
        /// <param name="mediumCount">mediumCount.</param>
        /// <param name="lowCount">lowCount.</param>
        /// <param name="highestSeverity">highestSeverity.</param>
        /// <param name="activeCount">activeCount.</param>
        /// <param name="alertInboxUrl">alertInboxUrl.</param>
        public AlertSummaryDto(string text = default(string), long alertType = default(long), long subType = default(long), int priority = default(int), int highCount = default(int), int mediumCount = default(int), int lowCount = default(int), AlertSeverityDto? highestSeverity = default(AlertSeverityDto?), int activeCount = default(int), string alertInboxUrl = default(string))
        {
            this.Text = text;
            this.AlertType = alertType;
            this.SubType = subType;
            this.Priority = priority;
            this.HighCount = highCount;
            this.MediumCount = mediumCount;
            this.LowCount = lowCount;
            this.HighestSeverity = highestSeverity;
            this.ActiveCount = activeCount;
            this.AlertInboxUrl = alertInboxUrl;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets AlertType
        /// </summary>
        [DataMember(Name = "alertType", EmitDefaultValue = false)]
        public long AlertType { get; set; }

        /// <summary>
        /// Gets or Sets SubType
        /// </summary>
        [DataMember(Name = "subType", EmitDefaultValue = false)]
        public long SubType { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets HighCount
        /// </summary>
        [DataMember(Name = "highCount", EmitDefaultValue = false)]
        public int HighCount { get; set; }

        /// <summary>
        /// Gets or Sets MediumCount
        /// </summary>
        [DataMember(Name = "mediumCount", EmitDefaultValue = false)]
        public int MediumCount { get; set; }

        /// <summary>
        /// Gets or Sets LowCount
        /// </summary>
        [DataMember(Name = "lowCount", EmitDefaultValue = false)]
        public int LowCount { get; set; }

        /// <summary>
        /// Gets or Sets ActiveCount
        /// </summary>
        [DataMember(Name = "activeCount", EmitDefaultValue = false)]
        public int ActiveCount { get; set; }

        /// <summary>
        /// Gets or Sets AlertInboxUrl
        /// </summary>
        [DataMember(Name = "alertInboxUrl", EmitDefaultValue = true)]
        public string AlertInboxUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlertSummaryDto {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  AlertType: ").Append(AlertType).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  HighCount: ").Append(HighCount).Append("\n");
            sb.Append("  MediumCount: ").Append(MediumCount).Append("\n");
            sb.Append("  LowCount: ").Append(LowCount).Append("\n");
            sb.Append("  HighestSeverity: ").Append(HighestSeverity).Append("\n");
            sb.Append("  ActiveCount: ").Append(ActiveCount).Append("\n");
            sb.Append("  AlertInboxUrl: ").Append(AlertInboxUrl).Append("\n");
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
