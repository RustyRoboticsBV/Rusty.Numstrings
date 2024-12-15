using System;

namespace Rusty.Numstrings
{
    internal static class FloatArrayParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static float[] Parse(string str)
        {
            if (str == "{ }")
                return new float[0];

            if (!(str.StartsWith("{ ") && str.EndsWith(" }")))
                throw new Exception();

            string[] substrings = str.Substring(2, str.Length - 4).Split(", ");
            float[] result = new float[substrings.Length];
            for (int i = 0; i < substrings.Length; i++)
            {
                result[i] = FloatParser.Parse(substrings[i]);
            }
            return result;
        }

        /// <summary>
        /// Serialize a value of the parser's type floato a string.
        /// </summary>
        public static string Serialize(float[] value)
        {
            if (value == null || value.Length == 0)
                return "{ }";

            string str = FloatParser.Serialize(value[0]);
            for (int i = 1; i < value.Length; i++)
            {
                str += ", " + FloatParser.Serialize(value[i]);
            }
            return "{ " + str + " }";
        }
    }
}