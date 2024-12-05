namespace Rusty.Numstrings
{
    internal class ByteParser : UnsignedParser<byte>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => byte.Parse;
        protected override byte MaxValue => byte.MaxValue;
    }
}