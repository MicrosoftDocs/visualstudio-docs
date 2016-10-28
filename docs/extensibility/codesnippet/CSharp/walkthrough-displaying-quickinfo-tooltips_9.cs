    public IQuickInfoSource TryCreateQuickInfoSource(ITextBuffer textBuffer)
    {
        return new TestQuickInfoSource(this, textBuffer);
    }