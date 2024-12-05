namespace Rusty.Numstrings
{
    internal class FloatParser : RealParser<float>
    {
        /* Protected properties. */
        protected override ParserHandler ParseMethod => float.Parse;
        protected override float MinValue => float.MinValue;
        protected override float MaxValue => float.MaxValue;
    }
}
