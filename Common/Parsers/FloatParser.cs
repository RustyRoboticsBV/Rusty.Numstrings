namespace Rusty.Numstrings
{
    internal static class FloatParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static float Parse(string str)
        {
            return float.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(float value)
        {
            return value.ToString();
        }
    }
}