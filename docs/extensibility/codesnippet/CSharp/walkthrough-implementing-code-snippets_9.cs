        internal TestCompletionCommandHandler(IVsTextView textViewAdapter, ITextView textView, TestCompletionHandlerProvider provider)
        {
            this.m_textView = textView;
            m_vsTextView = textViewAdapter;
            m_provider = provider;
            //get the text manager from the service provider
            IVsTextManager2 textManager = (IVsTextManager2)m_provider.ServiceProvider.GetService(typeof(SVsTextManager));
            textManager.GetExpansionManager(out m_exManager);
            m_exSession = null;

            //add the command to the command chain
            textViewAdapter.AddCommandFilter(this, out m_nextCommandHandler);
        }