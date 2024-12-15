namespace Rusty.Numstrings
{
    internal static class UintParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static uint Parse(string str)
        {
            return uint.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(uint value)
        {
            return value.ToString();
        }
    }
}