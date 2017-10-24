    Public Function TryCreateIntellisenseController(ByVal textView As ITextView, ByVal subjectBuffers As IList(Of ITextBuffer)) As IIntellisenseController Implements IIntellisenseControllerProvider.TryCreateIntellisenseController
        Return New TestQuickInfoController(textView, subjectBuffers, Me)
    End Function