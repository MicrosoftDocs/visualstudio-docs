using System;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return false;

            return Char.IsUpper(s[0]);
        }

        public static bool StartsWithLower(this string s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return false;

            return Char.IsLower(s[0]);
        }

        public static bool HasEmbeddedSpaces(this string s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return false;

            foreach (var ch in s.Trim())
            {
                // <Snippet1>
                if (Char.IsWhiteSpace(ch))
                // </Snippet1>
                    return true;
            }
            return false;
        }

        public static bool HasNonAsciiChars(this string s)
        {
            if (String.IsNullOrWhiteSpace(s))
                return false;

            foreach (var ch in s)
            {
                if (ch > 0x0080)
                    return true;
            }
            return false;
        }
    }
}
