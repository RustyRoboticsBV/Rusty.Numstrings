namespace Rusty.Numstrings
{
    internal class BoolParser : ScalarParser<bool>
    {
        /* Protected properties. */
        protected override string Pattern => @$"^\s*{Group("[tT][rR][uU][eE]")}\s*$";

        /* Protected methods. */
        protected override bool Convert(string str)
        {
            return bool.Parse(str);
        }
    }
}