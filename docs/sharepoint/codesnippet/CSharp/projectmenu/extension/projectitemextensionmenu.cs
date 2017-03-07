//<Snippet1>
using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;

namespace Contoso.Examples
{
    [Export(typeof(ISharePointProjectExtension))]
    internal class ExampleProjectExtensionWithMenu : ISharePointProjectExtension
    {
        public void Initialize(ISharePointProjectService projectService)
        {
            projectService.ProjectMenuItemsRequested += projectService_ProjectMenuItemsRequested;
        }

        void projectService_ProjectMenuItemsRequested(object sender, 
            SharePointProjectMenuItemsRequestedEventArgs e)
        {
            IMenuItem menuItem = e.ActionMenuItems.Add("Write Message to Output Window");
            menuItem.Click += MenuItemExtension_Click;
        }

        void MenuItemExtension_Click(object sender, MenuItemEventArgs e)
        {
            ISharePointProject project = e.Owner as ISharePointProject;
            if (project != null)
            {
                project.ProjectService.Logger.WriteLine(
                    String.Format("This message was written from a shortcut menu for the {0} project.", project.Name),
                    LogCategory.Status);
            }
        }
    }
}
//</Snippet1>