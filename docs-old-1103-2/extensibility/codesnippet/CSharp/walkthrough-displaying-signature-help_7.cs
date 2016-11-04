    internal TestSignature(ITextBuffer subjectBuffer, string content, string doc, ReadOnlyCollection<IParameter> parameters)
    {
        m_subjectBuffer = subjectBuffer;
        m_content = content;
        m_documentation = doc;
        m_parameters = parameters;
        m_subjectBuffer.Changed += new EventHandler<TextContentChangedEventArgs>(OnSubjectBufferChanged);
    }