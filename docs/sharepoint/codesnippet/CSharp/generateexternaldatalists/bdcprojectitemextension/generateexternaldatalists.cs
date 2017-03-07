//<Snippet2>
using Microsoft.VisualStudio.SharePoint;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Contoso.SharePointProjectItemExtensions.GenerateExternalDataLists
{
    // Creates the external data lists for the BDC item. The other part of the partial class 
    // defines the BDC project item extension.
    internal partial class GenerateExternalDataListsExtension
    {
        private const string ModelFileNameString = "ModelFileName";
        private const string EXTENSION_BDCM = ".bdcm";
        private const string NamespaceString = "http://schemas.microsoft.com/windows/2007/BusinessDataCatalog";
        private static readonly XNamespace BdcNamespace = XNamespace.Get(NamespaceString);

        // Generates an external data list for each Entity in the BDC model. This event handler is called
        // when the developer clicks the shortcut menu item that the extension adds to the BDC project item.
        private void GenerateExternalDataLists_Execute(object sender, MenuItemEventArgs e)
        {
            ISharePointProjectItem projectItem = (ISharePointProjectItem)e.Owner;
            ISharePointProjectItemFile bdcmFile = GetModelFile(projectItem);

            XDocument doc = XDocument.Load(bdcmFile.FullPath);
            List<XElement> skippedEntities = new List<XElement>();

            // Try to generate an external data list for each entity defined in the BDC model file.
            foreach (XElement entity in doc.Root.Elements(BdcNamespace + "LobSystems").Elements(
                BdcNamespace + "LobSystem").Elements(BdcNamespace + "Entities").Elements(BdcNamespace + "Entity"))
            {
                if (!GenerateExternalDataList(projectItem, entity))
                {
                    skippedEntities.Add(entity);
                }
            }

            // Report skipped entities.
            if (skippedEntities.Count != 0)
            {
                StringBuilder entityNameList = null;
                skippedEntities.ForEach(delegate(XElement entity)
                {
                    if (entityNameList == null)
                    {
                        entityNameList = new StringBuilder();
                    }
                    else
                    {
                        entityNameList.AppendLine(",");
                    }
                    entityNameList.Append(entity.Attribute("Name").Value);
                });

                string message = string.Format("The following Entities were skipped because either a LobSystemInstance, " +
                    "SpecificFinder, or Finder was not found for them. \r\n{0}", entityNameList);
                projectItem.Project.ProjectService.Logger.WriteLine(message, LogCategory.Warning);
            }
        }

        // Gets the ISharePointProjectItemFile object for the BDC model file.
        private ISharePointProjectItemFile GetModelFile(ISharePointProjectItem projectItem)
        {
            string modelFileName;
            if (projectItem.FeatureProperties.TryGetValue(ModelFileNameString, out modelFileName))
            {
                modelFileName = Path.GetFileName(modelFileName);
                return (from file in projectItem.Files
                        where string.Compare(file.Name, modelFileName, StringComparison.OrdinalIgnoreCase) == 0
                        select file).FirstOrDefault();
            }
            else
            {
                // if we can't find the ModelFileName through the FeatureProperties, 
                // get the first file that has a '.bdcm' extension
                return (from file in projectItem.Files
                        where file.Name.EndsWith(EXTENSION_BDCM, StringComparison.OrdinalIgnoreCase)
                        select file).FirstOrDefault();
            }
        }

        // Boilerplate XML for the new list instance that is based on the BDC model.
        private const string externalDataListContent =
            @"<?xml version=""1.0"" encoding=""utf-8""?>
            <Elements xmlns=""http://schemas.microsoft.com/sharepoint/"">
              <ListInstance Title=""$EntityName$DataList""
                            OnQuickLaunch=""TRUE""
                            TemplateType=""104""
                            FeatureId=""$SharePoint.Feature.Id$""
                            Url=""Lists/$EntityName$DataList""
                            Description=""Default List for $EntityName$."">
                <DataSource>
                  <Property Name=""LobSystemInstance"" Value=""$LobSystemInstance$"" />
                  <Property Name=""EntityNamespace"" Value=""$EntityNamespace$"" />
                  <Property Name=""Entity"" Value=""$EntityName$"" />
                  <Property Name=""SpecificFinder"" Value=""$SpecificFinder$"" />
                  <Property Name=""Finder"" Value=""$Finder$"" />
                </DataSource>
              </ListInstance>
            </Elements>";

        // Tries to generate an external data list for the specified BDC model project item and entity.
        private bool GenerateExternalDataList(ISharePointProjectItem projectItem, XElement entity)
        {
            string lobSystemInstanceName = GetLobSystemInstanceName(entity);
            string specificFinderName = GetSpecificFinderName(entity);
            string finderName = GetFinderName(entity);
            string entityName = entity.Attribute("Name").Value;

            if (string.IsNullOrEmpty(lobSystemInstanceName) || string.IsNullOrEmpty(specificFinderName) || 
                string.IsNullOrEmpty(finderName))
            {
                return false;
            }

            string newExternalDataListName = entityName + "DataList";
            ISharePointProjectItem existingProjectItem = (from ISharePointProjectItem existingItem in projectItem.Project.ProjectItems
                                                where existingItem.Name == newExternalDataListName
                                                select existingItem).FirstOrDefault();

            // Add a new list instance and populate it with data from the BDC model.
            if (existingProjectItem == null)
            {
                ISharePointProjectItem newExternalDataList = projectItem.Project.ProjectItems.Add(newExternalDataListName, 
                    "Microsoft.VisualStudio.SharePoint.ListInstance");

                string newExternalDataListString = externalDataListContent;
                newExternalDataListString = newExternalDataListString.Replace("$EntityName$", entityName);
                newExternalDataListString = newExternalDataListString.Replace("$LobSystemInstance$", lobSystemInstanceName);
                newExternalDataListString = newExternalDataListString.Replace("$EntityNamespace$", entity.Attribute("Namespace").Value);
                newExternalDataListString = newExternalDataListString.Replace("$SpecificFinder$", specificFinderName);
                newExternalDataListString = newExternalDataListString.Replace("$Finder$", finderName);

                string elementsXmlPath = Path.Combine(newExternalDataList.FullPath, "Elements.xml");
                File.WriteAllText(elementsXmlPath, newExternalDataListString);
                ISharePointProjectItemFile elementsFile = newExternalDataList.Files.AddFromFile(elementsXmlPath);
                elementsFile.DeploymentType = DeploymentType.ElementManifest;
            }

            return true;
        }

        private string GetLobSystemInstanceName(XElement entity)
        {
            XElement lobSystemInstances = entity.Parent.Parent.Element(BdcNamespace + "LobSystemInstances");
            if (lobSystemInstances != null)
            {
                XElement lobSystemInstance = lobSystemInstances.Elements(BdcNamespace + "LobSystemInstance").FirstOrDefault();
                if (lobSystemInstance != null)
                {
                    return lobSystemInstance.Attribute("Name").Value;
                }
            }
            return null;
        }

        private string GetSpecificFinderName(XElement entity)
        {
            return GetMethodInstance(entity, "SpecificFinder");
        }

        private string GetFinderName(XElement entity)
        {
            return GetMethodInstance(entity, "Finder");
        }

        private string GetMethodInstance(XElement entity, string methodInstanceType)
        {
            XElement methods = entity.Element(BdcNamespace + "Methods");
            if (methods != null)
            {
                foreach (XElement method in methods.Elements(BdcNamespace + "Method"))
                {
                    XElement methodInstances = method.Element(BdcNamespace + "MethodInstances");
                    if (methodInstances != null)
                    {
                        foreach (XElement methodInstance in methodInstances.Elements(BdcNamespace + "MethodInstance"))
                        {
                            if (methodInstance.Attribute("Type").Value == methodInstanceType)
                            {
                                return methodInstance.Attribute("Name").Value;
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
//</Snippet2>