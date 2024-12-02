using Godot;

namespace Rusty.Numstrings
{
    internal class IntVectorParser
    {
        /* Internal methods. */
        internal static Vector4I Parse(string str)
        {
            str = Trimmer.RemoveWhiteSpace(str);
            str = Trimmer.TrimParentheses(str);

            string[] strs = str.Split(',');

            Vector4I result = Vector4I.Zero;
            for (int i = 0; i < strs.Length && i < 4; i++)
            {
                result[i] = SignedParser.Parse(strs[i], int.Parse, default, int.MinValue, int.MaxValue);
            }
            return result;
        }
    }
}
