        Public Function GetGlyphFactory(ByVal view As IWpfTextView, ByVal margin As IWpfTextViewMargin) As IGlyphFactory Implements IGlyphFactoryProvider.GetGlyphFactory
            Return New TodoGlyphFactory()
        End Function