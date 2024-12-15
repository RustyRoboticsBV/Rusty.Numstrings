using System;

namespace Rusty.Numstrings
{
#if !GODOT && !UNITY_5_3_OR_NEWER
    /// <summary>
    /// A string-based variant class. Capable of parsing to all common C# types, but not particularly efficient.
    /// </summary>
#endif
    [Serializable]
    public readonly partial struct Numstring : ICloneable, IComparable, IComparable<Numstring>, IEquatable<Numstring>
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
            str = BoolParser.Serialize(value);
        }

        public Numstring(sbyte value)
        {
            str = SbyteParser.Serialize(value);
        }

        public Numstring(short value)
        {
            str = ShortParser.Serialize(value);
        }

        public Numstring(int value)
        {
            str = IntParser.Serialize(value);
        }

        public Numstring(long value)
        {
            str = LongParser.Serialize(value);
        }

        public Numstring(byte value)
        {
            str = ByteParser.Serialize(value);
        }

        public Numstring(ushort value)
        {
            str = UshortParser.Serialize(value);
        }

        public Numstring(uint value)
        {
            str = UintParser.Serialize(value);
        }

        public Numstring(ulong value)
        {
            str = UlongParser.Serialize(value);
        }

        public Numstring(float value)
        {
            str = FloatParser.Serialize(value);
        }

        public Numstring(double value)
        {
            str = DoubleParser.Serialize(value);
        }

        public Numstring(decimal value)
        {
            str = DecimalParser.Serialize(value);
        }

        public Numstring(char value)
        {
            str = CharParser.Serialize(value);
        }

        public Numstring(string value)
        {
            str = value;
        }

        public Numstring(int[] value)
        {
            str = IntArrayParser.Serialize(value);
        }

        public Numstring(float[] value)
        {
            str = FloatArrayParser.Serialize(value);
        }

#if !GODOT && !UNITY_5_3_OR_NEWER
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
                default:
                    throw new Exception($"Cannot create numstring from object of type '{value.GetType().Name}'.");
            }
        }
#endif

        /* Casting operators. */
        // From numstring.
        public static explicit operator bool(Numstring value)
        {
            return BoolParser.Parse(value.str);
        }

        public static explicit operator sbyte(Numstring value)
        {
            return SbyteParser.Parse(value.str);
        }

        public static explicit operator short(Numstring value)
        {
            return ShortParser.Parse(value.str);
        }

        public static explicit operator int(Numstring value)
        {
            return IntParser.Parse(value.str);
        }

        public static explicit operator long(Numstring value)
        {
            return LongParser.Parse(value.str);
        }

        public static explicit operator byte(Numstring value)
        {
            return ByteParser.Parse(value.str);
        }

        public static explicit operator ushort(Numstring value)
        {
            return UshortParser.Parse(value.str);
        }

        public static explicit operator uint(Numstring value)
        {
            return UintParser.Parse(value.str);
        }

        public static explicit operator ulong(Numstring value)
        {
            return UlongParser.Parse(value.str);
        }

        public static explicit operator float(Numstring value)
        {
            return FloatParser.Parse(value.str);
        }

        public static explicit operator double(Numstring value)
        {
            return DoubleParser.Parse(value.str);
        }

        public static explicit operator decimal(Numstring value)
        {
            return DecimalParser.Parse(value.str);
        }

        public static explicit operator char(Numstring value)
        {
            return CharParser.Parse(value.str);
        }

        public static implicit operator string(Numstring value)
        {
            return value.str;
        }

        public static implicit operator int[](Numstring value)
        {
            return IntArrayParser.Parse(value.str);
        }

        public static implicit operator float[](Numstring value)
        {
            return FloatArrayParser.Parse(value.str);
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

        public static implicit operator Numstring(int[] value)
        {
            return new(value);
        }

        public static implicit operator Numstring(float[] value)
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