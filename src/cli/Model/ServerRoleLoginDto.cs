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
    /// ServerRoleLoginDto
    /// </summary>
    [DataContract(Name = "ServerRoleLoginDto")]
    public partial class ServerRoleLoginDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public ServerRole? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerRoleLoginDto" /> class.
        /// </summary>
        /// <param name="role">role.</param>
        /// <param name="roleName">roleName.</param>
        /// <param name="loginDtos">loginDtos.</param>
        public ServerRoleLoginDto(ServerRole? role = default(ServerRole?), string roleName = default(string), List<LoginDto> loginDtos = default(List<LoginDto>))
        {
            this.Role = role;
            this.RoleName = roleName;
            this.LoginDtos = loginDtos;
        }

        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name = "roleName", EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or Sets LoginDtos
        /// </summary>
        [DataMember(Name = "loginDtos", EmitDefaultValue = true)]
        public List<LoginDto> LoginDtos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServerRoleLoginDto {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  LoginDtos: ").Append(LoginDtos).Append("\n");
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
