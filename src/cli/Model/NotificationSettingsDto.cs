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
///     NotificationSettingsDto
/// </summary>
[DataContract(Name = "NotificationSettingsDto")]
public class NotificationSettingsDto : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NotificationSettingsDto" /> class.
    /// </summary>
    /// <param name="emailServerSettings">emailServerSettings.</param>
    /// <param name="emailSettings">emailSettings.</param>
    /// <param name="slackSettings">slackSettings.</param>
    /// <param name="snmpSettings">snmpSettings.</param>
    /// <param name="webhookSettings">webhookSettings.</param>
    /// <param name="scriptSettings">scriptSettings.</param>
    /// <param name="webUiPrefix">webUiPrefix.</param>
    public NotificationSettingsDto(EmailServerSettingsDto emailServerSettings = default,
        EmailSettingsDto emailSettings = default, SlackSettingsDto slackSettings = default,
        SnmpSettingsDto snmpSettings = default, WebhookSettingsDto webhookSettings = default,
        ScriptSettingsDto scriptSettings = default, string webUiPrefix = default)
    {
        EmailServerSettings = emailServerSettings;
        EmailSettings = emailSettings;
        SlackSettings = slackSettings;
        SnmpSettings = snmpSettings;
        WebhookSettings = webhookSettings;
        ScriptSettings = scriptSettings;
        WebUiPrefix = webUiPrefix;
    }

    /// <summary>
    ///     Gets or Sets EmailServerSettings
    /// </summary>
    [DataMember(Name = "emailServerSettings", EmitDefaultValue = false)]
    public EmailServerSettingsDto EmailServerSettings { get; set; }

    /// <summary>
    ///     Gets or Sets EmailSettings
    /// </summary>
    [DataMember(Name = "emailSettings", EmitDefaultValue = false)]
    public EmailSettingsDto EmailSettings { get; set; }

    /// <summary>
    ///     Gets or Sets SlackSettings
    /// </summary>
    [DataMember(Name = "slackSettings", EmitDefaultValue = false)]
    public SlackSettingsDto SlackSettings { get; set; }

    /// <summary>
    ///     Gets or Sets SnmpSettings
    /// </summary>
    [DataMember(Name = "snmpSettings", EmitDefaultValue = false)]
    public SnmpSettingsDto SnmpSettings { get; set; }

    /// <summary>
    ///     Gets or Sets WebhookSettings
    /// </summary>
    [DataMember(Name = "webhookSettings", EmitDefaultValue = false)]
    public WebhookSettingsDto WebhookSettings { get; set; }

    /// <summary>
    ///     Gets or Sets ScriptSettings
    /// </summary>
    [DataMember(Name = "scriptSettings", EmitDefaultValue = false)]
    public ScriptSettingsDto ScriptSettings { get; set; }

    /// <summary>
    ///     Gets or Sets WebUiPrefix
    /// </summary>
    [DataMember(Name = "webUiPrefix", EmitDefaultValue = true)]
    public string WebUiPrefix { get; set; }

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
        sb.Append("class NotificationSettingsDto {\n");
        sb.Append("  EmailServerSettings: ").Append(EmailServerSettings).Append("\n");
        sb.Append("  EmailSettings: ").Append(EmailSettings).Append("\n");
        sb.Append("  SlackSettings: ").Append(SlackSettings).Append("\n");
        sb.Append("  SnmpSettings: ").Append(SnmpSettings).Append("\n");
        sb.Append("  WebhookSettings: ").Append(WebhookSettings).Append("\n");
        sb.Append("  ScriptSettings: ").Append(ScriptSettings).Append("\n");
        sb.Append("  WebUiPrefix: ").Append(WebUiPrefix).Append("\n");
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