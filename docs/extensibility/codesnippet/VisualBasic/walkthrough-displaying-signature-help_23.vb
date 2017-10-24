    Public Function TryCreateSignatureHelpSource(ByVal textBuffer As ITextBuffer) As ISignatureHelpSource Implements ISignatureHelpSourceProvider.TryCreateSignatureHelpSource
        Return New TestSignatureHelpSource(textBuffer)
    End Function