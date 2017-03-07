//<Snippet2>
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Deployment;
using System.ComponentModel.Composition;

namespace Contoso.DeploymentSteps.Upgrade
{
    // Enables Visual Studio to discover and load this project-level extension.
    [Export(typeof(ISharePointProjectExtension))]

    // Defines a project-level extension. The extension creates a new deployment configuration that includes the
    // upgrade deployment step.
    internal class DeploymentConfigurationExtension : ISharePointProjectExtension
    {
        // Implements ISharePointProjectExtension.Initialize.
        public void Initialize(ISharePointProjectService projectService)
        {
            projectService.ProjectInitialized += ProjectInitialized;
        }

        // Creates the new deployment configuration.
        private void ProjectInitialized(object sender, SharePointProjectEventArgs e)
        {
            string[] deploymentSteps = new string[] 
            {
                DeploymentStepIds.PreDeploymentCommand,
                DeploymentStepIds.RecycleApplicationPool,
                "Contoso.DeploymentSteps.UpgradeSolution",
                DeploymentStepIds.PostDeploymentCommand 
            };

            string[] retractionSteps = new string[] 
            {
                DeploymentStepIds.RecycleApplicationPool,
                DeploymentStepIds.RetractSolution                
            };

            IDeploymentConfiguration configuration = e.Project.DeploymentConfigurations.Add(
                "Upgrade", deploymentSteps, retractionSteps);
            configuration.Description = "This is the upgrade deployment configuration";
        }
    }
}
//</Snippet2>