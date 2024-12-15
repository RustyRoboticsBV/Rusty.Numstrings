using System;

namespace Rusty.Numstrings
{
    internal static class IntArrayParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static int[] Parse(string str)
        {
            if (str == "{ }")
                return new int[0];

            if (!(str.StartsWith("{ ") && str.EndsWith(" }")))
                throw new Exception();

            string[] substrings = str.Substring(2, str.Length - 4).Split(", ");
            int[] result = new int[substrings.Length];
            for (int i = 0; i < substrings.Length; i++)
            {
                result[i] = IntParser.Parse(substrings[i]);
            }
            return result;
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(int[] value)
        {
            if (value == null || value.Length == 0)
                return "{ }";

            string str = IntParser.Serialize(value[0]);
            for (int i = 1; i < value.Length; i++)
            {
                str += ", " + IntParser.Serialize(value[i]);
            }
            return "{ " + str + " }";
        }
    }
}