    public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
    {
        return new TestCompletionSource(this, textBuffer);
    }