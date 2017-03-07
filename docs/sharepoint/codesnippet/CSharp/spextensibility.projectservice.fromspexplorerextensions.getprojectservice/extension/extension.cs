using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;
using Microsoft.VisualStudio.SharePoint.Explorer.Extensions;

namespace Contoso.ServerExplorerExtension
{
    //<Snippet1>
    [Export(typeof(IExplorerNodeTypeExtension))]
    [ExplorerNodeType(ExtensionNodeTypes.ListNode)]
    internal class ListNodeExtension : IExplorerNodeTypeExtension
    {
        private ISharePointProjectService projectService;

        public void Initialize(IExplorerNodeType nodeType)
        {
            nodeType.NodeMenuItemsRequested += nodeType_NodeMenuItemsRequested;
        }

        void nodeType_NodeMenuItemsRequested(object sender, ExplorerNodeMenuItemsRequestedEventArgs e)
        {
            IMenuItem writeMessageMenuItem = e.MenuItems.Add("Write Message to Output Window and Error List Window");
            writeMessageMenuItem.Click += writeMessageMenuItem_Click;
        }

        void writeMessageMenuItem_Click(object sender, MenuItemEventArgs e)
        {
            IExplorerNode node = (IExplorerNode)e.Owner;
            if (projectService == null)
            {
                projectService = (ISharePointProjectService)node.ServiceProvider.GetService(typeof(ISharePointProjectService));
            }

            projectService.Logger.WriteLine("Clicked the menu item for " + node.Text, LogCategory.Message);
        }
    }
    //</Snippet1>
}
