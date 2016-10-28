        Friend Sub New(ByVal textViewAdapter As IVsTextView, ByVal textView As ITextView, ByVal provider As TestCompletionHandlerProvider)
            Me.m_textView = textView
            Me.m_provider = provider
            Me.m_vsTextView = textViewAdapter

            Dim textManager As IVsTextManager2 = DirectCast(m_provider.ServiceProvider.GetService(GetType(SVsTextManager)), IVsTextManager2)
            textManager.GetExpansionManager(m_exManager)
            m_exSession = Nothing

            'add the command to the command chain
            textViewAdapter.AddCommandFilter(Me, m_nextCommandHandler)
        End Sub