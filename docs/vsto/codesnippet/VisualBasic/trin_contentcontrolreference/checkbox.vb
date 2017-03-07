Partial Public NotInheritable Class ThisDocument
    Private Sub AddCheckBoxControlAtSelection()
        '<Snippet800>
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        Dim checkBoxControl1 As Microsoft.Office.Tools.Word.ContentControl =
            Me.Controls.AddContentControl("checkBoxControl1", Word.WdContentControlType.wdContentControlCheckBox)


        checkBoxControl1.Checked = True

        '</Snippet800>
    End Sub
End Class

