Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Explorer
Imports Microsoft.VisualStudio.SharePoint.Explorer.Extensions

Namespace Contoso.ServerExplorerExtension

    '<Snippet1>
    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExtensionNodeTypes.ListNode)> _
    Friend Class ListNodeExtension
        Implements IExplorerNodeTypeExtension

        Private projectService As ISharePointProjectService

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize
            AddHandler nodeType.NodeMenuItemsRequested, AddressOf nodeType_NodeMenuItemsRequested
        End Sub

        Private Sub nodeType_NodeMenuItemsRequested(ByVal Sender As Object, ByVal e As ExplorerNodeMenuItemsRequestedEventArgs)
            Dim writeMessageMenuItem As IMenuItem = e.MenuItems.Add("Write Message to Output Window and Error List Window")
            AddHandler writeMessageMenuItem.Click, AddressOf writeMessageMenuItem_Click
        End Sub

        Private Sub writeMessageMenuItem_Click(ByVal Sender As Object, ByVal e As MenuItemEventArgs)
            Dim node As IExplorerNode = CType(e.Owner, IExplorerNode)
            If projectService Is Nothing Then
                projectService = CType(node.ServiceProvider.GetService(GetType(ISharePointProjectService)), ISharePointProjectService)
            End If
            projectService.Logger.WriteLine("Clicked the menu item for " + node.Text, LogCategory.Message)
        End Sub
    End Class
    '</Snippet1>
End Namespace
