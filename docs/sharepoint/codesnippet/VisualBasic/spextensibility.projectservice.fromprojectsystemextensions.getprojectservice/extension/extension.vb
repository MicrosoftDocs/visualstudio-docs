Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Composition
Imports System.Threading
Imports Microsoft.VisualStudio.SharePoint

Namespace GetProjectService

    '<Snippet1>
    <Export(GetType(ISharePointProjectExtension))> _
    Friend Class GetServiceInProject
        Implements ISharePointProjectExtension

        Private Sub Initialize(ByVal projectService As ISharePointProjectService) _
            Implements ISharePointProjectExtension.Initialize
            projectService.Logger.WriteLine("This message was written by using the " & _
                "project service in a project extension.", LogCategory.Message)
        End Sub
    End Class
    '</Snippet1>

    '<Snippet2>
    <Export(GetType(ISharePointProjectItemTypeExtension))> _
    <SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListDefinition")> _
    Friend Class GetServiceInProjectItem
        Implements ISharePointProjectItemTypeExtension

        Private Sub Initialize(ByVal projectItemType As ISharePointProjectItemType) _
            Implements ISharePointProjectItemTypeExtension.Initialize
            projectItemType.ProjectService.Logger.WriteLine("This message was written " & _
                "by using the project service in an extension for the ListDefinition project item.", _
                LogCategory.Message)
        End Sub
    End Class
    '</Snippet2>

    '<Snippet3>
    <Export(GetType(ISharePointProjectItemTypeProvider))> _
    <SharePointProjectItemType("Contoso.CustomAction")> _
    Friend Class CustomActionProvider
        Implements ISharePointProjectItemTypeProvider

        Private Sub InitializeType(ByVal projectItemTypeDefinition As ISharePointProjectItemTypeDefinition) _
            Implements ISharePointProjectItemTypeProvider.InitializeType
            projectItemTypeDefinition.ProjectService.Logger.WriteLine("This message was written " & _
                "by using the project service in the Custom Action project item type.", _
                LogCategory.Message)
        End Sub
    End Class
    '</Snippet3>

End Namespace
