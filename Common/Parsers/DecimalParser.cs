namespace Rusty.Numstrings
{
    internal static class DecimalParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static decimal Parse(string str)
        {
            return decimal.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(decimal value)
        {
            return value.ToString();
        }
    }
}