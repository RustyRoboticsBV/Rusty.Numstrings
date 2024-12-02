using System;

namespace Rusty.Numstrings
{
    /// <summary>
    /// A parser for signed numeric strings.
    /// </summary>
    internal class SignedParser
    {
        public static T Parse<T>(string str, ParserMethod<T> parser, T defaultValue, T minValue, T maxValue)
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
                if (str.Contains('-'))
                    return minValue;
                else
                    return maxValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}