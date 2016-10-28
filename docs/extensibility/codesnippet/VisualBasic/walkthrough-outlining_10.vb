    Private Shared Function AsSnapshotSpan(ByVal region As Region, ByVal snapshot As ITextSnapshot) As SnapshotSpan
        Dim startLine = snapshot.GetLineFromLineNumber(region.StartLine)
        Dim endLine = If((region.StartLine = region.EndLine), startLine, snapshot.GetLineFromLineNumber(region.EndLine))
        Return New SnapshotSpan(startLine.Start + region.StartOffset, endLine.[End])
    End Function