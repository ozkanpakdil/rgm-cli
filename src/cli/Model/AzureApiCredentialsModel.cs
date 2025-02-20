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
///     AzureApiCredentialsModel
/// </summary>
[DataContract(Name = "AzureApiCredentialsModel")]
public class AzureApiCredentialsModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AzureApiCredentialsModel" /> class.
    /// </summary>
    /// <param name="authenticationMode">authenticationMode.</param>
    /// <param name="servicePrincipalCredentialsId">servicePrincipalCredentialsId.</param>
    public AzureApiCredentialsModel(AzureApiAuthenticationMode? authenticationMode = default,
        Guid? servicePrincipalCredentialsId = default)
    {
        AuthenticationMode = authenticationMode;
        ServicePrincipalCredentialsId = servicePrincipalCredentialsId;
    }

    /// <summary>
    ///     Gets or Sets AuthenticationMode
    /// </summary>
    [DataMember(Name = "authenticationMode", EmitDefaultValue = false)]
    public AzureApiAuthenticationMode? AuthenticationMode { get; set; }

    /// <summary>
    ///     Gets or Sets ServicePrincipalCredentialsId
    /// </summary>
    [DataMember(Name = "servicePrincipalCredentialsId", EmitDefaultValue = true)]
    public Guid? ServicePrincipalCredentialsId { get; set; }

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
        sb.Append("class AzureApiCredentialsModel {\n");
        sb.Append("  AuthenticationMode: ").Append(AuthenticationMode).Append("\n");
        sb.Append("  ServicePrincipalCredentialsId: ").Append(ServicePrincipalCredentialsId).Append("\n");
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