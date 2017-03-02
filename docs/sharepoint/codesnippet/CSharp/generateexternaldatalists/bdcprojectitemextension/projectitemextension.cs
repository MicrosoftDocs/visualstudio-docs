//<Snippet1>
using Microsoft.VisualStudio.SharePoint;
using System.ComponentModel.Composition;

namespace Contoso.SharePointProjectItemExtensions.GenerateExternalDataLists
{
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(ISharePointProjectItemTypeExtension))]

    // Specifies the ID of the project item to extend.
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.BusinessDataConnectivity")]

    // Defines the extension for the BDC project item. The other part of the partial class contains
    // the logic for generating the external data lists. 
    internal partial class GenerateExternalDataListsExtension : ISharePointProjectItemTypeExtension
    {
        // Implements IProjectItemTypeExtension.Initialize. Creates the new shortcut menu item that
        // the user clicks to generate the external data lists.
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.ProjectItemMenuItemsRequested += ProjectItemMenuItemsRequested;
        }

        private void ProjectItemMenuItemsRequested(object sender, SharePointProjectItemMenuItemsRequestedEventArgs e)
        {
            e.ViewMenuItems.Add("Generate External Data List").Click += GenerateExternalDataLists_Execute;
        }
    }
}
//</Snippet1>

