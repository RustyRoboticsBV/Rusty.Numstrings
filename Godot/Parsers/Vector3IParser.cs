#if GODOT
using Godot;
using System;

namespace Rusty.Numstrings
{
    internal static class Vector3IParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static Vector3I Parse(string str)
        {
            if (!(str.StartsWith("(") && str.EndsWith(")")))
                throw new Exception();

            if (str.Count(",", 1, str.Length - 2) != 2)
                throw new Exception();

            string[] substrings = str.Substring(1, str.Length - 2).Split(", ");
            return new Vector3I(
                IntParser.Parse(substrings[0]),
                IntParser.Parse(substrings[1]),
                IntParser.Parse(substrings[2])
            );
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(Vector3I value)
        {
            return $"({value.X}, {value.Y}, {value.Z})";
        }
    }
}
#endif