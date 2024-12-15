#if GODOT
using Godot;

namespace Rusty.Numstrings
{
    internal static class ColorParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static Color Parse(string str)
        {
            return Color.FromHtml(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(Color value)
        {
            return value.ToHtml();
        }
    }
}
#endif