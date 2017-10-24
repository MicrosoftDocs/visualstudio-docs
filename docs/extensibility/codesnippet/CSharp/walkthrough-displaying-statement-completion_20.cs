    private bool TriggerCompletion()
    {
        //the caret must be in a non-projection location 
        SnapshotPoint? caretPoint =
        m_textView.Caret.Position.Point.GetPoint(
        textBuffer => (!textBuffer.ContentType.IsOfType("projection")), PositionAffinity.Predecessor);
        if (!caretPoint.HasValue)
        {
            return false;
        }

        m_session = m_provider.CompletionBroker.CreateCompletionSession
     (m_textView,
            caretPoint.Value.Snapshot.CreateTrackingPoint(caretPoint.Value.Position, PointTrackingMode.Positive),
            true);

        //subscribe to the Dismissed event on the session 
        m_session.Dismissed += this.OnSessionDismissed;
        m_session.Start();

        return true;
    }