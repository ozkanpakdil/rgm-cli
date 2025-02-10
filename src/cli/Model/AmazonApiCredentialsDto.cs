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
///     AmazonApiCredentialsDto
/// </summary>
[DataContract(Name = "AmazonApiCredentialsDto")]
public class AmazonApiCredentialsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AmazonApiCredentialsDto" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AmazonApiCredentialsDto()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AmazonApiCredentialsDto" /> class.
    /// </summary>
    /// <param name="authenticationMode">authenticationMode (required).</param>
    /// <param name="region">region (required).</param>
    /// <param name="dbIdentifier">dbIdentifier (required).</param>
    /// <param name="roleArn">roleArn.</param>
    /// <param name="accessKey">accessKey.</param>
    /// <param name="secretKey">secretKey.</param>
    /// <param name="decryptionFailed">decryptionFailed.</param>
    public AmazonApiCredentialsDto(AmazonAwsCredentialOptions authenticationMode = default, string region = default,
        string dbIdentifier = default, string roleArn = default, string accessKey = default, string secretKey = default,
        bool decryptionFailed = default)
    {
        AuthenticationMode = authenticationMode;
        // to ensure "region" is required (not null)
        if (region == null)
            throw new ArgumentNullException(
                "region is a required property for AmazonApiCredentialsDto and cannot be null");
        Region = region;
        // to ensure "dbIdentifier" is required (not null)
        if (dbIdentifier == null)
            throw new ArgumentNullException(
                "dbIdentifier is a required property for AmazonApiCredentialsDto and cannot be null");
        DbIdentifier = dbIdentifier;
        RoleArn = roleArn;
        AccessKey = accessKey;
        SecretKey = secretKey;
        DecryptionFailed = decryptionFailed;
    }

    /// <summary>
    ///     Gets or Sets AuthenticationMode
    /// </summary>
    [DataMember(Name = "authenticationMode", IsRequired = true, EmitDefaultValue = true)]
    public AmazonAwsCredentialOptions AuthenticationMode { get; set; }

    /// <summary>
    ///     Gets or Sets Region
    /// </summary>
    [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = true)]
    public string Region { get; set; }

    /// <summary>
    ///     Gets or Sets DbIdentifier
    /// </summary>
    [DataMember(Name = "dbIdentifier", IsRequired = true, EmitDefaultValue = true)]
    public string DbIdentifier { get; set; }

    /// <summary>
    ///     Gets or Sets RoleArn
    /// </summary>
    [DataMember(Name = "roleArn", EmitDefaultValue = true)]
    public string RoleArn { get; set; }

    /// <summary>
    ///     Gets or Sets AccessKey
    /// </summary>
    [DataMember(Name = "accessKey", EmitDefaultValue = true)]
    public string AccessKey { get; set; }

    /// <summary>
    ///     Gets or Sets SecretKey
    /// </summary>
    [DataMember(Name = "secretKey", EmitDefaultValue = true)]
    public string SecretKey { get; set; }

    /// <summary>
    ///     Gets or Sets DecryptionFailed
    /// </summary>
    [DataMember(Name = "decryptionFailed", EmitDefaultValue = true)]
    public bool DecryptionFailed { get; set; }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        // Region (string) minLength
        if (Region != null && Region.Length < 1)
            yield return new ValidationResult("Invalid value for Region, length must be greater than 1.",
                new[] { "Region" });

        // DbIdentifier (string) minLength
        if (DbIdentifier != null && DbIdentifier.Length < 1)
            yield return new ValidationResult("Invalid value for DbIdentifier, length must be greater than 1.",
                new[] { "DbIdentifier" });

        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AmazonApiCredentialsDto {\n");
        sb.Append("  AuthenticationMode: ").Append(AuthenticationMode).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  DbIdentifier: ").Append(DbIdentifier).Append("\n");
        sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
        sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
        sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
        sb.Append("  DecryptionFailed: ").Append(DecryptionFailed).Append("\n");
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