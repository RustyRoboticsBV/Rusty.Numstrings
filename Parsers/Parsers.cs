namespace Rusty.Numstrings
{
    internal class Parsers
    {
        internal static BoolParser Bool { get; } = new();
        internal static SbyteParser Sbyte { get; } = new();
        internal static ShortParser Short { get; } = new();
        internal static IntParser Int { get; } = new();
        internal static LongParser Long { get; } = new();
        internal static ByteParser Byte { get; } = new();
        internal static UshortParser Ushort { get; } = new();
        internal static UintParser Uint { get; } = new();
        internal static UlongParser Ulong { get; } = new();
        internal static FloatParser Float { get; } = new();
        internal static DoubleParser Double { get; } = new();
        internal static DecimalParser Decimal { get; } = new();
        internal static CharParser Char { get; } = new();
    }
}
