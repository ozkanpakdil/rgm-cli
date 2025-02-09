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
    /// HistoricVolumeUsageViewModel
    /// </summary>
    [DataContract(Name = "HistoricVolumeUsageViewModel")]
    public partial class HistoricVolumeUsageViewModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricVolumeUsageViewModel" /> class.
        /// </summary>
        /// <param name="showLimitedDataWarning">showLimitedDataWarning.</param>
        /// <param name="showShortPurgeSettingWarning">showShortPurgeSettingWarning.</param>
        /// <param name="used">used.</param>
        /// <param name="totalProjectedSizeNow">totalProjectedSizeNow.</param>
        /// <param name="totalProjectedSizeInOneYear">totalProjectedSizeInOneYear.</param>
        /// <param name="totalUsedSpace">totalUsedSpace.</param>
        /// <param name="totalCapacity">totalCapacity.</param>
        /// <param name="storageDataPurgeLifeTime">storageDataPurgeLifeTime.</param>
        public HistoricVolumeUsageViewModel(bool showLimitedDataWarning = default(bool), bool showShortPurgeSettingWarning = default(bool), List<List<long>> used = default(List<List<long>>), double totalProjectedSizeNow = default(double), double totalProjectedSizeInOneYear = default(double), double totalUsedSpace = default(double), double totalCapacity = default(double), string storageDataPurgeLifeTime = default(string))
        {
            this.ShowLimitedDataWarning = showLimitedDataWarning;
            this.ShowShortPurgeSettingWarning = showShortPurgeSettingWarning;
            this.Used = used;
            this.TotalProjectedSizeNow = totalProjectedSizeNow;
            this.TotalProjectedSizeInOneYear = totalProjectedSizeInOneYear;
            this.TotalUsedSpace = totalUsedSpace;
            this.TotalCapacity = totalCapacity;
            this.StorageDataPurgeLifeTime = storageDataPurgeLifeTime;
        }

        /// <summary>
        /// Gets or Sets ShowLimitedDataWarning
        /// </summary>
        [DataMember(Name = "showLimitedDataWarning", EmitDefaultValue = true)]
        public bool ShowLimitedDataWarning { get; set; }

        /// <summary>
        /// Gets or Sets ShowShortPurgeSettingWarning
        /// </summary>
        [DataMember(Name = "showShortPurgeSettingWarning", EmitDefaultValue = true)]
        public bool ShowShortPurgeSettingWarning { get; set; }

        /// <summary>
        /// Gets or Sets Used
        /// </summary>
        [DataMember(Name = "used", EmitDefaultValue = true)]
        public List<List<long>> Used { get; set; }

        /// <summary>
        /// Gets or Sets TotalProjectedSizeNow
        /// </summary>
        [DataMember(Name = "totalProjectedSizeNow", EmitDefaultValue = false)]
        public double TotalProjectedSizeNow { get; set; }

        /// <summary>
        /// Gets or Sets TotalProjectedSizeInOneYear
        /// </summary>
        [DataMember(Name = "totalProjectedSizeInOneYear", EmitDefaultValue = false)]
        public double TotalProjectedSizeInOneYear { get; set; }

        /// <summary>
        /// Gets or Sets TotalUsedSpace
        /// </summary>
        [DataMember(Name = "totalUsedSpace", EmitDefaultValue = false)]
        public double TotalUsedSpace { get; set; }

        /// <summary>
        /// Gets or Sets TotalCapacity
        /// </summary>
        [DataMember(Name = "totalCapacity", EmitDefaultValue = false)]
        public double TotalCapacity { get; set; }

        /// <summary>
        /// Gets or Sets StorageDataPurgeLifeTime
        /// </summary>
        [DataMember(Name = "storageDataPurgeLifeTime", EmitDefaultValue = true)]
        public string StorageDataPurgeLifeTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoricVolumeUsageViewModel {\n");
            sb.Append("  ShowLimitedDataWarning: ").Append(ShowLimitedDataWarning).Append("\n");
            sb.Append("  ShowShortPurgeSettingWarning: ").Append(ShowShortPurgeSettingWarning).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  TotalProjectedSizeNow: ").Append(TotalProjectedSizeNow).Append("\n");
            sb.Append("  TotalProjectedSizeInOneYear: ").Append(TotalProjectedSizeInOneYear).Append("\n");
            sb.Append("  TotalUsedSpace: ").Append(TotalUsedSpace).Append("\n");
            sb.Append("  TotalCapacity: ").Append(TotalCapacity).Append("\n");
            sb.Append("  StorageDataPurgeLifeTime: ").Append(StorageDataPurgeLifeTime).Append("\n");
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
