using Godot;

namespace Rusty.Numstrings
{
    internal class FloatVectorParser
    {
        /* Internal methods. */
        internal static Vector4 Parse(string str)
        {
            str = Trimmer.RemoveWhiteSpace(str);
            str = Trimmer.TrimParentheses(str);

            string[] strs = str.Split(',');

            Vector4 result = Vector4.Zero;
            for (int i = 0; i < strs.Length && i < 4; i++)
            {
                result[i] = SignedParser.Parse(strs[i], float.Parse, default, float.MinValue, float.MaxValue);
            }
            return result;
        }
    }
}
