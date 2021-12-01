using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LibraryService.Heplers.Extensions
{
    public static class TypeExtensions
    {
        public static string GenerateStoreProcedure(this Type type)
        {
            return string.Empty;
        }

        public static string SetJsonProperty<T>(this T property, T value, out string json)
        {
            property = value;
            json = property == null ? string.Empty : JsonSerializer.Serialize(property);
            return json;
        }

        public static T GetJsonProperty<T>(this string propertyJson, ref T property)
        {
            property ??= string.IsNullOrWhiteSpace(propertyJson) ? default : JsonSerializer.Deserialize<T>(propertyJson);
            return property;
        }
    }
}
