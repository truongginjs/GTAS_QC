using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace QCService.Helpers.Extensions
{
    public static class TypeExtensions
    {
        public static string GenerateStoreProcedure(this Type type)
        {
            return string.Empty;
        }
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };
        public static string SetJsonProperty<T>(this T property, T value, out string json)
        {
            property = value;
            json = property == null ? string.Empty : JsonSerializer.Serialize(property, options);
            return json;
        }

        public static T GetJsonProperty<T>(this string propertyJson, ref T property)
        {
            property ??= string.IsNullOrWhiteSpace(propertyJson) ? default : JsonSerializer.Deserialize<T>(propertyJson, options);
            return property;
        }
    }
}
