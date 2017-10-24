    Public Function TryCreateCompletionSource(ByVal textBuffer As ITextBuffer) As ICompletionSource Implements ICompletionSourceProvider.TryCreateCompletionSource
        Return New TestCompletionSource(Me, textBuffer)
    End Function