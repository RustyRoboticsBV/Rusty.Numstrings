using Godot;
using System;

namespace Rusty.Numstrings
{
    internal class ColorParser
    {
        internal static Color ParseName(string name)
        {
            switch (name.ToLower())
            {
                case "red":
                    return new Color(1f, 0f, 0f);
                case "orange":
                    return new Color(1f, 0.5f, 0f);
                case "yellow":
                    return new Color(1f, 1f, 0f);
                case "chartreuse":
                    return new Color(0.5f, 1f, 0f);
                case "green":
                    return new Color(0f, 1f, 0f);
                case "spring green":
                case "springgreen":
                case "spring_green":
                    return new Color(0f, 1f, 0.5f);
                case "cyan":
                    return new Color(0f, 1f, 1f);
                case "azure":
                    return new Color(0f, 0.5f, 1f);
                case "blue":
                    return new Color(0f, 0f, 1f);
                case "violet":
                    return new Color(0.5f, 0f, 1f);
                case "magenta":
                    return new Color(1f, 0f, 1f);
                case "rose":
                    return new Color(1f, 0f, 0.5f);
                case "white":
                    return new Color(1f, 1f, 1f);
                case "grey":
                case "gray":
                    return new Color(0.5f, 0.5f, 0.5f);
                case "black":
                    return new Color(0f, 0f, 0f);
                case "pink":
                    return new Color(1f, 0.75f, 0.75f);
                case "brown":
                    return new Color(0.5f, 0.25f, 0f);
                case "purple":
                    return new Color(0.75f, 0f, 1f);
                default:
                    throw new Exception($"The color name {name} is not recognized.");
            }
        }
    }
}
