    public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
    {
        if (buffer == null)
        {
            throw new ArgumentNullException("buffer");
        }

        return new TodoTagger(AggregatorService.GetClassifier(buffer)) as ITagger<T>;
    }