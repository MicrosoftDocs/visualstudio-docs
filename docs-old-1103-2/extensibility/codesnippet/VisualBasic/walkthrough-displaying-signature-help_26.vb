    Friend Sub New(ByVal textViewAdapter As IVsTextView, ByVal textView As ITextView, ByVal nav As ITextStructureNavigator, ByVal broker As ISignatureHelpBroker)
        Me.m_textView = textView
        Me.m_broker = broker
        Me.m_navigator = nav

        'add this to the filter chain
        textViewAdapter.AddCommandFilter(Me, m_nextCommandHandler)
    End Sub