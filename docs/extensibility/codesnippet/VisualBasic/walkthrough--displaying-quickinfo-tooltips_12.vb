    Friend Sub New(ByVal textView As ITextView, ByVal subjectBuffers As IList(Of ITextBuffer), ByVal provider As TestQuickInfoControllerProvider)
        m_textView = textView
        m_subjectBuffers = subjectBuffers
        m_provider = provider

        AddHandler m_textView.MouseHover, AddressOf Me.OnTextViewMouseHover
    End Sub