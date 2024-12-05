namespace Rusty.Numstrings
{
    internal class UlongParser : UnsignedParser<ulong>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => ulong.Parse;
        protected override ulong MaxValue => ulong.MaxValue;
    }
}