//<Snippet1>
using Microsoft.VisualStudio.SharePoint;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;

namespace Contoso.ExampleProjectItemExtension
{
    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.EventHandler")]
    internal class ExampleProjectItemExtension : ISharePointProjectItemTypeExtension
    {
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.ProjectItemAdded += projectItemType_ProjectItemAdded;
        }

        void projectItemType_ProjectItemAdded(object sender, SharePointProjectItemEventArgs e)
        {
            ISharePointProjectItem projectItem = (ISharePointProjectItem)sender;
            string message = String.Format("An Event Handler project item named {0} was added to the {1} project.",
                projectItem.Name, projectItem.Project.Name);
            projectItem.Project.ProjectService.Logger.WriteLine(message, LogCategory.Message);
        }
    }
}
//</Snippet1>