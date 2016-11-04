    public void AugmentQuickInfoSession(IQuickInfoSession session, IList<object> qiContent, out ITrackingSpan applicableToSpan)
    {
        // Map the trigger point down to our buffer.
        SnapshotPoint? subjectTriggerPoint = session.GetTriggerPoint(m_subjectBuffer.CurrentSnapshot);
        if (!subjectTriggerPoint.HasValue)
        {
            applicableToSpan = null;
            return;
        }

        ITextSnapshot currentSnapshot = subjectTriggerPoint.Value.Snapshot;
        SnapshotSpan querySpan = new SnapshotSpan(subjectTriggerPoint.Value, 0);

        //look for occurrences of our QuickInfo words in the span
        ITextStructureNavigator navigator = m_provider.NavigatorService.GetTextStructureNavigator(m_subjectBuffer);
        TextExtent extent = navigator.GetExtentOfWord(subjectTriggerPoint.Value);
        string searchText = extent.Span.GetText();

        foreach (string key in m_dictionary.Keys)
        {
            int foundIndex = searchText.IndexOf(key, StringComparison.CurrentCultureIgnoreCase);
            if (foundIndex > -1)
            {
                applicableToSpan = currentSnapshot.CreateTrackingSpan
                    (
                    //querySpan.Start.Add(foundIndex).Position, 9, SpanTrackingMode.EdgeInclusive
                                            extent.Span.Start + foundIndex, key.Length, SpanTrackingMode.EdgeInclusive
                    );

                string value;
                m_dictionary.TryGetValue(key, out value);
                if (value != null)
                    qiContent.Add(value);
                else
                    qiContent.Add("");

                return;
            }
        }

        applicableToSpan = null;
    }