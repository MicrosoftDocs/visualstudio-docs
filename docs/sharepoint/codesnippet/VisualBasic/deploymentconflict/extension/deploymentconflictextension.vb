'<Snippet1>
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Deployment
Imports System.ComponentModel.Composition

<Export(GetType(ISharePointProjectItemTypeExtension))>
<SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListDefinition")>
Public Class DeploymentConflictExtension
    Implements ISharePointProjectItemTypeExtension

    Private Sub Initialize(ByVal projectItemType As ISharePointProjectItemType) _
    Implements ISharePointProjectItemTypeExtension.Initialize
        AddHandler projectItemType.DeploymentStepStarted, AddressOf DeploymentStepStarted
    End Sub

    Private Sub DeploymentStepStarted(ByVal Sender As Object, ByVal e As DeploymentStepStartedEventArgs)
        If e.DeploymentStepInfo.Id = DeploymentStepIds.AddSolution Then
            e.Conflicts.Add("This is an example conflict", AddressOf Me.Resolve, True)
            e.ProjectItem.Project.ProjectService.Logger.WriteLine("Added new example conflict.", LogCategory.Status)
        End If
    End Sub

    Private Function Resolve(ByVal projectItem As ISharePointProjectItem) As Boolean
        projectItem.Project.ProjectService.Logger.WriteLine("Returning 'true' from Resolve method for example conflict.",
            LogCategory.Status)
        Return True
    End Function
End Class
'</Snippet1>
