    static bool TryGetLevel(string text, int startIndex, out int level)
    {
        level = -1;
        if (text.Length > startIndex + 3)
        {
            if (int.TryParse(text.Substring(startIndex + 1), out level))
                return true;
        }

        return false;
    }