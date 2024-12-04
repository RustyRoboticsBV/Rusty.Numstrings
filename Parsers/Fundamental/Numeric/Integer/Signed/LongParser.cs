namespace Rusty.Numstrings
{
    internal class LongParser : SignedParser<long>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => long.Parse;
        protected override long DefaultValue => default;
        protected override long MinValue => long.MinValue;
        protected override long MaxValue => long.MaxValue;
    }
}