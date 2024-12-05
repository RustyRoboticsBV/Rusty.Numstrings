namespace Rusty.Numstrings
{
    internal class SbyteParser : SignedParser<sbyte>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => sbyte.Parse;
        protected override sbyte MinValue => sbyte.MinValue;
        protected override sbyte MaxValue => sbyte.MaxValue;
    }
}