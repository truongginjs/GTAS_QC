using System;
using System.Linq;

namespace SINNIKA.Cipher.Tool.Types
{
    public enum FlatType
    {
        unknown,
        name,
        text,
        password,
        help,
        encrypt,
        decrypt
    }
    public static class Flat
    {
        public static FlatType GetFlat(this string param)
        {
            var value = param;
            var index = param.StartsWith("--") ? 2 : param.StartsWith('-') ? 1 : -1;
            value = param.Substring(index);
            // Console.WriteLine(value);
            switch (index)
            {
                case 2:
                    return GetFlat(str => str == value);
                case 1:
                    return GetFlat(str => str[0].ToString() == value);
                default:
                    return FlatType.unknown;
            }
        }
        private static FlatType GetFlat(Func<string, bool> func)
        {
            var flatValues = Enum.GetNames(typeof(FlatType));

            for (int i = 0; i < flatValues.Length; i++)
            {
                if (func(flatValues[i]))
                    return (FlatType)i;
            }
            return FlatType.unknown;

        }
    }
}