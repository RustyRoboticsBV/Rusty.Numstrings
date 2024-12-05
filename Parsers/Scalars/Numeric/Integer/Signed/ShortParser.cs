namespace Rusty.Numstrings
{
    internal class ShortParser : SignedParser<short>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => short.Parse;
        protected override short MinValue => short.MinValue;
        protected override short MaxValue => short.MaxValue;
    }
}