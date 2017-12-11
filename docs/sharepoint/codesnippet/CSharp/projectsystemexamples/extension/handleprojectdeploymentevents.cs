//<Snippet12>
using System;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Deployment;
using System.ComponentModel.Composition;

namespace Contoso.ProjectDeploymentExtension
{
    [Export(typeof(ISharePointProjectExtension))]
    internal class ExampleProjectDeploymentExtension : ISharePointProjectExtension
    {
        public void Initialize(ISharePointProjectService projectService)
        {
            projectService.DeploymentStarted += ProjectService_DeploymentStarted;
            projectService.DeploymentCompleted += ProjectService_DeploymentCompleted;
        }

        void ProjectService_DeploymentStarted(object sender, DeploymentEventArgs e)
        {
            if (e.DeploymentContext.IsDeploying)
            {
                string message = String.Format("Deployment started for the {0} project.",
                     e.Project.Name);
                e.DeploymentContext.Logger.WriteLine(message, LogCategory.Status);
            }
        }

        void ProjectService_DeploymentCompleted(object sender, DeploymentEventArgs e)
        {
            if (e.DeploymentContext.IsDeploying)
            {
                string message = String.Format("Deployment completed for the {0} project.",
                     e.Project.Name);
                e.DeploymentContext.Logger.WriteLine(message, LogCategory.Status);
            }
        }
    }
}
//</Snippet12>