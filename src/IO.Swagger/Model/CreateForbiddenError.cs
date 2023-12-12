/* 
 * Maps Booking Partners API
 *
 * # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// Создание записи запрещено. Например, пользователь находится в блок-листе.
    /// </summary>
    /// <value>Создание записи запрещено. Например, пользователь находится в блок-листе.</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CreateForbiddenError
    {
        /// <summary>
        /// Enum CREATEFORBIDDEN for value: CREATE_FORBIDDEN
        /// </summary>
        [EnumMember(Value = "CREATE_FORBIDDEN")]
        CREATEFORBIDDEN = 1    }
}
