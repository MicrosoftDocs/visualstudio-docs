Partial Public NotInheritable Class ThisDocument


    ' DropDownListContentControl constructor #1: create a DropDownListContentControl at the current selection.
    '<Snippet300>
    Dim dropDownListControl1 As Microsoft.Office.Tools.Word.DropDownListContentControl

    Private Sub AddDropDownListControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        dropDownListControl1 = Me.Controls.AddDropDownListContentControl("dropDownListControl1")
        With dropDownListControl1
            .DropDownListEntries.Add("Monday", "Monday", 0)
            .DropDownListEntries.Add("Tuesday", "Tuesday", 1)
            .DropDownListEntries.Add("Wednesday", "Wednesday", 2)
            .PlaceholderText = "Choose a day"
        End With
    End Sub
    '</Snippet300>

    ' DropDownListContentControl constructor #2: create a DropDownListContentControl at a specified range.
    '<Snippet301>
    Dim dropDownListControl2 As Microsoft.Office.Tools.Word.DropDownListContentControl

    Private Sub AddDropDownListControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        dropDownListControl2 = Me.Controls.AddDropDownListContentControl(Me.Paragraphs(1).Range, _
            "dropDownListControl2")
        With dropDownListControl2
            .DropDownListEntries.Add("Monday", "Monday", 0)
            .DropDownListEntries.Add("Tuesday", "Tuesday", 1)
            .DropDownListEntries.Add("Wednesday", "Wednesday", 2)
            .PlaceholderText = "Choose a day"
        End With
    End Sub
    '</Snippet301>

    ' DropDownListContentControl constructor #3: create a DropDownListContentControl for every
    ' native drop down list control in the document.
    '<Snippet302>
    Private dropDownListControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.DropDownListContentControl)

    Private Sub CreateDropDownListControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlDropdownList Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.DropDownListContentControl = _
                    Me.Controls.AddDropDownListContentControl(nativeControl, _
                    "VSTODropDownListContentControl" + count.ToString())
                dropDownListControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet302>


    ' DropDownListContentControl constructor #3: create a 
    ' DropDownListContentControl for every native drop down list added to the document.
    '<Snippet303>
    Private Sub ThisDocument_DropDownListContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlDropdownList Then
            Me.Controls.AddDropDownListContentControl(NewContentControl, _
                "DropDownListControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet303>

End Class
