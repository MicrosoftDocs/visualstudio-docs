using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

// Need to mention this in snippet intros.
using Microsoft.VisualStudio.Tools.Applications;
using Microsoft.VisualStudio.Tools.Applications.Runtime;


namespace Trin_ServerDocument
{
    public partial class Form1 : Form
    {
        // All of these snippets assume ExcelWorkbook1.xlsx exists on the desktop!!!

        public Form1()
        {
            InitializeComponent();

            string desktopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //CreateServerDocumentFromPath(desktopPath + @"\ExcelWorkbook1.xlsx");
            //CreateServerDocumentFromByteArray(desktopPath + @"\ExcelWorkbook1.xlsx");
            //CreateServerDocumentFromStream(desktopPath + @"\ExcelWorkbook1.xlsx");
            //CreateServerDocumentReadOnly(desktopPath + @"\ExcelWorkbook1.xlsx");
            //DisplayDataCacheContents(desktopPath + @"\ExcelWorkbook1.xlsx");
            //AddCustomizationUsingDocumentPath(desktopPath + @"\ExcelWorkbook1.xlsx", desktopPath + @"\Publish Test\ExcelWorkbook1.vsto");
            //AddCustomizationUsingAssemblyPath(desktopPath + @"\ExcelWorkbook1.xlsx",
            //    desktopPath + @"\Publish Test\ExcelWorkbook1_1_0_0_0\ExcelWorkbook1.dll.deploy",
            //    new Guid("5f51999b-7fd5-44c9-9360-0e28aa08e164"), desktopPath + @"\Publish Test\ExcelWorkbook1.vsto");
            //RemoveAssembly(desktopPath + @"\ExcelWorkbook1.xlsx");
            //DisplayCustomizationInformation(desktopPath + @"\ExcelWorkbook1.xlsx");
            //ModifyCachedString(desktopPath + @"\ExcelWorkbook1.xlsx");
            //ReadCachedStringValue(desktopPath + @"\ExcelWorkbook1.xlsx");
        }

        //<Snippet1>
        private void CreateServerDocumentFromPath(string documentPath)
        {
            int runtimeVersion = 0;
            ServerDocument serverDocument1 = null;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);
                if (runtimeVersion == 3)
                {
                    serverDocument1 = new ServerDocument(documentPath);
                    MessageBox.Show("The URL of the deployment manifest is: \n" +
                        serverDocument1.DeploymentManifestUrl.ToString());
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            finally
            {
                if (serverDocument1 != null)
                    serverDocument1.Close();
            }
        }
        //</Snippet1>

