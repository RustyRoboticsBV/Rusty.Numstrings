using System;

namespace Rusty.Numstrings
{
    internal abstract class RealParser<T> : NumericParser<T>
    {
        /* Public methods. */
        public override string Number => $"{sign}?({digits}?[.])?{digits}+";

        /* Protected properties. */
        protected abstract T MinValue { get; }

        /* Protected methods. */
        protected override T Convert(string str)
        {
            str = str.Replace("+", "");
            try
            {
                return ParseMethod(str);
            }
            catch (OverflowException)
            {
                if (str.Contains("-"))
                    return MinValue;
                else
                    return MaxValue;
            }
            catch
            {
                return DefaultValue;
            }
        }
    }
}