namespace Rusty.Numstrings
{
    internal static class BoolParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static bool Parse(string str)
        {
            return bool.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(bool value)
        {
            return value.ToString();
        }
    }
}