    public IIntellisenseController TryCreateIntellisenseController(ITextView textView, IList<ITextBuffer> subjectBuffers)
    {
        return new TestQuickInfoController(textView, subjectBuffers, this);
    }