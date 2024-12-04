using Godot;
using System;

namespace Rusty.Numstrings
{
    /// <summary>
    /// A string-based variant class. Very flexible, but not particularly efficient.
    /// </summary>
    [Serializable]
    public readonly struct Numstring : ICloneable, IComparable, IComparable<Numstring>, IEquatable<Numstring>
    {
        /* Fields. */
        private readonly string str;

        /* Constructors. */
        public Numstring(Numstring value)
        {
            str = (string)value;
        }

        public Numstring(bool value)
        {
            str = new BoolParser().Serialize(value);
        }

        public Numstring(sbyte value)
        {
            str = new SbyteParser().Serialize(value);
        }

        public Numstring(short value)
        {
            str = new ShortParser().Serialize(value);
        }

        public Numstring(int value)
        {
            str = new IntParser().Serialize(value);
        }

        public Numstring(long value)
        {
            str = new LongParser().Serialize(value);
        }

        public Numstring(byte value)
        {
            str = new ByteParser().Serialize(value);
        }

        public Numstring(ushort value)
        {
            str = new UshortParser().Serialize(value);
        }

        public Numstring(uint value)
        {
            str = new UintParser().Serialize(value);
        }

        public Numstring(ulong value)
        {
            str = new UlongParser().Serialize(value);
        }

        public Numstring(float value)
        {
            str = new FloatParser().Serialize(value);
        }

        public Numstring(double value)
        {
            str = new DoubleParser().Serialize(value);
        }

        public Numstring(decimal value)
        {
            str = new DecimalParser().Serialize(value);
        }

        public Numstring(char value)
        {
            str = new CharParser().Serialize(value);
        }

        public Numstring(string value)
        {
            str = value;
        }

        public Numstring(Vector2I value)
        {
            str = $"({value.X}, {value.Y})";
        }

        public Numstring(Vector3I value)
        {
            str = $"({value.X}, {value.Y}, {value.Z})";
        }

        public Numstring(Vector4I value)
        {
            str = $"({value.X}, {value.Y}, {value.Z}, {value.W})";
        }

        public Numstring(Vector2 value)
        {
            str = $"({value.X}, {value.Y})";
        }

        public Numstring(Vector3 value)
        {
            str = $"({value.X}, {value.Y}, {value.Z})";
        }

        public Numstring(Vector4 value)
        {
            str = $"({value.X}, {value.Y}, {value.Z}, {value.W})";
        }

        public Numstring(Quaternion value)
        {
            str = $"({value.X}, {value.Y}, {value.Z}, {value.W})";
        }

        public Numstring(Plane value)
        {
            str = $"(({value.X}, {value.Y}, {value.Z}), {value.D})";
        }

        public Numstring(Rect2I value)
        {
            str = $"(({value.Position.X}, {value.Position.Y}), ({value.Size.X}, {value.Size.Y}))";
        }

        public Numstring(Rect2 value)
        {
            str = $"(({value.Position.X}, {value.Position.Y}), ({value.Size.X}, {value.Size.Y}))";
        }

        public Numstring(Aabb value)
        {
            str = $"(({value.Position.X}, {value.Position.Y}, {value.Position.Z}), ({value.Size.X}, {value.Size.Y}, {value.Size.Z}))";
        }

        public Numstring(Transform2D value)
        {
            str = $"[({value.X.X}, {value.X.Y}), ({value.Y.X}, {value.Y.Y}), ({value.Origin.X}, {value.Origin.Y})]";
        }

        public Numstring(Basis value)
        {
            str = $"[({value.X.X}, {value.X.Y}, {value.X.Z}), ({value.Y.X}, {value.Y.Y}, {value.Y.Z}), ({value.Z.X}, {value.Z.Y}, {value.Z.Z})]";
        }

        public Numstring(Transform3D value)
        {
            throw new NotImplementedException();
        }

        public Numstring(Color value, bool includeAlpha = true)
        {
            str = $"#{value.ToHtml(includeAlpha)}";
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
                case char @char:
                    this = @char;
                    break;
                case string @string:
                    this = @string;
                    break;
                case Vector2I int2:
                    this = int2;
                    break;
                case Vector3I int3:
                    this = int3;
                    break;
                case Vector4I int4:
                    this = int4;
                    break;
                case Vector2 float2:
                    this = float2;
                    break;
                case Vector3 float3:
                    this = float3;
                    break;
                case Vector4 float4:
                    this = float4;
                    break;
                case Quaternion quat:
                    this = quat;
                    break;
                case Plane plane:
                    this = plane;
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
                case Transform2D float3x2:
                    this = float3x2;
                    break;
                case Basis float3x3:
                    this = float3x3;
                    break;
                case Transform3D float4x3:
                    this = float4x3;
                    break;
                case Color color:
                    this = color;
                    break;
                default:
                    throw new Exception($"Cannot create numstring from object of type '{value.GetType().Name}'.");
            }
        }

