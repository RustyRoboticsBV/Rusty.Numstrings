namespace Rusty.Numstrings
{
    internal class DoubleParser : RealParser<double>
    {
        /* Protected properties. */
        protected override ParserHandler ParseMethod => double.Parse;
        protected override double MinValue => double.MinValue;
        protected override double MaxValue => double.MaxValue;
    }
}
