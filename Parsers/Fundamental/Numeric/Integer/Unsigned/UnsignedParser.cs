using System;

namespace Rusty.Numstrings
{
    internal abstract class UnsignedParser<T> : IntegerParser<T>
    {
        /* Public methods. */
        public override T Parse(string str)
        {
            try
            {
                Extract(str, Patterns, out str);
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
            catch
            {
                return DefaultValue;
            }
        }
    }
}