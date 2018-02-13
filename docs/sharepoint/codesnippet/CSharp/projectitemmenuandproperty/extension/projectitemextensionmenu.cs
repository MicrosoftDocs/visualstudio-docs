//<Snippet1>
using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;

namespace Contoso.Examples.ProjectItemExtensionWithMenu
{
    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.EventHandler")]
    internal class ExampleProjectItemExtensionWithMenu : ISharePointProjectItemTypeExtension
    {
        //<Snippet2>
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.ProjectItemMenuItemsRequested += projectItemType_ProjectItemMenuItemsRequested;
        }
        //</Snippet2>

        //<Snippet3>
        void projectItemType_ProjectItemMenuItemsRequested(object sender, 
            SharePointProjectItemMenuItemsRequestedEventArgs e)
        {
            IMenuItem menuItem = e.ViewMenuItems.Add("Write Message to Output Window");
            menuItem.Click += MenuItemExtension_Click;
        }
        //</Snippet3>

        void MenuItemExtension_Click(object sender, MenuItemEventArgs e)
        {
            ISharePointProjectItem projectItem = (ISharePointProjectItem)e.Owner;
            projectItem.Project.ProjectService.Logger.WriteLine(
                String.Format("This message was written from a shortcut menu for {0}.", projectItem.Name), 
                LogCategory.Status);
        }
    }
}
//</Snippet1>