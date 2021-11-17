using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.Helpers.Extensions
{
    public static class StringExtensions
    {
        public static T ToEnum<T>(this string value, T defaultValue) where T : struct, IConvertible
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            T result;
            return Enum.TryParse(value, true, out result) ? result : defaultValue;
        }
    }
}
