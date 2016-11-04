    Public Sub New(ByVal provider As TestQuickInfoSourceProvider, ByVal subjectBuffer As ITextBuffer)
        m_provider = provider
        m_subjectBuffer = subjectBuffer

        'these are the method names and their descriptions
        m_dictionary = New Dictionary(Of String, String)()
        m_dictionary.Add("add", "int add(int firstInt, int secondInt)" & vbLf & "Adds one integer to another.")
        m_dictionary.Add("subtract", "int subtract(int firstInt, int secondInt)" & vbLf & "Subtracts one integer from another.")
        m_dictionary.Add("multiply", "int multiply(int firstInt, int secondInt)" & vbLf & "Multiplies one integer by another.")
        m_dictionary.Add("divide", "int divide(int firstInt, int secondInt)" & vbLf & "Divides one integer by another.")
    End Sub