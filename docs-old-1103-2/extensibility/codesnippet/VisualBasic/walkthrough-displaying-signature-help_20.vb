    Public Function GetBestMatch(ByVal session As ISignatureHelpSession) As ISignature Implements ISignatureHelpSource.GetBestMatch
        If session.Signatures.Count > 0 Then
            Dim applicableToSpan As ITrackingSpan = session.Signatures(0).ApplicableToSpan
            Dim text As String = applicableToSpan.GetText(applicableToSpan.TextBuffer.CurrentSnapshot)

            If text.Trim().Equals("add") Then 'get only "add"
                Return session.Signatures(0)
            End If
        End If
        Return Nothing
    End Function