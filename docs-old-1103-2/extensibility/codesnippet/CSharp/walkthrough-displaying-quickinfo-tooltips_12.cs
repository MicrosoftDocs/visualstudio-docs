    internal TestQuickInfoController(ITextView textView, IList<ITextBuffer> subjectBuffers, TestQuickInfoControllerProvider provider)
    {
        m_textView = textView;
        m_subjectBuffers = subjectBuffers;
        m_provider = provider;

        m_textView.MouseHover += this.OnTextViewMouseHover;
    }