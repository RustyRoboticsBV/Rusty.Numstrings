namespace Rusty.Numstrings
{
    internal static class UshortParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static ushort Parse(string str)
        {
            return ushort.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(ushort value)
        {
            return value.ToString();
        }
    }
}