//<Snippet1>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using Microsoft.VisualStudio.SharePoint;
using EnvDTE;

// Adds a new property called MapImagesFolder to any SharePoint project.
// When MapImagesFolder is set to true, the Image folder is mapped to the project.
// When MapImagesFolder is set to false, the Image folder is deleted from the project.
namespace SP_Project_Extension
{
    // Export attribute: Enables Visual Studio to discover and load this extension.
    [Export(typeof(ISharePointProjectExtension))]

    // Defines a new custom project property that applies to any SharePoint project.
    public class SPProjectExtension : ISharePointProjectExtension
    {
        // Implements ISharePointProjectService.Initialize, which determines the behavior of the new property.
        public void Initialize(ISharePointProjectService projectService)
        {
            // Handle events for when a project property is changed.
            projectService.ProjectPropertiesRequested +=
                new EventHandler<SharePointProjectPropertiesRequestedEventArgs>(projectService_ProjectPropertiesRequested);
        }

        void projectService_ProjectPropertiesRequested(object sender, SharePointProjectPropertiesRequestedEventArgs e)
        {
            // Add a new property to the SharePoint project.
            e.PropertySources.Add((object)new ImagesMappedFolderProperty(e.Project));
        }
    }

    public class ImagesMappedFolderProperty
    {
        ISharePointProject sharePointProject = null;
        public ImagesMappedFolderProperty(ISharePointProject myProject)
        {
            sharePointProject = myProject;
        }
        static bool MapFolderSetting = false;

        [DisplayName("Map Images Folder")]
        [DescriptionAttribute("Specifies whether an Images folder is mapped to the SharePoint project.")]
        public bool MapImagesFolder
        // Represents the new boolean property MapImagesFolder.
        // True = Map an Images folder to the project if one does not already exist; otherwise, do nothing.
        // False = Remove the Images folder from the project, if one exists; otherwise, do nothing.
        {
            get
            {
                // Get the current property value.
                return MapFolderSetting;
            }
            set
            {
                if (value)
                {
                    if (!ImagesMappedFolderInProjectExists(sharePointProject))
                    {
                        // An Images folder is not mapped to the project, so map one.
                        IMappedFolder mappedFolder1 = sharePointProject.MappedFolders.Add(MappedFolderType.Images);
                        // Add a note to the logger that a mapped folder was added.
                        sharePointProject.ProjectService.Logger.WriteLine("Mapped Folder added:" + mappedFolder1.Name, LogCategory.Status);
                    }
                }
                else
                {
                    if (ImagesMappedFolderInProjectExists(sharePointProject) && UserSaysDeleteFile())
                    {
                        // An Images folder is mapped to the project and the user wants to remove it.
                        // The Visual Studio DTE object model is required to delete the mapped folder.
                        // Reference the Visual Studio DTE model, get handles for the SharePoint project and project items.
                        EnvDTE.Project dteProject = sharePointProject.ProjectService.Convert<ISharePointProject, EnvDTE.Project>(sharePointProject);
                        string targetFolderName = sharePointProject.MappedFolders.First(mf => mf.FolderType == MappedFolderType.Images).Name;
                        EnvDTE.ProjectItem mappedFolderItem = dteProject.ProjectItems.Item(targetFolderName);
                        mappedFolderItem.Delete();
                        sharePointProject.ProjectService.Logger.WriteLine("Mapped Folder " + targetFolderName + " deleted", LogCategory.Status);
                    }
                }
                MapFolderSetting = value;
            }

        }

        private bool ImagesMappedFolderInProjectExists(ISharePointProject sharePointProject)
        {
            bool retVal = false;
            foreach (IMappedFolder folder in sharePointProject.MappedFolders)
            {
                // Check to see if an Images folder is already mapped.
                if (folder.FolderType == MappedFolderType.Images)
                    retVal = true;
            }
            return retVal;
        }

        private bool UserSaysDeleteFile()
        {
            // Prompt the user whether they want to delete the Images folder.
            bool retVal = false;
            if (MessageBox.Show("Do you want to delete the Images folder from the project?", "Delete the Images folder?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                retVal = true;
            }
            return retVal;

        }
    }
}
//</Snippet1>
