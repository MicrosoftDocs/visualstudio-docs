'<Snippet1>
Imports System
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint

Namespace Contoso.Examples

    <Export(GetType(ISharePointProjectExtension))> _
    Friend Class ExampleProjectExtensionWithMenu
        Implements ISharePointProjectExtension

        Private Sub Initialize(ByVal projectService As ISharePointProjectService) _
            Implements ISharePointProjectExtension.Initialize
            AddHandler projectService.ProjectMenuItemsRequested, AddressOf ProjectMenuItemsRequested
        End Sub

        Private Sub ProjectMenuItemsRequested(ByVal Sender As Object,
            ByVal e As SharePointProjectMenuItemsRequestedEventArgs)
            Dim menuItem As IMenuItem = e.ActionMenuItems.Add("Write Message to Output Window")
            AddHandler menuItem.Click, AddressOf MenuItem_Click
        End Sub

        Private Sub MenuItem_Click(ByVal Sender As Object, ByVal e As MenuItemEventArgs)
            Dim project As ISharePointProject = TryCast(e.Owner, ISharePointProject)
            If project IsNot Nothing Then
                project.ProjectService.Logger.WriteLine(
                    String.Format("This message was written from a shortcut menu for the {0} project.", project.Name),
                    LogCategory.Status)
            End If
        End Sub
    End Class
End Namespace
'</Snippet1>

