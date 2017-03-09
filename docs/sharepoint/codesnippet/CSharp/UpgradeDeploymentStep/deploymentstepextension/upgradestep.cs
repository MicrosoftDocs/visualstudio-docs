//<Snippet1>
using System;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Deployment;
using System.ComponentModel.Composition;

namespace Contoso.DeploymentSteps.Upgrade
{
    // Enables Visual Studio to discover and load this deployment step.
    [Export(typeof(IDeploymentStep))]

    // Specifies the ID for this new deployment step.
    [DeploymentStep("Contoso.DeploymentSteps.UpgradeSolution")]

    // Defines a new deployment step that can be used to upgrade a solution on a SharePoint site.
    internal class UpgradeStep : IDeploymentStep
    {
        private string solutionName;
        private string solutionFullPath;

        // Implements IDeploymentStep.Initialize.
        public void Initialize(IDeploymentStepInfo stepInfo)
        {
            stepInfo.Name = "Upgrade solution";
            stepInfo.StatusBarMessage = "Upgrading solution...";
            stepInfo.Description = "Upgrades the solution on the local machine.";
        }

        // Implements IDeploymentStep.CanExecute. Specifies whether the solution can be upgraded.
        public bool CanExecute(IDeploymentContext context)
        {
            // SharePoint returns all the installed solutions names in lower case.
            solutionName = (context.Project.Package.Model.Name + ".wsp").ToLower();
            solutionFullPath = context.Project.Package.OutputPath;
            bool solutionExists = context.Project.SharePointConnection.ExecuteCommand<string, bool>(
                "Contoso.Commands.IsSolutionDeployed", solutionName);

            // Throw exceptions in error cases because deployment cannot proceed.
            if (context.Project.IsSandboxedSolution)
            {
                string sandboxMessage = "Cannot upgrade the solution. The upgrade deployment configuration " +
                    "does not support Sandboxed solutions.";
                context.Logger.WriteLine(sandboxMessage, LogCategory.Error);
                throw new InvalidOperationException(sandboxMessage);
            }
            else if (!solutionExists)
            {
                string notDeployedMessage = string.Format("Cannot upgrade the solution. The IsSolutionDeployed " +
                    "command cannot find the following solution: {0}.", solutionName);
                context.Logger.WriteLine(notDeployedMessage, LogCategory.Error);
                throw new InvalidOperationException(notDeployedMessage);
            }

            // Execute step and continue with deployment.
            return true;
        }

        // Implements IDeploymentStep.Execute.
        //<Snippet6>
        public void Execute(IDeploymentContext context)
        {
            context.Logger.WriteLine("Upgrading solution: " + solutionName, LogCategory.Status);
            context.Project.SharePointConnection.ExecuteCommand("Contoso.Commands.UpgradeSolution",
                solutionFullPath);
        }
        //</Snippet6>
    }
}
//</Snippet1>
