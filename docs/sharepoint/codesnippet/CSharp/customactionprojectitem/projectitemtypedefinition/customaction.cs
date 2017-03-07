//<Snippet1>
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;

namespace Contoso.SharePointProjectItems.CustomAction
{
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(ISharePointProjectItemTypeProvider))]

    // Specifies the ID for this new project item type. This string must match the value of the 
    // Type attribute of the ProjectItem element in the .spdata file for the project item.
    [SharePointProjectItemType("Contoso.CustomAction")]

    // Specifies the icon to display with this project item in Solution Explorer.
    [SharePointProjectItemIcon("ProjectItemDefinition.CustomAction_SolutionExplorer.ico")]

    // Defines a new type of project item that can be used to create a custom action on a SharePoint site.
    internal partial class CustomActionProjectItemTypeProvider : ISharePointProjectItemTypeProvider
    {
        // Implements IProjectItemTypeProvider.InitializeType. Configures the behavior of the project item type.
        public void InitializeType(ISharePointProjectItemTypeDefinition projectItemTypeDefinition)
        {
            projectItemTypeDefinition.Name = "CustomAction";
            projectItemTypeDefinition.SupportedDeploymentScopes =
                SupportedDeploymentScopes.Site | SupportedDeploymentScopes.Web;
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All;

            projectItemTypeDefinition.ProjectItemNameChanged += ProjectItemNameChanged;
            projectItemTypeDefinition.ProjectItemMenuItemsRequested += ProjectItemMenuItemsRequested;
        }

        private const string designerMenuItemText = "View Custom Action Designer";

        private void ProjectItemMenuItemsRequested(object sender, SharePointProjectItemMenuItemsRequestedEventArgs e)
        {
            e.ViewMenuItems.Add(designerMenuItemText).Click += MenuItemClick;
        }

        private void MenuItemClick(object sender, MenuItemEventArgs e)
        {
            ISharePointProjectItem projectItem = (ISharePointProjectItem)e.Owner;
            string message = String.Format("You clicked the menu on the {0} item. " +
                "You could perform some related task here, such as displaying a designer " +
                "for the custom action.", projectItem.Name);
            System.Windows.Forms.MessageBox.Show(message, "Contoso Custom Action");
        }

        private void ProjectItemNameChanged(object sender, NameChangedEventArgs e)
        {
            ISharePointProjectItem projectItem = (ISharePointProjectItem)sender;
            string message = String.Format("The name of the {0} item changed to: {1}",
                e.OldName, projectItem.Name);
            projectItem.Project.ProjectService.Logger.WriteLine(message, LogCategory.Message);
        }
    }
}
//</Snippet1>
