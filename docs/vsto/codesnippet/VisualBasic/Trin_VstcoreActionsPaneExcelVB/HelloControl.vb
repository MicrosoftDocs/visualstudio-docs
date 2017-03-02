Public Class HelloControl

    '--------------------------------------------------------------------------
    '<Snippet5>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button1.Click

        Globals.Sheet1.Range("A1").Value2 = "Hello world!"
    End Sub
    '</Snippet5>
End Class
