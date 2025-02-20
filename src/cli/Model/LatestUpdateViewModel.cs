/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace cli.Model;

/// <summary>
///     LatestUpdateViewModel
/// </summary>
[DataContract(Name = "LatestUpdateViewModel")]
public class LatestUpdateViewModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="LatestUpdateViewModel" /> class.
    /// </summary>
    /// <param name="productLevel">productLevel.</param>
    /// <param name="downloadUrl">downloadUrl.</param>
    /// <param name="servicePackDownloadUrl">servicePackDownloadUrl.</param>
    /// <param name="releaseDate">releaseDate.</param>
    /// <param name="versionNumber">versionNumber.</param>
    public LatestUpdateViewModel(string productLevel = default, string downloadUrl = default,
        string servicePackDownloadUrl = default, DateTime releaseDate = default, string versionNumber = default)
    {
        ProductLevel = productLevel;
        DownloadUrl = downloadUrl;
        ServicePackDownloadUrl = servicePackDownloadUrl;
        ReleaseDate = releaseDate;
        VersionNumber = versionNumber;
    }

    /// <summary>
    ///     Gets or Sets ProductLevel
    /// </summary>
    [DataMember(Name = "productLevel", EmitDefaultValue = true)]
    public string ProductLevel { get; set; }

    /// <summary>
    ///     Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = true)]
    public string DownloadUrl { get; set; }

    /// <summary>
    ///     Gets or Sets ServicePackDownloadUrl
    /// </summary>
    [DataMember(Name = "servicePackDownloadUrl", EmitDefaultValue = true)]
    public string ServicePackDownloadUrl { get; set; }

    /// <summary>
    ///     Gets or Sets ReleaseDate
    /// </summary>
    [DataMember(Name = "releaseDate", EmitDefaultValue = false)]
    public DateTime ReleaseDate { get; set; }

    /// <summary>
    ///     Gets or Sets VersionNumber
    /// </summary>
    [DataMember(Name = "versionNumber", EmitDefaultValue = true)]
    public string VersionNumber { get; set; }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LatestUpdateViewModel {\n");
        sb.Append("  ProductLevel: ").Append(ProductLevel).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  ServicePackDownloadUrl: ").Append(ServicePackDownloadUrl).Append("\n");
        sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
        sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    ///     Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}