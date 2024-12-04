namespace Rusty.Numstrings
{
    internal class UintParser : UnsignedParser<uint>
    {
        /* Protected methods. */
        protected override ParserHandler ParseMethod => uint.Parse;
        protected override uint DefaultValue => default;
        protected override uint MaxValue => uint.MaxValue;
    }
}