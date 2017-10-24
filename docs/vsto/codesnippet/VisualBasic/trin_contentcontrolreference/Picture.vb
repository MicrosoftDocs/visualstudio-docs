Partial Public NotInheritable Class ThisDocument

    ' PictureContentControl constructor #1: create a PictureContentControl at the current selection.
    ' Note: This code snippet assumes that MyDocuments\picture.bmp exists.
    '<Snippet500>
    Dim pictureControl1 As Microsoft.Office.Tools.Word.PictureContentControl
    Dim bitmap1 As System.Drawing.Bitmap

    Private Sub AddPictureControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        pictureControl1 = Me.Controls.AddPictureContentControl("pictureControl1")
        Dim imagePath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & _
                "\picture.bmp"
        bitmap1 = New System.Drawing.Bitmap(imagePath, True)
        pictureControl1.Image = bitmap1
    End Sub
    '</Snippet500>

    ' PictureContentControl constructor #2: create a PictureContentControl at a specified range.
    ' Note: This code snippet assumes that MyDocuments\picture.bmp exists.
    '<Snippet501>
    Dim pictureControl2 As Microsoft.Office.Tools.Word.PictureContentControl
    Dim bitmap2 As System.Drawing.Bitmap

    Private Sub AddPictureControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        pictureControl2 = Me.Controls.AddPictureContentControl(Me.Paragraphs(1).Range, "pictureControl2")
        Dim imagePath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & _
                "\picture.bmp"
        bitmap2 = New System.Drawing.Bitmap(imagePath, True)
        pictureControl2.Image = bitmap2
    End Sub
    '</Snippet501>

    ' PictureContentControl constructor #3: create a PictureContentControl for every
    ' native picture control in the document.
    '<Snippet502>
    Private pictureControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.PictureContentControl)

    Private Sub CreatePictureControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlPicture Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.PictureContentControl = _
                    Me.Controls.AddPictureContentControl(nativeControl, _
                    "VSTOPictureContentControl" + count.ToString())
                pictureControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet502>


    ' PictureContentControl constructor #3: create a 
    ' PictureContentControl for every native picture added to the document.
    '<Snippet503>
    Private Sub ThisDocument_PictureContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlPicture Then
            Me.Controls.AddPictureContentControl(NewContentControl, _
                "PictureControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet503>

End Class
