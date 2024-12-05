using System;
using System.Text.RegularExpressions;

namespace Rusty.Numstrings
{
    /// <summary>
    /// Base class for all parsers.
    /// </summary>
    internal abstract class Parser<MatchT, ParseT>
    {
        /* Protected constants. */
        protected const string sign = "[+-]";
        protected const string digits = "[0-9]";
        protected const string letters = "[a-z|A-Z]";

        /* Protected properties. */
        protected virtual string Pattern => "";
        protected virtual ParseT DefaultValue => default;

        /* Private properties. */
        private static int GroupIndex { get; set; }

        /* Public methods. */
        /// <summary>
        /// Parse a string and return an object.
        /// </summary>
        public ParseT Parse(string str)
        {
            try
            {
                MatchT extracted = Extract(str, Pattern);
                try
                {
                    return Convert(extracted);
                }
                catch
                {
                    return DefaultValue;
                }
            }
            catch
            {
                return DefaultValue;
            }
        }

        /// <summary>
        /// Serialize an object and return the string representation.
        /// </summary>
        public virtual string Serialize(ParseT obj)
        {
            return obj.ToString();
        }

        /* Protected methods. */
        /// <summary>
        /// Take a string and a regular expression, and extract some value.
        /// </summary>
        protected abstract MatchT Extract(string str, string pattern);

        /// <summary>
        /// Take an extracted value and interpret it as a parsed value.
        /// </summary>
        protected abstract ParseT Convert(MatchT extracted);


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
