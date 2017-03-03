using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;

namespace Contoso.ExampleProjectExtension
{
    [Export(typeof(ISharePointProjectExtension))]
    internal class SaveDataProjectExtension : ISharePointProjectExtension
    {
        public void Initialize(ISharePointProjectService projectService)
        {
            projectService.ProjectMenuItemsRequested += projectService_ProjectMenuItemsRequested;
        }

        void projectService_ProjectMenuItemsRequested(object sender, SharePointProjectMenuItemsRequestedEventArgs e)
        {
            IMenuItem menuItem1 = e.ActionMenuItems.Add("Save data to project file");
            menuItem1.Click += menuItem1_Click;
        }

        private void menuItem1_Click(object sender, MenuItemEventArgs e)
        {
            ISharePointProject project = (ISharePointProject)e.Owner;

            //<Snippet13>
            IVsBuildPropertyStorage projectStorage = project.ProjectService.Convert<ISharePointProject, IVsBuildPropertyStorage>(project);
            projectStorage.SetPropertyValue("MyCustomProperty", string.Empty, (uint)_PersistStorageType.PST_PROJECT_FILE,
                "Custom property value");
            //</Snippet13>
        }
    }
}
