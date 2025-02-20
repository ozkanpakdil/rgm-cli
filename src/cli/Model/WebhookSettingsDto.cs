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
///     WebhookSettingsDto
/// </summary>
[DataContract(Name = "WebhookSettingsDto")]
public class WebhookSettingsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="WebhookSettingsDto" /> class.
    /// </summary>
    /// <param name="enable">enable.</param>
    /// <param name="url">url.</param>
    /// <param name="integrationType">integrationType.</param>
    /// <param name="notificationLevel">notificationLevel.</param>
    /// <param name="template">template.</param>
    /// <param name="headers">headers.</param>
    /// <param name="ignoreSslErrors">ignoreSslErrors.</param>
    public WebhookSettingsDto(bool enable = default, string url = default,
        WebhookIntegrationTypeDto? integrationType = default, NotificationLevel? notificationLevel = default,
        string template = default, string headers = default, bool ignoreSslErrors = default)
    {
        Enable = enable;
        Url = url;
        IntegrationType = integrationType;
        NotificationLevel = notificationLevel;
        Template = template;
        Headers = headers;
        IgnoreSslErrors = ignoreSslErrors;
    }

    /// <summary>
    ///     Gets or Sets IntegrationType
    /// </summary>
    [DataMember(Name = "integrationType", EmitDefaultValue = false)]
    public WebhookIntegrationTypeDto? IntegrationType { get; set; }

    /// <summary>
    ///     Gets or Sets NotificationLevel
    /// </summary>
    [DataMember(Name = "notificationLevel", EmitDefaultValue = false)]
    public NotificationLevel? NotificationLevel { get; set; }

    /// <summary>
    ///     Gets or Sets Enable
    /// </summary>
    [DataMember(Name = "enable", EmitDefaultValue = true)]
    public bool Enable { get; set; }

    /// <summary>
    ///     Gets or Sets Url
    /// </summary>
    [DataMember(Name = "url", EmitDefaultValue = true)]
    public string Url { get; set; }

    /// <summary>
    ///     Gets or Sets Template
    /// </summary>
    [DataMember(Name = "template", EmitDefaultValue = true)]
    public string Template { get; set; }

    /// <summary>
    ///     Gets or Sets Headers
    /// </summary>
    [DataMember(Name = "headers", EmitDefaultValue = true)]
    public string Headers { get; set; }

    /// <summary>
    ///     Gets or Sets IgnoreSslErrors
    /// </summary>
    [DataMember(Name = "ignoreSslErrors", EmitDefaultValue = true)]
    public bool IgnoreSslErrors { get; set; }

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
        sb.Append("class WebhookSettingsDto {\n");
        sb.Append("  Enable: ").Append(Enable).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
        sb.Append("  NotificationLevel: ").Append(NotificationLevel).Append("\n");
        sb.Append("  Template: ").Append(Template).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("  IgnoreSslErrors: ").Append(IgnoreSslErrors).Append("\n");
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