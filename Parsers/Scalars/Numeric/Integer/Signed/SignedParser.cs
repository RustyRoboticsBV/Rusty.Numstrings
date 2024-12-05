using System;

namespace Rusty.Numstrings
{
    internal abstract class SignedParser<T> : IntegerParser<T>
    {
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