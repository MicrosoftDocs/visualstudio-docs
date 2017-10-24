    Friend Sub New(ByVal subjectBuffer As ITextBuffer, ByVal content As String, ByVal doc As String, ByVal parameters As ReadOnlyCollection(Of IParameter))
        m_subjectBuffer = subjectBuffer
        m_content = content
        m_documentation = doc
        m_parameters = parameters
        AddHandler m_subjectBuffer.Changed, AddressOf OnSubjectBufferChanged
    End Sub