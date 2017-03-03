'<Snippet4>
Imports System
Imports System.IO
Imports Microsoft.SharePoint
Imports Microsoft.SharePoint.Administration
Imports Microsoft.VisualStudio.SharePoint.Commands

Namespace Contoso.DeploymentSteps.Upgrade

    Friend Class Commands

        ' Determines whether the specified solution has been deployed to the local SharePoint server.
        <SharePointCommand("Contoso.Commands.IsSolutionDeployed")> _
        Private Function IsSolutionDeployed(ByVal context As ISharePointCommandContext, ByVal solutionName As String) As Boolean
            Dim solution As SPSolution = SPFarm.Local.Solutions(solutionName)
            Return solution IsNot Nothing
        End Function

        ' Upgrades the specified solution to the local SharePoint server.
        '<Snippet5>
        <SharePointCommand("Contoso.Commands.UpgradeSolution")> _
        Private Sub UpgradeSolution(ByVal context As ISharePointCommandContext, ByVal fullWspPath As String)
            Dim solution As SPSolution = SPFarm.Local.Solutions(Path.GetFileName(fullWspPath))
            If solution Is Nothing Then
                Throw New InvalidOperationException("The solution has not been deployed.")
            End If
            solution.Upgrade(fullWspPath)
        End Sub
        '</Snippet5>

    End Class
End Namespace
'</Snippet4>

