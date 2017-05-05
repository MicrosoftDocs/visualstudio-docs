'<Snippet4>
Imports System
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint

Namespace Contoso.Examples.ProjectItemTypeWithMenu

    <Export(GetType(ISharePointProjectItemTypeProvider))> _
    <SharePointProjectItemType("Contoso.ExampleProjectItemType")> _
    <SharePointProjectItemIcon("ExampleProjectItemType.ProjectItemIcon.ico")> _
    Friend Class ExampleProjectItemTypeWithMenu
        Implements ISharePointProjectItemTypeProvider

        '<Snippet5>
        Private Sub InitializeType(ByVal projectItemTypeDefinition As ISharePointProjectItemTypeDefinition) _
            Implements ISharePointProjectItemTypeProvider.InitializeType
            projectItemTypeDefinition.Name = "ExampleProjectItemType"
            projectItemTypeDefinition.SupportedDeploymentScopes = _
                SupportedDeploymentScopes.Site Or SupportedDeploymentScopes.Web
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All

            AddHandler projectItemTypeDefinition.ProjectItemMenuItemsRequested, AddressOf ProjectItemMenuItemsRequested
        End Sub
        '</Snippet5>

        '<Snippet6>
        Private Sub ProjectItemMenuItemsRequested(ByVal Sender As Object,
            ByVal e As SharePointProjectItemMenuItemsRequestedEventArgs)
            Dim menuItem As IMenuItem = e.ViewMenuItems.Add("Write Message to Output Window")
            AddHandler menuItem.Click, AddressOf MenuItem_Click
        End Sub
        '</Snippet6>

        Private Sub MenuItem_Click(ByVal Sender As Object, ByVal e As MenuItemEventArgs)
            Dim projectItem As ISharePointProjectItem = CType(e.Owner, ISharePointProjectItem)
            projectItem.Project.ProjectService.Logger.WriteLine(
                String.Format("This message was written from a shortcut menu for {0}.", projectItem.Name),
                LogCategory.Status)
        End Sub
    End Class
End Namespace
'</Snippet4>
