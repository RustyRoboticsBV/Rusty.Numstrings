using System;

namespace Rusty.Numstrings
{
    /// <summary>
    /// A parser for unsigned numeric strings.
    /// </summary>
    internal class UnsignedParser
    {
        /* Internal methods. */
        internal static T Parse<T>(string str, ParserMethod<T> parser, T defaultValue, T maxValue)
        {
            try
            {
                str = Trimmer.RemoveWhiteSpace(str);
                str = str.Replace("+", "");
                str = str.Replace("--", "");
                return parser(str);
            }
            catch (OverflowException)
            {
                return maxValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
