Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.Shell.Interop
Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Composition

Namespace Contoso.ExampleProjectExtension
    <Export(GetType(ISharePointProjectExtension))> _
    Class SaveDataProjectExtension
        Implements ISharePointProjectExtension

        Public Sub Initialize(ByVal projectService As ISharePointProjectService) _
            Implements ISharePointProjectExtension.Initialize
            AddHandler projectService.ProjectMenuItemsRequested, AddressOf projectService_ProjectMenuItemsRequested
        End Sub

        Private Sub projectService_ProjectMenuItemsRequested(ByVal sender As Object, ByVal e As SharePointProjectMenuItemsRequestedEventArgs)
            Dim menuItem1 As IMenuItem = e.ActionMenuItems.Add("Save data to project file")
            AddHandler menuItem1.Click, AddressOf menuItem1_Click
        End Sub

        Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As MenuItemEventArgs)
            Dim project As ISharePointProject = CType(e.Owner, ISharePointProject)

            '<Snippet13>
            Dim projectStorage As IVsBuildPropertyStorage = project.ProjectService.Convert(Of ISharePointProject, IVsBuildPropertyStorage)(project)
            projectStorage.SetPropertyValue("MyCustomProperty", String.Empty, CUInt(_PersistStorageType.PST_PROJECT_FILE),
                "Custom property value")
            '</Snippet13>
        End Sub
    End Class
End Namespace
'</Snippet3>

