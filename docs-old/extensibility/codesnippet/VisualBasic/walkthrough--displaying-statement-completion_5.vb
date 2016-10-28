    Private Sub AugmentCompletionSession(ByVal session As ICompletionSession, ByVal completionSets As IList(Of CompletionSet)) Implements ICompletionSource.AugmentCompletionSession
        Dim strList As New List(Of String)()
        strList.Add("addition")
        strList.Add("adaptation")
        strList.Add("subtraction")
        strList.Add("summation")

        m_compList = New List(Of Completion)()
        For Each str As String In strList
            m_compList.Add(New Completion(str, str, str, Nothing, Nothing))
        Next str

        completionSets.Add(New CompletionSet(
            "Tokens",
            "Tokens",
            FindTokenSpanAtPosition(session.GetTriggerPoint(m_textBuffer),
                session),
            m_compList,
            Nothing))
    End Sub