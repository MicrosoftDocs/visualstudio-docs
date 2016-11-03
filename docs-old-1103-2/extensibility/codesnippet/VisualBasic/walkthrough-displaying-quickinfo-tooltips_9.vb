    Public Function TryCreateQuickInfoSource(ByVal textBuffer As ITextBuffer) As IQuickInfoSource Implements IQuickInfoSourceProvider.TryCreateQuickInfoSource
        Return New TestQuickInfoSource(Me, textBuffer)
    End Function