'<Snippet2>
Imports System
Imports System.ComponentModel.Composition
Imports Microsoft.VisualStudio.SharePoint

Namespace Contoso.ExampleProjectItemType

    <Export(GetType(ISharePointProjectItemTypeProvider))> _
    <SharePointProjectItemType("Contoso.ExampleProjectItemType")> _
    <SharePointProjectItemIcon("ExampleProjectItemType.ProjectItemIcon.ico")> _
    Friend Class ExampleProjectItemType
        Implements ISharePointProjectItemTypeProvider

        Private Sub InitializeType(ByVal projectItemTypeDefinition As ISharePointProjectItemTypeDefinition) _
            Implements ISharePointProjectItemTypeProvider.InitializeType
            projectItemTypeDefinition.Name = "ExampleProjectItemType"
            projectItemTypeDefinition.SupportedDeploymentScopes = _
                SupportedDeploymentScopes.Site Or SupportedDeploymentScopes.Web
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All
            AddHandler projectItemTypeDefinition.ProjectItemAdded, AddressOf ProjectItemAdded
        End Sub

        Private Sub ProjectItemAdded(ByVal Sender As Object, ByVal e As SharePointProjectItemEventArgs)
            Dim Message As String = String.Format("An example project item named {0} was added to the {1} project.", _
                e.ProjectItem.Name, e.ProjectItem.Project.Name)
            e.ProjectItem.Project.ProjectService.Logger.WriteLine(Message, LogCategory.Message)
        End Sub
    End Class
End Namespace
'</Snippet2>
