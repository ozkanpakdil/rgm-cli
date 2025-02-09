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
    /// DatabaseConfigurationServerInfoDto
    /// </summary>
    [DataContract(Name = "DatabaseConfigurationServerInfoDto")]
    public partial class DatabaseConfigurationServerInfoDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MonitoredEntityStatusCategory
        /// </summary>
        [DataMember(Name = "monitoredEntityStatusCategory", EmitDefaultValue = false)]
        public MonitoredEntityStatusCategory? MonitoredEntityStatusCategory { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public EntityType? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseConfigurationServerInfoDto" /> class.
        /// </summary>
        /// <param name="cir">cir.</param>
        /// <param name="overviewUrl">overviewUrl.</param>
        /// <param name="name">name.</param>
        /// <param name="group">group.</param>
        /// <param name="tags">tags.</param>
        /// <param name="monitoredEntityStatusCategory">monitoredEntityStatusCategory.</param>
        /// <param name="entityType">entityType.</param>
        public DatabaseConfigurationServerInfoDto(string cir = default(string), string overviewUrl = default(string), string name = default(string), string group = default(string), List<TagDto> tags = default(List<TagDto>), MonitoredEntityStatusCategory? monitoredEntityStatusCategory = default(MonitoredEntityStatusCategory?), EntityTypeEnum? entityType = default(EntityTypeEnum?))
        {
            this.Cir = cir;
            this.OverviewUrl = overviewUrl;
            this.Name = name;
            this.Group = group;
            this.Tags = tags;
            this.MonitoredEntityStatusCategory = monitoredEntityStatusCategory;
            this.EntityType = entityType;
        }

        /// <summary>
        /// Gets or Sets Cir
        /// </summary>
        [DataMember(Name = "cir", EmitDefaultValue = false)]
        public string Cir { get; set; }

        /// <summary>
        /// Gets or Sets OverviewUrl
        /// </summary>
        [DataMember(Name = "overviewUrl", EmitDefaultValue = true)]
        public string OverviewUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<TagDto> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatabaseConfigurationServerInfoDto {\n");
            sb.Append("  Cir: ").Append(Cir).Append("\n");
            sb.Append("  OverviewUrl: ").Append(OverviewUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  MonitoredEntityStatusCategory: ").Append(MonitoredEntityStatusCategory).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
