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
            foreach (var ch in s.Trim())
            {
                if (ch == ' ')
                    return true;
            }
            return false;
        }
    }
}
