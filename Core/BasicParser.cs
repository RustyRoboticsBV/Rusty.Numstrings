namespace Rusty.Numstrings
{
    /// <summary>
    /// A basic string parser.
    /// </summary>
    internal static class BasicParser
    {
        /* Internal methods. */
        internal static T Parse<T>(string str, ParserMethod<T> parser, T defaultValue)
        {
            try
            {
                return parser(str);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}