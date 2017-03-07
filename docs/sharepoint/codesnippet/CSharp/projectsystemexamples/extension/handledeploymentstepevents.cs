//<Snippet4>
using System;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Deployment;
using System.ComponentModel.Composition;

namespace Contoso.ListInstanceDeploymentExtension
{
    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListInstance")]
    internal class ExampleDeploymentStepExtension : ISharePointProjectItemTypeExtension
    {
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.DeploymentStepStarted += DeploymentStepStarted;
            projectItemType.DeploymentStepCompleted += DeploymentStepCompleted;
        }

        private void DeploymentStepStarted(object sender, DeploymentStepStartedEventArgs e)
        {
            if (e.DeploymentStepInfo.Id == DeploymentStepIds.RecycleApplicationPool &&
                e.DeploymentContext.IsDeploying)
            {
                e.DeploymentContext.Logger.WriteLine("The application pool is about to be " +
                    "recycled while the solution is being deployed.", LogCategory.Status);
            }
        }

        private void DeploymentStepCompleted(object sender, DeploymentStepCompletedEventArgs e)
        {
            if (e.DeploymentStepInfo.Id == DeploymentStepIds.RecycleApplicationPool &&
                e.DeploymentContext.IsRetracting)
            {
                e.DeploymentContext.Logger.WriteLine("The application pool was " +
                    "recycled while the solution is being retracted.", LogCategory.Status);
            }
        }
    }
}
//</Snippet4>
