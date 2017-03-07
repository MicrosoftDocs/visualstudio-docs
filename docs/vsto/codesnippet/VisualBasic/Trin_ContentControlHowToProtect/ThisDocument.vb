
Public Class ThisDocument

    '<Snippet1>
    Dim groupControl1 As Microsoft.Office.Tools.Word.GroupContentControl

    Private Sub ProtectFirstParagraph()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Dim range1 As Word.Range = Me.Paragraphs(1).Range
        range1.Text = "You cannot edit or change the formatting of text " & _
                "in this paragraph, because this paragraph is in a GroupContentControl."
        range1.Select()

        groupControl1 = Me.Controls.AddGroupContentControl("groupControl1")
    End Sub
    '</Snippet1>

    '<Snippet2>
    Dim deletableControl As Microsoft.Office.Tools.Word.RichTextContentControl
    Dim editableControl As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddProtectedContentControls()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Dim range1 As Word.Range = Me.Paragraphs(1).Range

        deletableControl = Me.Controls.AddRichTextContentControl(range1, _
            "deletableControl")
        deletableControl.PlaceholderText = "You can delete this control, " & _
            "but you cannot edit it"
        deletableControl.LockContents = True

        range1.InsertParagraphAfter()
        Dim range2 As Word.Range = Me.Paragraphs(2).Range

        editableControl = Me.Controls.AddRichTextContentControl(range2, _
            "editableControl")
        editableControl.PlaceholderText = "You can edit this control, " & _
            "but you cannot delete it"
        editableControl.LockContentControl = True
    End Sub
    '</Snippet2>

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        Try
            'ProtectFirstParagraph()
            'AddProtectedContentControls()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class
