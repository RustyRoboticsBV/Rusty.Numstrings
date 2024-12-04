namespace Rusty.Numstrings
{
    internal abstract class NumericParser<T> : Parser<T>
    {
        /* Public properties. */
        public abstract string Number { get; }

        /* Protected properties. */
        protected string[] Patterns => new string[]
        {
            $"^{whitespace}{Group(Number)}{whitespace}$",
            $"^{whitespace}{Group(Number)}{whitespace},"
        };

        protected abstract ParserHandler ParseMethod { get; }
        protected abstract T DefaultValue { get; }
        protected abstract T MaxValue { get; }

        /* Protected delegates. */
        protected delegate T ParserHandler(string str);
    }
}