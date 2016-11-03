    private static bool FindMatchingCloseChar(SnapshotPoint startPoint, char open, char close, int maxLines, out SnapshotSpan pairSpan)
    {
        pairSpan = new SnapshotSpan(startPoint.Snapshot, 1, 1);
        ITextSnapshotLine line = startPoint.GetContainingLine();
        string lineText = line.GetText();
        int lineNumber = line.LineNumber;
        int offset = startPoint.Position - line.Start.Position + 1;

        int stopLineNumber = startPoint.Snapshot.LineCount - 1;
        if (maxLines > 0)
            stopLineNumber = Math.Min(stopLineNumber, lineNumber + maxLines);

        int openCount = 0;
        while (true)
        {
            //walk the entire line
            while (offset < line.Length)
            {
                char currentChar = lineText[offset];
                if (currentChar == close) //found the close character
                {
                    if (openCount > 0)
                    {
                        openCount--;
                    }
                    else    //found the matching close
                    {
                        pairSpan = new SnapshotSpan(startPoint.Snapshot, line.Start + offset, 1);
                        return true;
                    }
                }
                else if (currentChar == open) // this is another open
                {
                    openCount++;
                }
                offset++;
            }

            //move on to the next line
            if (++lineNumber > stopLineNumber)
                break;

            line = line.Snapshot.GetLineFromLineNumber(lineNumber);
            lineText = line.GetText();
            offset = 0;
        }

        return false;
    }