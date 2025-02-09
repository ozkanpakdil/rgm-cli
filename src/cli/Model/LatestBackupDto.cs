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
    /// LatestBackupDto
    /// </summary>
    [DataContract(Name = "LatestBackupDto")]
    public partial class LatestBackupDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestBackupDto" /> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="duration">duration.</param>
        /// <param name="size">size.</param>
        /// <param name="nativeBackup">nativeBackup.</param>
        /// <param name="backedUpByRedgateSqlBackup">backedUpByRedgateSqlBackup.</param>
        public LatestBackupDto(DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), double duration = default(double), long size = default(long), bool nativeBackup = default(bool), bool backedUpByRedgateSqlBackup = default(bool))
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.Size = size;
            this.NativeBackup = nativeBackup;
            this.BackedUpByRedgateSqlBackup = backedUpByRedgateSqlBackup;
        }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public double Duration { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long Size { get; set; }

        /// <summary>
        /// Gets or Sets NativeBackup
        /// </summary>
        [DataMember(Name = "nativeBackup", EmitDefaultValue = true)]
        public bool NativeBackup { get; set; }

        /// <summary>
        /// Gets or Sets BackedUpByRedgateSqlBackup
        /// </summary>
        [DataMember(Name = "backedUpByRedgateSqlBackup", EmitDefaultValue = true)]
        public bool BackedUpByRedgateSqlBackup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LatestBackupDto {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  NativeBackup: ").Append(NativeBackup).Append("\n");
            sb.Append("  BackedUpByRedgateSqlBackup: ").Append(BackedUpByRedgateSqlBackup).Append("\n");
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
