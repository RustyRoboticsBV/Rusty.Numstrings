namespace Rusty.Numstrings
{
    /// <summary>
    /// Base class for all vector parsers.
    /// </summary>
    internal abstract class Vector4Parser<T> : VectorParser<T>
    {
        /* Protected properties. */
        protected override string[] Patterns => new string[]
        {
            $@"^\s*[(]\s*{Element}\s*,\s*{Element}\s*,\s*{Element}\s*,\s*{Element}\s*[)]\s*$"
        };
    }
}