        // Note: This works, but should come up with something a 
        // little more useful. 
        //<Snippet2>
        private void CreateServerDocumentFromByteArray(string documentPath)
        {
            int runtimeVersion = 0;
            ServerDocument serverDocument1 = null;
            System.IO.FileStream stream = null;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);
                if (runtimeVersion == 3)
                {
                    // Read the file into a byte array.
                    stream = new System.IO.FileStream(
                        documentPath, System.IO.FileMode.Open,
                        System.IO.FileAccess.Read);
                    byte[] buffer = new byte[(int)stream.Length];
                    stream.Read(buffer, 0, (int)buffer.Length);

                    // Display the number of bytes in the document.
                    serverDocument1 = new ServerDocument(buffer,
                        "*.xlsx");
                    MessageBox.Show("The Document property contains " +
                        serverDocument1.Document.Length.ToString() +
                        " bytes.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            finally
            {
                if (serverDocument1 != null)
                    serverDocument1.Close();
                if (stream != null)
                    stream.Close();
            }
        }
        //</Snippet2>

        //<Snippet3>
        private void CreateServerDocumentFromStream(string documentPath)
        {
            int runtimeVersion = 0;
            ServerDocument serverDocument1 = null;
            System.IO.FileStream stream = null;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);
                if (runtimeVersion == 3)
                {
                    stream = new System.IO.FileStream(
                        documentPath, System.IO.FileMode.Open);
                    serverDocument1 = new ServerDocument(stream,
                        "*.xlsx");
                    MessageBox.Show("The URL of the deployment manifest is: \n" +
                        serverDocument1.DeploymentManifestUrl.ToString());
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            finally
            {
                if (serverDocument1 != null)
                    serverDocument1.Close();
                if (stream != null)
                    stream.Close();
            }
        }
        //</Snippet3>

        //<Snippet4>
        private void CreateServerDocumentReadOnly(string documentPath)
        {
            int runtimeVersion = 0;
            ServerDocument serverDocument1 = null;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);
                if (runtimeVersion == 3)
                {
                    serverDocument1 = new ServerDocument(documentPath,
                        System.IO.FileAccess.Read);
                    MessageBox.Show("The URL of the deployment manifest is: \n" +
                        serverDocument1.DeploymentManifestUrl.ToString());
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (DocumentNotCustomizedException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not " +
                    "have a customization.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            finally
            {
                if (serverDocument1 != null)
                    serverDocument1.Close();
            }
        }
        //</Snippet4>

        //<Snippet5>
        private void DisplayDataCacheContents(string documentPath)
        {
            int runtimeVersion = 0;
            ServerDocument serverDocument1 = null;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                if (runtimeVersion != 3)
                {
                    MessageBox.Show("This document does not have a Visual Studio Tools for " +
                        "Office customization, or it has a customization that was created with " +
                        "a version of the runtime that is incompatible with this version of the " +
                        "ServerDocument class.");
                    return;
                }

                if (ServerDocument.IsCacheEnabled(documentPath))
                {
                    serverDocument1 = new ServerDocument(documentPath);
                    System.Text.StringBuilder stringBuilder1 =
                        new System.Text.StringBuilder();

                    // Display all of the cached data items 
                    // in the document.
                    foreach (CachedDataHostItem hostItem1 in
                        serverDocument1.CachedData.HostItems)
                    {
                        stringBuilder1.Append("\nNamespace and class: ");
                        stringBuilder1.Append(hostItem1.Id + "\n");
                        foreach (CachedDataItem dataItem1 in
                            hostItem1.CachedData)
                        {
                            stringBuilder1.Append("     Data item: ");
                            stringBuilder1.Append(dataItem1.Id + "\n");
                        }
                    }
                    MessageBox.Show(stringBuilder1.ToString());
                }
                else
                {
                    MessageBox.Show("The specified document does not have cached data.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            finally
            {
                if (serverDocument1 != null)
                    serverDocument1.Close();
            }
        }
        //</Snippet5>


        //<Snippet6>
        private void AddCustomizationUsingDocumentPath(string documentPath, string deployManifestPath)
        {
            int runtimeVersion = 0;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                // Make sure that this document does not yet have any Visual Studio Tools 
                // for Office customizations.
                if (runtimeVersion == 0)
                {
                    Uri deploymentManifestUri = new Uri(deployManifestPath);
                    ServerDocument.AddCustomization(documentPath, deploymentManifestUri);
                    MessageBox.Show("The document was successfully customized.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The document is already customized.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            catch (DocumentNotCustomizedException ex)
            {
                System.Windows.Forms.MessageBox.Show("The document could not be customized.\n" +
                    ex.Message);
            }
        }
        //</Snippet6>


        //<Snippet7>
        private void AddCustomizationUsingAssemblyPath(string documentPath, string assemblyName, 
            Guid solutionID, string deployManifestPath)
        {
            int runtimeVersion = 0;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                // Make sure that this document does not yet have any Visual Studio Tools 
                // for Office customizations.
                if (runtimeVersion == 0)
                {
                    Uri deploymentManifestUri = new Uri(deployManifestPath);
                    ServerDocument.AddCustomization(documentPath, assemblyName, solutionID, deploymentManifestUri);
                    MessageBox.Show("The document was successfully customized.");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The document is already customized.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            catch (DocumentNotCustomizedException ex)
            {
                System.Windows.Forms.MessageBox.Show("The document could not be customized.\n" +
                    ex.Message);
            }
        }
        //</Snippet7>


        //<Snippet8>
        private static void RemoveAssembly(string documentPath)
        {
            int runtimeVersion = 0;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                // Make sure that this customization was created using the correct runtime.
                if (runtimeVersion != 3)
                {
                    MessageBox.Show("This document does not have a Visual Studio Tools for " +
                        "Office customization, or it has a customization that was created with " +
                        "a version of the runtime that is incompatible with this version of the " +
                        "ServerDocument class.");
                    return;
                }

                ServerDocument.RemoveCustomization(documentPath);
                MessageBox.Show("The customization has been removed.");
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (System.IO.IOException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document is read-only.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            catch (InvalidOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show("The customization could not be removed.\n" +
                    ex.Message);
            }
        }
        //</Snippet8>


        //<Snippet9>
        private void ModifyCachedString(string documentPath)
        {
            int runtimeVersion = 0;
            ServerDocument serverDocument1 = null;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                if (runtimeVersion != 3)
                {
                    MessageBox.Show("This document does not have a Visual Studio Tools for " +
                        "Office customization, or it has a customization that was created with " +
                        "a version of the runtime that is incompatible with this version of the " +
                        "ServerDocument class.");
                    return;
                }

                if (ServerDocument.IsCacheEnabled(documentPath))
                {
                    //<Snippet11>
                    //<Snippet12>
                    serverDocument1 = new ServerDocument(documentPath);
                    CachedDataHostItem hostItem1 = 
                        serverDocument1.CachedData.HostItems["ExcelWorkbook1.Sheet1"];
                    CachedDataItem dataItem1 = hostItem1.CachedData["CachedString"];
                    //</Snippet12>

                    if (dataItem1 != null &&
                        Type.GetType(dataItem1.DataType) == typeof(string))
                    {
                        dataItem1.SerializeDataInstance("This is the new cached string value.");
                        serverDocument1.Save();
                    }
                    //</Snippet11>
                }
                else
                {
                    MessageBox.Show("The specified document does not have cached data.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            finally
            {
                if (serverDocument1 != null)
                    serverDocument1.Close();
            }
        }
        //</Snippet9>


        //<Snippet10>
        private void ReadCachedStringValue(string documentPath)
        {
            int runtimeVersion = 0;
            ServerDocument serverDocument1 = null;

            try
            {
                runtimeVersion = ServerDocument.GetCustomizationVersion(documentPath);

                if (runtimeVersion != 3)
                {
                    MessageBox.Show("This document does not have a Visual Studio Tools for " +
                        "Office customization, or it has a customization that was created with " +
                        "a version of the runtime that is incompatible with this version of the " +
                        "ServerDocument class.");
                    return;
                }

                if (ServerDocument.IsCacheEnabled(documentPath))
                {
                    serverDocument1 = new ServerDocument(documentPath);
                    CachedDataHostItem hostItem1 = 
                        serverDocument1.CachedData.HostItems["ExcelWorkbook1.Sheet1"];
                    CachedDataItem dataItem1 = hostItem1.CachedData["CachedString"];

                    if (dataItem1 != null && 
                        Type.GetType(dataItem1.DataType) == typeof(string))
                    {
                        using (System.IO.StringReader stringReader =
                            new System.IO.StringReader(dataItem1.Xml))
                        {
                            System.Xml.Serialization.XmlSerializer serializer =
                                new System.Xml.Serialization.XmlSerializer(typeof(string));
                            string cachedString = serializer.Deserialize(stringReader) as string;
                            MessageBox.Show("The value of CachedString is: " + cachedString);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The specified document does not have cached data.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document does not exist.");
            }
            catch (UnknownCustomizationFileException)
            {
                System.Windows.Forms.MessageBox.Show("The specified document has a file " +
                    "extension that is not supported by Visual Studio Tools for Office.");
            }
            finally
            {
                if (serverDocument1 != null)
                    serverDocument1.Close();
            }
        }
        //</Snippet10>
    }
}





