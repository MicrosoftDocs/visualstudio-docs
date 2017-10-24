    static SnapshotSpan AsSnapshotSpan(Region region, ITextSnapshot snapshot)
    {
        var startLine = snapshot.GetLineFromLineNumber(region.StartLine);
        var endLine = (region.StartLine == region.EndLine) ? startLine
             : snapshot.GetLineFromLineNumber(region.EndLine);
        return new SnapshotSpan(startLine.Start + region.StartOffset, endLine.End);
    }