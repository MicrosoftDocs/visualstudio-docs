    Public Function CreateTagger(Of T As ITag)(ByVal buffer As ITextBuffer) As ITagger(Of T) Implements ITaggerProvider.CreateTagger
        'create a single tagger for each buffer.
        Dim sc As Func(Of ITagger(Of T)) = Function() TryCast(New OutliningTagger(buffer), ITagger(Of T))
        Return buffer.Properties.GetOrCreateSingletonProperty(Of ITagger(Of T))(sc)
    End Function