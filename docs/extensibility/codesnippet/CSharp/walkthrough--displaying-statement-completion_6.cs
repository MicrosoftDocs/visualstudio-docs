    private ITrackingSpan FindTokenSpanAtPosition(ITrackingPoint point, ICompletionSession session)
    {
        SnapshotPoint currentPoint = (session.TextView.Caret.Position.BufferPosition) - 1;
        ITextStructureNavigator navigator = m_sourceProvider.NavigatorService.GetTextStructureNavigator(m_textBuffer);
        TextExtent extent = navigator.GetExtentOfWord(currentPoint);
        return currentPoint.Snapshot.CreateTrackingSpan(extent.Span, SpanTrackingMode.EdgeInclusive);
    }