//<Snippet10>
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;
using Microsoft.VisualStudio.SharePoint.Explorer.Extensions;

namespace Contoso.ServerExplorerExtension
{
    [Export(typeof(IExplorerNodeTypeExtension))]
    [ExplorerNodeType(ExtensionNodeTypes.ListNode)]
    internal class ListNodeExtension : IExplorerNodeTypeExtension
    {
        private ISharePointProjectService projectService;
        private EnvDTE.DTE dteObject;

        public void Initialize(IExplorerNodeType nodeType)
        {
            nodeType.NodeMenuItemsRequested += nodeType_NodeMenuItemsRequested;
        }

        void nodeType_NodeMenuItemsRequested(object sender, ExplorerNodeMenuItemsRequestedEventArgs e)
        {
            IMenuItem menuItem = e.MenuItems.Add("View in Visual Studio");
            menuItem.Click += menuItem_Click;
        }

        void menuItem_Click(object sender, MenuItemEventArgs e)
        {
            // Get the data for the list node.
            IExplorerNode node = (IExplorerNode)e.Owner;
            //<Snippet11>
            IListNodeInfo nodeInfo = node.Annotations.GetValue<IListNodeInfo>();
            //</Snippet11>

            if (dteObject == null)
            {
                if (projectService == null)
                {
                    projectService = (ISharePointProjectService)node.ServiceProvider.GetService(
                        typeof(ISharePointProjectService));
                }

                dteObject = (EnvDTE.DTE)projectService.ServiceProvider.GetService(typeof(EnvDTE.DTE));
            }

            dteObject.ItemOperations.Navigate(nodeInfo.DefaultViewUrl.ToString(), 
                EnvDTE.vsNavigateOptions.vsNavigateOptionsNewWindow);
        }
    }
}
//</Snippet10>
