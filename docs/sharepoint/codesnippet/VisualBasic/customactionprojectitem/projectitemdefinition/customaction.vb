'<Snippet1>
Imports System
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint

Namespace Contoso.SharePointProjectItems.CustomAction

    ' Export attribute: Enables Visual Studio to discover and load this extension.
    ' SharePointProjectItemType attribute: Specifies the ID for this new project item type. This string must 
    '     match the value of the Type attribute of the ProjectItem element in the .spdata file for 
    '     the project item.
    ' SharePointProjectItemIcon attribute: Specifies the icon to display with this project item in Solution Explorer.
    ' CustomActionProjectItemTypeProvider class: Defines a new type of project item that can be used to create a custom 
    '     action on a SharePoint site.
    <Export(GetType(ISharePointProjectItemTypeProvider))> _
    <SharePointProjectItemType("Contoso.CustomAction")> _
    <SharePointProjectItemIcon("ProjectItemDefinition.CustomAction_SolutionExplorer.ico")> _
    Partial Friend Class CustomActionProjectItemTypeProvider
        Implements ISharePointProjectItemTypeProvider

        Private WithEvents projectItemTypeDefinition As ISharePointProjectItemTypeDefinition

        ' Configures the behavior of the project item type.
        Private Sub InitializeType(ByVal projectItemTypeDefinition As ISharePointProjectItemTypeDefinition) _
            Implements ISharePointProjectItemTypeProvider.InitializeType

            projectItemTypeDefinition.Name = "CustomAction"
            projectItemTypeDefinition.SupportedDeploymentScopes = _
                SupportedDeploymentScopes.Site Or SupportedDeploymentScopes.Web
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All
            Me.projectItemTypeDefinition = projectItemTypeDefinition
        End Sub

        Private Const DesignerMenuItemText As String = "View Custom Action Designer"

        Private Sub ProjectItemMenuItemsRequested(ByVal Sender As Object, _
            ByVal e As SharePointProjectItemMenuItemsRequestedEventArgs) _
            Handles projectItemTypeDefinition.ProjectItemMenuItemsRequested

            Dim viewDesignerMenuItem As IMenuItem = e.ViewMenuItems.Add(DesignerMenuItemText)
            AddHandler viewDesignerMenuItem.Click, AddressOf MenuItemClick
        End Sub

        Private Sub MenuItemClick(ByVal Sender As Object, ByVal e As MenuItemEventArgs)
            Dim projectItem As ISharePointProjectItem = CType(e.Owner, ISharePointProjectItem)
            Dim message As String = String.Format("You clicked the menu on the {0} item. " & _
                "You could perform some related task here, such as displaying a designer " & _
                "for the custom action.", projectItem.Name)
            System.Windows.Forms.MessageBox.Show(message, "Contoso Custom Action")
        End Sub

        Private Sub ProjectItemNameChanged(ByVal Sender As Object, ByVal e As NameChangedEventArgs) _
            Handles projectItemTypeDefinition.ProjectItemNameChanged
            Dim projectItem As ISharePointProjectItem = CType(Sender, ISharePointProjectItem)
            Dim message As String = String.Format("The name of the {0} item changed to: {1}", _
                e.OldName, projectItem.Name)
            projectItem.Project.ProjectService.Logger.WriteLine(message, LogCategory.Message)
        End Sub
    End Class
End Namespace
'</Snippet1>

