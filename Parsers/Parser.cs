using System;
using System.Text.RegularExpressions;

namespace Rusty.Numstrings
{
    /// <summary>
    /// Base class for all parsers.
    /// </summary>
    internal abstract class Parser<T>
    {
        /* Protected constants. */
        protected static readonly string sign = "[+-]";
        protected static readonly string digits = "[0-9]";
        protected static readonly string letters = "[a-z|A-Z]";
        protected static readonly string whitespace = @"\s";
        protected static readonly string boolTrue = "[tT][rR][uU][eE]";
        protected static readonly string boolFalse = "(f|F)(a|A)(l|L)(s|S)(e|E)";

        /* Protected properties. */
        protected abstract string[] Patterns { get; }

        /* Private properties. */
        private static int GroupIndex { get; set; }

        /* Public methods. */
        /// <summary>
        /// Parse a string and return an object.
        /// </summary>
        public abstract T Parse(string str);

        /// <summary>
        /// Serialize an object and return the string representation.
        /// </summary>
        public virtual string Serialize(T obj)
        {
            return obj.ToString();
        }

        /* Protected methods. */
        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string pattern, out string group1)
        {
            Match match = Regex.Match(str, pattern);
            if (match.Success)
                group1 = match.Groups[1].Value;
            else
                throw new ArgumentException($"The string '{str}' did not match the pattern '{pattern}'.");
        }

        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string[] patterns, out string group1)
        {
            foreach (string pattern in patterns)
            {
                try
                {
                    Extract(str, pattern, out group1);
                    return;
                }
                catch { }
            }
            throw new ArgumentException($"The string '{str}' did not match any of the patterns in '{patterns}'.");
        }

        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string pattern, out string group1, out string group2)
        {
            Match match = Regex.Match(str, pattern);
            if (match.Success)
            {
                group1 = match.Groups[1].Value;
                group2 = match.Groups[2].Value;
            }
            else
                throw new ArgumentException($"The string '{str}' did not match the pattern '{pattern}'.");
        }

        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string[] patterns, out string group1, out string group2)
        {
            foreach (string pattern in patterns)
            {
                try
                {
                    Extract(str, pattern, out group1, out group2);
                    return;
                }
                catch { }
            }
            throw new ArgumentException($"The string '{str}' did not match any of the patterns in '{patterns}'.");
        }

        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string pattern, out string group1, out string group2, out string group3)
        {
            Match match = Regex.Match(str, pattern);
            if (match.Success)
            {
                group1 = match.Groups[1].Value;
                group2 = match.Groups[2].Value;
                group3 = match.Groups[3].Value;
            }
            else
                throw new ArgumentException($"The string '{str}' did not match the pattern '{pattern}'.");
        }

        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string[] patterns, out string group1, out string group2, out string group3)
        {
            foreach (string pattern in patterns)
            {
                try
                {
                    Extract(str, pattern, out group1, out group2, out group3);
                    return;
                }
                catch { }
            }
            throw new ArgumentException($"The string '{str}' did not match any of the patterns in '{patterns}'.");
        }

        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string pattern, out string group1, out string group2, out string group3,
            out string group4)
        {
            Match match = Regex.Match(str, pattern);
            if (match.Success)
            {
                group1 = match.Groups[1].Value;
                group2 = match.Groups[2].Value;
                group3 = match.Groups[3].Value;
                group4 = match.Groups[4].Value;
            }
            else
                throw new ArgumentException($"The string '{str}' did not match the pattern '{pattern}'.");
        }

        /// <summary>
        /// Match a string to some pattern.
        /// </summary>
        protected static void Extract(string str, string[] patterns, out string group1, out string group2, out string group3,
            out string group4)
        {
            foreach (string pattern in patterns)
            {
                try
                {
                    Extract(str, pattern, out group1, out group2, out group3, out group4);
                    return;
                }
                catch { }
            }
            throw new ArgumentException($"The string '{str}' did not match any of the patterns in '{patterns}'.");
        }

        /// <summary>
        /// Surrounds a pattern with optional whitespace patterns.
        /// </summary>
        protected static string Whitespace(string str)
        {
            return $"{whitespace}*{str}{whitespace}*";
        }

        /// <summary>
        /// Surrounds a pattern with a group marker.
        /// </summary>
        protected static string Group(string str)
        {
            string result =  $"(?<{GroupIndex + 1}>({str}))";
            GroupIndex++;
            return result;
        }
    }
}
