namespace Rusty.Numstrings
{
    internal class CharParser : Parser<char>
    {
        public override char Parse(string str)
        {
            try
            {
                return str[0];
            }
            catch
            {
                return default;
            }
        }
    }
}
