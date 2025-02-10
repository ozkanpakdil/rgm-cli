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
///     ClusterChannelInstanceRef
/// </summary>
[DataContract(Name = "ClusterChannelInstanceRef")]
public class ClusterChannelInstanceRef : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ClusterChannelInstanceRef" /> class.
    /// </summary>
    /// <param name="channelRef">channelRef.</param>
    /// <param name="channelKey">channelKey.</param>
    public ClusterChannelInstanceRef(ChannelRef channelRef = default, ChannelKey channelKey = default)
    {
        ChannelRef = channelRef;
        ChannelKey = channelKey;
    }

    /// <summary>
    ///     Gets or Sets ChannelRef
    /// </summary>
    [DataMember(Name = "channelRef", EmitDefaultValue = false)]
    public ChannelRef ChannelRef { get; set; }

    /// <summary>
    ///     Gets or Sets ChannelKey
    /// </summary>
    [DataMember(Name = "channelKey", EmitDefaultValue = false)]
    public ChannelKey ChannelKey { get; set; }

    /// <summary>
    ///     Gets or Sets ChannelInstanceRefs
    /// </summary>
    [DataMember(Name = "channelInstanceRefs", EmitDefaultValue = false)]
    public List<ChannelInstanceRef> ChannelInstanceRefs { get; private set; }

    /// <summary>
    ///     Gets or Sets RootChannelInstanceRef
    /// </summary>
    [DataMember(Name = "rootChannelInstanceRef", EmitDefaultValue = false)]
    public ChannelInstanceRef RootChannelInstanceRef { get; private set; }

    /// <summary>
    ///     Gets or Sets SubChannelInstanceRefs
    /// </summary>
    [DataMember(Name = "subChannelInstanceRefs", EmitDefaultValue = false)]
    public List<ChannelInstanceRef> SubChannelInstanceRefs { get; private set; }

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
    ///     Returns false as ChannelInstanceRefs should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeChannelInstanceRefs()
    {
        return false;
    }

    /// <summary>
    ///     Returns false as RootChannelInstanceRef should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeRootChannelInstanceRef()
    {
        return false;
    }

    /// <summary>
    ///     Returns false as SubChannelInstanceRefs should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeSubChannelInstanceRefs()
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
        sb.Append("class ClusterChannelInstanceRef {\n");
        sb.Append("  ChannelRef: ").Append(ChannelRef).Append("\n");
        sb.Append("  ChannelKey: ").Append(ChannelKey).Append("\n");
        sb.Append("  ChannelInstanceRefs: ").Append(ChannelInstanceRefs).Append("\n");
        sb.Append("  RootChannelInstanceRef: ").Append(RootChannelInstanceRef).Append("\n");
        sb.Append("  SubChannelInstanceRefs: ").Append(SubChannelInstanceRefs).Append("\n");
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