using System;

namespace Plugcoder
{
    public static class ExtensionMethods
    {
        public static string UppercaseFirstLetter(this string value)
        {
            // Uppercase the first letter in the string.
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

        public static string decToHex(this int decimalValue)
        {
            string hex = decimalValue.ToString("X");
            return hex;
        }

        public static int hexToDec(this string hex)
        {
            int dec = Convert.ToInt32(hex, 16);
            return dec;
        }

        public static string hexToAscii(this string hex)
        {
            string asc = Convert.ToChar(Convert.ToUInt32(hex, 16)).ToString();
            return asc;
        }
    }
}
