'<Snippet2>
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Deployment
Imports System.ComponentModel.Composition

Namespace Contoso.DeploymentSteps.Upgrade

    ' Export attribute: Enables Visual Studio to discover and load this project-level extension.
    ' DeploymentConfigurationExtension class: Defines a project-level extension. The extension creates 
    '     a new deployment configuration that includes the upgrade deployment step.
    <Export(GetType(ISharePointProjectExtension))> _
    Friend Class DeploymentConfigurationExtension
        Implements ISharePointProjectExtension

        Private Sub Initialize(ByVal projectService As ISharePointProjectService) _
            Implements ISharePointProjectExtension.Initialize
            AddHandler projectService.ProjectInitialized, AddressOf ProjectInitialized
        End Sub

        ' Creates the new deployment configuration.
        Private Sub ProjectInitialized(ByVal Sender As Object, ByVal e As SharePointProjectEventArgs)
            Dim deploymentSteps As String() = New String() _
            {
                DeploymentStepIds.PreDeploymentCommand, _
                DeploymentStepIds.RecycleApplicationPool, _
                "Contoso.DeploymentSteps.UpgradeSolution", _
                DeploymentStepIds.PostDeploymentCommand _
            }
            Dim retractionSteps As String() = New String() _
            {
                DeploymentStepIds.RecycleApplicationPool, _
                DeploymentStepIds.RetractSolution
            }
            Dim configuration As IDeploymentConfiguration = e.Project.DeploymentConfigurations.Add( _
                "Upgrade", deploymentSteps, retractionSteps)
            configuration.Description = "This is the upgrade deployment configuration"
        End Sub

    End Class
End Namespace
'</Snippet2>