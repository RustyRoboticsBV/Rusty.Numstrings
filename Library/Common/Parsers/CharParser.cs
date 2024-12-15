namespace Rusty.Numstrings
{
    internal static class CharParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static char Parse(string str)
        {
            return char.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(char value)
        {
            return value.ToString();
        }
    }
}