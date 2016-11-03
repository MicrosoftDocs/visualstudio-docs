    ReadOnly Property Content() As String Implements ISignature.Content
        Get
            Return (m_content)
        End Get
    End Property

    ReadOnly Property Documentation() As String Implements ISignature.Documentation
        Get
            Return (m_documentation)
        End Get
    End Property

    ReadOnly Property Parameters() As ReadOnlyCollection(Of IParameter) Implements ISignature.Parameters
        Get
            Return (m_parameters)
        End Get
    End Property

    ReadOnly Property PrettyPrintedContent() As String Implements ISignature.PrettyPrintedContent
        Get
            Return (m_printContent)
        End Get
    End Property