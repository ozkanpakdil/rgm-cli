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
    /// ChannelKey
    /// </summary>
    [DataContract(Name = "ChannelKey")]
    public partial class ChannelKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ChannelKey()
        {
        }

        /// <summary>
        /// Gets or Sets Keys
        /// </summary>
        [DataMember(Name = "keys", EmitDefaultValue = false)]
        public Dictionary<string, Object> Keys { get; private set; }

        /// <summary>
        /// Returns false as Keys should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKeys()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PropertyNames
        /// </summary>
        [DataMember(Name = "propertyNames", EmitDefaultValue = false)]
        public List<PropertyName> PropertyNames { get; private set; }

        /// <summary>
        /// Returns false as PropertyNames should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePropertyNames()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; private set; }

        /// <summary>
        /// Returns false as Count should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCount()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChannelKey {\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  PropertyNames: ").Append(PropertyNames).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
