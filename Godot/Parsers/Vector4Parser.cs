#if GODOT
using Godot;
using System;

namespace Rusty.Numstrings
{
    internal static class Vector4Parser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static Vector4 Parse(string str)
        {
            if (!(str.StartsWith("(") && str.EndsWith(")")))
                throw new Exception();

            if (str.Count(",", 1, str.Length - 2) != 3)
                throw new Exception();

            string[] substrings = str.Substring(1, str.Length - 2).Split(", ");
            return new Vector4(
                FloatParser.Parse(substrings[0]),
                FloatParser.Parse(substrings[1]),
                FloatParser.Parse(substrings[2]),
                FloatParser.Parse(substrings[3])
            );
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(Vector4 value)
        {
            return $"({value.X}, {value.Y}, {value.Z}, {value.W})";
        }
    }
}
#endif