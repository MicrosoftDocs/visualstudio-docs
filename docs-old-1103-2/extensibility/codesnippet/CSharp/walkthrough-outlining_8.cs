    void ReParse()
    {
        ITextSnapshot newSnapshot = buffer.CurrentSnapshot;
        List<Region> newRegions = new List<Region>();

        //keep the current (deepest) partial region, which will have
        // references to any parent partial regions.
        PartialRegion currentRegion = null;

        foreach (var line in newSnapshot.Lines)
        {
            int regionStart = -1;
            string text = line.GetText();

            //lines that contain a "[" denote the start of a new region.
            if ((regionStart = text.IndexOf(startHide, StringComparison.Ordinal)) != -1)
            {
                int currentLevel = (currentRegion != null) ? currentRegion.Level : 1;
                int newLevel;
                if (!TryGetLevel(text, regionStart, out newLevel))
                    newLevel = currentLevel + 1;

                //levels are the same and we have an existing region;
                //end the current region and start the next
                if (currentLevel == newLevel && currentRegion != null)
                {
                    newRegions.Add(new Region()
                    {
                        Level = currentRegion.Level,
                        StartLine = currentRegion.StartLine,
                        StartOffset = currentRegion.StartOffset,
                        EndLine = line.LineNumber
                    });

                    currentRegion = new PartialRegion()
                    {
                        Level = newLevel,
                        StartLine = line.LineNumber,
                        StartOffset = regionStart,
                        PartialParent = currentRegion.PartialParent
                    };
                }
                //this is a new (sub)region
                else
                {
                    currentRegion = new PartialRegion()
                    {
                        Level = newLevel,
                        StartLine = line.LineNumber,
                        StartOffset = regionStart,
                        PartialParent = currentRegion
                    };
                }
            }
            //lines that contain "]" denote the end of a region
            else if ((regionStart = text.IndexOf(endHide, StringComparison.Ordinal)) != -1)
            {
                int currentLevel = (currentRegion != null) ? currentRegion.Level : 1;
                int closingLevel;
                if (!TryGetLevel(text, regionStart, out closingLevel))
                    closingLevel = currentLevel;

                //the regions match
                if (currentRegion != null &&
                    currentLevel == closingLevel)
                {
                    newRegions.Add(new Region()
                    {
                        Level = currentLevel,
                        StartLine = currentRegion.StartLine,
                        StartOffset = currentRegion.StartOffset,
                        EndLine = line.LineNumber
                    });

                    currentRegion = currentRegion.PartialParent;
                }
            }
        }

        //determine the changed span, and send a changed event with the new spans
        List<Span> oldSpans =
            new List<Span>(this.regions.Select(r => AsSnapshotSpan(r, this.snapshot)
                .TranslateTo(newSnapshot, SpanTrackingMode.EdgeExclusive)
                .Span));
        List<Span> newSpans =
                new List<Span>(newRegions.Select(r => AsSnapshotSpan(r, newSnapshot).Span));

        NormalizedSpanCollection oldSpanCollection = new NormalizedSpanCollection(oldSpans);
        NormalizedSpanCollection newSpanCollection = new NormalizedSpanCollection(newSpans);

        //the changed regions are regions that appear in one set or the other, but not both.
        NormalizedSpanCollection removed =
        NormalizedSpanCollection.Difference(oldSpanCollection, newSpanCollection);

        int changeStart = int.MaxValue;
        int changeEnd = -1;

        if (removed.Count > 0)
        {
            changeStart = removed[0].Start;
            changeEnd = removed[removed.Count - 1].End;
        }

        if (newSpans.Count > 0)
        {
            changeStart = Math.Min(changeStart, newSpans[0].Start);
            changeEnd = Math.Max(changeEnd, newSpans[newSpans.Count - 1].End);
        }

        this.snapshot = newSnapshot;
        this.regions = newRegions;

        if (changeStart <= changeEnd)
        {
            ITextSnapshot snap = this.snapshot;
            if (this.TagsChanged != null)
                this.TagsChanged(this, new SnapshotSpanEventArgs(
                    new SnapshotSpan(this.snapshot, Span.FromBounds(changeStart, changeEnd))));
        }
    }