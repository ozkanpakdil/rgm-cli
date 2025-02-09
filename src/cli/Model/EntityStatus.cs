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
    /// EntityStatus
    /// </summary>
    [DataContract(Name = "EntityStatus")]
    public partial class EntityStatus : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public ContinuousEventDto? EventType { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", EmitDefaultValue = false)]
        public MonitoredObjectSeverityDto? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityStatus" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="dateRaised">dateRaised.</param>
        /// <param name="activeForMinutes">activeForMinutes.</param>
        /// <param name="severity">severity.</param>
        /// <param name="order">order.</param>
        /// <param name="extra">extra.</param>
        /// <param name="mostRelevantAlertId">mostRelevantAlertId.</param>
        /// <param name="alertCir">alertCir.</param>
        /// <param name="fullAlertTypeSerialised">fullAlertTypeSerialised.</param>
        /// <param name="startTimeTicks">startTimeTicks.</param>
        /// <param name="lastOk">lastOk.</param>
        public EntityStatus(string text = default(string), ContinuousEventDto? eventType = default(ContinuousEventDto?), DateTime? dateRaised = default(DateTime?), int activeForMinutes = default(int), MonitoredObjectSeverityDto? severity = default(MonitoredObjectSeverityDto?), int order = default(int), long extra = default(long), IntegerIdentifier mostRelevantAlertId = default(IntegerIdentifier), GroupOrCir alertCir = default(GroupOrCir), string fullAlertTypeSerialised = default(string), long startTimeTicks = default(long), DateTime? lastOk = default(DateTime?))
        {
            this.Text = text;
            this.EventType = eventType;
            this.DateRaised = dateRaised;
            this.ActiveForMinutes = activeForMinutes;
            this.Severity = severity;
            this.Order = order;
            this.Extra = extra;
            this.MostRelevantAlertId = mostRelevantAlertId;
            this.AlertCir = alertCir;
            this.FullAlertTypeSerialised = fullAlertTypeSerialised;
            this.StartTimeTicks = startTimeTicks;
            this.LastOk = lastOk;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets DateRaised
        /// </summary>
        [DataMember(Name = "dateRaised", EmitDefaultValue = true)]
        public DateTime? DateRaised { get; set; }

        /// <summary>
        /// Gets or Sets ActiveForMinutes
        /// </summary>
        [DataMember(Name = "activeForMinutes", EmitDefaultValue = false)]
        public int ActiveForMinutes { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Extra
        /// </summary>
        [DataMember(Name = "extra", EmitDefaultValue = false)]
        public long Extra { get; set; }

        /// <summary>
        /// Gets or Sets MostRelevantAlertId
        /// </summary>
        [DataMember(Name = "mostRelevantAlertId", EmitDefaultValue = false)]
        public IntegerIdentifier MostRelevantAlertId { get; set; }

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
        /// Gets or Sets StartTimeTicks
        /// </summary>
        [DataMember(Name = "startTimeTicks", EmitDefaultValue = false)]
        public long StartTimeTicks { get; set; }

        /// <summary>
        /// Gets or Sets LastOk
        /// </summary>
        [DataMember(Name = "lastOk", EmitDefaultValue = true)]
        public DateTime? LastOk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityStatus {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  DateRaised: ").Append(DateRaised).Append("\n");
            sb.Append("  ActiveForMinutes: ").Append(ActiveForMinutes).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
            sb.Append("  MostRelevantAlertId: ").Append(MostRelevantAlertId).Append("\n");
            sb.Append("  AlertCir: ").Append(AlertCir).Append("\n");
            sb.Append("  FullAlertTypeSerialised: ").Append(FullAlertTypeSerialised).Append("\n");
            sb.Append("  StartTimeTicks: ").Append(StartTimeTicks).Append("\n");
            sb.Append("  LastOk: ").Append(LastOk).Append("\n");
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
