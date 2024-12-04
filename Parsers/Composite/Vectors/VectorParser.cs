namespace Rusty.Numstrings
{
    /// <summary>
    /// Base class for all vector parsers.
    /// </summary>
    internal abstract class VectorParser<T> : Parser<T>
    {
        /* Protected constants. */
        protected abstract string Element { get; }
    }
}