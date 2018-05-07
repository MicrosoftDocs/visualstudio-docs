'<Snippet10>
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Explorer
Imports Microsoft.VisualStudio.SharePoint.Explorer.Extensions

Namespace Contoso.ServerExplorerExtension
    <Export(GetType(IExplorerNodeTypeExtension))> _
    <ExplorerNodeType(ExtensionNodeTypes.ListNode)> _
    Friend Class ListNodeExtension
        Implements IExplorerNodeTypeExtension

        Private projectService As ISharePointProjectService
        Private dteObject As EnvDTE.DTE

        Private Sub Initialize(ByVal nodeType As IExplorerNodeType) _
            Implements IExplorerNodeTypeExtension.Initialize
            AddHandler nodeType.NodeMenuItemsRequested, AddressOf NodeMenuItemsRequested
        End Sub

        Private Sub NodeMenuItemsRequested(ByVal Sender As Object, ByVal e As ExplorerNodeMenuItemsRequestedEventArgs)
            Dim menuItem = e.MenuItems.Add("View in Visual Studio")
            AddHandler menuItem.Click, AddressOf MenuItemClick
        End Sub

        Private Sub MenuItemClick(ByVal Sender As Object, ByVal e As MenuItemEventArgs)

            ' Get the data for the list node.
            Dim node As IExplorerNode = CType(e.Owner, IExplorerNode)
            '<Snippet11>
            Dim nodeInfo As IListNodeInfo = node.Annotations.GetValue(Of IListNodeInfo)()
            '</Snippet11>

            If dteObject Is Nothing Then

                If projectService Is Nothing Then
                    projectService = CType(node.ServiceProvider.GetService(GetType(ISharePointProjectService)), 
                        ISharePointProjectService)
                End If
                dteObject = CType(projectService.ServiceProvider.GetService(GetType(EnvDTE.DTE)), EnvDTE.DTE)
            End If

            dteObject.ItemOperations.Navigate(nodeInfo.DefaultViewUrl.ToString(),
                EnvDTE.vsNavigateOptions.vsNavigateOptionsNewWindow)
        End Sub
    End Class
End Namespace
'</Snippet10>

