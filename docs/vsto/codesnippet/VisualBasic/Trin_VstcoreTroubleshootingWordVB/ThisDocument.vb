'<Snippet2>
Imports Word = Microsoft.Office.Interop.Word
'</Snippet2>


Public Class ThisDocument

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
    End Sub

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
    End Sub


    Class Document
    End Class


    '--------------------------------------------------------------------------
    Sub Test2()

        '<Snippet4>
        Dim doc As Document  ' Class is ambiguous
        '</Snippet4>

        doc = New Document
    End Sub


    '--------------------------------------------------------------------------
    Sub Test1()

        '<Snippet3>
        Dim doc As Word.Document
        '</Snippet3>

        doc = New Word.Document
    End Sub


    '--------------------------------------------------------------------------
    '<Snippet1>
    Dim form1 As SampleForm

    Sub OpenForm()
        form1 = New SampleForm
        form1.Show()  ' Show the form modelessly.
    End Sub

    Sub ForceShutdown()

        ' Completely close the form if it is still running.
        ' Note that hiding the form might not work by itself.

        If (Not form1 Is Nothing) Then
            form1.Close()
            form1.Dispose()
            form1 = Nothing
        End If

        Me.Close()
    End Sub
    '</Snippet1>
End Class
