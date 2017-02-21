//<Snippet8>
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;

namespace Contoso.Examples.ProjectItemExtensionWithProperty
{
    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.EventHandler")]
    internal class ExampleProjectItemExtensionWithProperty : ISharePointProjectItemTypeExtension
    {
        //<Snippet9>
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.ProjectItemPropertiesRequested += 
                projectItemType_ProjectItemPropertiesRequested;
        }
        //</Snippet9>

        //<Snippet10>
        void projectItemType_ProjectItemPropertiesRequested(object sender, 
            SharePointProjectItemPropertiesRequestedEventArgs e)
        {
            CustomProperties propertyObject;

            // If the properties object already exists, get it from the project item's annotations.
            if (!e.ProjectItem.Annotations.TryGetValue(out propertyObject))
            {
                // Otherwise, create a new properties object and add it to the annotations.
                propertyObject = new CustomProperties(e.ProjectItem);
                e.ProjectItem.Annotations.Add(propertyObject);
            }

            e.PropertySources.Add(propertyObject);
        }
        //</Snippet10>
    }

    internal class CustomProperties
    {
        private ISharePointProjectItem projectItem;

        internal CustomProperties(ISharePointProjectItem projectItem)
        {
            this.projectItem = projectItem;
        }

        private const string PropertyId = "Contoso.ExampleProperty";
        private const string PropertyDefaultValue = "This is an example property.";

        [DisplayName("Example Property")]
        [DescriptionAttribute("This is an example property for project items.")]
        [DefaultValue(PropertyDefaultValue)]
        public string ExampleProperty
        {
            get
            {
                string propertyValue;

                // Get the current property value if it already exists; otherwise, return a default value.
                if (!projectItem.ExtensionData.TryGetValue(PropertyId, out propertyValue))
                {
                    propertyValue = PropertyDefaultValue;
                }
                return propertyValue;
            }
            set
            {
                if (value != PropertyDefaultValue)
                {
                    // Store the property value in the ExtensionData property of the project item. 
                    // Data in the ExtensionData property persists when the project is closed.
                    projectItem.ExtensionData[PropertyId] = value;
                }
                else
                {
                    // Do not save the default value.
                    projectItem.ExtensionData.Remove(PropertyId);
                }
            }
        }
    }
}
//</Snippet8>