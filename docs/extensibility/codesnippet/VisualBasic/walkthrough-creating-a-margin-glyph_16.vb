    Public Function CreateTagger(Of T As Microsoft.VisualStudio.Text.Tagging.ITag)(ByVal buffer As Microsoft.VisualStudio.Text.ITextBuffer) As Microsoft.VisualStudio.Text.Tagging.ITagger(Of T) Implements Microsoft.VisualStudio.Text.Tagging.ITaggerProvider.CreateTagger
        If buffer Is Nothing Then
            Throw New ArgumentNullException("buffer")
        End If

        Return TryCast(New TodoTagger(AggregatorService.GetClassifier(buffer)), ITagger(Of T))
    End Function