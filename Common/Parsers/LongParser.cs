namespace Rusty.Numstrings
{
    internal static class LongParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static long Parse(string str)
        {
            return long.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(long value)
        {
            return value.ToString();
        }
    }
}