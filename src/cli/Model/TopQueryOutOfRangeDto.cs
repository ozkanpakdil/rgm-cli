/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using RedGate.SqlMonitor.Channels.Data;

namespace cli.Model;

/// <summary>
///     TopQueryOutOfRangeDto
/// </summary>
[DataContract(Name = "TopQueryOutOfRangeDto")]
public class TopQueryOutOfRangeDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TopQueryOutOfRangeDto" /> class.
    /// </summary>
    /// <param name="channelInstanceRef">channelInstanceRef.</param>
    /// <param name="queryText">queryText.</param>
    /// <param name="queryHash">queryHash.</param>
    /// <param name="database">database.</param>
    public TopQueryOutOfRangeDto(ChannelInstanceRef channelInstanceRef = default, FullQueryTextDto queryText = default,
        string queryHash = default, string database = default)
    {
        ChannelInstanceRef = channelInstanceRef;
        QueryText = queryText;
        QueryHash = queryHash;
        Database = database;
    }

    /// <summary>
    ///     Gets or Sets ChannelInstanceRef
    /// </summary>
    [DataMember(Name = "channelInstanceRef", EmitDefaultValue = false)]
    public ChannelInstanceRef ChannelInstanceRef { get; set; }

    /// <summary>
    ///     Gets or Sets QueryText
    /// </summary>
    [DataMember(Name = "queryText", EmitDefaultValue = false)]
    public FullQueryTextDto QueryText { get; set; }

    /// <summary>
    ///     Gets or Sets QueryHash
    /// </summary>
    [DataMember(Name = "queryHash", EmitDefaultValue = false)]
    public string QueryHash { get; set; }

    /// <summary>
    ///     Gets or Sets Database
    /// </summary>
    [DataMember(Name = "database", EmitDefaultValue = false)]
    public string Database { get; set; }

    /// <summary>
    ///     Gets or Sets IsTrackedAndNotInZoomRange
    /// </summary>
    [DataMember(Name = "isTrackedAndNotInZoomRange", EmitDefaultValue = true)]
    public bool IsTrackedAndNotInZoomRange { get; private set; }

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
    ///     Returns false as IsTrackedAndNotInZoomRange should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeIsTrackedAndNotInZoomRange()
    {
        return false;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TopQueryOutOfRangeDto {\n");
        sb.Append("  ChannelInstanceRef: ").Append(ChannelInstanceRef).Append("\n");
        sb.Append("  QueryText: ").Append(QueryText).Append("\n");
        sb.Append("  QueryHash: ").Append(QueryHash).Append("\n");
        sb.Append("  Database: ").Append(Database).Append("\n");
        sb.Append("  IsTrackedAndNotInZoomRange: ").Append(IsTrackedAndNotInZoomRange).Append("\n");
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