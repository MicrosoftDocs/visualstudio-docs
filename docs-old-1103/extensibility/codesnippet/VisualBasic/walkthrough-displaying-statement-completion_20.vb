    Private Function TriggerCompletion() As Boolean
        'the caret must be in a non-projection location 
        Dim caretPoint As SnapshotPoint? = m_textView.Caret.Position.Point.GetPoint(Function(textBuffer) ((Not textBuffer.ContentType.IsOfType("projection"))), PositionAffinity.Predecessor)
        If Not caretPoint.HasValue Then
            Return False
        End If

        m_session = m_provider.CompletionBroker.CreateCompletionSession(m_textView, caretPoint.Value.Snapshot.CreateTrackingPoint(caretPoint.Value.Position, PointTrackingMode.Positive), True)

        'subscribe to the Dismissed event on the session 
        AddHandler m_session.Dismissed, AddressOf OnSessionDismissed
        m_session.Start()

        Return True
    End Function