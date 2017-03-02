//<Snippet1>
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint.Explorer;

namespace ServerExplorer.SharePointConnections.WebPartNode
{
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(IExplorerNodeTypeExtension))]        

    // Indicates that this class extends SharePoint site nodes in Server Explorer.
    [ExplorerNodeType(ExplorerNodeTypes.SiteNode)]

    // Represents an extension of SharePoint site nodes in Server Explorer.
    internal class SiteNodeExtension : IExplorerNodeTypeExtension
    {
        public void Initialize(IExplorerNodeType nodeType)
        {
            // The NodeChildrenRequested event is raised when the user expands the
            // SharePoint site node in Server Explorer.
            nodeType.NodeChildrenRequested += NodeChildrenRequested;
        }

        // Creates the new Web Part Gallery node with the specified icon.
        private void NodeChildrenRequested(object sender, ExplorerNodeEventArgs e)
        {
            // The CreateWebPartNodes argument is a delegate that Visual Studio calls 
            // to create the child nodes under the Web Part Gallery node.
            e.Node.ChildNodes.AddFolder("Web Part Gallery",
                Properties.Resources.WebPartsNode.ToBitmap(), CreateWebPartNodes);
        }

        // Creates all of the individual Web Part nodes under the new Web Part Gallery node.
        private void CreateWebPartNodes(IExplorerNode parentNode)
        {
            // Call the custom SharePoint command to get items from the Web Part gallery.
            var webParts = parentNode.Context.SharePointConnection.ExecuteCommand<WebPartNodeInfo[]>(
                WebPartCommandIds.GetWebParts);

            if (webParts != null)
            {
                foreach (WebPartNodeInfo webPart in webParts)
                {
                    // Create a new annotation object to store the current Web Part item with the new node.
                    var annotations = new Dictionary<object, object>() 
                    { 
                        { typeof(WebPartNodeInfo), webPart } 
                    };

                    // Create the new node for the current Web Part item.
                    parentNode.ChildNodes.Add(WebPartNodeTypeProvider.WebPartNodeTypeId,
                        webPart.Name, annotations);
                }
            }
        }
    }
}
//</Snippet1>