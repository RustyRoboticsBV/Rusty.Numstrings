namespace Rusty.Numstrings
{
    internal abstract class NumericParser<T> : ScalarParser<T>
    {
        /* Public properties. */
        public abstract string Number { get; }

        /* Protected properties. */
        protected override string Pattern => $@"^\s*{Group(Number)}\s*$";

        protected abstract ParserHandler ParseMethod { get; }
        protected abstract T MaxValue { get; }

        /* Protected delegates. */
        protected delegate T ParserHandler(string str);
    }
}