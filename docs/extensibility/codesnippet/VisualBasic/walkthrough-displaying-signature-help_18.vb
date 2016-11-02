    Public Sub AugmentSignatureHelpSession(ByVal session As ISignatureHelpSession, ByVal signatures As IList(Of ISignature)) Implements ISignatureHelpSource.AugmentSignatureHelpSession
        Dim snapshot As ITextSnapshot = m_textBuffer.CurrentSnapshot
        Dim position As Integer = session.GetTriggerPoint(m_textBuffer).GetPosition(snapshot)

        Dim applicableToSpan As ITrackingSpan = m_textBuffer.CurrentSnapshot.CreateTrackingSpan(New Span(position, 0), SpanTrackingMode.EdgeInclusive, 0)

        signatures.Add(CreateSignature(m_textBuffer, "add(int firstInt, int secondInt)", "Documentation for adding integers.", applicableToSpan))
        signatures.Add(CreateSignature(m_textBuffer, "add(double firstDouble, double secondDouble)", "Documentation for adding doubles.", applicableToSpan))
    End Sub