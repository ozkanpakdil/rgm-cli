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
///     SqlServerCredentialsModel
/// </summary>
[DataContract(Name = "SqlServerCredentialsModel")]
public class SqlServerCredentialsModel : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="SqlServerCredentialsModel" /> class.
    /// </summary>
    /// <param name="isSameAsWindowsCredentials">isSameAsWindowsCredentials.</param>
    /// <param name="isBaseMonitorAccount">isBaseMonitorAccount.</param>
    /// <param name="userName">userName.</param>
    /// <param name="password">password.</param>
    /// <param name="decryptionFailed">decryptionFailed.</param>
    /// <param name="authenticationMode">authenticationMode.</param>
    public SqlServerCredentialsModel(bool isSameAsWindowsCredentials = default, bool isBaseMonitorAccount = default,
        string userName = default, string password = default, bool decryptionFailed = default,
        SqlServerAuthenticationMode? authenticationMode = default)
    {
        IsSameAsWindowsCredentials = isSameAsWindowsCredentials;
        IsBaseMonitorAccount = isBaseMonitorAccount;
        UserName = userName;
        Password = password;
        DecryptionFailed = decryptionFailed;
        AuthenticationMode = authenticationMode;
    }

    /// <summary>
    ///     Gets or Sets AuthenticationMode
    /// </summary>
    [DataMember(Name = "authenticationMode", EmitDefaultValue = false)]
    public SqlServerAuthenticationMode? AuthenticationMode { get; set; }

    /// <summary>
    ///     Gets or Sets IsSameAsWindowsCredentials
    /// </summary>
    [DataMember(Name = "isSameAsWindowsCredentials", EmitDefaultValue = true)]
    public bool IsSameAsWindowsCredentials { get; set; }

    /// <summary>
    ///     Gets or Sets IsBaseMonitorAccount
    /// </summary>
    [DataMember(Name = "isBaseMonitorAccount", EmitDefaultValue = true)]
    public bool IsBaseMonitorAccount { get; set; }

    /// <summary>
    ///     Gets or Sets UserName
    /// </summary>
    [DataMember(Name = "userName", EmitDefaultValue = true)]
    public string UserName { get; set; }

    /// <summary>
    ///     Gets or Sets Password
    /// </summary>
    [DataMember(Name = "password", EmitDefaultValue = true)]
    public string Password { get; set; }

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
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SqlServerCredentialsModel {\n");
        sb.Append("  IsSameAsWindowsCredentials: ").Append(IsSameAsWindowsCredentials).Append("\n");
        sb.Append("  IsBaseMonitorAccount: ").Append(IsBaseMonitorAccount).Append("\n");
        sb.Append("  UserName: ").Append(UserName).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  DecryptionFailed: ").Append(DecryptionFailed).Append("\n");
        sb.Append("  AuthenticationMode: ").Append(AuthenticationMode).Append("\n");
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