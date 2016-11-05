    Friend Sub New(ByVal textViewAdapter As IVsTextView, ByVal textView As ITextView, ByVal provider As TestCompletionHandlerProvider)
        Me.m_textView = textView
        Me.m_provider = provider

        'add the command to the command chain
        textViewAdapter.AddCommandFilter(Me, m_nextCommandHandler)
    End Sub