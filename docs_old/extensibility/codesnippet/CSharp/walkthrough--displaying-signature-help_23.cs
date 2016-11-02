    public ISignatureHelpSource TryCreateSignatureHelpSource(ITextBuffer textBuffer)
    {
        return new TestSignatureHelpSource(textBuffer);
    }