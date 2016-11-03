    internal BraceMatchingTagger(ITextView view, ITextBuffer sourceBuffer)
    {
        //here the keys are the open braces, and the values are the close braces
        m_braceList = new Dictionary<char, char>();
        m_braceList.Add('{', '}');
        m_braceList.Add('[', ']');
        m_braceList.Add('(', ')');
        this.View = view;
        this.SourceBuffer = sourceBuffer;
        this.CurrentChar = null;

        this.View.Caret.PositionChanged += CaretPositionChanged;
        this.View.LayoutChanged += ViewLayoutChanged;
    }