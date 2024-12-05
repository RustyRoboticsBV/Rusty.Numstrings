namespace Rusty.Numstrings
{
    internal abstract class IntegerParser<T> : NumericParser<T>
    {
        /* Public properties. */
        public override string Number => $"{sign}?{digits}+";
    }
}