Partial Public NotInheritable Class ThisDocument

    ' DatePickerContentControl constructor #1: create a DatePickerContentControl at the current selection.
    '<Snippet200>
    Dim datePickerControl1 As Microsoft.Office.Tools.Word.DatePickerContentControl

    Private Sub AddDatePickerControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        datePickerControl1 = Me.Controls.AddDatePickerContentControl("datePickerControl1")
        datePickerControl1.DateDisplayFormat = "MMMM d, yyyy"
        datePickerControl1.PlaceholderText = "Choose a date"
    End Sub
    '</Snippet200>

    ' DatePickerContentControl constructor #2: create a DatePickerContentControl at a specified range.
    '<Snippet201>
    Dim datePickerControl2 As Microsoft.Office.Tools.Word.DatePickerContentControl

    Private Sub AddDatePickerControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        datePickerControl2 = Me.Controls.AddDatePickerContentControl(Me.Paragraphs(1).Range, "datePickerControl2")
        datePickerControl2.DateDisplayFormat = "MMMM d, yyyy"
        datePickerControl2.PlaceholderText = "Choose a date"
    End Sub
    '</Snippet201>

    ' DatePickerContentControl constructor #3: create a DatePickerContentControl for every
    ' native date picker control in the document.
    '<Snippet202>
    Private datePickerControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.DatePickerContentControl)

    Private Sub CreateDatePickerControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlDate Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.DatePickerContentControl = _
                    Me.Controls.AddDatePickerContentControl(nativeControl, _
                    "VSTODatePickerContentControl" + count.ToString())
                datePickerControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet202>


    ' DatePickerContentControl constructor #3: create a 
    ' DatePickerContentControl for every native date picker added to the document.
    '<Snippet203>
    Private Sub ThisDocument_DatePickerContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlDate Then
            Me.Controls.AddDatePickerContentControl(NewContentControl, _
                "DatePickerControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet203>

End Class
