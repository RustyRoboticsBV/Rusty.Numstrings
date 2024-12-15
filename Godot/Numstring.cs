#if GODOT
using Godot;
using System;

namespace Rusty.Numstrings
{
    /// <summary>
    /// A string-based variant class. Capable of parsing to all common C# and engine types, but not particularly efficient.
    /// </summary>
    public readonly partial struct Numstring
    {
        /* Constructors. */
        public Numstring(Vector2I value)
        {
            str = Vector2IParser.Serialize(value);
        }

        public Numstring(Vector3I value)
        {
            str = Vector3IParser.Serialize(value);
        }

        public Numstring(Vector4I value)
        {
            str = Vector4IParser.Serialize(value);
        }

        public Numstring(Vector2 value)
        {
            str = Vector2Parser.Serialize(value);
        }

        public Numstring(Vector3 value)
        {
            str = Vector3Parser.Serialize(value);
        }

        public Numstring(Vector4 value)
        {
            str = Vector4Parser.Serialize(value);
        }

        public Numstring(Quaternion value)
        {
            str = QuaternionParser.Serialize(value);
        }

        public Numstring(Plane value)
        {
            str = PlaneParser.Serialize(value);
        }

        public Numstring(Color value)
        {
            str = ColorParser.Serialize(value);
        }

        public Numstring(Rect2I value)
        {
            str = Rect2IParser.Serialize(value);
        }

        public Numstring(Rect2 value)
        {
            str = Rect2Parser.Serialize(value);
        }

        public Numstring(Aabb value)
        {
            str = AabbParser.Serialize(value);
        }

        public Numstring(Transform2D value)
        {
            str = Transform2DParser.Serialize(value);
        }

        public Numstring(Basis value)
        {
            str = BasisParser.Serialize(value);
        }

        public Numstring(Transform3D value)
        {
            str = Transform3DParser.Serialize(value);
        }

        public Numstring(object value)
        {
            switch (value)
            {
                case Numstring numstring:
                    this = numstring;
                    break;
                case bool @bool:
                    this = @bool;
                    break;
                case sbyte @sbyte:
                    this = @sbyte;
                    break;
                case short @short:
                    this = @short;
                    break;
                case int @int:
                    this = @int;
                    break;
                case long @long:
                    this = @long;
                    break;
                case byte @byte:
                    this = @byte;
                    break;
                case ushort @ushort:
                    this = @ushort;
                    break;
                case uint @uint:
                    this = @uint;
                    break;
                case ulong @ulong:
                    this = @ulong;
                    break;
                case float @float:
                    this = @float;
                    break;
                case double @double:
                    this = @double;
                    break;
                case decimal @decimal:
                    this = @decimal;
                    break;
                case char @char:
                    this = @char;
                    break;
                case string @string:
                    this = @string;
                    break;
                case Vector2I vector2i:
                    this = vector2i;
                    break;
                case Vector3I vector3i:
                    this = vector3i;
                    break;
                case Vector4I vector4i:
                    this = vector4i;
                    break;
                case Vector2 vector2:
                    this = vector2;
                    break;
                case Vector3 vector3:
                    this = vector3;
                    break;
                case Vector4 vector4:
                    this = vector4;
                    break;
                case Quaternion quat:
                    this = quat;
                    break;
                case Plane plane:
                    this = plane;
                    break;
                case Color color:
                    this = color;
                    break;
                case Rect2I intRect:
                    this = intRect;
                    break;
                case Rect2 floatRect:
                    this = floatRect;
                    break;
                case Aabb aabb:
                    this = aabb;
                    break;
                case Transform2D transform2d:
                    this = transform2d;
                    break;
                case Basis basis:
                    this = basis;
                    break;
                case Transform3D transform3d:
                    this = transform3d;
                    break;
                default:
                    throw new Exception($"Cannot create numstring from object of type '{value.GetType().Name}'.");
            }
        }

        /* Conversion operators. */
        // From numstring.
        public static explicit operator Vector2I(Numstring value)
        {
            return Vector2IParser.Parse(value.str);
        }

        public static explicit operator Vector3I(Numstring value)
        {
            return Vector3IParser.Parse(value.str);
        }

        public static explicit operator Vector4I(Numstring value)
        {
            return Vector4IParser.Parse(value.str);
        }

        public static explicit operator Vector2(Numstring value)
        {
            return Vector2Parser.Parse(value.str);
        }

        public static explicit operator Vector3(Numstring value)
        {
            return Vector3Parser.Parse(value.str);
        }

        public static explicit operator Vector4(Numstring value)
        {
            return Vector4Parser.Parse(value.str);
        }

        public static explicit operator Quaternion(Numstring value)
        {
            return QuaternionParser.Parse(value.str);
        }

        public static explicit operator Plane(Numstring value)
        {
            return PlaneParser.Parse(value.str);
        }

        public static explicit operator Color(Numstring value)
        {
            return ColorParser.Parse(value.str);
        }

        public static explicit operator Rect2I(Numstring value)
        {
            return Rect2IParser.Parse(value.str);
        }

        public static explicit operator Rect2(Numstring value)
        {
            return Rect2Parser.Parse(value.str);
        }

        public static explicit operator Aabb(Numstring value)
        {
            return AabbParser.Parse(value.str);
        }

        public static explicit operator Transform2D(Numstring value)
        {
            return Transform2DParser.Parse(value.str);
        }

        public static explicit operator Basis(Numstring value)
        {
            return BasisParser.Parse(value.str);
        }

        public static explicit operator Transform3D(Numstring value)
        {
            return Transform3DParser.Parse(value.str);
        }

        // To numstring.
        public static implicit operator Numstring(Vector2I value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Vector3I value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Vector4I value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Vector2 value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Vector3 value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Vector4 value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Quaternion value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Plane value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Color value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Rect2I value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Rect2 value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Aabb value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Transform2D value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Basis value)
        {
            return new(value);
        }

        public static implicit operator Numstring(Transform3D value)
        {
            return new(value);
        }
    }
}
#endif