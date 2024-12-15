namespace Rusty.Numstrings
{
    internal static class ByteParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static byte Parse(string str)
        {
            return byte.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(byte value)
        {
            return value.ToString();
        }
    }
}