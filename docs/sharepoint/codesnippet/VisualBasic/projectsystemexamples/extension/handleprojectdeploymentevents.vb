'<Snippet12>
Imports System
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Deployment
Imports System.ComponentModel.Composition

Namespace Contoso.ProjectDeploymentExtension

    <Export(GetType(ISharePointProjectExtension))> _
    Friend Class ExampleProjectDeploymentExtension
        Implements ISharePointProjectExtension

        Private Sub Initialize(ByVal projectService As ISharePointProjectService) _
            Implements ISharePointProjectExtension.Initialize
            AddHandler projectService.DeploymentStarted, AddressOf DeploymentStarted
            AddHandler projectService.DeploymentCompleted, AddressOf DeploymentCompleted
        End Sub

        Private Sub DeploymentStarted(ByVal Sender As Object, ByVal e As DeploymentEventArgs)
            If e.DeploymentContext.IsDeploying Then
                Dim message As String = String.Format("Deployment started for the {0} project.", 
                     e.Project.Name)
                e.DeploymentContext.Logger.WriteLine(message, LogCategory.Status)
            End If
        End Sub

        Private Sub DeploymentCompleted(ByVal Sender As Object, ByVal e As DeploymentEventArgs)
            If e.DeploymentContext.IsDeploying Then
                Dim message As String = String.Format("Deployment completed for the {0} project.", 
                    e.Project.Name)
                e.DeploymentContext.Logger.WriteLine(message, LogCategory.Status)
            End If
        End Sub
    End Class
End Namespace
'</Snippet12>

