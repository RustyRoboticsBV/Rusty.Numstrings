namespace Rusty.Numstrings
{
    internal static class ShortParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static short Parse(string str)
        {
            return short.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(short value)
        {
            return value.ToString();
        }
    }
}