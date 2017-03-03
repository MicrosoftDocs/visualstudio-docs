Public Class HelloControl

    '--------------------------------------------------------------------------
    '<Snippet12>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Button1.Click

        Globals.ThisDocument.Paragraphs(1).Range.Text = "Hello world!"
    End Sub
    '</Snippet12>

End Class
