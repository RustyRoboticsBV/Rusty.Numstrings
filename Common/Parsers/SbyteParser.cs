namespace Rusty.Numstrings
{
    internal static class SbyteParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static sbyte Parse(string str)
        {
            return sbyte.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(sbyte value)
        {
            return value.ToString();
        }
    }
}