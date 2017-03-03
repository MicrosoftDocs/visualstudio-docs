//<Snippet2>
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;

namespace ServerExplorer.SharePointConnections.WebPartNode
{
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(IExplorerNodeTypeProvider))]

    // Specifies the ID for this new node type.
    [ExplorerNodeType(WebPartNodeTypeProvider.WebPartNodeTypeId)]

    // Defines a new node type that represents a Web Part on a SharePoint site.
    internal class WebPartNodeTypeProvider : IExplorerNodeTypeProvider
    {
        internal const string WebPartNodeTypeId = "Contoso.WebPart";

        public void InitializeType(IExplorerNodeTypeDefinition typeDefinition)
        {
            typeDefinition.DefaultIcon = Properties.Resources.WebPart.ToBitmap();
            typeDefinition.IsAlwaysLeaf = true;
            typeDefinition.NodePropertiesRequested += NodePropertiesRequested;
        }

        // Retrieves properties that are displayed in the Properties window when
        // a Web Part node is selected.
        private void NodePropertiesRequested(object sender,
            ExplorerNodePropertiesRequestedEventArgs e)
        {
            var webPartNodeInfo = e.Node.Annotations.GetValue<WebPartNodeInfo>();

            // Call the custom SharePoint command to get the Web Part properties.
            Dictionary<string, string> properties =
                e.Node.Context.SharePointConnection.ExecuteCommand<
                WebPartNodeInfo, Dictionary<string, string>>(
                WebPartCommandIds.GetWebPartProperties, webPartNodeInfo);

            object propertySource = e.Node.Context.CreatePropertySourceObject(properties);
            e.PropertySources.Add(propertySource);
        }
    }
}
//</Snippet2>
