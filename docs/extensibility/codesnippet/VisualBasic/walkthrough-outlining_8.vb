    Private Sub ReParse()
        Dim newSnapshot As ITextSnapshot = buffer.CurrentSnapshot
        Dim newRegions As New List(Of Region)()

        'keep the current (deepest) partial region, which will have
        ' references to any parent partial regions.
        Dim currentRegion As PartialRegion = Nothing

        For Each line In newSnapshot.Lines
            Dim regionStart As Integer = -1
            Dim text As String = line.GetText()

            'lines that contain a "[" denote the start of a new region.
            If text.IndexOf(startHide, StringComparison.Ordinal) <> -1 Then
                regionStart = text.IndexOf(startHide, StringComparison.Ordinal)
                Dim currentLevel As Integer = If((currentRegion IsNot Nothing), currentRegion.Level, 1)
                Dim newLevel As Integer
                If Not TryGetLevel(text, regionStart, newLevel) Then
                    newLevel = currentLevel + 1
                End If

                'levels are the same and we have an existing region;
                'end the current region and start the next
                If currentLevel = newLevel AndAlso currentRegion IsNot Nothing Then
                    Dim newRegion = New Region()
                    newRegion.Level = currentRegion.Level
                    newRegion.StartLine = currentRegion.StartLine
                    newRegion.StartOffset = currentRegion.StartOffset
                    newRegion.EndLine = line.LineNumber
                    newRegions.Add(newRegion)

                    currentRegion = New PartialRegion()
                    currentRegion.Level = newLevel
                    currentRegion.StartLine = line.LineNumber
                    currentRegion.StartOffset = regionStart
                    currentRegion.PartialParent = currentRegion.PartialParent

                Else
                    'this is a new (sub)region
                    currentRegion = New PartialRegion()
                    currentRegion.Level = newLevel
                    currentRegion.StartLine = line.LineNumber
                    currentRegion.StartOffset = regionStart
                    currentRegion.PartialParent = currentRegion
                End If
                'lines that contain "]" denote the end of a region
            ElseIf (text.IndexOf(endHide, StringComparison.Ordinal)) <> -1 Then
                regionStart = text.IndexOf(endHide, StringComparison.Ordinal)
                Dim currentLevel As Integer = If((currentRegion IsNot Nothing), currentRegion.Level, 1)
                Dim closingLevel As Integer
                If Not TryGetLevel(text, regionStart, closingLevel) Then
                    closingLevel = currentLevel
                End If

                'the regions match
                If currentRegion IsNot Nothing AndAlso currentLevel = closingLevel Then
                    Dim newRegion As Region
                    newRegion = New Region()
                    newRegion.Level = currentLevel
                    newRegion.StartLine = currentRegion.StartLine
                    newRegion.StartOffset = currentRegion.StartOffset
                    newRegion.EndLine = line.LineNumber
                    newRegions.Add(newRegion)

                    currentRegion = currentRegion.PartialParent
                End If
            End If
        Next
        'determine the changed span, and send a changed event with the new spans
        Dim oldSpans As New List(Of Span)(Me.regions.[Select](Function(r) AsSnapshotSpan(r, Me.snapshot).TranslateTo(newSnapshot, SpanTrackingMode.EdgeExclusive).Span))
        Dim newSpans As New List(Of Span)(newRegions.[Select](Function(r) AsSnapshotSpan(r, newSnapshot).Span))

        Dim oldSpanCollection As New NormalizedSpanCollection(oldSpans)
        Dim newSpanCollection As New NormalizedSpanCollection(newSpans)

        'the changed regions are regions that appear in one set or the other, but not both.
        Dim removed As NormalizedSpanCollection = NormalizedSpanCollection.Difference(oldSpanCollection, newSpanCollection)

        Dim changeStart As Integer = Integer.MaxValue
        Dim changeEnd As Integer = -1

        If removed.Count > 0 Then
            changeStart = removed(0).Start
            changeEnd = removed(removed.Count - 1).[End]
        End If

        If newSpans.Count > 0 Then
            changeStart = Math.Min(changeStart, newSpans(0).Start)
            changeEnd = Math.Max(changeEnd, newSpans(newSpans.Count - 1).[End])
        End If

        Me.snapshot = newSnapshot
        Me.regions = newRegions

        If changeStart <= changeEnd Then
            Dim snap As ITextSnapshot = Me.snapshot
            RaiseEvent TagsChanged(Me, New SnapshotSpanEventArgs(New SnapshotSpan(Me.snapshot, Span.FromBounds(changeStart, changeEnd))))
        End If
    End Sub