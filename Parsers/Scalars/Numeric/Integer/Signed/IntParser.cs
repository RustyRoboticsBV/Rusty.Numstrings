namespace Rusty.Numstrings
{
    internal class IntParser : SignedParser<int>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => int.Parse;
        protected override int MinValue => int.MinValue;
        protected override int MaxValue => int.MaxValue;
    }
}