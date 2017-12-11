//<Snippet5>
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;

namespace Contoso.ServerExplorerExtension
{
    //<Snippet6>
    [Export(typeof(IExplorerNodeTypeProvider))]
    [ExplorerNodeType(ExampleNodeTypeProvider.NodeTypeId)]
    internal class ExampleNodeTypeProvider : IExplorerNodeTypeProvider
    {
        internal const string NodeTypeId = "Contoso.ServerExplorerNodeExample";

        public void InitializeType(IExplorerNodeTypeDefinition typeDefinition)
        {
            typeDefinition.DefaultIcon =
                Properties.Resources.CustomChildNodeIcon.ToBitmap();
            typeDefinition.IsAlwaysLeaf = true;
        }
    }
    //</Snippet6>

    //<Snippet7>
    [Export(typeof(IExplorerNodeTypeExtension))]
    [ExplorerNodeType(ExplorerNodeTypes.SiteNode)]
    internal class SiteNodeExtension : IExplorerNodeTypeExtension
    {
        public void Initialize(IExplorerNodeType nodeType)
        {
            nodeType.NodeChildrenRequested += NodeChildrenRequested;
        }

        //<Snippet8>
        private void NodeChildrenRequested(object sender, ExplorerNodeEventArgs e)
        {
            e.Node.ChildNodes.Add(ExampleNodeTypeProvider.NodeTypeId,
                "Custom Node", null);
        }
        //</Snippet8>
    }
    //</Snippet7>
}
//</Snippet5>