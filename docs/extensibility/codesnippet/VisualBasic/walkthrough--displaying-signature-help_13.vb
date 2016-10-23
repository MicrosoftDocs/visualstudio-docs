    ReadOnly Property ApplicableToSpan() As ITrackingSpan Implements ISignature.ApplicableToSpan
        Get
            Return (m_applicableToSpan)
        End Get
    End Property