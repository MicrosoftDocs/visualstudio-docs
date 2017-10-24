    Public Sub AugmentQuickInfoSession(ByVal session As IQuickInfoSession, ByVal qiContent As IList(Of Object), ByRef applicableToSpan As ITrackingSpan) Implements IQuickInfoSource.AugmentQuickInfoSession
        ' Map the trigger point down to our buffer.
        Dim subjectTriggerPoint As System.Nullable(Of SnapshotPoint) = session.GetTriggerPoint(m_subjectBuffer.CurrentSnapshot)
        If Not subjectTriggerPoint.HasValue Then
            applicableToSpan = Nothing
            Exit Sub
        End If

        Dim currentSnapshot As ITextSnapshot = subjectTriggerPoint.Value.Snapshot
        Dim querySpan As New SnapshotSpan(subjectTriggerPoint.Value, 0)

        'look for occurrences of our QuickInfo words in the span
        Dim navigator As ITextStructureNavigator = m_provider.NavigatorService.GetTextStructureNavigator(m_subjectBuffer)
        Dim extent As TextExtent = navigator.GetExtentOfWord(subjectTriggerPoint.Value)
        Dim searchText As String = extent.Span.GetText()

        For Each key As String In m_dictionary.Keys
            Dim foundIndex As Integer = searchText.IndexOf(key, StringComparison.CurrentCultureIgnoreCase)
            If foundIndex > -1 Then
                'applicableToSpan = currentSnapshot.CreateTrackingSpan(querySpan.Start.Add(foundIndex).Position, 9, SpanTrackingMode.EdgeInclusive)

                applicableToSpan = currentSnapshot.CreateTrackingSpan(extent.Span.Start + foundIndex, key.Length, SpanTrackingMode.EdgeInclusive)
                Dim value As String = ""
                m_dictionary.TryGetValue(key, value)
                If value IsNot Nothing Then
                    qiContent.Add(value)
                Else
                    qiContent.Add("")
                End If

                Exit Sub
            End If
        Next

        applicableToSpan = Nothing
    End Sub