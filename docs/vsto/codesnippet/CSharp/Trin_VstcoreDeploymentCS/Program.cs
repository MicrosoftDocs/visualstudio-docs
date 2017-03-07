using System.IO;
using System.IO.Packaging;
using System.Xml;

//<Snippet4>
//<Snippet1>
using Microsoft.VisualStudio.Tools.Applications;
//</Snippet1>
using Microsoft.VisualStudio.Tools.Applications.Runtime;
//</Snippet4>
using System;

namespace Trin_VstcoreDeploymentCS
{
    class Program
    {
        static void Main()
        {
            //RemoveVSTOCustomization();
            //AddVSTOCustomization();
        }


        private static void RemoveVSTOCustomization()
        {
            //<Snippet2>
            string documentPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop) + @"\WordDocument1.docx";
            int runtimeVersion = 0;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                if (runtimeVersion == 3)
                {
                    ServerDocument.RemoveCustomization(documentPath);
                    System.Windows.Forms.MessageBox.Show("The customization has been removed.");
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document is read-only.");
            }
            catch (InvalidOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show("The customization could not be removed.\n" +
                    ex.Message);
            }
            //</Snippet2>
        }

        private static void AddVSTOCustomization()
        {
            //<Snippet3>
            string documentPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop) + @"\WordDocument1.docx";
            int runtimeVersion = 0;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                // Make sure that this document does not yet have any Visual Studio Tools 
                // for Office customizations.
                if (runtimeVersion == 0)
                {
                    string deployManifestPath = System.Environment.GetFolderPath(
                        Environment.SpecialFolder.Desktop) + @"\Publish\WordDocument1.vsto";

                    Uri deploymentManifestUri = new Uri(deployManifestPath);
                    ServerDocument.AddCustomization(documentPath, deploymentManifestUri);
                    System.Windows.Forms.MessageBox.Show("The document was successfully customized.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The document is already customized.");
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (DocumentNotCustomizedException ex)
            {
                System.Windows.Forms.MessageBox.Show("The document could not be customized.\n" +
                    ex.Message);
            }
            //</Snippet3>
        }

        // This is a method I'm just toying with to try to remove the custom document properties programmatically via
        // the new WinFX APIs. This will not wind up in the docs.
        //private static void RemoveCustomDocumentProperties()
        //{
        //    string documentPath = System.Environment.GetFolderPath(
        //        Environment.SpecialFolder.Desktop) + @"\Publish\WordDocument1.docx";

        //    using (Package package = Package.Open(documentPath, FileMode.Open,
        //        FileAccess.ReadWrite))
        //    {
        //        Uri uriPartTarget = new Uri("/docProps/custom.xml", UriKind.Relative);

        //        if (package.PartExists(uriPartTarget))
        //        {
        //            ZipPackagePart customProperties = package.GetPart(uriPartTarget) as ZipPackagePart;
        //            using (Stream partStream = customProperties.GetStream())
        //            {
        //                XmlDocument xmlDoc = new XmlDocument();
        //                xmlDoc.Load(partStream);

        //                //XmlNode root = xmlDoc.DocumentElement;
        //                //XmlNode locationElement = root.SelectSingleNode(
        //                //    "descendant::property[property/name='_AssemblyLocation']");
        //                //if (locationElement != null)
        //                //{
        //                //    xmlDoc.RemoveChild(locationElement);
        //                //}

        //                //XmlNode nameElement = xmlDoc.SelectSingleNode(
        //                //    "descendant::Properties[property/name='_AssemblyName']");
        //                //if (nameElement != null)
        //                //{
        //                //    xmlDoc.RemoveChild(nameElement);
        //                //}

        //                XmlNode root = xmlDoc.DocumentElement;
        //                foreach (XmlNode node in root.ChildNodes)
        //                {
        //                    if (node.NodeType == XmlNodeType.Element &&
        //                        node.Name == "property")
        //                    {
        //                        foreach (XmlAttribute attribute in node.Attributes)
        //                        {
        //                            if (attribute.Name == "name" && (
        //                                attribute.Value == "_AssemblyLocation" ||
        //                                attribute.Value == "_AssemblyName"))
        //                            {
        //                                root.RemoveChild(node);
        //                            }
        //                        }
        //                    }
        //                }

        //                xmlDoc.Save(partStream);
        //            }
        //        }
        //    }
        //}
    }
}
