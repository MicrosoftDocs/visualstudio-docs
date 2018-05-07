Partial Public NotInheritable Class ThisDocument

    ' ComboBoxContentControl constructor #1: create a ComboBoxContentControl at the current selection.
    '<Snippet100>
    Dim comboBoxControl1 As Microsoft.Office.Tools.Word.ComboBoxContentControl

    Private Sub AddComboBoxControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        comboBoxControl1 = Me.Controls.AddComboBoxContentControl("comboBoxControl1")
        With comboBoxControl1
            .DropDownListEntries.Add("Red", "Red", 0)
            .DropDownListEntries.Add("Green", "Green", 1)
            .DropDownListEntries.Add("Blue", "Blue", 2)
            .PlaceholderText = "Choose a color, or enter your own"
        End With
    End Sub
    '</Snippet100>

    ' ComboBoxContentControl constructor #2: create a ComboBoxContentControl at a specified range.
    '<Snippet101>
    Dim comboBoxControl2 As Microsoft.Office.Tools.Word.ComboBoxContentControl

    Private Sub AddComboBoxControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        comboBoxControl2 = Me.Controls.AddComboBoxContentControl(Me.Paragraphs(1).Range, "comboBoxControl2")
        With comboBoxControl2
            .DropDownListEntries.Add("Red", "Red", 0)
            .DropDownListEntries.Add("Green", "Green", 1)
            .DropDownListEntries.Add("Blue", "Blue", 2)
            .PlaceholderText = "Choose a color, or enter your own"
        End With
    End Sub
    '</Snippet101>

    ' ComboBoxContentControl constructor #3: create a ComboBoxContentControl for every
    ' native rich text control in the document.
    '<Snippet102>
    Private comboBoxControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.ComboBoxContentControl)

    Private Sub CreateComboBoxControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlComboBox Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.ComboBoxContentControl = _
                    Me.Controls.AddComboBoxContentControl(nativeControl, _
                    "VSTOComboBoxContentControl" + count.ToString())
                comboBoxControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet102>


    ' ComboBoxContentControl constructor #3: create a 
    ' ComboBoxContentControl for every native combo box control added to the document.
    '<Snippet103>
    Private Sub ThisDocument_ComboBoxContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlComboBox Then
            Me.Controls.AddComboBoxContentControl(NewContentControl, _
                "ComboBoxControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet103>

End Class
