---
title: "Create a Custom data editor for a Diagnostic Data Adapter in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Diagnostic Data Adapter, creating custom editor"
ms.assetid: 24970227-d1ea-4f6d-9839-e911478848ba
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Create a Custom Editor for Data for Your Diagnostic Data Adapter

When you create a diagnostic data adapter, you might want to enable the end user to configure specific data when your custom diagnostic data adapter is selected for their test settings. For example, you can select the configuration data that specifies which registry keys to extract, what level of network load to simulate, or in which directory to find temporary files or work files to attach.

You must use a configuration file to set up initial values for your diagnostic data adapter. You can provide a custom editor to enable the user to modify the configuration data.

To create your own editor, you will create a user control that implements <xref:Microsoft.VisualStudio.TestTools.Execution.IDataCollectorConfigurationEditor>.

Your diagnostic data adapter can use a <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute> to specify the editor class to use for editing diagnostic data configuration settings.

You also specify the default configuration data that you want to use.  See [Sample Project for Creating a Diagnostic Data Adapter](../test/sample-project-for-creating-a-diagnostic-data-adapter.md) for sample default configuration.

Use the following procedure to create a custom editor to update data for your test settings when your custom data diagnostic adapter is used.

> [!NOTE]
> To create a custom editor, you must first create your diagnostic data adapter that has the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute> applied to the class. You can use the optional <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute.HelpUri*> property in that attribute to specify the help content source for your editor. For more information about how to create your diagnostic data adapter, see [How to: Create a Diagnostic Data Adapter](../test/how-to-create-a-diagnostic-data-adapter.md).

For a complete example diagnostic data adapter project, including a custom configuration editor, see [Sample Project for Creating a Diagnostic Data Adapter](../test/sample-project-for-creating-a-diagnostic-data-adapter.md).

## To create a custom editor for your diagnostic data adapter

1.  Create a user control in the project for your data diagnostic adapter:

    1.  Right-click the code project that contains your diagnostic data adapter class, point to **Add** and then point to **User Control**.

    2.  For this example, add a label to the form with this text: **Data File Name:** and a text box named **FileTextBox** that will enable the user to enter the necessary data.

    > [!NOTE]
    > Only Windows Forms user controls are currently supported.

2.  Add these lines to the declaration section:

    ```csharp
    using System.Xml;
    using Microsoft.VisualStudio.TestTools.Common;
    using Microsoft.VisualStudio.TestTools.Execution;
    ```

3.  Make this user control into a custom editor.

    1.  Right-click the user control in your code project and point to **View code**.

    2.  Set the class to implement the editor interface <xref:Microsoft.VisualStudio.TestTools.Execution.IDataCollectorConfigurationEditor> as follows:

    ```csharp
    public partial class MyDataConfigEditor :
         UserControl, IDataCollectorConfigurationEditor
    ```

    1.  Right-click <xref:Microsoft.VisualStudio.TestTools.Execution.IDataCollectorConfigurationEditor> in the code, and select the **Implement Interface** command. The methods that you must implement for this interface are added to your class.

    2.  Add the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute> to your user control for your editor to identify it as a diagnostic data adapter editor, replacing **Company**, **Product**, and **Version** with the appropriate information for your diagnostic data adapter:

        ```csharp
        [DataCollectorConfigurationEditorTypeUri(
            "configurationeditor://MyCompany/MyConfigEditor/1.0")]
        ```

4.  Add two private variables as follows:

    ```csharp
    private DataCollectorSettings collectorSettings;
    private IServiceProvider ServiceProvider { get; set; }
    ```

5.  Add code to initialize your editor for your diagnostic data adapter. You can add default values to the fields in your user control by using data that is in the settings variable. This is the data that is in the `<DefaultConfiguration>` element in the XML configuration file for your adapter.

    ```csharp
    public void Initialize(
        IServiceProvider svcProvider,
        DataCollectorSettings settings)
    {
        ServiceProvider = svcProvider;
        collectorSettings = settings;

        // Display the default file name as listed in the settings file.
        this.SuspendLayout();
        this.FileTextBox.Text = getText(collectorSettings.Configuration);
        this.ResumeLayout();
    }
    ```

