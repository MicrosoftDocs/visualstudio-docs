---
title: "Sample Project for Creating a Diagnostic Data Adapter in Visual Studio"
ms.date: 10/19/2016
ms.topic: sample
helpviewer_keywords:
  - "Diagnostic Data Adapter [Visual Studio ALM]"
  - "samples. Diagnostic Data Adapter [Visual Studio ALM]"
  - "Diagnostic Data Adapter, sample"
ms.assetid: 548bdc5e-338f-4be7-a555-e6a2efb1df6b
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# Sample Project for Creating a Diagnostic Data Adapter

"MyDiagnosticDataAdapter" is a simple diagnostic data adapter that can attach a log file to the test results when you run your tests.

 You will need administrative permissions on any machine where the diagnostic data collector or configuration editor is installed.

## Example data adapter

This sample demonstrates how to perform the following tasks:

-   Apply attributes to make a class discoverable to Microsoft Test Manager as a diagnostic data adapter.

-   Apply attributes to make a user control class discoverable to Microsoft Test Manager as an editor to use to change the configuration for a diagnostic data adapter.

-   Access default configuration data.

-   Register for specific Diagnostic Data Collection events.

-   Attach the log file by sending it to the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionSink>.

```csharp
// My Data Collector Class
using Microsoft.VisualStudio.TestTools.Common;
using Microsoft.VisualStudio.TestTools.Execution;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System;

namespace MyCompany.MyDiagnosticDataAdapters
{
    // Provide a URI and friendly name for your diagnostic data adapter
    [DataCollectorTypeUri("datacollector://MyCompany/MyDataCollector/1.0")]
    [DataCollectorFriendlyName("Collect Log Files sample", false)]
    // Designate your chosen configuration editor
    [DataCollectorConfigurationEditor(
        "configurationeditor://MyCompany/MyDataConfigEditor/1.0")]
    public class MyDataCollector : DataCollector
    {
        private DataCollectionEvents dataEvents;
        private DataCollectionLogger dataLogger;
        private DataCollectionSink dataSink;
        private XmlElement configurationSettings;

        // Required method called by the testing framework
        public override void Initialize(
            XmlElement configurationElement,
            DataCollectionEvents events,
            DataCollectionSink sink,
            DataCollectionLogger logger,
            DataCollectionEnvironmentContext environmentContext)
        {
            dataEvents = events; // The test events
            dataLogger = logger; // The error and warning log
            dataSink = sink;     // Saves collected data
            // Configuration from the test settings
            configurationSettings = configurationElement;

            // Register common events for the data collector
            // Not all of the events are used in this class
            dataEvents.SessionStart +=
                new EventHandler<SessionStartEventArgs>(OnSessionStart);
            dataEvents.SessionEnd +=
                new EventHandler<SessionEndEventArgs>(OnSessionEnd);
            dataEvents.TestCaseStart +=
                new EventHandler<TestCaseStartEventArgs>(OnTestCaseStart);
            dataEvents.TestCaseEnd +=
                new EventHandler<TestCaseEndEventArgs>(OnTestCaseEnd);
            dataEvents.DataRequest +=
                new EventHandler<DataRequestEventArgs>(OnDataRequest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dataEvents.SessionStart -=
                    new EventHandler<SessionStartEventArgs>(OnSessionStart);
                dataEvents.SessionEnd -=
                    new EventHandler<SessionEndEventArgs>(OnSessionEnd);
                dataEvents.TestCaseStart -=
                    new EventHandler<TestCaseStartEventArgs>(OnTestCaseStart);
                dataEvents.TestCaseEnd -=
                    new EventHandler<TestCaseEndEventArgs>(OnTestCaseEnd);
                dataEvents.DataRequest -=
                    new EventHandler<DataRequestEventArgs>(OnDataRequest);
            }
        }

        #region Event Handlers
        public void OnSessionStart(object sender, SessionStartEventArgs e)
        {
            // TODO: Provide implementation
        }

        public void OnSessionEnd(object sender, SessionEndEventArgs e)
        {
            // TODO: Provide implementation
        }

        public void OnTestCaseStart(object sender, TestCaseEventArgs e)
        {
            // TODO: Provide implementation
        }

        public void OnTestCaseEnd(object sender, TestCaseEndEventArgs e)
        {
            // Get any files to be collected that are
            // configured in your test settings
            List<string> files = getFilesToCollect();

            // For each of the files, send the file to the data sink
            // which will attach it to the test results or to a bug
            foreach (string file in files)
            {
                dataSink.SendFileAsync(e.Context, file, false);
            }
        }

        public void OnDataRequest(object sender, DataRequestEventArgs e)
        {
            // TODO: Provide implementation
            // Most likely this occurs because a bug is being filed
        }
        #endregion

        // A private method to collect the configured file names
        private List<string> getFilesToCollect()
        {
            // Seetup namespace manager with our namespace
            XmlNamespaceManager nsmgr =
                new XmlNamespaceManager(
                    configurationSettings.OwnerDocument.NameTable);
            nsmgr.AddNamespace("ns",
                "http://MyCompany/schemas/MyDataCollector/1.0");

            // Find all of the "File" elements under our configuration
            XmlNodeList files =
                configurationSettings.SelectNodes(
                    "//ns:MyDataCollector/ns:File");

            // Build the list of files to collect from the
            // "FullPath" attributes of the "File" nodes.
            List<string> result = new List<string>();
            foreach (XmlNode fileNode in files)
            {
                XmlAttribute pathAttribute =
                    fileNode.Attributes["FullPath"];
                if (pathAttribute != null &&
                    !String.IsNullOrEmpty(pathAttribute.Value))
                {
                    result.Add(pathAttribute.Value);
                }
            }

            return result;
        }
    }
}
```

