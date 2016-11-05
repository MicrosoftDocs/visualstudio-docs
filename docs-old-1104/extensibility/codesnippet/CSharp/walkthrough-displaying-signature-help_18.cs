    public void AugmentSignatureHelpSession(ISignatureHelpSession session, IList<ISignature> signatures)
    {
        ITextSnapshot snapshot = m_textBuffer.CurrentSnapshot;
        int position = session.GetTriggerPoint(m_textBuffer).GetPosition(snapshot);

        ITrackingSpan applicableToSpan = m_textBuffer.CurrentSnapshot.CreateTrackingSpan(
         new Span(position, 0), SpanTrackingMode.EdgeInclusive, 0);

        signatures.Add(CreateSignature(m_textBuffer, "add(int firstInt, int secondInt)", "Documentation for adding integers.", applicableToSpan));
        signatures.Add(CreateSignature(m_textBuffer, "add(double firstDouble, double secondDouble)", "Documentation for adding doubles.", applicableToSpan));

    }