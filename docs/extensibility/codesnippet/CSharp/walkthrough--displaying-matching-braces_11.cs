    public ITagger<T> CreateTagger<T>(ITextView textView, ITextBuffer buffer) where T : ITag
    {
        if (textView == null)
            return null;

        //provide highlighting only on the top-level buffer
        if (textView.TextBuffer != buffer)
            return null;

        return new BraceMatchingTagger(textView, buffer) as ITagger<T>;
    }