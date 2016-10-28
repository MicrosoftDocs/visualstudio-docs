    internal TestSignatureHelpCommandHandler(IVsTextView textViewAdapter, ITextView textView, ITextStructureNavigator nav, ISignatureHelpBroker broker)
    {
        this.m_textView = textView;
        this.m_broker = broker;
        this.m_navigator = nav;

        //add this to the filter chain
        textViewAdapter.AddCommandFilter(this, out m_nextCommandHandler);
    }