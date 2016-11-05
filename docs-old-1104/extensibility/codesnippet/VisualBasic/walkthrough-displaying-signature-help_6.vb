    Private m_subjectBuffer As ITextBuffer
    Private m_currentParameter As IParameter
    Private m_content As String
    Private m_documentation As String
    Friend m_applicableToSpan As ITrackingSpan
    Friend m_parameters As ReadOnlyCollection(Of IParameter)
    Private m_printContent As String