## Example configuration editor

This is a sample configuration editor for your diagnostic data adapter. Add a User Control to your project and create a very simple form that has a label ("Name of Log File:") and a text box that is named "FileTextBox".

```csharp
using Microsoft.VisualStudio.TestTools.Common;
using Microsoft.VisualStudio.TestTools.Execution;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System;

namespace MyCompany.DiagnosticDataAdapters.ConfigurationEditors
{
    [DataCollectorConfigurationEditorTypeUri(
        "configurationeditor://MyCompany/MyConfigEditor/1.0")]
    public partial class MyDataConfigEditor :
        UserControl, IDataCollectorConfigurationEditor
    {
        private DataCollectorSettings collectorSettings;

        // Create a private property for the service provider
        private IServiceProvider ServiceProvider { get; set; }

        // Constructor
        public MyConfigurationEditor()
        {
            InitializeComponent();
        }

        // Required method called by the testing framework
        public void Initialize(
            IServiceProvider svcProvider,
            DataCollectorSettings settings)
        {
            ServiceProvider = svcProvider;
            collectorSettings = settings;

            // Display the file name as listed in the settings file.
            // If the configuration has not been updated before, this
            // data will be provided by the default configuration
            // section from <nameofcollector>.dll.config:
            // <DefaultConfiguration>
            //   <MyCollectorName
            //       xmlns="http://MyCompany/schemas/ProductName/Version");
            //     <File FullPath="C:\temp\logfile1.txt" />
            //   </MyCollectorName>
            // </DefaultConfiguration>
            this.SuspendLayout();
            this.FileTextBox.Text = GetText(collectorSettings.Configuration);
            this.ResumeLayout();
        }

        // Can be used to verify data before saving it
        public bool VerifyData()
        {
            // Not currently verifying data
            return true;
        }

        // Reset to default value from XML configuration
        // using a custom method
        public void ResetToAgentDefaults()
        {
            this.FileTextBox.Text =
                getText(collectorSettings.DefaultConfiguration);
        }

        // Saves data changed in the editor to the test configuration
        // settings. Does not change the default value.
        public DataCollectorSettings SaveData()
        {
            collectorSettings.Configuration.InnerXml =
                String.Format(
                    @"<MyCollectorName
      xmlns=""http://MyCompany/schemas/MyDataCollector/1.0"">
  <File FullPath=""{0}"" />
</MyCollectorName>",
                    FileTextBox.Text);
            return collectorSettings;
        }

        // Reads the configuration settings
        private string getText(XmlElement element)
        {
            // Setup namespace manager with our namespace
            XmlNamespaceManager nsmgr =
                new XmlNamespaceManager(
                    element.OwnerDocument.NameTable);

            // Find all the "File" elements under our configuration
            XmlNodeList files = element.SelectNodes("//ns:MyDataCollector/ns:File", nsmgr);

            string result = String.Empty;
            if (files.Count > 0)
            {
                XmlAttribute pathAttribute = files[0].Attributes["FullPath"];
                if (pathAttribute != null &&
                    !String.IsNullOrEmpty(pathAttribute.Value))
                {
                    result = pathAttribute.Value;
                }
            }

            return result;
        }
    }
}
```

## Example configuration file

