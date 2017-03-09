Partial Public NotInheritable Class ThisDocument

    ' BuildingBlockGalleryContentControl constructor #1: 
    ' create a BuildingBlockGalleryContentControl at the current selection.
    '<Snippet1>
    Dim buildingBlockGalleryControl1 As Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl

    Private Sub AddBuildingBlockGalleryControlAtSelection()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        Me.Paragraphs(1).Range.Select()
        buildingBlockGalleryControl1 = Me.Controls.AddBuildingBlockGalleryContentControl( _
            "buildingBlockGalleryControl1")
        With buildingBlockGalleryControl1
            .PlaceholderText = "Choose an equation"
            .BuildingBlockCategory = "Built-In"
            .BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeEquations
        End With
    End Sub
    '</Snippet1>

    ' BuildingBlockGalleryContentControl constructor #2: 
    ' create a BuildingBlockGalleryContentControl at a specified range.
    '<Snippet2>
    Dim buildingBlockGalleryControl2 As Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl

    Private Sub AddBuildingBlockGalleryControlAtRange()
        Me.Paragraphs(1).Range.InsertParagraphBefore()
        buildingBlockGalleryControl2 = Me.Controls.AddBuildingBlockGalleryContentControl( _
            Me.Paragraphs(1).Range, "buildingBlockGalleryControl2")
        With buildingBlockGalleryControl2
            .PlaceholderText = "Choose an equation"
            .BuildingBlockCategory = "Built-In"
            .BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeEquations
        End With
    End Sub
    '</Snippet2>

    ' BuildingBlockGalleryContentControl constructor #3: create a BuildingBlockGalleryContentControl for every
    ' native control in the document.
    '<Snippet3>
    Private buildingBlockControls As New System.Collections.Generic.List _
            (Of Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl)

    Private Sub CreateBuildingBlockGalleryControlsFromNativeControls()
        If Me.ContentControls.Count <= 0 Then
            Return
        End If

        Dim count As Integer = 0
        For Each nativeControl As Word.ContentControl In Me.ContentControls
            If nativeControl.Type = Word.WdContentControlType.wdContentControlBuildingBlockGallery Then
                count += 1
                Dim tempControl As Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl = _
                    Me.Controls.AddBuildingBlockGalleryContentControl(nativeControl, _
                    "VSTOBuildingBlockGalleryContentControl" + count.ToString())
                buildingBlockControls.Add(tempControl)
            End If
        Next nativeControl
    End Sub
    '</Snippet3>

    ' BuildingBlockGalleryContentControl constructor #3: create a 
    ' BuildingBlockGalleryContentControl for every native building block control added to the document.
    '<Snippet4>
    Private Sub ThisDocument_BuildingBlockContentControlAfterAdd(ByVal NewContentControl As Word.ContentControl, _
        ByVal InUndoRedo As Boolean) Handles Me.ContentControlAfterAdd

        If NewContentControl.Type = Word.WdContentControlType.wdContentControlBuildingBlockGallery Then
            Me.Controls.AddBuildingBlockGalleryContentControl(NewContentControl, _
                "BuildingBlockControl" + NewContentControl.ID)
        End If
    End Sub
    '</Snippet4>

End Class
