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
    /// RecentAlertDetailsDto
    /// </summary>
    [DataContract(Name = "RecentAlertDetailsDto")]
    public partial class RecentAlertDetailsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentAlertDetailsDto" /> class.
        /// </summary>
        /// <param name="alertId">alertId.</param>
        /// <param name="startTimeTicks">startTimeTicks.</param>
        /// <param name="status">status.</param>
        /// <param name="text">text.</param>
        /// <param name="alertCir">alertCir.</param>
        /// <param name="fullAlertTypeSerialised">fullAlertTypeSerialised.</param>
        /// <param name="cleared">cleared.</param>
        /// <param name="detailsHtml">detailsHtml.</param>
        /// <param name="descriptionUrl">descriptionUrl.</param>
        /// <param name="comments">comments.</param>
        /// <param name="occurrences">occurrences.</param>
        public RecentAlertDetailsDto(IntegerIdentifier alertId = default(IntegerIdentifier), long startTimeTicks = default(long), string status = default(string), string text = default(string), GroupOrCir alertCir = default(GroupOrCir), string fullAlertTypeSerialised = default(string), bool cleared = default(bool), string detailsHtml = default(string), string descriptionUrl = default(string), List<RecentAlertCommentDto> comments = default(List<RecentAlertCommentDto>), List<RecentAlertOccurrenceDto> occurrences = default(List<RecentAlertOccurrenceDto>))
        {
            this.AlertId = alertId;
            this.StartTimeTicks = startTimeTicks;
            this.Status = status;
            this.Text = text;
            this.AlertCir = alertCir;
            this.FullAlertTypeSerialised = fullAlertTypeSerialised;
            this.Cleared = cleared;
            this.DetailsHtml = detailsHtml;
            this.DescriptionUrl = descriptionUrl;
            this.Comments = comments;
            this.Occurrences = occurrences;
        }

        /// <summary>
        /// Gets or Sets AlertId
        /// </summary>
        [DataMember(Name = "alertId", EmitDefaultValue = false)]
        public IntegerIdentifier AlertId { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeTicks
        /// </summary>
        [DataMember(Name = "startTimeTicks", EmitDefaultValue = false)]
        public long StartTimeTicks { get; set; }

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
        /// Gets or Sets AlertCir
        /// </summary>
        [DataMember(Name = "alertCir", EmitDefaultValue = true)]
        public GroupOrCir AlertCir { get; set; }

        /// <summary>
        /// Gets or Sets FullAlertTypeSerialised
        /// </summary>
        [DataMember(Name = "fullAlertTypeSerialised", EmitDefaultValue = true)]
        public string FullAlertTypeSerialised { get; set; }

        /// <summary>
        /// Gets or Sets Cleared
        /// </summary>
        [DataMember(Name = "cleared", EmitDefaultValue = true)]
        public bool Cleared { get; set; }

        /// <summary>
        /// Gets or Sets DetailsHtml
        /// </summary>
        [DataMember(Name = "detailsHtml", EmitDefaultValue = true)]
        public string DetailsHtml { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionUrl
        /// </summary>
        [DataMember(Name = "descriptionUrl", EmitDefaultValue = true)]
        public string DescriptionUrl { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = true)]
        public List<RecentAlertCommentDto> Comments { get; set; }

        /// <summary>
        /// Gets or Sets Occurrences
        /// </summary>
        [DataMember(Name = "occurrences", EmitDefaultValue = true)]
        public List<RecentAlertOccurrenceDto> Occurrences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecentAlertDetailsDto {\n");
            sb.Append("  AlertId: ").Append(AlertId).Append("\n");
            sb.Append("  StartTimeTicks: ").Append(StartTimeTicks).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  AlertCir: ").Append(AlertCir).Append("\n");
            sb.Append("  FullAlertTypeSerialised: ").Append(FullAlertTypeSerialised).Append("\n");
            sb.Append("  Cleared: ").Append(Cleared).Append("\n");
            sb.Append("  DetailsHtml: ").Append(DetailsHtml).Append("\n");
            sb.Append("  DescriptionUrl: ").Append(DescriptionUrl).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
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
