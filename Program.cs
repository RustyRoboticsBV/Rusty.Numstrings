using Godot;
using System;
using Rusty.Numstrings;
using Expression = System.Linq.Expressions.Expression;
using System.Text.RegularExpressions;

Test.Print<bool>(false);
Test.Print<bool>(true);
Test.Print<sbyte>(1);
Test.Print<short>((short)17);
Test.Print<int>(99999);
Test.Print<long>(999999L);
Test.Print<byte>(7);
Test.Print<ushort>((ushort)21);
Test.Print<uint>(387u);
Test.Print<ulong>(123456789uL);
Test.Print<Vector2>(new Vector2(1f, 2f));
Test.Print<Vector3>(new Vector3(1f, 2f, 3f));
Test.Print<Vector4>(new Vector4(1f, 2f, 3f, 4f));
Test.Print<Vector4>(1f);
Test.Print<Vector4>(new Vector2(1f, 4f));
Test.Print<Quaternion>(Quaternion.Identity);
Test.Print<Color>(Colors.Red);
Test.Print<Color>("#00ff00");
Test.Print<Color>("(0, 0, 1, 1)");

string integer_pattern = @"[+-]?[0-9]+";
string real_pattern = "[+-]?([0-9]*[.])?[0-9]+";
Test.CheckMatch("", real_pattern);
Test.CheckMatch("1.1.1", real_pattern);
Test.CheckMatch("1", real_pattern);
Test.CheckMatch(".1", real_pattern);
Test.CheckMatch("1.1", real_pattern);
Test.CheckMatch("+1.1", real_pattern);
Test.CheckMatch("-.1", real_pattern);

public class Test
{
    public static void CheckMatch(string input, string pattern)
    {
        Match match = Regex.Match(input, $"^{pattern}$");
        bool success = match.Success;
        Console.WriteLine(success + (success ? $" (\"{input}\" -> {match.Value})" : $"(\"{input}\")"));
    }
    public static void Print<T>(object obj)
    {
        Numstring numstring = new(obj);
        T parsed = (T)Cast(numstring, typeof(T));
        Console.WriteLine($"{typeof(T).Name} {obj}:\n serialized: {numstring}\n parsed: {parsed}");
    }

    public static object Cast(object data, Type Type)
    {
        var DataParam = Expression.Parameter(typeof(object), "data");
        var Body = Expression.Block(Expression.Convert(Expression.Convert(DataParam, data.GetType()), Type));

        var Run = Expression.Lambda(Body, DataParam).Compile();
        var ret = Run.DynamicInvoke(data);
        return ret;
    }
}