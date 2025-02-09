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
    /// AzureFlexHostDto
    /// </summary>
    [DataContract(Name = "AzureFlexHostDto")]
    public partial class AzureFlexHostDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DisplayType
        /// </summary>
        [DataMember(Name = "displayType", EmitDefaultValue = false)]
        public EntityType? DisplayType { get; set; }

        /// <summary>
        /// Returns false as DisplayType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureFlexHostDto" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="cir">cir.</param>
        /// <param name="group">group.</param>
        /// <param name="monitoredObjectState">monitoredObjectState.</param>
        /// <param name="baseMonitor">baseMonitor.</param>
        /// <param name="entityReference">entityReference.</param>
        /// <param name="tags">tags.</param>
        public AzureFlexHostDto(string name = default(string), Guid id = default(Guid), ChannelInstanceRef cir = default(ChannelInstanceRef), GroupDto group = default(GroupDto), MonitoredObjectStateDto monitoredObjectState = default(MonitoredObjectStateDto), BaseMonitorDto baseMonitor = default(BaseMonitorDto), ChannelInstanceRef entityReference = default(ChannelInstanceRef), List<TagDto> tags = default(List<TagDto>))
        {
            this.Name = name;
            this.Id = id;
            this.Cir = cir;
            this.Group = group;
            this.MonitoredObjectState = monitoredObjectState;
            this.BaseMonitor = baseMonitor;
            this.EntityReference = entityReference;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Cir
        /// </summary>
        [DataMember(Name = "cir", EmitDefaultValue = true)]
        public ChannelInstanceRef Cir { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public GroupDto Group { get; set; }

        /// <summary>
        /// Gets or Sets MonitoredObjectState
        /// </summary>
        [DataMember(Name = "monitoredObjectState", EmitDefaultValue = false)]
        public MonitoredObjectStateDto MonitoredObjectState { get; set; }

        /// <summary>
        /// Gets or Sets BaseMonitor
        /// </summary>
        [DataMember(Name = "baseMonitor", EmitDefaultValue = false)]
        public BaseMonitorDto BaseMonitor { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        public string FullName { get; private set; }

        /// <summary>
        /// Returns false as FullName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFullName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets EntityReference
        /// </summary>
        [DataMember(Name = "entityReference", EmitDefaultValue = true)]
        public ChannelInstanceRef EntityReference { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<TagDto> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AzureFlexHostDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Cir: ").Append(Cir).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  MonitoredObjectState: ").Append(MonitoredObjectState).Append("\n");
            sb.Append("  BaseMonitor: ").Append(BaseMonitor).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  EntityReference: ").Append(EntityReference).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
