'<Snippet1>
Imports System
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Deployment
Imports System.ComponentModel.Composition

Namespace Contoso.DeploymentSteps.Upgrade

    ' Export attribute: Enables Visual Studio to discover and load this deployment step.
    ' DeploymentStep attribute: Specifies the ID for this new deployment step.
    ' UpgradeStep class: Defines a new deployment step that can be used to upgrade a solution 
    '     on a SharePoint site.
    <Export(GetType(IDeploymentStep))> _
    <DeploymentStep("Contoso.DeploymentSteps.UpgradeSolution")> _
    Friend Class UpgradeStep
        Implements IDeploymentStep

        Private solutionName As String
        Private solutionFullPath As String

        Private Sub Initialize(ByVal stepInfo As IDeploymentStepInfo) _
            Implements IDeploymentStep.Initialize
            stepInfo.Name = "Upgrade solution"
            stepInfo.StatusBarMessage = "Upgrading solution..."
            stepInfo.Description = "Upgrades the solution on the local machine."
        End Sub

        ' Specifies whether the solution can be upgraded.
        Private Function CanExecute(ByVal context As IDeploymentContext) As Boolean _
            Implements IDeploymentStep.CanExecute

            ' SharePoint returns all the installed solutions names in lower case.
            solutionName = (context.Project.Package.Model.Name & ".wsp").ToLower()
            solutionFullPath = context.Project.Package.OutputPath
            Dim solutionExists As Boolean = _
                context.Project.SharePointConnection.ExecuteCommand(Of String, Boolean)(
                "Contoso.Commands.IsSolutionDeployed", solutionName)

            ' Throw exceptions in error cases because deployment cannot proceed.
            If context.Project.IsSandboxedSolution = True Then
                Dim sandboxMessage As String = "Cannot upgrade the solution. Upgrade deployment " & _
                    "configuration does not support Sandboxed solutions."
                context.Logger.WriteLine(sandboxMessage, LogCategory.Error)
                Throw New InvalidOperationException()
            ElseIf solutionExists = False Then
                Dim notDeployedMessage As String = String.Format("Cannot upgrade the solution. The IsSolutionDeployed " & _
                    "command cannot find the following solution on the SharePoint site: {0}.", solutionName)
                context.Logger.WriteLine(notDeployedMessage, LogCategory.Error)
                Throw New InvalidOperationException(notDeployedMessage)
            End If

            ' Execute step and continue with deployment.
            Return True
        End Function

        '<Snippet6>
        Private Sub Execute(ByVal context As IDeploymentContext) _
            Implements IDeploymentStep.Execute
            context.Logger.WriteLine("Upgrading solution: " & solutionName, LogCategory.Status)
            context.Project.SharePointConnection.ExecuteCommand("Contoso.Commands.UpgradeSolution", _
                solutionFullPath)
        End Sub
        '</Snippet6>

    End Class
End Namespace
'</Snippet1>
