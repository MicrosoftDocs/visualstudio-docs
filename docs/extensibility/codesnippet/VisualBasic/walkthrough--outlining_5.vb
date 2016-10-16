    Public Function GetTags(ByVal spans As NormalizedSnapshotSpanCollection) As IEnumerable(Of ITagSpan(Of IOutliningRegionTag)) Implements ITagger(Of Microsoft.VisualStudio.Text.Tagging.IOutliningRegionTag).GetTags
        If spans.Count = 0 Then
            Return Nothing
            Exit Function
        End If
        Dim currentRegions As List(Of Region) = Me.regions
        Dim currentSnapshot As ITextSnapshot = Me.snapshot
        Dim entire As SnapshotSpan = New SnapshotSpan(spans(0).Start, spans(spans.Count - 1).[End]).TranslateTo(currentSnapshot, SpanTrackingMode.EdgeExclusive)
        Dim startLineNumber As Integer = entire.Start.GetContainingLine().LineNumber
        Dim endLineNumber As Integer = entire.[End].GetContainingLine().LineNumber

        Dim list As List(Of ITagSpan(Of IOutliningRegionTag))
        list = New List(Of ITagSpan(Of IOutliningRegionTag))()

        For Each region In currentRegions
            If region.StartLine <= endLineNumber AndAlso region.EndLine >= startLineNumber Then
                Dim startLine = currentSnapshot.GetLineFromLineNumber(region.StartLine)
                Dim endLine = currentSnapshot.GetLineFromLineNumber(region.EndLine)

                'the region starts at the beginning of the "[", and goes until the *end* of the line that contains the "]".
                list.Add(New TagSpan(Of IOutliningRegionTag)(New SnapshotSpan(startLine.Start + region.StartOffset, endLine.End),
                New OutliningRegionTag(False, False, ellipsis, hoverText)))
            End If
        Next
        Return list
    End Function