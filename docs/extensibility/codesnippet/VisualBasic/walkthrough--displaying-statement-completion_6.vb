    Private Function FindTokenSpanAtPosition(ByVal point As ITrackingPoint, ByVal session As ICompletionSession) As ITrackingSpan
        Dim currentPoint As SnapshotPoint = (session.TextView.Caret.Position.BufferPosition) - 1
        Dim navigator As ITextStructureNavigator = m_sourceProvider.NavigatorService.GetTextStructureNavigator(m_textBuffer)
        Dim extent As TextExtent = navigator.GetExtentOfWord(currentPoint)
        Return currentPoint.Snapshot.CreateTrackingSpan(extent.Span, SpanTrackingMode.EdgeInclusive)
    End Function