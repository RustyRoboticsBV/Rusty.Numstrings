namespace Rusty.Numstrings
{
    internal class DecimalParser : RealParser<decimal>
    {
        /* Protected properties. */
        protected override ParserHandler ParseMethod => decimal.Parse;
        protected override decimal DefaultValue => default;
        protected override decimal MinValue => decimal.MinValue;
        protected override decimal MaxValue => decimal.MaxValue;
    }
}
