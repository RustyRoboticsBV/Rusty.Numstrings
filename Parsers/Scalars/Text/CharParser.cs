namespace Rusty.Numstrings
{
    internal class CharParser : ScalarParser<char>
    {
        protected override char Convert(string str)
        {
            return str[0];
        }

        protected override string Extract(string str, string pattern)
        {
            return str;
        }
    }
}