The following is a sample configuration file for your diagnostic data collector configuration editor.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <section
      name="DataCollectorConfiguration"
      type="Microsoft.VisualStudio.QualityTools.Execution.DataCollectorConfigurationSection,
        Microsoft.visualStudio.QualityTools.ExecutionCommon,
        Version=4.0.0.0, Culture=neutral,
        PublicKeyToken=b03f5f7f11d50a3a" />
  </configSections>
  <DataCollectorConfiguration
      xmlns="http://microsoft.com/schemas/VisualStudio/TeamTest/11">
    <DataCollector
        typeUri="datacollector://MyCompany/MyDataCollector/1.0">
      <DefaultConfiguration>
        <!-- Your default config settings-->
        <File FullPath="c:\temp\logfile1.txt" />
      </DefaultConfiguration>
    </DataCollector>
  </DataCollectorConfiguration>
</configuration>

```

## Compiling the Code

### To create the code project for this diagnostic adapter

1.  Create a new class library project that is named "MyDataCollector".

2.  In **Solution Explorer**, right-click the project and then choose **Properties**. To select a folder to add, choose **Reference Paths** and then choose the ellipsis (**…**).

     The **Select Reference Path** dialog box is displayed.

3.  Select the following path, based on your installation directory: *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PrivateAssemblies*. Choose **OK**.

4.  To add the folder to your reference path, choose **Add Folder**.

     The folder is displayed in the list of reference paths.

5.  Choose the **Save All** icon to save the reference paths.

6.  Add the assembly **Microsoft.VisualStudio.QualityTools.ExecutionCommon**.

    1.  In **Solution Explorer**, right-click **References** and then choose **Add Reference**.

    2.  Choose **Browse** and locate **Microsoft.VisualStudio.QualityTools.ExecutionCommon.dll**.

         This assembly will be found in *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PrivateAssemblies*.

    3.  Choose **OK**.

7.  Add the assembly **Microsoft.VisualStudio.QualityTools.Common**.

    1.  In Solution Explorer, right-click **References** and select **Add Reference**.

    2.  Choose **Browse** and locate **Microsoft.VisualStudio.QualityTools.Common.dll**.

         This assembly will be found in *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PrivateAssemblies*.

    3.  Choose **OK**.

8.  Copy the diagnostic data adapter class that was listed earlier in this document into the class for your class library. Save this class.

9. To add a user control to the project, right-click MyDataCollector project in Solution Explorer, point to **Add**, and then choose **User Control**. Choose **Add**.

10. By using the Toolbox, add a label to the user control and change the Text property to **File Name:**.

11. By using the Toolbox, add a text box to the user control and change the name to **textBoxFileName**.

12. In **Solution Explorer**, right-click the user control and then choose **View Code.** Replace this user control class with the user control class that was listed earlier in this document. Save this class.

    > [!NOTE]
    > By default, the user control is called UserControl1. Make sure that the user control class code uses the name of your user control.

13. To create the configuration file, in **Solution Explorer** right-click the solution, point to **Add**, and then choose **New Item**. Choose to select **Application Configuration File**, and then choose **Add**. This will add a file that is named **App.config** to your solution.

14. Copy the XML from the sample that was provided earlier into the XML file. Save the file.

15. Build the solution, and then copy the built assembly and the `App.config` file into the *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PrivateAssemblies\DataCollectors* directory.

16. Create test settings that use this custom data diagnostic adapter. Configure the test settings to collect a file that exists.

     If you are running your tests from Microsoft Test Manager, you can assign these test settings to your test plan before you run your tests or use the Run with Options command to assign test settings and override test settings. For more information about test settings, see [Collect Diagnostic Information Using Test Settings](../test/collect-diagnostic-information-using-test-settings.md).

17. Run your tests by using the test settings with your diagnostic data adapter selected.

     The data file that you specified will be attached to your test results when the test is executed.

## See also

- [How to: Create a Diagnostic Data Adapter](../test/how-to-create-a-diagnostic-data-adapter.md)
- [How to: Create a Custom Editor for Data for Your Diagnostic Data Adapter](../test/how-to-create-a-custom-editor-for-data-for-your-diagnostic-data-adapter.md)
- [How to: Install a Custom Diagnostic Data Adapter](../test/how-to-install-a-custom-diagnostic-data-adapter.md)
- [Creating a Diagnostic Data Adapter to Collect Custom Data or Affect a Test Machine](../test/create-a-diagnostic-data-adapter-to-collect-custom-data-or-affect-a-test-machine.md)