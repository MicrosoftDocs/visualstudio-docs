    public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
    {
        //create a single tagger for each buffer.
        Func<ITagger<T>> sc = delegate() { return new OutliningTagger(buffer) as ITagger<T>; };
        return buffer.Properties.GetOrCreateSingletonProperty<ITagger<T>>(sc);
    } 