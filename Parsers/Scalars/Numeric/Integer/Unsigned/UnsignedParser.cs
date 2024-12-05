using System;

namespace Rusty.Numstrings
{
    internal abstract class UnsignedParser<T> : IntegerParser<T>
    {
        /* Protected methods. */
        protected override T Convert(string str)
        {
            str = str.Replace("+", "").Replace("-", "");
            try
            {
                return ParseMethod(str);
            }
            catch (OverflowException)
            {
                return MaxValue;
            }
            catch
            {
                return DefaultValue;
            }
        }
    }
}