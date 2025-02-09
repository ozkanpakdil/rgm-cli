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
    /// SuspendEntityRequest
    /// </summary>
    [DataContract(Name = "SuspendEntityRequest")]
    public partial class SuspendEntityRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuspendEntityRequest" /> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        /// <param name="makeSuspended">makeSuspended.</param>
        public SuspendEntityRequest(List<string> ids = default(List<string>), bool makeSuspended = default(bool))
        {
            this.Ids = ids;
            this.MakeSuspended = makeSuspended;
        }

        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name = "ids", EmitDefaultValue = true)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or Sets MakeSuspended
        /// </summary>
        [DataMember(Name = "makeSuspended", EmitDefaultValue = true)]
        public bool MakeSuspended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SuspendEntityRequest {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  MakeSuspended: ").Append(MakeSuspended).Append("\n");
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
