namespace Rusty.Numstrings
{
    internal static class UlongParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static ulong Parse(string str)
        {
            return ulong.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(ulong value)
        {
            return value.ToString();
        }
    }
}