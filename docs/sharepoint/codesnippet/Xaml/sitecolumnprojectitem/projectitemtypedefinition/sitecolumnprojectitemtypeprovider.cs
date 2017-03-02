//<Snippet1>
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;

namespace Contoso.SharePointProjectItems.SiteColumn
{
    // Enables Visual Studio to discover and load this extension.
    [Export(typeof(ISharePointProjectItemTypeProvider))]

    // Specifies the ID for the new project item type. This string must match the value of the 
    // Type attribute of the ProjectItem element in the .spdata file for the project item.
    [SharePointProjectItemType("Contoso.SiteColumn")]

    // Defines a new type of project item.
    internal class SiteColumnProjectItemTypeProvider : ISharePointProjectItemTypeProvider
    {
        // Implements IProjectItemTypeProvider.InitializeType. Configures the behavior of the project item type.
        public void InitializeType(ISharePointProjectItemTypeDefinition projectItemTypeDefinition)
        {
            projectItemTypeDefinition.SupportedDeploymentScopes =
               SupportedDeploymentScopes.Site | SupportedDeploymentScopes.Web;
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All;

            // Handle event to create a custom property for this project item.
            projectItemTypeDefinition.ProjectItemPropertiesRequested +=
                projectItemTypeDefinition_ProjectItemPropertiesRequested;
        }

        // Creates a custom property for this project item.
        void projectItemTypeDefinition_ProjectItemPropertiesRequested(object sender,
            SharePointProjectItemPropertiesRequestedEventArgs e)
        {
            SiteColumnProperties properties = null;

            // If the Properties object already exists, get it from the project item's annotations.
            if (!e.ProjectItem.Annotations.TryGetValue(out properties))
            {
                // Otherwise, create a new Properties object and add it to the annotations.
                properties = new SiteColumnProperties(e.ProjectItem);
                e.ProjectItem.Annotations.Add(properties);
            }

            e.PropertySources.Add(properties);
        }
    }

    internal class SiteColumnProperties
    {
        // This class defines the property behavior.
        private ISharePointProjectItem projectItem;
        private const string propertyId = "Contoso.SiteColumnProperty";
        private const string propertyDefaultValue = "Default custom property value.";

        internal SiteColumnProperties(ISharePointProjectItem projectItem)
        {
            this.projectItem = projectItem;
        }

        // The property gets or sets a simple string value. 
        [DisplayName("Example Property")]
        [DescriptionAttribute("This is an example property for site column project items.")]
        [DefaultValue(propertyDefaultValue)]
        public string ExampleProperty
        {
            get
            {
                string propertyValue;

                // Get the current property value if it already exists; otherwise, return a default value.
                if (!projectItem.ExtensionData.TryGetValue(propertyId, out propertyValue))
                {
                    propertyValue = propertyDefaultValue;
                }
                return propertyValue;
            }
            set
            {
                if (value != propertyDefaultValue)
                {
                    // Store the property value in the ExtensionData property of the project item. 
                    // Data in the ExtensionData property persists when the project is closed.
                    projectItem.ExtensionData[propertyId] = value;
                }
                else
                {
                    // Do not save the default value.
                    projectItem.ExtensionData.Remove(propertyId);
                }
            }
        }
    }
}
//</Snippet1>