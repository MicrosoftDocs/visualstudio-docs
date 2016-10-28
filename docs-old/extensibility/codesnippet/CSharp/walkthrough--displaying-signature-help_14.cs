    public string Content
    {
        get { return (m_content); }
        internal set { m_content = value; }
    }

    public string Documentation
    {
        get { return (m_documentation); }
        internal set { m_documentation = value; }
    }

    public ReadOnlyCollection<IParameter> Parameters
    {
        get { return (m_parameters); }
        internal set { m_parameters = value; }
    }

    public string PrettyPrintedContent
    {
        get { return (m_printContent); }
        internal set { m_printContent = value; }
    }