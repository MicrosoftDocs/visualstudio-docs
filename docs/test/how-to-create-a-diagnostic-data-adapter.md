---
title: "How to: Create a Diagnostic Data Adapter"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Diagnostic Data Adapter, creating"
ms.assetid: bd7ad36c-54cb-4d2a-9aea-9d10ad98d7ba
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create a diagnostic data adapter

To create a *diagnostic data adapter*, you create a class library using Visual Studio, and then add the Diagnostic Data Adapter APIs provided by Visual Studio Enterprise to your class library. Send any information that you want as a stream or a file to the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionSink> provided by the framework, when handling the events that are raised during the test run. The streams or files sent to the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionSink> are stored as attachments to the test results when your test finishes. If you create a bug from these test results or when you use [!INCLUDE[mtrlong](../test/includes/mtrlong_md.md)], the files are also linked to the bug.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

You can create a diagnostic data adapter that affects the machine where your tests are run, or a machine that is part of the environment you are using to run your application under test. For example, collecting files on your test machine where the tests are run, or collecting files on the machine serving in the web server role for your application.

You can give your diagnostic data adapter a friendly name that displays when you create your test settings using Microsoft Test Manager or using Visual Studio. Test settings enable you to define which machine role will run specific diagnostic data adapters in your environment when you run your tests. You can also configure your diagnostic data adapters when you create your test settings. For example, you may create a diagnostic data adapter that collects custom logs from your web server. When you create your test settings, you can select to run this diagnostic data adapter on the machine or machines that are performing this web server role and you can modify the configuration for your test settings to collect only the last three logs that were created. For more information about test settings, see [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md).

Events are raised when you run your tests so that your diagnostic data adapter can perform tasks at that point in the test.

> [!IMPORTANT]
> These events may be raised on different threads, especially when you have tests running on multiple machines. Therefore, you must be aware of possible threading issues and not inadvertently corrupt the internal data of the custom adapter. Make sure your diagnostic data adapter is thread safe.

The following is a partial list of key events that you can use when you create your diagnostic data adapter. For a complete list of diagnostic data adapter events, see the abstract <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents> class.

|Event|Description|
|-|-----------------|
|<xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents.SessionStart>|Start of your test run|
|<xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents.SessionEnd>|End of your test run|
|<xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents.TestCaseStart>|Start of each test in the test run|
|<xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents.TestCaseEnd>|End of each test in the test run|
|<xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents.TestStepStart>|Start of each test step in a test|
|<xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents.TestStepEnd>|End of each test step in a test|

> [!NOTE]
> When a manual test is completed, no more data collection events are sent to the diagnostic data adapter. When a test is rerun, it will have a new test case identifier. If a user resets a test during a test (which raises the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents.TestCaseReset> event), or changes a test step outcome, no data collection event is sent to the diagnostic data adapter, but the test case identifier remains the same. To determine whether a test case has been reset, you must track the test case identifier in your diagnostic data adapter.

Use the following procedure to create diagnostic data adapter that collects a data file that is based on information that you configure when you create your test settings.

For a complete example diagnostic data adapter project, including a custom configuration editor, see [Sample project for creating a diagnostic data adapter](../test/quickstart-create-a-load-test-project.md).

## Create and install a diagnostic data adapter

1. Create a new **Class Library** project.

2. Add the assembly **Microsoft.VisualStudio.QualityTools.ExecutionCommon**.

   1. In **Solution Explorer**, right-click **References** and choose the **Add Reference** command.

   2. Choose **.NET** and locate **Microsoft.VisualStudio.QualityTools.ExecutionCommon.dll**.

   3. Choose **OK**.

3. Add the assembly **Microsoft.VisualStudio.QualityTools.Common**.

   1. In **Solution Explorer**, right-click **References** and select the **Add Reference** command.

   2. Choose **/.NET**, locate **Microsoft.VisualStudio.QualityTools.Common.dll**.

   3. Choose **OK**.

4. Add the following `using` directives to your class file:

   ```csharp
   using Microsoft.VisualStudio.TestTools.Common;
   using Microsoft.VisualStudio.TestTools.Execution;
   using System.Linq;
   using System.Text;
   using System.Xml;
   using System;
   ```

5. Add the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorTypeUriAttribute> to the class for your diagnostic data adapter to identify it as a diagnostic data adapter, replacing **Company**, **Product**, and **Version** with the appropriate information for your Diagnostic Data Adapter:

   ```csharp
   [DataCollectorTypeUri("datacollector://Company/Product/Version")]
   ```

6. Add the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorFriendlyNameAttribute> attribute to the class, replacing the parameters with the appropriate information for your Diagnostic Data Adapter:

   ```csharp
   [DataCollectorFriendlyName("Collect Log Files", false)]
   ```

    This friendly name is displayed in the test settings activity.

   > [!NOTE]
   > You can also add the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute> to specify the `Type` of your custom configuration editor for this data adapter, and to optionally specify the help file to use for the editor.
   >
   > You can also apply the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorEnabledByDefaultAttribute> to specify that it should always be enabled.

7. Your diagnostic data adapter class must inherit from the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollector> class as follows:

   ```csharp
   public class MyDiagnosticDataAdapter : DataCollector
   ```

8. Add the local variables as follows:

   ```csharp
   private DataCollectionEvents dataEvents;
   private DataCollectionLogger dataLogger;
   private DataCollectionSink dataSink;
   private XmlElement configurationSettings;
   ```

