    internal TestCompletionCommandHandler(IVsTextView textViewAdapter, ITextView textView, TestCompletionHandlerProvider provider)
    {
        this.m_textView = textView;
        this.m_provider = provider;

        //add the command to the command chain
        textViewAdapter.AddCommandFilter(this, out m_nextCommandHandler);
    }