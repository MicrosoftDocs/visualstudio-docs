    public IEnumerable<ITagSpan<IOutliningRegionTag>> GetTags(NormalizedSnapshotSpanCollection spans)
    {
        if (spans.Count == 0)
            yield break;
        List<Region> currentRegions = this.regions;
        ITextSnapshot currentSnapshot = this.snapshot;
        SnapshotSpan entire = new SnapshotSpan(spans[0].Start, spans[spans.Count - 1].End).TranslateTo(currentSnapshot, SpanTrackingMode.EdgeExclusive);
        int startLineNumber = entire.Start.GetContainingLine().LineNumber;
        int endLineNumber = entire.End.GetContainingLine().LineNumber;
        foreach (var region in currentRegions)
        {
            if (region.StartLine <= endLineNumber &&
                region.EndLine >= startLineNumber)
            {
                var startLine = currentSnapshot.GetLineFromLineNumber(region.StartLine);
                var endLine = currentSnapshot.GetLineFromLineNumber(region.EndLine);

                //the region starts at the beginning of the "[", and goes until the *end* of the line that contains the "]".
                yield return new TagSpan<IOutliningRegionTag>(
                    new SnapshotSpan(startLine.Start + region.StartOffset,
                    endLine.End),
                    new OutliningRegionTag(false, false, ellipsis, hoverText));
            }
        }
    }