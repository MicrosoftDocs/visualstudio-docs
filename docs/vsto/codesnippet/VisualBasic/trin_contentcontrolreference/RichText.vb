Partial Public NotInheritable Class ThisDocument

    ' RichTextContentControl constructor #1: create a RichTextContentControl at the current selection.
    '<Snippet700>
    Dim richTextControl1 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        richTextControl1 = Me.Controls.AddRichTextContentControl("richTextControl1")
        richTextControl1.PlaceholderText = "Enter your first name"
    End Sub
    '</Snippet700>

    ' RichTextContentControl constructor #2: create a RichTextContentControl at a specified range.
    '<Snippet701>
    Dim richTextControl2 As Microsoft.Office.Tools.Word.RichTextContentControl

    Private Sub AddRichTextControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        richTextControl2 = Me.Controls.AddRichTextContentControl(Me.Paragraphs(1).Range, _
            "richTextControl2")
        richTextControl2.PlaceholderText = "Enter your first name"
    End Sub
    '</Snippet701>

    ' RichTextContentControl constructor #3: create a RichTextContentControl for every
    ' native rich text control in the document.
    '<Snippet702>
    Private richTextControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.RichTextContentControl)

    Private Sub CreateRichTextControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlRichText Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.RichTextContentControl = _
                    Me.Controls.AddRichTextContentControl(nativeControl, _
                    "VSTORichTextContentControl" + count.ToString())
                richTextControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet702>

    ' RichTextContentControl constructor #3: create a 
    ' RichTextContentControl for every native rich text control added to the document.
    '<Snippet703>
    Private Sub ThisDocument_RichTextContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlRichText Then
            Me.Controls.AddRichTextContentControl(NewContentControl, _
                "RichTextControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet703>

End Class
