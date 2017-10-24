    public void Detach(ITextView textView)
    {
        if (m_textView == textView)
        {
            m_textView.MouseHover -= this.OnTextViewMouseHover;
            m_textView = null;
        }
    }