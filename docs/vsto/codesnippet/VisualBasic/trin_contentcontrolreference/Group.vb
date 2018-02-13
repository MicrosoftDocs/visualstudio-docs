Partial Public NotInheritable Class ThisDocument

    ' GroupContentControl constructor #1: create a GroupContentControl at the current selection.
    '<Snippet400>
    Dim groupControl1 As Microsoft.Office.Tools.Word.GroupContentControl

    Private Sub AddGroupControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Text = "You cannot edit or change the formatting of text " & _
                "in this paragraph, because this paragraph is in a GroupContentControl."
        Me.Paragraphs(1).Range.Select()
        groupControl1 = Me.Controls.AddGroupContentControl("groupControl1")
    End Sub
    '</Snippet400>

    ' GroupContentControl constructor #2: create a GroupContentControl at a specified range.
    '<Snippet401>
    Dim groupControl2 As Microsoft.Office.Tools.Word.GroupContentControl

    Private Sub AddGroupControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Dim range1 As Word.Range = Me.Paragraphs(1).Range
        range1.Text = "You cannot edit or change the formatting of text " & _
                "in this paragraph, because this paragraph is in a GroupContentControl."
        range1.Select()
        groupControl2 = Me.Controls.AddGroupContentControl(range1, "groupControl2")
    End Sub
    '</Snippet401>

    ' GroupContentControl constructor #3: create a GroupContentControl for every
    ' native group control in the document.
    '<Snippet402>
    Private groupControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.GroupContentControl)

    Private Sub CreateGroupControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlGroup Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.GroupContentControl = _
                    Me.Controls.AddGroupContentControl(nativeControl, _
                    "VSTOGroupContentControl" + count.ToString())
                groupControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet402>


    ' GroupContentControl constructor #3: create a 
    ' GroupContentControl for every native group added to the document.
    '<Snippet403>
    Private Sub ThisDocument_GroupContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlGroup Then
            Me.Controls.AddGroupContentControl(NewContentControl, _
                "GroupControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet403>

End Class
