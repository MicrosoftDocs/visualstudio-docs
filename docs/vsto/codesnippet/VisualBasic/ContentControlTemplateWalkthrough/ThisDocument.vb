
Public Class ThisDocument

    '<Snippet1>
    Private GroupControl1 As Microsoft.Office.Tools.Word.GroupContentControl
    Private BuildingBlockControl1 As Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl
    Private BuildingBlockControl2 As Microsoft.Office.Tools.Word.BuildingBlockGalleryContentControl
    '</Snippet1>

    Private Sub ThisDocument_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        Try

            '<Snippet2>
            ComboBoxContentControl1.PlaceholderText = "Choose a title, or enter your own"
            ComboBoxContentControl1.DropDownListEntries.Add("Engineer", "Engineer", 0)
            ComboBoxContentControl1.DropDownListEntries.Add("Designer", "Designer", 1)
            ComboBoxContentControl1.DropDownListEntries.Add("Manager", "Manager", 2)

            DropDownListContentControl1.PlaceholderText = _
                "Choose a rating (1 lowest, 3 highest)"
            DropDownListContentControl1.DropDownListEntries.Add("1", "1", 0)
            DropDownListContentControl1.DropDownListEntries.Add("2", "2", 1)
            DropDownListContentControl1.DropDownListEntries.Add("3", "3", 2)
            '</Snippet2>

            '<Snippet3>
            Me.Tables(1).Select()
            GroupControl1 = Me.Controls.AddGroupContentControl("groupControl1")
            '</Snippet3>

            '<Snippet4>
            Dim template1 As Word.Template = TryCast(Me.AttachedTemplate, Word.Template)
            If template1 IsNot Nothing Then

                template1.BuildingBlockEntries.Add("Employee Table", _
                    Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information", _
                    Me.Tables(1).Range, InsertOptions:=Word.WdDocPartInsertOptions.wdInsertContent)
                template1.BuildingBlockEntries.Add("Customer Table", _
                    Word.WdBuildingBlockTypes.wdTypeCustom1, "Employee and Customer Information", _
                    Me.Tables(2).Range, InsertOptions:=Word.WdDocPartInsertOptions.wdInsertContent)
            End If
            '</Snippet4>

            '<Snippet5>
            If Me.FormsDesign = False Then
                Me.ToggleFormsDesign()
            End If
            Me.Tables(2).Delete()
            Me.Tables(1).Delete()
            Me.ToggleFormsDesign()
            '</Snippet5>

            '<Snippet6>
            BuildingBlockControl1 = Me.Controls.AddBuildingBlockGalleryContentControl( _
                Me.Paragraphs(1).Range, "buildingBlockControl1")
            BuildingBlockControl1.BuildingBlockCategory = "Employee and Customer Information"
            BuildingBlockControl1.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1
            BuildingBlockControl1.PlaceholderText = "Choose your first building block"

            BuildingBlockControl2 = Me.Controls.AddBuildingBlockGalleryContentControl( _
                Me.Paragraphs(2).Range, "buildingBlockControl2")
            BuildingBlockControl2.BuildingBlockCategory = "Employee and Customer Information"
            BuildingBlockControl2.BuildingBlockType = Word.WdBuildingBlockTypes.wdTypeCustom1
            BuildingBlockControl2.PlaceholderText = "Choose your second building block"
            '</Snippet6>

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ThisDocument_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub

End Class
