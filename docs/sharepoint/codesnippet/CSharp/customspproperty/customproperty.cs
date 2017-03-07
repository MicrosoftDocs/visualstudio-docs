// <Snippet1>
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.Shell.Interop;

namespace CustomSharePointProperty
{
    [Export(typeof(ISharePointProjectExtension))]
    public class ProjectExtensionWithProperty : ISharePointProjectExtension
    {
        public void Initialize(ISharePointProjectService projectService)
        {
            projectService.ProjectPropertiesRequested += projectService_ProjectPropertiesRequested;           
        }

        void projectService_ProjectPropertiesRequested(object sender, SharePointProjectPropertiesRequestedEventArgs e)
        {
            CustomProjectProperties propertiesObject;

            // If the properties object already exists, get it from the project's annotations.
            if (!e.Project.Annotations.TryGetValue(out propertiesObject))
            {
                // Otherwise, create a new properties object and add it to the annotations.
                propertiesObject = new CustomProjectProperties(e.Project);
                e.Project.Annotations.Add(propertiesObject);
            }

            e.PropertySources.Add(propertiesObject);
        }
    }

    public class CustomProjectProperties
    {
        //<Snippet3>
        private ISharePointProject sharePointProject;
        private IVsBuildPropertyStorage projectStorage;
        private const string ProjectFilePropertyId = "ContosoCustomProjectFileProperty";
        private const string ProjectFilePropertyDefaultValue = "Default";

        public CustomProjectProperties(ISharePointProject myProject)
        {
            sharePointProject = myProject;
            projectStorage = sharePointProject.ProjectService.Convert<ISharePointProject, IVsBuildPropertyStorage>(sharePointProject);
        }

        [DisplayName("Custom Project File Property")]
        [DescriptionAttribute("This property is saved to the .csproj/.vbproj file.")]
        [DefaultValue(ProjectFilePropertyDefaultValue)]
        public string CustomProjectFileProperty
        {
            get
            {
                string propertyValue;
                int hr = projectStorage.GetPropertyValue(ProjectFilePropertyId, string.Empty, 
                    (uint)_PersistStorageType.PST_PROJECT_FILE, out propertyValue);

                // Try to get the current value from the project file; if it does not yet exist, return a default value.
                if (!ErrorHandler.Succeeded(hr) || String.IsNullOrEmpty(propertyValue))
                {
                    propertyValue = ProjectFilePropertyDefaultValue;
                }

                return propertyValue;
            }

            set
            {
                // Do not save the default value.
                if (value != ProjectFilePropertyDefaultValue)
                {
                    projectStorage.SetPropertyValue(ProjectFilePropertyId, string.Empty, 
                        (uint)_PersistStorageType.PST_PROJECT_FILE, value);
                }
            }
        }
        //</Snippet3>  

        //<Snippet2>
        private const string UserFilePropertyId = "ContosoCustomUserFileProperty";
        private const string UserFilePropertyDefaultValue = "Default";

        [DisplayName("Custom Project User File Property")]
        [DescriptionAttribute("This property is saved to the .user file.")]
        [DefaultValue(UserFilePropertyDefaultValue)]
        public string CustomUserFileProperty
        {
            get
            {
                string propertyValue = string.Empty;
                
                // Try to get the current value from the .user file; if it does not yet exist, return a default value.
                if (!sharePointProject.ProjectUserFileData.TryGetValue(UserFilePropertyId, out propertyValue))
                {
                    propertyValue = UserFilePropertyDefaultValue; 
                }

                return propertyValue; 
            }
            
            set
            {
                // Do not save the default value.
                if (value != UserFilePropertyDefaultValue)
                {
                    sharePointProject.ProjectUserFileData[UserFilePropertyId] = value;
                }
            }
        }                
        //</Snippet2>    
    }
}
//</Snippet1>