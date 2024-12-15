namespace Rusty.Numstrings
{
    internal static class DoubleParser
    {
        /// <summary>
        /// Parse a string and return a value of the desired type.
        /// </summary>
        public static double Parse(string str)
        {
            return double.Parse(str);
        }

        /// <summary>
        /// Serialize a value of the parser's type into a string.
        /// </summary>
        public static string Serialize(double value)
        {
            return value.ToString();
        }
    }
}