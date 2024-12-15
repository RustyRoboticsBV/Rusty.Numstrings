#if GODOT
using Godot;
using System;

namespace Rusty.Numstrings
{
    internal static class Vector2Parser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static Vector2 Parse(string str)
        {
            if (!(str.StartsWith("(") && str.EndsWith(")")))
                throw new Exception();

            if (str.Count(",", 1, str.Length - 2) != 1)
                throw new Exception();

            string[] substrings = str.Substring(1, str.Length - 2).Split(", ");
            return new Vector2(
                FloatParser.Parse(substrings[0]),
                FloatParser.Parse(substrings[1])
            );
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(Vector2 value)
        {
            return $"({value.X}, {value.Y})";
        }
    }
}
#endif