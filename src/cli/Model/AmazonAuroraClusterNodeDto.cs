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

namespace cli.Model;

/// <summary>
///     AmazonAuroraClusterNodeDto
/// </summary>
[DataContract(Name = "AmazonAuroraClusterNodeDto")]
public class AmazonAuroraClusterNodeDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AmazonAuroraClusterNodeDto" /> class.
    /// </summary>
    /// <param name="identifier">identifier.</param>
    /// <param name="instanceName">instanceName.</param>
    /// <param name="status">status.</param>
    /// <param name="isWriter">isWriter.</param>
    /// <param name="location">location.</param>
    /// <param name="size">size.</param>
    /// <param name="serverlessMinCapacity">serverlessMinCapacity.</param>
    /// <param name="serverlessMaxCapacity">serverlessMaxCapacity.</param>
    /// <param name="acuUtilization">acuUtilization.</param>
    /// <param name="writeIops">writeIops.</param>
    /// <param name="readIops">readIops.</param>
    public AmazonAuroraClusterNodeDto(string identifier = default, string instanceName = default,
        string status = default, bool isWriter = default, string location = default, string size = default,
        double serverlessMinCapacity = default, double serverlessMaxCapacity = default,
        DoubleSparklineJsModel acuUtilization = default, DoubleSparklineJsModel writeIops = default,
        DoubleSparklineJsModel readIops = default)
    {
        Identifier = identifier;
        InstanceName = instanceName;
        Status = status;
        IsWriter = isWriter;
        Location = location;
        Size = size;
        ServerlessMinCapacity = serverlessMinCapacity;
        ServerlessMaxCapacity = serverlessMaxCapacity;
        AcuUtilization = acuUtilization;
        WriteIops = writeIops;
        ReadIops = readIops;
    }

    /// <summary>
    ///     Gets or Sets Identifier
    /// </summary>
    [DataMember(Name = "identifier", EmitDefaultValue = true)]
    public string Identifier { get; set; }

    /// <summary>
    ///     Gets or Sets InstanceName
    /// </summary>
    [DataMember(Name = "instanceName", EmitDefaultValue = true)]
    public string InstanceName { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = true)]
    public string Status { get; set; }

    /// <summary>
    ///     Gets or Sets IsWriter
    /// </summary>
    [DataMember(Name = "isWriter", EmitDefaultValue = true)]
    public bool IsWriter { get; set; }

    /// <summary>
    ///     Gets or Sets Location
    /// </summary>
    [DataMember(Name = "location", EmitDefaultValue = true)]
    public string Location { get; set; }

    /// <summary>
    ///     Gets or Sets Size
    /// </summary>
    [DataMember(Name = "size", EmitDefaultValue = true)]
    public string Size { get; set; }

    /// <summary>
    ///     Gets or Sets ServerlessMinCapacity
    /// </summary>
    [DataMember(Name = "serverlessMinCapacity", EmitDefaultValue = false)]
    public double ServerlessMinCapacity { get; set; }

    /// <summary>
    ///     Gets or Sets ServerlessMaxCapacity
    /// </summary>
    [DataMember(Name = "serverlessMaxCapacity", EmitDefaultValue = false)]
    public double ServerlessMaxCapacity { get; set; }

    /// <summary>
    ///     Gets or Sets AcuUtilization
    /// </summary>
    [DataMember(Name = "acuUtilization", EmitDefaultValue = false)]
    public DoubleSparklineJsModel AcuUtilization { get; set; }

    /// <summary>
    ///     Gets or Sets WriteIops
    /// </summary>
    [DataMember(Name = "writeIops", EmitDefaultValue = false)]
    public DoubleSparklineJsModel WriteIops { get; set; }

    /// <summary>
    ///     Gets or Sets ReadIops
    /// </summary>
    [DataMember(Name = "readIops", EmitDefaultValue = false)]
    public DoubleSparklineJsModel ReadIops { get; set; }

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
        sb.Append("class AmazonAuroraClusterNodeDto {\n");
        sb.Append("  Identifier: ").Append(Identifier).Append("\n");
        sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  IsWriter: ").Append(IsWriter).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  ServerlessMinCapacity: ").Append(ServerlessMinCapacity).Append("\n");
        sb.Append("  ServerlessMaxCapacity: ").Append(ServerlessMaxCapacity).Append("\n");
        sb.Append("  AcuUtilization: ").Append(AcuUtilization).Append("\n");
        sb.Append("  WriteIops: ").Append(WriteIops).Append("\n");
        sb.Append("  ReadIops: ").Append(ReadIops).Append("\n");
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