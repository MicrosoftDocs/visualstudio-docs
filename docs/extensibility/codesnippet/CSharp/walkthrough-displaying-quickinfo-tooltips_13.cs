    private void OnTextViewMouseHover(object sender, MouseHoverEventArgs e)
    {
        //find the mouse position by mapping down to the subject buffer
        SnapshotPoint? point = m_textView.BufferGraph.MapDownToFirstMatch
             (new SnapshotPoint(m_textView.TextSnapshot, e.Position),
            PointTrackingMode.Positive,
            snapshot => m_subjectBuffers.Contains(snapshot.TextBuffer),
            PositionAffinity.Predecessor);

        if (point != null)
        {
            ITrackingPoint triggerPoint = point.Value.Snapshot.CreateTrackingPoint(point.Value.Position,
            PointTrackingMode.Positive);

            if (!m_provider.QuickInfoBroker.IsQuickInfoActive(m_textView))
            {
                m_session = m_provider.QuickInfoBroker.TriggerQuickInfo(m_textView, triggerPoint, true);
            }
        }
    }