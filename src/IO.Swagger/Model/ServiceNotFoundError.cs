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
    /// Услуга не найдена/недоступна для онлайн-записи
    /// </summary>
    /// <value>Услуга не найдена/недоступна для онлайн-записи</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceNotFoundError
    {
        /// <summary>
        /// Enum SERVICENOTFOUND for value: SERVICE_NOT_FOUND
        /// </summary>
        [EnumMember(Value = "SERVICE_NOT_FOUND")]
        SERVICENOTFOUND = 1    }
}