    private static bool FindMatchingOpenChar(SnapshotPoint startPoint, char open, char close, int maxLines, out SnapshotSpan pairSpan)
    {
        pairSpan = new SnapshotSpan(startPoint, startPoint);

        ITextSnapshotLine line = startPoint.GetContainingLine();

        int lineNumber = line.LineNumber;
        int offset = startPoint - line.Start - 1; //move the offset to the character before this one

        //if the offset is negative, move to the previous line
        if (offset < 0)
        {
            line = line.Snapshot.GetLineFromLineNumber(--lineNumber);
            offset = line.Length - 1;
        }

        string lineText = line.GetText();

        int stopLineNumber = 0;
        if (maxLines > 0)
            stopLineNumber = Math.Max(stopLineNumber, lineNumber - maxLines);

        int closeCount = 0;

        while (true)
        {
            // Walk the entire line
            while (offset >= 0)
            {
                char currentChar = lineText[offset];

                if (currentChar == open)
                {
                    if (closeCount > 0)
                    {
                        closeCount--;
                    }
                    else // We've found the open character
                    {
                        pairSpan = new SnapshotSpan(line.Start + offset, 1); //we just want the character itself
                        return true;
                    }
                }
                else if (currentChar == close)
                {
                    closeCount++;
                }
                offset--;
            }

            // Move to the previous line
            if (--lineNumber < stopLineNumber)
                break;

            line = line.Snapshot.GetLineFromLineNumber(lineNumber);
            lineText = line.GetText();
            offset = line.Length - 1;
        }
        return false;
    }