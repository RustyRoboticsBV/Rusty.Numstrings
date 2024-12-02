using System.Text.RegularExpressions;

namespace Rusty.Numstrings
{
    /// <summary>
    /// A class that can remove characters from strings.
    /// </summary>
    internal class Trimmer
    {
        /* Internal methods. */
        /// <summary>
        /// Remove all white-spaces from the string and return the result.
        /// </summary>
        internal static string RemoveWhiteSpace(string str)
        {
            return Regex.Replace(str, @"\s", "");
        }

        /// <summary>
        /// Try to trim the parentheses from the start and end of a string and return the result.
        /// If the string wasn't enclosed by parentheses, the string is returned unchanged.
        /// </summary>
        internal static string TrimParentheses(string str)
        {
            if (str.StartsWith('(') && str.EndsWith(')'))
                return str.Substring(1, str.Length - 2);
            else
                return str;
        }

        /// <summary>
        /// Try to trim the curly braces from the start and end of a string and return the result.
        /// If the string wasn't enclosed by curly braces, the string is returned unchanged.
        /// </summary>
        internal static string TrimCurlyBraces(string str)
        {
            if (str.StartsWith('{') && str.EndsWith('}'))
                return str.Substring(1, str.Length - 2);
            else
                return str;
        }

        /// <summary>
        /// Try to trim the square brackets from the start and end of a string and return the result.
        /// If the string wasn't enclosed by square brackets, the string is returned unchanged.
        /// </summary>
        internal static string TrimSquareBrackets(string str)
        {
            if (str.StartsWith('[') && str.EndsWith(']'))
                return str.Substring(1, str.Length - 2);
            else
                return str;
        }
    }
}