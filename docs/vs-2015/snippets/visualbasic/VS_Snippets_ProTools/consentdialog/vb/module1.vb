'<snippet7>
Module Module1

    Function Main() As Integer
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim f As New Form1()
        Application.Run(f)
        If (Not f.accepted) Then
            Return -1
        Else
            Return 0
        End If
    End Function

End Module
'</snippet7>
