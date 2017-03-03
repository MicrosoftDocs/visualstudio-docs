'<Snippet4>
Imports System
Imports Microsoft.VisualStudio.SharePoint
Imports Microsoft.VisualStudio.SharePoint.Deployment
Imports System.ComponentModel.Composition

Namespace Contoso.ListInstanceDeploymentExtension

    <Export(GetType(ISharePointProjectItemTypeExtension))> _
    <SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListInstance")> _
    Friend Class ExampleDeploymentStepExtension
        Implements ISharePointProjectItemTypeExtension

        Private Sub Initialize(ByVal projectItemType As ISharePointProjectItemType) _
            Implements ISharePointProjectItemTypeExtension.Initialize
            AddHandler projectItemType.DeploymentStepStarted, AddressOf DeploymentStepStarted
            AddHandler projectItemType.DeploymentStepCompleted, AddressOf DeploymentStepCompleted
        End Sub

        Private Sub DeploymentStepStarted(ByVal Sender As Object, ByVal e As DeploymentStepStartedEventArgs)
            If e.DeploymentStepInfo.Id = DeploymentStepIds.RecycleApplicationPool AndAlso
                e.DeploymentContext.IsDeploying Then
                e.DeploymentContext.Logger.WriteLine("The application pool is about to be " &
                    "recycled while the solution is being deployed.", LogCategory.Status)
            End If
        End Sub

        Private Sub DeploymentStepCompleted(ByVal Sender As Object, ByVal e As DeploymentStepCompletedEventArgs)
            If e.DeploymentStepInfo.Id = DeploymentStepIds.RecycleApplicationPool AndAlso
                e.DeploymentContext.IsRetracting Then
                e.DeploymentContext.Logger.WriteLine("The application pool was " &
                    "recycled while the solution is being retracted.", LogCategory.Status)
            End If
        End Sub
    End Class
End Namespace
'</Snippet4>

