namespace Rusty.Numstrings
{
    internal abstract class IntegerParser<T> : NumericParser<T>
    {
        /* Public constants. */
        public override string Number => $"{sign}?{digits}+";
    }
}