9. Add the <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollector.Initialize*> method and a **Dispose** method. In the `Initialize` method, you initialize the data sink, any configuration data from test settings, and register the event handlers you want to use as follows:

    ```csharp
    public override void Initialize(
        XmlElement configurationElement,
        DataCollectionEvents events,
        DataCollectionSink sink,
        DataCollectionLogger logger,
        DataCollectionEnvironmentContext environmentContext)
    {
           dataEvents = events;  // The test events
           dataLogger = logger;  // The error and warning log
           dataSink = sink;      // Saves collected data
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
    }

    public override void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Unregister the registered events
            dataEvents.SessionStart -=
                new EventHandler<SessionStartEventArgs>(OnSessionStart);
            dataEvents.SessionEnd -=
                new EventHandler<SessionEndEventArgs>(OnSessionEnd);
            dataEvents.TestCaseStart -=
                new EventHandler<TestCaseStartEventArgs>(OnTestCaseStart);
            dataEvents.TestCaseEnd -=
                new EventHandler<TestCaseEndEventArgs>(OnTestCaseEnd);
        }
    }
    ```

10. Use the following event handler code and private method to collect the log file generated during the test:

    ```csharp
    public void OnTestCaseEnd(sender, TestCaseEndEventArgs e)
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

    // A private method that returns the file names
    private List<string> getFilesToCollect()
    {
        // Get a namespace manager with our namespace
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
    ```

     These files are attached to the test results. If you create a bug from these test results or when you use [!INCLUDE[mtrlong](../test/includes/mtrlong_md.md)], the files are also attached to the bug.

     If you want to use your own editor to collect data to use in your test settings, see [How to: Create a custom editor for data for your diagnostic data adapter](../test/quickstart-create-a-load-test-project.md).

11. To collect a log file when a test finishes based on what the user configured in test settings, you must create an *App.config* file and add it to your solution. This file has the following format and must contain the URI for your diagnostic data adapter to identify it. Substitute real values for the "Company/ProductName/Version".

    > [!NOTE]
    > If you do not need to configure any information for your diagnostic data adapter, then you do not need to create a configuration file.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <configuration>
      <configSections>
        <section name="DataCollectorConfiguration" type="Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationSection, Microsoft.VisualStudio.QualityTools.ExecutionCommon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a "/>
      </configSections>
      <DataCollectorConfiguration xmlns="http://microsoft.com/schemas/VisualStudio/TeamTest/2010">
        <DataCollector typeUri="datacollector://MyCompany/MyProduct/1.0">
          <DefaultConfiguration>
            <!-- Your default config settings -->
            <Binaries>
              <Binary FullPath="C:\Example\Example.dll"/>
              <Binary FullPath="\\Server2\Example2.dll"/>
            </Binaries>
            <Symbols>
              <Symbol FullPath="\\ExampleServer\ExampleSymbol.pdb"/>
            </Symbols>
          </DefaultConfiguration>
        </DataCollector>
      </DataCollectorConfiguration>
    </configuration>
    ```

    > [!NOTE]
    > The default configuration element can contain any data that you require. If the user does not configure the diagnostic data adapter in test settings, then the default data will be passed to your diagnostic data adapter when it is executed. Because the XML you add to the `<DefaultConfigurations>` section is not likely to be part of the declared schema, you can ignore any XML errors it generates.
    >
    > There are other examples of configuration files in the following path based on your installation directory: *Program Files\Microsoft Visual Studio 10.0\Common7\IDE\PrivateAssemblies\DataCollectors*.

     For more information about how to configure your test settings to use an environment when you run your tests, see [Collect diagnostic data in manual tests (Azure Test Plans)](/azure/devops/test/mtm/collect-more-diagnostic-data-in-manual-tests?view=vsts).

     For more information about installing the configuration file, see [How to: Install a custom diagnostic data adapter](../test/quickstart-create-a-load-test-project.md)

12. Build your solution to create your diagnostic data adapter assembly.

13. For information about installing your custom editor, see [How to: Install a custom diagnostic data adapter](../test/quickstart-create-a-load-test-project.md).

14. For more information about how to configure your test settings to use an environment when you run your tests, see [Collect diagnostic data in manual tests (Azure Test Plans)](/azure/devops/test/mtm/collect-more-diagnostic-data-in-manual-tests?view=vsts).

15. To select your diagnostic data adapter, you must first select an existing test settings or create a new one from Microsoft Test Manager or Visual Studio. The adapter is displayed on the **Data and Diagnostics** tab of your test settings with the friendly name that you assigned to the class.

16. Set these test settings to be active. For more information about test settings, see [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md).

17. Run your tests using the test settings with your diagnostic data adapter selected.

    The data file that you specified is attached to your test results.

## See also

- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorConfigurationEditorAttribute>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionEvents>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollector>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectionSink>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorTypeUriAttribute>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorFriendlyNameAttribute>
- <xref:Microsoft.VisualStudio.TestTools.Execution.DataCollectorEnabledByDefaultAttribute>
- [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md)
- [Collect diagnostic data in manual tests (Azure Test Plans)](/azure/devops/test/mtm/collect-more-diagnostic-data-in-manual-tests?view=vsts)
- [Collect diagnostic data while testing (Azure Test Plans)](/azure/devops/test/collect-diagnostic-data?view=vsts)
- [How to: Create a custom editor for data for your diagnostic data adapter](../test/quickstart-create-a-load-test-project.md)
