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
    /// AccessRequest
    /// </summary>
    [DataContract(Name = "AccessRequest")]
    public partial class AccessRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public EntityType? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRequest" /> class.
        /// </summary>
        /// <param name="entityType">entityType.</param>
        /// <param name="name">name.</param>
        /// <param name="topLevelRequest">topLevelRequest.</param>
        public AccessRequest(EntityTypeEnum? entityType = default(EntityTypeEnum?), string name = default(string), AccessRequest topLevelRequest = default(AccessRequest))
        {
            this.EntityType = entityType;
            this.Name = name;
            this.TopLevelRequest = topLevelRequest;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TopLevelRequest
        /// </summary>
        [DataMember(Name = "topLevelRequest", EmitDefaultValue = false)]
        public AccessRequest TopLevelRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessRequest {\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TopLevelRequest: ").Append(TopLevelRequest).Append("\n");
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
