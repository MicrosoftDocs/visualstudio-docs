---
title: "Using the IntelliTrace stand-alone collector"
description: Use the IntelliTrace stand-alone collector to collect data without installing Visual Studio and without changing the target system's environment.
ms.date: "10/14/2023"
ms.topic: how-to
f1_keywords:
  - "vs.historicaldebug.collectdataoutsideVS"
helpviewer_keywords:
  - "IntelliTrace, debugging applications in production"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Using the IntelliTrace stand-alone collector (C#, Visual Basic)

The **IntelliTrace stand-alone collector** lets you collect IntelliTrace diagnostic data for your apps on production servers or other environments without installing Visual Studio on the target machine and without changing the target system's environment. The IntelliTrace stand-alone collector works on web, SharePoint, WPF and Windows Forms apps. When you're done collecting data, just delete the collector to uninstall it.

> [!NOTE]
> For recommended approaches to diagnosing issues on production servers, see [Diagnose problems after deployment](../debugger/diagnose-problems-after-deployment.md).

 **Requirements**

- .NET Framework 3.5 or higher

- Visual Studio Enterprise (but not Professional or Community editions) on a development computer or other computer to open .iTrace files

  > [!NOTE]
  > Make sure to save your symbol (.pdb) files. To debug with IntelliTrace and step through code, you must have the matching source files and symbol files. See [Diagnose problems after deployment](../debugger/diagnose-problems-after-deployment.md).

  **FAQ**

- [What apps work with the collector?](#WhatApps)

- [How do I get started?](#GetStarted)

- [How can I get the most data without slowing down my app?](#Minimizing)

- [Where else can I get IntelliTrace data?](#WhereElse)

## <a name="WhatApps"></a> What apps work with the collector?

- ASP.NET Web apps hosted on Internet Information Services (IIS) version 7.0, 7.5, 8.0, 12.0, and 16.0

- SharePoint 2010 and SharePoint 2013 applications

- Windows Presentation Foundation (WPF) and Windows Forms apps.

## <a name="GetStarted"></a> How do I get started?

1. [Install the collector](#BKMK_Install_the_IntelliTrace_Stand_Alone_Collector)

2. [Set up permissions for the collector directory](#ConfigurePermissionsRunningCollector)

3. [Install IntelliTrace PowerShell cmdlets to collect data for Web apps or SharePoint applications](#BKMK_Set_up_the_IntelliTrace_PowerShell_commandlets)

4. [Set up permissions for the .iTrace file directory](#BKMK_Create_and_Configure_a_Log_File_Directory)

5. [Collect data from a Web app or SharePoint application](#BKMK_Collect_Data_from_IIS_Application_Pools)

    -or-

    [Collect data from a managed app](#BKMK_Collect_Data_from_Executables)

6. [Open the .iTrace file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files)

## <a name="BKMK_Install_the_IntelliTrace_Stand_Alone_Collector"></a> Install the collector

1. On your app's server, create the collector directory, for example: **C:\IntelliTraceCollector**

2. Get the collector from the Visual Studio installation folder.

   1. Copy IntelliTraceCollection.cab from the folder where the collector is installed, for example:
        ::: moniker range=">=visualstudio"
        **..\Microsoft Visual Studio\18\Enterprise\Common7\IDE\CommonExtensions\Microsoft\IntelliTrace**
        ::: moniker-end
        ::: moniker range="<=vs-2022"
        **..\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\CommonExtensions\Microsoft\IntelliTrace**
        ::: moniker-end

        or, for previous versions of Visual Studio:

        **..\Microsoft Visual Studio 12.0\Common7\IDE\CommonExtensions\Microsoft\IntelliTrace\12.0.0**

   2. Put IntelliTraceCollection.cab in the collector directory, for example: **C:\IntelliTraceCollector**

3. Expand IntelliTraceCollection.cab:

   1. On your app's server, open a command prompt window as an administrator.

   2. Browse to the collector directory, for example: **C:\IntelliTraceCollector**

   3. Use the **expand** command, including the period (**.**) at the end, to expand IntelliTraceCollection.cab:

        `expand  /f:* IntelliTraceCollection.cab .`

       > [!NOTE]
       > The period (**.**) preserves the subfolders that contain localized collection plans.

## <a name="ConfigurePermissionsRunningCollector"></a> Set up permissions for the collector directory

1. On your app's server, open a command prompt window as an administrator.

2. Use the Windows **icacls** command to give the server administrator full permissions to the collector directory. For example:

     `icacls "C:\IntelliTraceCollector" /grant "` *\<Domain\AdministratorID>* `":F`

3. To collect data for a Web app or SharePoint application:

    1. Give the person who will run the IntelliTrace PowerShell cmdlets full permissions to the collector directory.

         For example:

         `icacls "C:\IntelliTraceCollector" /grant "` *\<Domain\UserID>* `":F`

    2. Give the application pool for the Web app or SharePoint application read and execute permissions to the collector directory.

         For example:

        - For a Web app in the **DefaultAppPool** application pool:

             `icacls "C:\IntelliTraceCollector" /grant "IIS APPPOOL\DefaultAppPool":RX`

        - For a SharePoint application in the **SharePoint - 80** application pool:

             `icacls "C:\IntelliTraceCollector" /grant "IIS APPPOOL\SharePoint - 80":RX`

## <a name="BKMK_Set_up_the_IntelliTrace_PowerShell_commandlets"></a> Install IntelliTrace PowerShell cmdlets to collect data for Web apps or SharePoint applications

1. On your app's server, make sure that PowerShell is enabled. On most versions of Windows Server, you can add this feature in the **Server Manager** administrative tool.

     ![Adding PowerShell by using Server Manager](../debugger/media/intellitrace_servermanager_addpowershell.png "INTELLITRACE_ServerManager_AddPowerShell")

2. Install the IntelliTrace PowerShell cmdlets.

    1. Open a PowerShell command window as an administrator.

        1. Choose **Start**, **All Programs**, **Accessories**, **Windows PowerShell**.

        2. Choose one of the following steps:

            - On 64-bit operating systems, open the shortcut menu for **Windows PowerShell**. Choose **Run as administrator**.

            - On 32-bit operating systems, open the shortcut menu for **Windows PowerShell (x86)**. Choose **Run as administrator**.

    2. In the PowerShell command window, use the **Import-Module** command to import **Microsoft.VisualStudio.IntelliTrace.PowerShell.dll**.

         For example:

         `Import-Module "C:\IntelliTraceCollector\Microsoft.VisualStudio.IntelliTrace.PowerShell.dll"`

## <a name="BKMK_Create_and_Configure_a_Log_File_Directory"></a> Set up permissions for the .iTrace file directory

1. On your app's server, create the .iTrace file directory, for example: **C:\IntelliTraceLogFiles**

   > [!NOTE]
   > - To avoid slowing down your app, choose a location on a local high-speed disk that's not very active.
   >   - You can put .iTrace files and the collector files in the same place. However, if you have a Web app or SharePoint application, make sure this place is outside the directory that hosts the application.
   >
   > [!IMPORTANT]
   > - Restrict the .iTrace file directory only to those identities that must work with the collector. An .iTrace file might contain sensitive information, such as data from users, databases, other source locations, and connection strings because IntelliTrace can record any data that passes into method parameters or as return values.
   >   - Make sure those who can open .iTrace files have the authority to view sensitive data. Use caution when sharing .iTrace files. If other people must have access, copy the files to a secure shared location.

2. For a Web app or SharePoint application, give its application pool full permissions to the .iTrace file directory. You can use the Windows **icacls** command or use Windows Explorer (or File Explorer).

    For example:

   - To set up permissions with the Windows **icacls** command:

     - For a Web app in the **DefaultAppPool** application pool:

        `icacls "C:\IntelliTraceLogFiles" /grant "IIS APPPOOL\DefaultAppPool":F`

     - For a SharePoint application in the **SharePoint - 80** application pool:

        `icacls "C:\IntelliTraceLogFiles" /grant "IIS APPPOOL\SharePoint - 80":F`

        -or-

   - To set up permissions with Windows Explorer (or File Explorer):

     1. Open **Properties** for the .iTrace file directory.

     2. On the **Security** tab, choose **Edit**, **Add**.

     3. Make sure **Built-in security principals** appears in the **Select this object type** box. If it's not there, choose **Object Types** to add it.

     4. Make sure your local computer appears in the **From this location** box. If it's not there, choose **Locations** to change it.

     5. In the **Enter the object names to select** box, add the application pool for the Web app or SharePoint application.

     6. Choose **Check Names** to resolve the name. Choose **OK**.

     7. Make sure the application pool has **Full control**.

## <a name="BKMK_Collect_Data_from_IIS_Application_Pools"></a> Collect data from a Web app or SharePoint application

1. To start collecting data, open a PowerShell command window as an administrator, then run this command:

     `Start-IntelliTraceCollection` `"` *\<ApplicationPool>* `"` *\<PathToCollectionPlan>* *\<FullPathToITraceFileDirectory>*

    > [!IMPORTANT]
    > After you run this command, type **Y** to confirm that you want to start collecting data.

     For example, to collect data from a SharePoint application in the **SharePoint - 80** application pool:

     `Start-IntelliTraceCollection "SharePoint - 80" "C:\IntelliTraceCollector\collection_plan.ASP.NET.default.xml" "C:\IntelliTraceLogFiles"`

    |Name|Description|
    |-|-|
    |*ApplicationPool*|The name of the application pool where your application runs|
    |*PathToCollectionPlan*|The path to a collection plan, an .xml file that configures settings for the collector.<br /><br /> You can specify a plan that comes with the collector. The following plans work for Web apps and SharePoint applications:<br /><br /> -   collection_plan.ASP.NET.default.xml<br />     Collects only IntelliTrace events and SharePoint events, including exceptions, database calls, and Web server requests.<br />-   collection_plan.ASP.NET.trace.xml<br />     Collects function calls and all the data in collection_plan.ASP.NET.default.xml. This plan is good for detailed analysis, but it might slow down your app more than collection_plan.ASP.NET.default.xml.<br /><br /> To avoid slowing down your app, customize these plans or create your own plan. For security, put any custom plans in the same secure location as the collector files. See [Creating and Customizing IntelliTrace Collection Plans](https://devblogs.microsoft.com/devops/modifying-an-intellitrace-collection-plan-for-the-stand-alone-collector/) and [How do I get the most data without slowing down my app?](#Minimizing) **Note:**  By default, the max size of the .iTrace file is 100 MB. When the .iTrace file reaches this limit, the collector deletes the file's earliest entries to make space for newer entries. To change this limit, edit the collection plan's `MaximumLogFileSize` attribute. <br /><br /> *Where can I find localized versions of these collection plans?*<br /><br /> You can find localized plans in the collector's subfolders.|
    |*FullPathToITraceFileDirectory*|The full path to the .iTrace file directory. **Security Note:**  Provide the full path, not a relative path.|

     The collector attaches to the application pool and starts collecting data.

     *Can I open the .iTrace file at this time?* No, the file is locked during data collection.

2. Reproduce the problem.

3. To create a checkpoint of the .iTrace file, use this syntax:

     `Checkpoint-IntelliTraceCollection` `"` *\<ApplicationPool>* `"`

4. To check collection status, use this syntax:

     `Get-IntelliTraceCollectionStatus`

5. To stop collecting data, use this syntax:

     `Stop-IntelliTraceCollection` `"` *\<ApplicationPool>* `"`

    > [!IMPORTANT]
    > After you run this command, type **Y** to confirm that you want to stop collecting data. Otherwise, the collector might continue collecting data, the iTrace file will remain locked, or the file might not contain any useful data.

6. [Open the .iTrace file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files)

## <a name="BKMK_Collect_Data_from_Executables"></a> Collect data from a managed app

1. To start your app and collect data at the same time, use this syntax:

     *\<FullPathToIntelliTraceCollectorExecutable>* `\IntelliTraceSC.exe launch /cp:` *\<PathToCollectionPlan>* `/f:` *\<FullPathToITraceFileDirectoryAndFileName>* *\<PathToAppExecutableFileAndFileName>*

     For example, to collect data from an app named **MyApp**:

     `C:IntelliTraceCollectorIntelliTraceSC.exe launch /cp:"C:IntelliTraceCollectorcollection_plan.ASP.NET.default.xml" /f:"C:IntelliTraceLogFilesMyApp.itrace" "C:MyAppMyApp.exe"`

    |Name|Description|
    |-|-|
    |*FullPathToIntelliTraceCollectorExecutable*|The full path to the collector executable, IntelliTraceSC.exe|
    |*PathToCollectionPlan*|The path to a collection plan, an .xml file that configures settings for the collector.<br /><br /> You can specify a plan that comes with the collector. The following plans work for managed apps:<br /><br /> -   collection_plan.ASP.NET.default.xml<br />     Collects IntelliTrace events only, including exceptions, database calls, and Web server requests.<br />-   collection_plan.ASP.NET.trace.xml<br />     Collects function calls and all the data in collection_plan.ASP.NET.default.xml. This plan is good for detailed analysis, but it might slow down your app more than collection_plan.ASP.NET.default.xml.<br /><br /> To avoid slowing down your app, customize these plans or create your own plan. For security, put any custom plans in the same secure location as the collector files. See [Creating and Customizing IntelliTrace Collection Plans](https://devblogs.microsoft.com/devops/modifying-an-intellitrace-collection-plan-for-the-stand-alone-collector/) and [How do I get the most data without slowing down my app?](#Minimizing) **Note:**  By default, the max size of the .iTrace file is 100 MB. When the .iTrace file reaches this limit, the collector deletes the file's earliest entries to make space for newer entries. To change this limit, edit the collection plan's `MaximumLogFileSize` attribute. <br /><br /> *Where can I find localized versions of these collection plans?*<br /><br /> You can find localized plans in the collector's subfolders.|
    |*FullPathToITraceFileDirectoryAndFileName*|The full path to the .iTrace file directory and the .iTrace file name with the **.itrace** extension. **Security Note:**  Provide the full path, not a relative path.|
    |*PathToAppExecutableFileAndFileName*|The path and file name of your managed app|

2. Stop data collection by exiting the app.

3. [Open the .iTrace file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files)

## <a name="BKMK_View_IntelliTrace_Log_Files"></a> Open the .iTrace file in Visual Studio Enterprise

> [!NOTE]
> To debug with IntelliTrace and step through code, you must have the matching source files and symbol files. See [Diagnose problems after deployment](../debugger/diagnose-problems-after-deployment.md).

1. Move the .iTrace file or copy it to a computer with Visual Studio Enterprise (but not Professional or Community editions).

2. Double-click the .iTrace file outside Visual Studio, or open the file from inside Visual Studio.

     Visual Studio shows the **IntelliTrace Summary** page. In most sections, you can review events or other items, choose an item, and start debugging with IntelliTrace at the point where and when an event happened. See [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md).

    > [!NOTE]
    > To debug with IntelliTrace and step through code, you must have the matching source files and symbol files on your development machine. See [Diagnose problems after deployment](../debugger/diagnose-problems-after-deployment.md).

## <a name="Minimizing"></a> How do I get the most data without slowing down my app?
 IntelliTrace can collect lots of data, so the impact on your app's performance depends on the data that IntelliTrace collects and the kind of code it analyzes. See [Optimizing IntelliTrace Collection on Production Servers](https://devblogs.microsoft.com/devops/optimizing-intellitrace-collection-on-production-server/).

 Here are some ways to get the most data without slowing down your app:

- Run the collector only when you think there's a problem, or when you can reproduce the problem.

   Start collection, reproduce the problem, and then stop collection. Open the .iTrace file in Visual Studio Enterprise and examine the data. See [Open the .iTrace file in Visual Studio Enterprise](#BKMK_View_IntelliTrace_Log_Files).

- For Web apps and SharePoint applications, the collector records data for every app that shares the specified application pool. This might slow down any app that shares the same application pool, even though you can only specify modules for a single app in a collection plan.

   To prevent the collector from slowing down other apps, host each app in its own application pool.

- Review the events in the collection plan for which IntelliTrace collects data. Edit the collection plan to disable events that aren't relevant or don't interest you.

   To disable an event, set the `enabled` attribute for the `<DiagnosticEventSpecification>` element to `false`:

   `<DiagnosticEventSpecification enabled="false">`

   If the `enabled` attribute doesn't exist, the event is enabled.

   *How does this improve performance?*

  - You can reduce startup time by disabling events that aren't relevant to the app. For example, disable Windows Workflow events for apps that don't use Windows Workflow.

  - You can improve both startup and run-time performance by disabling registry events for apps that access the registry but don't show problems with registry settings.

- Review the modules in the collection plan for which IntelliTrace collects data. Edit the collection plan to include only the modules that interest you:

  1. Open the collection plan. Find the `<ModuleList>` element.

  2. In `<ModuleList>`, set the `isExclusionList` attribute to `false`.

  3. Use the `<Name>` element to specify each module with one of the following: file name, string value to include any module whose name contains that string, or public key.

     For example, to collect data from just the main Web module of the Fabrikam Fiber Web app, create a list like this one:

  ```xml
  <ModuleList isExclusionList="false">
     <Name>FabrikamFiber.Web.dll</Name>
  </ModuleList>
  ```

   To collect data from any module whose name includes "Fabrikam", create a list like this one:

  ```xml
  <ModuleList isExclusionList="false">
     <Name>Fabrikam</Name>
  </ModuleList>
  ```

   To collect data from modules by specifying their public key tokens, create a list like this one:

  ```xml
  <ModuleList isExclusionList="false">
     <Name>PublicKeyToken:B77A5C561934E089</Name>
     <Name>PublicKeyToken:B03F5F7F11D50A3A</Name>
     <Name>PublicKeyToken:31BF3856AD364E35</Name>
     <Name>PublicKeyToken:89845DCD8080CC91</Name>
     <Name>PublicKeyToken:71E9BCE111E9429C</Name>
  </ModuleList>
  ```

   *How does this improve performance?*

   This reduces the amount of method call information and other instrumentation data that IntelliTrace collects when the app starts and runs. This data lets you:

  - Step through code after collecting the data.

  - Examine values passed to and returned from function calls.

    *Why not exclude modules instead?*

    By default, collection plans exclude modules by setting the `isExclusionList` attribute to `true`. However, excluding modules might still result in collecting data from modules that don't meet the list's criteria and might not interest you, such as third-party or open-source modules.

- *Is there any data that IntelliTrace doesn't collect?*

   Yes, to reduce performance impact, IntelliTrace restricts data collection to values of primitive data types passed to and returned from methods and to values of primitive data types in fields on top-level objects passed to and returned from methods.

   For example, suppose you have an `AlterEmployee` method signature that accepts an integer `id` and an `Employee` object `oldemployee`:

   `public Employee AlterEmployee(int id, Employee oldemployee)`

   The `Employee` type has the following attributes: `Id`, `Name`, and `HomeAddress`. An association relationship exists between `Employee` and the `Address` type.

   ![Relationship between Employee and Address](../debugger/media/employeeaddressrelationship.png "EmployeeAddressRelationship")

   The collector records values for `id`, `Employee.Id`, `Employee.Name` and the `Employee` object returned from the `AlterEmployee` method. However, the collector doesn't record information about the `Address` object other than whether it was null or not. The collector also doesn't record data about local variables in the `AlterEmployee` method unless other methods use those local variables as parameters at which point they are recorded as method parameters.

## <a name="WhereElse"></a> Where else can I get IntelliTrace data?

You can get IntelliTrace data from an IntelliTrace debugging session in Visual Studio Enterprise. See [IntelliTrace Features](../debugger/intellitrace-features.md).

## Where can I get more information?
 [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md)

 [IntelliTrace](../debugger/intellitrace.md)

### Blogs
 [Using the IntelliTrace Standalone Collector Remotely](https://devblogs.microsoft.com/devops/using-the-intellitrace-standalone-collector-remotely/)

 [Creating and Customizing IntelliTrace Collection Plans](https://devblogs.microsoft.com/devops/modifying-an-intellitrace-collection-plan-for-the-stand-alone-collector/)

 [Optimizing IntelliTrace Collection on Production Servers](https://devblogs.microsoft.com/devops/optimizing-intellitrace-collection-on-production-server/)

 [Microsoft DevOps](https://devblogs.microsoft.com/devops/)

### Forums
 [Visual Studio Debugger](https://social.msdn.microsoft.com/Forums/en-US/home)