6.  Add code to save the data from your controls in your editor back into the XML format required by the diagnostic data adapter API as follows:

    ```csharp
    public DataCollectorSettings SaveData()
    {
        collectorSettings.Configuration.InnerXml =
            String.Format(
    @"<MyCollectorName
        xmlns=""http://MyCompany/schemas/MyDiagnosticDataCollector/1.0"">
      <File FullPath=""{0}"" />
    </MyCollectorName>",
        FileTextBox.Text);
        return collectorSettings;
    }
    ```

7.  If it is important to you, add code to verify the data is correct in the `VerifyData` method, or you can have the method return `true`.

    ```csharp
    public bool VerifyData()
    {
        // Not currently verifying data
        return true;
    }
    ```

8.  (Optional) You can add code to reset the data to the initial settings that are provided in the XML configuration file in the `ResetToAgentDefaults()` method which uses the private `getText()` method.

    ```csharp
    // Reset to default value from XML configuration
    // using a custom getText() method
    public void ResetToAgentDefaults()
    {
        this.FileTextBox.Text = getText(collectorSettings.DefaultConfiguration);
    }

    // Local method to read the configuration settings
    private string getText(XmlElement element)
    {
        // Setup namespace manager with our namespace
        XmlNamespaceManager nsmgr =
            new XmlNamespaceManager(
                element.OwnerDocument.NameTable);

        // Find all the "File" elements under our configuration
        XmlNodeList files = element.SelectNodes("//ns:MyCollectorName/ns:File", nsmgr);

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
    ```

9. Build your solution. Copy the data diagnostic adapter assembly and the XML configuration file (`<diagnostic data adapter name>.dll.config`) to the following location based on your installation directory: *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PrivateAssemblies\DataCollectors*.

    > [!NOTE]
    > Although the configuration editor can be in a project and an assembly that is different from the diagnostic data adapter, they can also be in the same assembly.

10. To use your diagnostic data adapter in testing, you must select from the list of existing test settings or create a new one from Microsoft Test Manager or Visual Studio and then select your diagnostic data adapter.

     The adapter is displayed on the **Data and Diagnostics** tab of your test settings with the friendly name that you assigned to the class.

11. To configure your diagnostic data adapter for your test settings, choose **Configure** next to the adapter name.

     Your custom editor is now displayed.

12. Edit the fields in your custom editor as required, and then choose **Save**.

13. If you are running your tests from Microsoft Test Manager, you can assign these test settings to your test plan before you run your tests, or use the **Run with Options** command to assign test settings and override test settings. For more information about test settings, see [Collect Diagnostic Information Using Test Settings](../test/collect-diagnostic-information-using-test-settings.md).

14. Before you can use your new configuration editor with a diagnostic data adapter, you must apply the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute> to each diagnostic data adapter class that you want to use the editor, and recompile and reinstall them on the client computer. For more information about how to install diagnostic data adapters and configuration editors, see [How to: Install a Custom Diagnostic Data Adapter](../test/how-to-install-a-custom-diagnostic-data-adapter.md).

15. Run your tests using the test settings with your diagnostic data adapter selected.

     The data file that you specified in your editor is attached to your test results.

 For more information about how to configure your test settings to use an environment when you run your tests, see [Collect diagnostic data while testing (VSTS)](/vsts/manual-test/collect-diagnostic-data) or [Collect diagnostic data in manual tests (VSTS)](/vsts/manual-test/mtm/collect-more-diagnostic-data-in-manual-tests).

## See also

- <xref:Microsoft.VisualStudio.TestTools.Execution.IDataCollectorConfigurationEditor>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute>
- [Creating a Diagnostic Data Adapter to Collect Custom Data or Affect a Test Machine](../test/create-a-diagnostic-data-adapter-to-collect-custom-data-or-affect-a-test-machine.md)
- [Collect Diagnostic Information Using Test Settings](../test/collect-diagnostic-information-using-test-settings.md)
- [Sample Project for Creating a Diagnostic Data Adapter](../test/sample-project-for-creating-a-diagnostic-data-adapter.md)