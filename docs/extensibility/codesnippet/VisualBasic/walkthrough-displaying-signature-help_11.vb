    Friend Sub ComputeCurrentParameter()
        If Parameters.Count = 0 Then
            Me.m_currentParameter = Nothing
            Return
        End If

        'the number of commas in the string is the index of the current parameter
        Dim sigText As String = ApplicableToSpan.GetText(m_subjectBuffer.CurrentSnapshot)

        Dim currentIndex As Integer = 0
        Dim commaCount As Integer = 0
        Do While currentIndex < sigText.Length
            Dim commaIndex As Integer = sigText.IndexOf(","c, currentIndex)
            If commaIndex = -1 Then
                Exit Do
            End If
            commaCount += 1
            currentIndex = commaIndex + 1
        Loop

        If commaCount < Parameters.Count Then
            Me.m_currentParameter = Parameters(commaCount)
        Else
            'too many commas, so use the last parameter as the current one.
            Me.m_currentParameter = Parameters(Parameters.Count - 1)
        End If
    End Sub