namespace Rusty.Numstrings
{
    internal class UshortParser : UnsignedParser<ushort>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => ushort.Parse;
        protected override ushort MaxValue => ushort.MaxValue;
    }
}