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
    /// ConfigurationComplianceTemplateDto
    /// </summary>
    [DataContract(Name = "ConfigurationComplianceTemplateDto")]
    public partial class ConfigurationComplianceTemplateDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationComplianceTemplateDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="options">options.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="isPreSet">isPreSet.</param>
        /// <param name="detailsMessage">detailsMessage.</param>
        public ConfigurationComplianceTemplateDto(Guid id = default(Guid), string name = default(string), Dictionary<string, Object> options = default(Dictionary<string, Object>), DateTime lastUpdated = default(DateTime), bool isPreSet = default(bool), string detailsMessage = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Options = options;
            this.LastUpdated = lastUpdated;
            this.IsPreSet = isPreSet;
            this.DetailsMessage = detailsMessage;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public Dictionary<string, Object> Options { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets IsPreSet
        /// </summary>
        [DataMember(Name = "isPreSet", EmitDefaultValue = true)]
        public bool IsPreSet { get; set; }

        /// <summary>
        /// Gets or Sets DetailsMessage
        /// </summary>
        [DataMember(Name = "detailsMessage", EmitDefaultValue = true)]
        public string DetailsMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationComplianceTemplateDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  IsPreSet: ").Append(IsPreSet).Append("\n");
            sb.Append("  DetailsMessage: ").Append(DetailsMessage).Append("\n");
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
