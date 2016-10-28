    Public Function CreateTagger(Of T As ITag)(ByVal textView As ITextView, ByVal buffer As ITextBuffer) As ITagger(Of T) Implements IViewTaggerProvider.CreateTagger
        If textView Is Nothing Then
            Return Nothing
        End If

        'provide highlighting only on the top-level buffer
        If textView.TextBuffer IsNot buffer Then
            Return Nothing
        End If

        Return TryCast(New BraceMatchingTagger(textView, buffer), ITagger(Of T))
    End Function