        /* Casting operators. */
        // From numstring.
        public static explicit operator bool(Numstring value)
        {
            return new BoolParser().Parse(value.str);
        }

        public static explicit operator sbyte(Numstring value)
        {
            return new SbyteParser().Parse(value.str);
        }

        public static explicit operator short(Numstring value)
        {
            return new ShortParser().Parse(value.str);
        }

        public static explicit operator int(Numstring value)
        {
            return new IntParser().Parse(value.str);
        }

        public static explicit operator long(Numstring value)
        {
            return new LongParser().Parse(value.str);
        }

        public static explicit operator byte(Numstring value)
        {
            return new ByteParser().Parse(value.str);
        }

        public static explicit operator ushort(Numstring value)
        {
            return new UshortParser().Parse(value.str);
        }

        public static explicit operator uint(Numstring value)
        {
            return new UintParser().Parse(value.str);
        }

        public static explicit operator ulong(Numstring value)
        {
            return new UlongParser().Parse(value.str);
        }

        public static explicit operator float(Numstring value)
        {
            return new FloatParser().Parse(value.str);
        }

        public static explicit operator double(Numstring value)
        {
            return new DoubleParser().Parse(value.str);
        }

        public static explicit operator decimal(Numstring value)
        {
            return new DecimalParser().Parse(value.str);
        }

        public static explicit operator char(Numstring value)
        {
            return new CharParser().Parse(value.str);
        }

        public static implicit operator string(Numstring value)
        {
            return value.str;
        }

        public static explicit operator Vector2I(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Vector3I(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Vector4I(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Vector2(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Vector3(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Vector4(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Quaternion(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Plane(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Rect2I(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Rect2(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Aabb(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Transform2D(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Basis(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Transform3D(Numstring value)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Color(Numstring value)
        {
            throw new NotImplementedException();
        }

        // To numstring.
        public static implicit operator Numstring(bool value)
        {
            return new(value);
        }

        public static implicit operator Numstring(sbyte value)
        {
            return new(value);
        }

        public static implicit operator Numstring(short value)
        {
            return new(value);
        }

        public static implicit operator Numstring(int value)
        {
            return new(value);
        }

        public static implicit operator Numstring(long value)
        {
            return new(value);
        }

        public static implicit operator Numstring(byte value)
        {
            return new(value);
        }

        public static implicit operator Numstring(ushort value)
        {
            return new(value);
        }

        public static implicit operator Numstring(uint value)
        {
            return new(value);
        }

        public static implicit operator Numstring(ulong value)
        {
            return new(value);
        }

        public static implicit operator Numstring(float value)
        {
            return new(value);
        }

        public static implicit operator Numstring(double value)
        {
            return new(value);
        }

        public static implicit operator Numstring(decimal value)
        {
            return new(value);
        }

        public static implicit operator Numstring(char value)
        {
            return new(value);
        }

        public static implicit operator Numstring(string value)
        {
            return new(value);
        }

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

        public static implicit operator Numstring(Color value)
        {
            return new(value);
        }

        /* Comparison operators. */
        public static bool operator ==(Numstring a, Numstring b)
        {
            return a.str == b.str;
        }

        public static bool operator !=(Numstring a, Numstring b)
        {
            return a.str != b.str;
        }

        /* Public methods. */
        public override string ToString()
        {
            return (string)this;
        }

        public override int GetHashCode()
        {
            return str.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Numstring value)
                return Equals(value);
            return false;
        }

        public bool Equals(Numstring other)
        {
            return this == other;
        }

        public object Clone()
        {
            return new Numstring(str);
        }

        public int CompareTo(object obj)
        {
            try
            {
                return CompareTo(new Numstring(obj));
            }
            catch (Exception)
            {
                throw new Exception($"Cannot compare a numstring to object of type '{obj.GetType().Name}'.");
            }
        }

        public int CompareTo(Numstring other)
        {
            return str.CompareTo(other.str);
        }
    }
}
