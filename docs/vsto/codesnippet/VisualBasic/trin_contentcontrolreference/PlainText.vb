Partial Public NotInheritable Class ThisDocument

    ' PlainTextContentControl constructor #1: create a PlainTextContentControl at the current selection.
    '<Snippet600>
    Dim plainTextControl1 As Microsoft.Office.Tools.Word.PlainTextContentControl

    Private Sub AddPlainTextControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        plainTextControl1 = Me.Controls.AddPlainTextContentControl("plainTextControl1")
        plainTextControl1.PlaceholderText = "Enter your first name"
    End Sub
    '</Snippet600>

    ' PlainTextContentControl constructor #2: create a PlainTextContentControl at a specified range.
    '<Snippet601>
    Dim plainTextControl2 As Microsoft.Office.Tools.Word.PlainTextContentControl

    Private Sub AddPlainTextControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        plainTextControl2 = Me.Controls.AddPlainTextContentControl(Me.Paragraphs(1).Range, "plainTextControl2")
        plainTextControl2.PlaceholderText = "Enter your first name"
    End Sub
    '</Snippet601>

    ' PlainTextContentControl constructor #3: create a PlainTextContentControl for every
    ' native plain text control in the document.
    '<Snippet602>
    Private plainTextControls As New System.Collections.Generic.List _
        (Of Microsoft.Office.Tools.Word.PlainTextContentControl)

    Private Sub CreatePlainTextControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlText Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.PlainTextContentControl = _
                    Me.Controls.AddPlainTextContentControl(nativeControl, _
                    "VSTOPlainTextContentControl" + count.ToString())
                plainTextControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet602>

    ' PlainTextContentControl constructor #3: create a 
    ' PlainTextContentControl for every native plain text control added to the document.
    '<Snippet603>
    Private Sub ThisDocument_PlainTextContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlText Then
            Me.Controls.AddPlainTextContentControl(NewContentControl, _
                "PlainTextControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet603>

End Class
