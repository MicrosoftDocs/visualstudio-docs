Public Class ThisDocument

    '<Snippet1>
    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        Me.Paragraphs(1).Range.InsertParagraphAfter()
        Me.Paragraphs(2).Range.Text = "This text was added by using code."
    End Sub
    '</Snippet1>

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class
