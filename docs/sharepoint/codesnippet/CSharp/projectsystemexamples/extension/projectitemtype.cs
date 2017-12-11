//<Snippet2>
using System;
using Microsoft.VisualStudio.SharePoint;
using System.ComponentModel.Composition;

namespace Contoso.ExampleProjectItemType
{
    [Export(typeof(ISharePointProjectItemTypeProvider))]
    [SharePointProjectItemType("Contoso.ExampleProjectItemType")]
    [SharePointProjectItemIcon("ExampleProjectItemType.ProjectItemIcon.ico")]
    internal class ExampleProjectItemType : ISharePointProjectItemTypeProvider
    {
        public void InitializeType(ISharePointProjectItemTypeDefinition projectItemTypeDefinition)
        {
            projectItemTypeDefinition.Name = "ExampleProjectItemType";
            projectItemTypeDefinition.SupportedDeploymentScopes =
                SupportedDeploymentScopes.Site | SupportedDeploymentScopes.Web;
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All;
            projectItemTypeDefinition.ProjectItemAdded += projectItemTypeDefinition_ProjectItemAdded;
        }

        void projectItemTypeDefinition_ProjectItemAdded(object sender, SharePointProjectItemEventArgs e)
        {
            string message = String.Format("An example project item named {0} was added to the {1} project.",
                e.ProjectItem.Name, e.ProjectItem.Project.Name);
            e.ProjectItem.Project.ProjectService.Logger.WriteLine(message, LogCategory.Message);
        }
    }
}
//</Snippet2>
