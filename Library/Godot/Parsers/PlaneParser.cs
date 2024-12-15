#if GODOT
using Godot;
using System;

namespace Rusty.Numstrings
{
    /// <summary>
    /// A parser for planes.
    /// </summary>
    internal static class PlaneParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static Plane Parse(string str)
        {
            if (!(str.StartsWith("(") && str.EndsWith(")")))
                throw new Exception();

            if (str.Count(",", 1, str.Length - 2) != 3)
                throw new Exception();

            string[] substrings = str.Substring(0, str.Length - 2).Split(", ");
            if (!(substrings[0].StartsWith("(") && substrings[2].EndsWith(")")))
                throw new Exception();
            return new Plane(
                FloatParser.Parse(substrings[0].Substring(1)),
                FloatParser.Parse(substrings[1]),
                FloatParser.Parse(substrings[2].Substring(0, substrings[2].Length - 1)),
                FloatParser.Parse(substrings[3])
            );
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(Plane value)
        {
            return $"(({value.X}, {value.Y}, {value.Z}), {value.D})";
        }
    }
}
#endif