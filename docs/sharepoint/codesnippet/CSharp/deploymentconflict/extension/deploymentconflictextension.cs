//<Snippet1>
using Microsoft.VisualStudio.SharePoint;
using Microsoft.VisualStudio.SharePoint.Deployment;
using System.ComponentModel.Composition;

namespace Contoso.DeploymentConflictExtension
{
    [Export(typeof(ISharePointProjectItemTypeExtension))]
    [SharePointProjectItemType("Microsoft.VisualStudio.SharePoint.ListDefinition")]
    class DeploymentConflictExtension : ISharePointProjectItemTypeExtension
    {
        public void Initialize(ISharePointProjectItemType projectItemType)
        {
            projectItemType.DeploymentStepStarted += DeploymentStepStarted;
        }

        private void DeploymentStepStarted(object sender, DeploymentStepStartedEventArgs e)
        {
            if (e.DeploymentStepInfo.Id == DeploymentStepIds.AddSolution)
            {
                e.Conflicts.Add("This is an example conflict", this.Resolve, true);
                e.ProjectItem.Project.ProjectService.Logger.WriteLine("Added new example conflict.", LogCategory.Status);
            }
        }

        private bool Resolve(ISharePointProjectItem projectItem)
        {
            projectItem.Project.ProjectService.Logger.WriteLine("Returning 'true' from Resolve method for example conflict.", 
                LogCategory.Status);
            return true;
        }
    }
}
//</Snippet1>


// Following code might be useful in a future walkthrough...

//using System;
//using System.IO;
//using System.Linq;
//using System.Collections.Generic;
//using System.Xml;
//using System.Xml.Linq;

            //IEnumerable<ISharePointProjectItemFile> manifests = e.ProjectItem.Files.Where(fileElement => fileElement.DeploymentType == DeploymentType.ElementManifest);

            //foreach (ISharePointProjectItemFile manifest in manifests)
            //{
            //    XNamespace SPNamespace = "http://schemas.microsoft.com/sharepoint/";
            //    string uri = Path.GetDirectoryName(e.ProjectItem.Project.FullPath) + @"\" + manifest.RelativePath;

            //    XmlReader reader = XmlReader.Create(uri);
            //    var xdoc = XDocument.Load(reader);

            //    var collisions = xdoc.Elements(SPNamespace + "Elements")
            //          .Elements(SPNamespace + "Module")
            //            .Elements(SPNamespace + "File")
            //            .Attributes("Url")
            //            .Where(blah => Path.GetFileName(blah.Value) == "MyImage.bmp");
            //}

