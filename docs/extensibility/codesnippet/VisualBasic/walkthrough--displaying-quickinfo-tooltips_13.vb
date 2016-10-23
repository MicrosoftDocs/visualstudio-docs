    Private Sub OnTextViewMouseHover(ByVal sender As Object, ByVal e As MouseHoverEventArgs)
        'find the mouse position by mapping down to the subject buffer
        Dim point As System.Nullable(Of SnapshotPoint) = m_textView.BufferGraph.MapDownToFirstMatch(New SnapshotPoint(m_textView.TextSnapshot, e.Position), PointTrackingMode.Positive, Function(snapshot) m_subjectBuffers.Contains(snapshot.TextBuffer), PositionAffinity.Predecessor)

        If point IsNot Nothing Then
            Dim triggerPoint As ITrackingPoint = point.Value.Snapshot.CreateTrackingPoint(point.Value.Position, PointTrackingMode.Positive)

            If Not m_provider.QuickInfoBroker.IsQuickInfoActive(m_textView) Then
                m_session = m_provider.QuickInfoBroker.TriggerQuickInfo(m_textView, triggerPoint, True)
            End If
        End If
    End Sub