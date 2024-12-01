using System;

using Int2 = Godot.Vector2I;
using Int3 = Godot.Vector3I;
using Int4 = Godot.Vector4I;

using Float2 = Godot.Vector2;
using Float3 = Godot.Vector3;
using Float4 = Godot.Vector4;

using Color = Godot.Color;
using Quaternion = Godot.Quaternion;
using Plane = Godot.Plane;

using IntRect = Godot.Rect2I;
using FloatRect = Godot.Rect2;
using FloatAABB = Godot.Aabb;

using Float3x2 = Godot.Transform2D;
using Float3x3 = Godot.Basis;
using Float4x3 = Godot.Transform3D;

namespace Rusty.Numstrings
{
    /// <summary>
    /// A string-based variant type that can easily convert implicitly between various common types. Flexible, but not
    /// particularly performant.
    /// </summary>
    [Serializable]
    public readonly struct Numstring : ICloneable, IComparable, IComparable<Numstring>, IEquatable<Numstring>
    {
        /* Fields. */
        private readonly string value;

        /* Public properties. */
        public static Numstring Null => new Numstring((string)null);

        public bool IsNumerical => double.TryParse(value, out _);
        public int Length => value.Length;
        public char this[int index] => value[index];

        /* Constructors. */
        public Numstring(bool value) : this()
        {
            this.value = value ? "true" : "false";
        }

        public Numstring(int value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(long value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(uint value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(ulong value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(float value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(double value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(char value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(string value) : this()
        {
            this.value = value;
        }

        public Numstring(int[] value)
        {
            this.value = ArrayToString(value);
        }

        public Numstring(float[] value)
        {
            this.value = ArrayToString(value);
        }

        public Numstring(double[] value)
        {
            this.value = ArrayToString(value);
        }

        public Numstring(Float2 value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(Float3 value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(Float4 value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(Int2 value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(Int3 value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(Int4 value) : this()
        {
            this.value = value.ToString();
        }

        public Numstring(Quaternion value)
        {
            this.value = value.ToString();
        }

        public Numstring(Color value) : this()
        {
            this.value = value.ToHtml(value.A < 1f);
        }

        public Numstring(Plane value) : this()
        {
            this.value = $"(({value.Normal.X}, {value.Normal.Y}, {value.Normal.Z}), {value.D})";
        }

        /* Public methods. */
        public bool Equals(Numstring other)
        {
            return value == other.value;
        }

        public override bool Equals(object other)
        {
            return other.GetType() == typeof(Numstring) && Equals((Numstring)other);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public object Clone()
        {
            return this;
        }

        public int CompareTo(object other)
        {
            return value.CompareTo(other);
        }

        public int CompareTo(Numstring other)
        {
            return value.CompareTo(other);
        }

        public static Numstring FromObject(object obj)
        {
            switch (obj)
            {
                case bool:
                    return (bool)obj;
                case sbyte:
                    return (sbyte)obj;
                case short:
                    return (short)obj;
                case int:
                    return (int)obj;
                case long:
                    return (long)obj;
                case byte:
                    return (byte)obj;
                case ushort:
                    return (ushort)obj;
                case uint:
                    return (uint)obj;
                case ulong:
                    return (ulong)obj;
                case float:
                    return (float)obj;
                case double:
                    return (double)obj;
                case char:
                    return (char)obj;
                case string:
                    return (string)obj;
                case int[]:
                    return (int[])obj;
                case float[]:
                    return (float[])obj;
                case Float2:
                    return (Float2)obj;
                case Float3:
                    return (Float3)obj;
                case Float4:
                    return (Float4)obj;
                case Int2:
                    return (Int2)obj;
                case Int3:
                    return (Int3)obj;
                case Int4:
                    return (Int4)obj;
                case Color:
                    return (Color)obj;
                case Quaternion:
                    return (Quaternion)obj;
                default:
                    return (string)null;
            }
        }

        // String methods.
        public override string ToString()
        {
            return this;
        }

        /// <summary>
        /// Return a copy of this string where all letters have been converted to lower-case.
        /// </summary>
        public string ToLower()
        {
            if (value == null)
                return value;
            return value.ToLower();
        }

        /// <summary>
        /// Return a copy of this string where all letters have been converted to upper-case.
        /// </summary>
        public string ToUpper()
        {
            if (value == null)
                return value;
            return value.ToUpper();
        }

        /// <summary>
        /// Returns the result of concatenating another string at the end of this string.
        /// </summary>
        public string Concat(string suffix)
        {
            if (value == null)
                return suffix;
            return value + suffix;
        }

        /// <summary>
        /// Returns a new string in which all occurances of a specified Unicode character are replaced with another.
        /// </summary>
        public string Replace(char oldChar, char newChar)
        {
            if (value == null)
                return value;
            return value.Replace(oldChar, newChar);
        }

        /// <summary>
        /// Returns a new string in which all occurances of a specified substring are replaced with another.
        /// </summary>
        public string Replace(string oldvalue, string newvalue)
        {
            if (value == null)
                return value;
            return value.Replace(oldvalue, newvalue);
        }

        /// <summary>
        /// Returns a new string in which all characters, beginning at a specified position and continuing through the last,
        /// position, have been deleted.
        /// </summary>
        public string Remove(int startIndex)
        {
            if (value == null)
                return value;
            return value.Remove(startIndex);
        }

        /// <summary>
        /// Returns a new string in which a specified number of characters beginning at a specified position have been deleted.
        /// </summary>
        public string Remove(int startIndex, int length)
        {
            if (value == null)
                return value;
            return value.Remove(startIndex, length);
        }

        /// <summary>
        /// Returns whether a specified character occurs in this string.
        /// </summary>
        public bool Contains(char value)
        {
            if (this.value == null)
                return false;
            return this.value.Contains(value);
        }

        /// <summary>
        /// Returns whether a specified substring occurs within this string.
        /// </summary>
        public bool Contains(string value)
        {
            if (this.value == null)
                return false;
            return this.value.Contains(value);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at a specified position and continues to the end of
        /// the string.
        /// </summary>
        public string Substring(int startIndex)
        {
            if (value == null)
                return null;
            return value.Substring(startIndex);
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at a specified character position and has a specified
        /// length.
        /// </summary>
        public string Substring(int startIndex, int length)
        {
            if (value == null)
                return null;
            return value.Substring(startIndex, length);
        }

        // Comparison operators.
        /// <summary>
        /// Check if the numstrings are equal.
        /// </summary>
        public static bool operator ==(Numstring a, Numstring b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// Check if the numstrings are NOT equal.
        /// </summary>
        public static bool operator !=(Numstring a, Numstring b)
        {
            return !a.Equals(b);
        }

        /// <summary>
        /// Interpret numstrings as numbers, and perform a greater-than check.
        /// </summary>
        public static bool operator >(Numstring a, Numstring b)
        {
            return (double)a > (double)b;
        }

        /// <summary>
        /// Interpret numstrings as numbers, and perform a less-than check.
        /// </summary>
        public static bool operator <(Numstring a, Numstring b)
        {
            return (double)a < (double)b;
        }

        /// <summary>
        /// Interpret numstrings as numbers, and perform a greater-than-or-equal check.
        /// </summary>
        public static bool operator >=(Numstring a, Numstring b)
        {
            return (double)a >= (double)b;
        }

        /// <summary>
        /// Interpret numstrings as numbers, and perform a less-than-or-equal check.
        /// </summary>
        public static bool operator <=(Numstring a, Numstring b)
        {
            return (double)a <= (double)b;
        }

        // Arithmetic operators.
        /// <summary>
        /// Interpret numstrings as numbers and perform addition.
        /// Use Concat for concatenation.
        /// </summary>
        public static double operator +(Numstring a, Numstring b)
        {
            return (double)a + (double)b;
        }

        /// <summary>
        /// Interpret numstrings as numbers and perform subtraction.
        /// </summary>
        public static double operator -(Numstring a, Numstring b)
        {
            return (double)a - (double)b;
        }

        /// <summary>
        /// Interpret numstrings as numbers and perform multiplication.
        /// </summary>
        public static double operator *(Numstring a, Numstring b)
        {
            return (double)a * (double)b;
        }

        /// <summary>
        /// Interpret numstrings as numbers and perform division.
        /// </summary>
        public static double operator /(Numstring a, Numstring b)
        {
            return (double)a / (double)b;
        }

        /// <summary>
        /// Interpret numstrings as numbers and perform a modulo operation.
        /// </summary>
        public static double operator %(Numstring a, Numstring b)
        {
            return (double)a % (double)b;
        }

        /// <summary>
        /// Interpret numstring as a number, increment its value, and return the result.
        /// </summary>
        public static Numstring operator ++(Numstring value)
        {
            return (double)value + 1d;
        }

        /// <summary>
        /// Interpret numstring as a number, decrement its value, and return the result.
        /// </summary>
        public static Numstring operator --(Numstring value)
        {
            return (double)value - 1d;
        }

        // Boolean operators.
        /// <summary>
        /// Interpret numstring as a boolean, negate it, and return the result.
        /// </summary>
        public static Numstring operator !(Numstring value)
        {
            return !(bool)value;
        }

        // Casting operators: to NumString.
        public static implicit operator Numstring(bool value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(int value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(long value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(uint value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(ulong value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(float value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(double value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(char value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(string value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(int[] value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(float[] value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Float2 value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Float3 value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Float4 value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Int2 value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Int3 value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Int4 value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Color value)
        {
            return new Numstring(value);
        }

        public static implicit operator Numstring(Quaternion value)
        {
            return new Numstring(value);
        }

        // Casting operators: to other types.
        public static explicit operator bool(Numstring numstring)
        {
            try
            {
                return bool.Parse(numstring.value);
            }
            catch
            {
                return false;
            }
        }

        public static explicit operator int(Numstring numstring)
        {
            return ParseSignedNumeric(numstring.value, int.Parse, 0, int.MinValue, int.MaxValue);
        }

        public static explicit operator long(Numstring numstring)
        {
            return ParseSignedNumeric(numstring.value, long.Parse, 0, long.MinValue, long.MaxValue);
        }

        public static explicit operator uint(Numstring numstring)
        {
            return ParseUnsignedNumeric(numstring.value, uint.Parse, 0u, uint.MaxValue);
        }

        public static explicit operator ulong(Numstring numstring)
        {
            return ParseUnsignedNumeric(numstring.value, ulong.Parse, 0u, ulong.MaxValue);
        }

        public static explicit operator float(Numstring numstring)
        {
            return ParseSignedNumeric(numstring.value, float.Parse, 0, float.MinValue, float.MaxValue);
        }

        public static explicit operator double(Numstring numstring)
        {
            return ParseSignedNumeric(numstring.value, double.Parse, 0, double.MinValue, double.MaxValue);
        }

        public static explicit operator char(Numstring numstring)
        {
            try
            {
                return char.Parse(numstring.value);
            }
            catch
            {
                return (char)0;
            }
        }

        public static implicit operator string(Numstring numstring)
        {
            return numstring.value;
        }

        public static explicit operator int[](Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator float[](Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator double[](Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Float2(Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Float3(Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Float4(Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Int2(Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Int3(Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Int4(Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Quaternion(Numstring numstring)
        {
            throw new NotImplementedException();
        }

        public static explicit operator Color(Numstring numstring)
        {
            try
            {
                return Color.FromHtml(numstring.value);
            }
            catch
            {
                return new Color(0f, 0f, 0f, 0f);
            }
        }

        /* Private delegates. */
        private delegate T ParseHandler<T>(string str);

        /* Private methods. */
        /// <summary>
        /// Convert a vector with two elements to a string.
        /// </summary>
        private static string VectorToString<T>(T x, T y)
        {
            return $"({x},{y})";
        }

        /// <summary>
        /// Convert a vector with thtee elements to a string.
        /// </summary>
        private static string VectorToString<T>(T x, T y, T z)
        {
            return $"({x},{y},{z})";
        }

        /// <summary>
        /// Convert a vector with four elements to a string.
        /// </summary>
        private static string VectorToString<T>(T x, T y, T z, T w)
        {
            return $"({x},{y},{z},{w})";
        }

        /// <summary>
        /// Convert an array to a string.
        /// </summary>
        private static string ArrayToString<T>(params T[] array)
        {
            return "{" + string.Join(",", array) + "}";
        }



        private delegate T Parser<T>(string str);

        private static T ParseSignedNumeric<T>(string str, Parser<T> parser, T defaultValue, T minValue, T maxValue)
        {
            try
            {
                return parser(str);
            }
            catch (OverflowException)
            {
                if (str.Contains('-'))
                    return minValue;
                else
                    return maxValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        private static T ParseUnsignedNumeric<T>(string str, Parser<T> parser, T defaultValue, T maxValue)
        {
            try
            {
                return parser(str);
            }
            catch (OverflowException)
            {
                return maxValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
