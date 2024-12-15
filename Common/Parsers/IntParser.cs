namespace Rusty.Numstrings
{
    internal static class IntParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static int Parse(string str)
        {
            return int.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(int value)
        {
            return value.ToString();
        }
    }
}