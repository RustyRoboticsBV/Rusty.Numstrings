namespace Rusty.Numstrings
{
    internal class BoolParser : Parser<bool>
    {
        /* Private properties. */
        private static string[] Patterns => new string[]
        {
            $"^{whitespace}*{Group(boolTrue)}{whitespace}*$",
            $"^{whitespace}*{Group(boolTrue)}{whitespace}*,"
        };

        /* Public methods. */
        public override bool Parse(string str)
        {
            try
            {
                try
                {
                    Extract(str, Patterns, out str);
                    try
                    {
                        return bool.Parse(str);
                    }
                    catch
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}