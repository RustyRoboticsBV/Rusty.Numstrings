using Godot;
using Rusty.Numstrings;

while (true)
{
    Console.WriteLine("> Enter value");
    string str = Console.ReadLine();
    if (str == "quit")
        break;

    Console.WriteLine("> Type?");
    string type = Console.ReadLine();
    switch (type)
    {
        case "string":
        case "str":
        case "":
            Console.WriteLine("> " + (string)(Numstring)str);
            break;
        case "int":
            Console.WriteLine("> " + (int)(Numstring)str);
            break;
        case "long":
            Console.WriteLine("> " + (long)(Numstring)str);
            break;
        case "int2":
            Console.WriteLine("> " + (Vector2I)(Numstring)str);
            break;
        case "float":
            Console.WriteLine("> " + (float)(Numstring)str);
            break;
        case "double":
            Console.WriteLine("> " + (double)(Numstring)str);
            break;
        case "float2":
            Console.WriteLine("> " + (Vector2)(Numstring)str);
            break;
        default:
            Console.WriteLine("Invalid type.");
            break;
    }
    Console.WriteLine();
}
