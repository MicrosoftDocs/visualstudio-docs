    public OutliningTagger(ITextBuffer buffer)
    {
        this.buffer = buffer;
        this.snapshot = buffer.CurrentSnapshot;
        this.regions = new List<Region>();
        this.ReParse();
        this.buffer.Changed += BufferChanged;
    }