Public Class AddTextControl

    '--------------------------------------------------------------------------
    '<Snippet25>
    Private Sub insertText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles insertText.Click

        With Globals.ThisDocument
            .InsertMemoFromNode.Text = Me.fromBox.Text
            .InsertMemoToNode.Text = Me.toBox.Text
            .InsertMemoSubjectNode.Text = Me.subjectBox.Text
        End With

        ' Clear the text boxes.
        Me.fromBox.Text = ""
        Me.toBox.Text = ""
        Me.subjectBox.Text = ""
    End Sub
    '</Snippet25>

End Class
