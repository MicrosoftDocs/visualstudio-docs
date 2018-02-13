//<Snippet9>
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Explorer;
using Microsoft.VisualStudio.SharePoint.Explorer.Extensions;

namespace Contoso.ServerExplorerExtension
{
    [Export(typeof(IExplorerNodeTypeExtension))]
    [ExplorerNodeType(ExplorerNodeTypes.SiteNode)]
    internal class SiteNodeExtensionWithContextMenu : IExplorerNodeTypeExtension
    {
        public void Initialize(IExplorerNodeType nodeType)
        {
            nodeType.NodeMenuItemsRequested += nodeType_NodeMenuItemsRequested;
        }

        void nodeType_NodeMenuItemsRequested(object sender, ExplorerNodeMenuItemsRequestedEventArgs e)
        {
            IMenuItem menuItem = e.MenuItems.Add("Display Message");
            menuItem.Click += menuItem_Click;
        }

        void menuItem_Click(object sender, MenuItemEventArgs e)
        {
            IExplorerNode node = (IExplorerNode)e.Owner;
            MessageBox.Show(string.Format("Clicked the menu item for the '{0}' node.", node.Text));
        }
    }

    [Export(typeof(IExplorerNodeTypeExtension))]
    [ExplorerNodeType(ExtensionNodeTypes.FieldNode)]
    internal class FieldNodeExtensionWithProperty : IExplorerNodeTypeExtension
    {
        public void Initialize(IExplorerNodeType nodeType)
        {
            nodeType.NodePropertiesRequested += nodeType_NodePropertiesRequested;
        }

        void nodeType_NodePropertiesRequested(object sender, ExplorerNodePropertiesRequestedEventArgs e)
        {
            // Only add the property to "Body" fields.
            if (e.Node.Text == "Body")
            {
                ExampleProperty propertyObject;

                // If the properties object already exists for this node, get it from the node's annotations.
                if (!e.Node.Annotations.TryGetValue(out propertyObject))
                {
                    // Otherwise, create a new properties object and add it to the annotations.
                    propertyObject = new ExampleProperty(e.Node);
                    e.Node.Annotations.Add(propertyObject);
                }

                e.PropertySources.Add(propertyObject);
            }
        }
    }

    internal class ExampleProperty
    {
        private IExplorerNode node;
        private const string propertyId = "Contoso.ExampleProperty";
        private const string propertyDefaultValue = "This is an example property.";

        internal ExampleProperty(IExplorerNode node)
        {
            this.node = node;
        }

        // Gets or sets a simple string property. 
        [DisplayName("ContosoExampleProperty")]
        [DescriptionAttribute("This is an example property for field nodes.")]
        [DefaultValue(propertyDefaultValue)]
        public string TestProperty
        {
            get
            {
                string propertyValue;

                // Get the current property value if it already exists; otherwise, return a default value.
                if (!node.Annotations.TryGetValue(propertyId, out propertyValue))
                {
                    propertyValue = propertyDefaultValue;
                }
                return propertyValue;
            }
            set
            {
                if (value != propertyDefaultValue)
                {
                    // Store the property value in the Annotations property of the node. 
                    // Data in the Annotations property does not persist when Visual Studio exits.
                    node.Annotations[propertyId] = value;
                }
                else
                {
                    // Do not save the default value.
                    node.Annotations.Remove(propertyId);
                }
            }
        }
    }

}
//</Snippet9>
