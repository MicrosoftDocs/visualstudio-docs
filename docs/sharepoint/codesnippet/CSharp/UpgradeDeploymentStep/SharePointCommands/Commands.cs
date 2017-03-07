//<Snippet4>
using System;
using System.IO;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.VisualStudio.SharePoint.Commands;

namespace Contoso.DeploymentSteps.Upgrade
{
    internal class Commands
    {
        // Determines whether the specified solution has been deployed to the local SharePoint server.
        [SharePointCommand("Contoso.Commands.IsSolutionDeployed")]
        private bool IsSolutionDeployed(ISharePointCommandContext context, string solutionName)
        {
            SPSolution solution = SPFarm.Local.Solutions[solutionName];
            return solution != null;
        }

        // Upgrades the specified solution to the local SharePoint server.
        //<Snippet5>
        [SharePointCommand("Contoso.Commands.UpgradeSolution")]
        private void UpgradeSolution(ISharePointCommandContext context, string fullWspPath)
        {
            SPSolution solution = SPFarm.Local.Solutions[Path.GetFileName(fullWspPath)];

            if (solution == null)
            {
                throw new InvalidOperationException("The solution has not been deployed.");
            }

            solution.Upgrade(fullWspPath);
        }
        //</Snippet5>
    }
}
//</Snippet4>
