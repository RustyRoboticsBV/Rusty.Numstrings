using System;

namespace Rusty.Numstrings
{
    internal abstract class RealParser<T> : NumericParser<T>
    {
        /* Public methods. */
        public override string Number => $"{sign}?({digits}?[.])?{digits}+";

        /* Protected properties. */
        protected abstract T MinValue { get; }

        /* Public methods. */
        public override T Parse(string str)
        {
            try
            {
                Extract(str, Patterns, out str);
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
            catch
            {
                return DefaultValue;
            }
        }
    }
}