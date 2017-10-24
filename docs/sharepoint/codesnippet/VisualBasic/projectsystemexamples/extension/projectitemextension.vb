'<Snippet1>
Imports Microsoft.VisualStudio.SharePoint
Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Composition

Namespace Contoso.ExampleProjectItemExtension

    <Export(GetType(ISharePointProjectItemTypeExtension))> _
    <SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.EventHandler")> _
    Friend Class ExampleProjectItemExtension
        Implements ISharePointProjectItemTypeExtension

        Private Sub Initialize(ByVal projectItemType As ISharePointProjectItemType) _
            Implements ISharePointProjectItemTypeExtension.Initialize
            AddHandler projectItemType.ProjectItemAdded, AddressOf ProjectItemAdded
        End Sub

        Private Sub ProjectItemAdded(ByVal Sender As Object, ByVal e As SharePointProjectItemEventArgs)
            Dim projectItem As ISharePointProjectItem = CType(Sender, ISharePointProjectItem)
            Dim Message As String = String.Format("An Event Handler project item named {0} was added to the {1} project.", _
                projectItem.Name, projectItem.Project.Name)
            projectItem.Project.ProjectService.Logger.WriteLine(Message, LogCategory.Message)
        End Sub
    End Class
End Namespace
'</Snippet1>
