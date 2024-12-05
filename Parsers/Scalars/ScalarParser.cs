using System.Text.RegularExpressions;
using System;

namespace Rusty.Numstrings
{
    /// <summary>
    /// Base class for all scalar parsers.
    /// </summary>
    internal abstract class ScalarParser<T> : Parser<string, T>
    {
        /* Protected methods. */
        protected override string Extract(string str, string pattern)
        {
            Extract(str, pattern, out string group1);
            return group1;
        }

        /* Private methods. */
        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        private static void Extract(string str, string pattern, out string group1)
        {
            Match match = Regex.Match(str, pattern);
            if (match.Success)
                group1 = match.Groups[1].Value;
            else
                throw new ArgumentException($"The string '{str}' did not match the pattern '{pattern}'.");
        }
    }
}
