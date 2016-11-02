    ITextView View { get; set; }
    ITextBuffer SourceBuffer { get; set; }
    SnapshotPoint? CurrentChar { get; set; }
    private Dictionary<char, char> m_braceList;