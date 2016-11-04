    Private Shared Function TryGetLevel(ByVal text As String, ByVal startIndex As Integer, ByRef level As Integer) As Boolean
        level = -1
        If text.Length > startIndex + 3 Then
            If Integer.TryParse(text.Substring(startIndex + 1), level) Then
                Return True
            End If
        End If

        Return False
    End Function