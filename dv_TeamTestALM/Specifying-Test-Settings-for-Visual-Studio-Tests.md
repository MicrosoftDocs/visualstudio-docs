---
title: "Specifying Test Settings for Visual Studio Tests"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0c15317e-80c6-4317-aed3-82b8e15e3901
caps.latest.revision: 100
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Specifying Test Settings for Visual Studio Tests
When you run tests from Visual Studio or in the [build service](../Topic/Run%20tests%20in%20your%20build%20process.md), the test framework can collect data such as diagnostic trace information, system information, or a video recording of a coded UI test. You can also simulate potential bottlenecks on the test machines, reduce the available system memory, or emulate a slow network.  
  
 ![Visual Studio test setting](../dv_TeamTestALM/media/TestSettingVSConceptual.png "TestSettingVSConceptual")  
  
 If your application runs on more than one machine, you can configure these choices separately for each machine, and choose which machine should run the test code.  
  
> [!IMPORTANT]
>  **.testsettings and .runsettings**  
>   
>  If you’re familiar with testing in previous editions of Visual Studio, you’ll notice that a .testsettings file is no longer included in a unit test project. The newer test framework, introduced in Visual Studio 2012, can be configured using a [.runsettings](../VS_IDE/Configure-unit-tests-by-using-a-.runsettings-file.md) file.  
>   
>  If you use a **.testsettings** file, the MSTest test framework will be used to run your tests. This runs more slowly and does not allow you to run tests from third-party test frameworks.  
>   
>  Therefore:  
>   
>  1.  Use the default configuration whenever you can.  
> 2.  To make additional files available during a test, such as test data or configuration files, incorporate the files into your project and set the **Copy to Output** property. If that is not practical, deploy additional files or directories by using the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute?qualifyHint=False> on test classes or methods.  
> 3.  Use a [.runsettings](../VS_IDE/Configure-unit-tests-by-using-a-.runsettings-file.md) file if you want to configure certain aspects of your test run such as the deployment directory or code coverage analysis.  
> 4.  Use a **.testsettings** file to configure diagnostic data collection and to control tests that are distributed over more than one machine.  
>   
>      You must use a **.testsettings** file in web performance and load tests and in coded UI tests.  
  
 **Requirements**  
  
-   Visual Studio Enterprise or Visual Studio Test Professional  
  
 This topic describes how to define test settings in Visual Studio. If you are running system tests in Microsoft Test Manager, see [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../Topic/Create%20Test%20Settings%20for%20Automated%20System%20Tests%20Using%20Microsoft%20Test%20Manager.md).  
  
## When should I use a test settings file?  
 When you want to:  
  
-   Collect diagnostic data to help isolate bugs in your application.  
  
-   Emulate potential bottlenecks that your app might occasionally encounter in a production environment.  
  
-   Run the client, server, and other parts of your app on different machines, to verify that it behaves as expected in a distributed environment.  
  
-   Distribute a large number of tests across additional machines.  
  
-   Run web performance and load tests. If you have added a [web performance and load test](../Topic/Web%20performance%20and%20load%20tests%20in%20Visual%20Studio.md) project to your solution, it will already contain a .testsettings file. You can simply edit that file.  
  
> [!WARNING]
>  [Unit tests run more slowly if you use a test settings file](assetId:///9bb75856-f68a-4de2-a084-b08a947a1172). We recommend that you do not use a test settings file with unit tests. You can configure unit tests by using the [.runsettings](../VS_IDE/Configure-unit-tests-by-using-a-.runsettings-file.md) file instead. To deploy additional files, use <xref:Microsoft.VisualStudio.TestTools.UnitTesting.DeploymentItemAttribute?qualifyHint=False>.  
>   
>  But web performance and load tests always use a test settings file.  
  
##  <a name="CreateTestSettingVSHowDoIUse"></a> How do I use a test settings file?  
 Add test settings files to your solution, and then select the one you want to use. You can add more than one test settings file if you want to be able to switch quickly between different settings.  
  
1.  **Add a .testsettings file to your solution.**  
  
     On the context menu of the Visual Studio solution, choose **Add**, **New Item**, and then select **Test Settings**.  
  
2.  **[Edit the test settings file](#EditTestSetting)**  
  
3.  Select the test settings to use:  
  
     **Select test settings for unit tests and coded UI tests:**  
     On the **TEST** menu, choose **Test Settings**, **Select Test Settings File**.  
  
     ![Set active test settings file Unit and Coded UI](../dv_TeamTestALM/media/VS_TestSettingsChooseUnitAndCUIT.png "VS_TestSettingsChooseUnitAndCUIT")  
    Selecting test settings for unit and coded UI test  
  
     **Select test settings for web performance and load tests:**  
     Open the context menu for the .testsettings file in your solution that you want to use and select **Active Load and Web Test Settings**.  
  
     ![Set active test setting load and Web performance](../dv_TeamTestALM/media/VS_TestSettingsChooseWebandLoad.png "VS_TestSettingsChooseWebandLoad")  
    Selecting test settings for web performance and load tests  
  
 *What else should I know?*  
 **Notes**  
  
-   ![Prerequsite](../dv_TeamTestALM/media/Prereq.png "Prereq") Add test settings to the solution, not a project.  
  
-   ![Prerequsite](../dv_TeamTestALM/media/Prereq.png "Prereq") There are separate commands for selecting the test settings for web performance tests and for other types of tests. Web performance tests always require a test settings file. Unit tests and coded UI tests do not require a test settings file.  
  
-   ![Caution icon](../dv_TeamTestALM/media/caution.gif "caution") **Warning** We don’t recommend that you apply test settings to a Visual Studio unit test project unless you specifically want the settings that it offers.  If you apply test settings, an older test framework is used to run the tests, and you will lose the performance and resilience benefits of the new framework.  
  
     If you use a test settings file and later decide that you don’t want it, you can cancel it on the **TEST** menu by choosing **Test Settings**.  
  
     This recommendation does not apply to Web Performance and Load Tests, which always have a settings file.  
  
-   ![Prerequsite](../dv_TeamTestALM/media/Prereq.png "Prereq") Test settings select and control *diagnostic data adapters*. There are several kinds of adapters that collect different kinds of information, and configure the environment in which the test runs.  
  
-   ![Prerequsite](../dv_TeamTestALM/media/Prereq.png "Prereq") Test settings also select the *test* controller. You use a test controller if you want to run the application on more than one machine.  
  
-   ![Prerequsite](../dv_TeamTestALM/media/Prereq.png "Prereq") When you add a Web Performance and Load test project to a solution, a default Local.testsettings file is created. It is added automatically to the solution under the **Solution Items** folder. This runs your tests locally without diagnostic data adapters selected. You can add or edit a .testsettings file to specify diagnostic data adapters and test controllers.  
  
-   ![Tip](../dv_TeamTestALM/media/Tip.png "Tip") For additional guidance, see [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 6: A Testing Toolbox](http://go.microsoft.com/fwlink/?LinkID=255203).  
  
##  <a name="EditTestSetting"></a> Editing test settings  
 You can configure various values for the test setting using the following pages in the **Test Settings** dialog box:  
  
-   **General**  
  
-   [Roles](#VSTestSettingsRoles)  
  
-   [Data and Diagnostics](#VSTestSettingsDataandDiagnostics)  
  
-   [Deployment](#VSTestSettingsDeployment)  
  
-   [Setup and Cleanup Scripts](#VSTestSettingsSetupandCleanupScripts)  
  
-   [Hosts](#VSTestSettingsHosts)  
  
-   [Test Timeouts](#VSTestSettingsTestTimeouts)  
  
-   [Unit Test](#VSTestSettingsUnitTest)  
  
-   [Web Test](#VSTestSettingsWebTest)  
  
##  <a name="VSTestSettingsRoles"></a> Test Settings: Roles  
 On the Roles page, you can either configure the test to run on your local machine or to run remotely:  
  
 ![Select local execution](../dv_TeamTestALM/media/VSAutomatedTestAddTestSetting5.png "VSAutomatedTestAddTestSetting5")  
  
-   **Local execution** is the default. It means that the tests and the application run on your Visual Studio machine, or on the build server after you have checked in the code. Proceed to [Data and Diagnostics](#VSTestSettingsDataandDiagnostics).  
  
-   **Local execution with remote collection** is a typical configuration for testing a web app or client-server system. The test code runs on the local machine, but you can also collect test data from the components of the application that are installed on other machines.  
  
-   **Remote execution** is used where you do not want to run any part of your application locally. This is a typical configuration where the application requires particular platforms, such as a specific web browser or database. You can collect test data and configure the test environment on each machine.  
  
###  <a name="ConfigureTestControllerandRoles"></a> Configure the test controller and roles for remote data collection and execution  
 Remote execution means that you install your application on one or more machines in addition to your local machine. The test settings can specify data collection and test environment configuration for these machines. Each machine must each have a test agent linked to a test controller. The test controller reads the test settings and uses the agents to configure each machine’s test environment and diagnostic data adapters. You can either [install the test controller and agents](../dv_TeamTestALM/Install-and-configure-test-agents.md) manually or you can [use Microsoft Test Manager to create a lab environment](../dv_TeamTestALM/Setting-Up-Test-Controllers-in-Lab-Environments.md).  
  
 For remote testing, the machines are identified by role names, such as “SQL Server,” “Web Server,” and “Desktop Client.” The names allow you to specify the configuration of each machine. When you install the application for testing, you use the role names to pick the correct machine for each component of the application.  
  
 ![Test setting role](../dv_TeamTestALM/media/Load_TestTestRole.png "Load_TestTestRole")  
  
1.  From the **Controller** drop-down list, choose a test controller for the test agents that will be used to run your tests or collect data.  
  
2.  To add the roles that you want to use to run tests and collect data, choose **Add**. For example, you might give the roles names such as “Desktop Client” or “Web server.”  
  
3.  Select the role that you want to run the tests, and then choose **Set as role to run tests**. Typically, this is the role on which a client component of the application is installed.  
  
    > [!NOTE]
    >  The other roles you define will not run test code, but will only be used to collect data according to the data and diagnostic adapters you specify for the roles in the **Data and Diagnostic** page.  
  
4.  To choose the test agents that can be used for a role, you must create attributes for that role and then assign those attributes to your test agents. If you want to run your tests simultaneously on multiple machines, you must assign to multiple test agents an attribute from the role that is set to run tests. To create an attribute, select the role and then choose **Add** in the toolbar above the attributes list.  
  
5.  The **Agent Selection Rule** dialog box is displayed.  
  
6.  Type the name in **Attribute Name** and the value in **Attribute Value**, and then choose **OK**. Add as many attributes as you require.  
  
7.  For example, you could add an attribute named "RAM > 16GB" with a value of "True" or "False" to filter on test agent machines with more than 16GB of memory. However, you have to manually choose an attribute value on your test agents. An attribute values is not automatically set based on the specifications of a machine.  
  
8.  To apply an attribute to one or more test agents, you assign the attribute to your test agents using the [Manage Test Controller](../dv_TeamTestALM/Managing-Test-Controllers-and-Test-Agents-with-Visual-Studio.md) dialog box.  
  
##  <a name="VSTestSettingsDataandDiagnostics"></a> Test Settings: Data and Diagnostics  
 In the **Test Setting** dialog box, choose the **Data and Diagnostics** page. At this point, depending on how you configured the option in the [Roles](#VSTestSettingsRoles) page, use one of the following options:  
  
-   **Collecting Data and Diagnostics data on your local machine**  
  
     To include the data and diagnostics that you want to collect on your local machine, select the *diagnostic data adapters* according to your testing needs. To configure a diagnostic data adapter that you have included, select the specific diagnostic data adapter and then choose the **Configure** option above the list of the data and diagnostic adapters.  
  
-   **Collecting Data and Diagnostics data on remote machines using roles**  
  
     In the **Data and Diagnostic** page, you define what the role does by selecting the *diagnostic data adapters* the role will use to collect data. Therefore, if one or more data and diagnostic adapters are enabled for the role, then the test controller will choose an available test agent machine to collect data for the specified data and diagnostic adapters based on the attributes you defined for the role. To select the data and diagnostic data adapters that you want to collect for each role, select the role. For each role, select the diagnostic data adapters according to the needs of the tests. To configure each diagnostic data adapter that you have selected for each role, choose the **Configure** option above the list of the data and diagnostic adapters.  
  
     **Example of roles and diagnostic data adapters:**  
  
     For example, you could create a client role named "Desktop Client" with an attribute of "Uses SQL" set to "True" and a server role named "SQL Server" with an attribute set to "RAM > 16GB". If you specify that the "Desktop Client" will run the tests by choosing **Set as role to run tests** in the **Roles** page, then the test controller will select machines with test agents that include the attribute of "Uses SQL" set to "True" to run the tests on. The test controller will also select SQL server machines with a test agents that include the attribute "RAM > 16GB" to collect only data that is defined by the data and diagnostic adapters included in the role. The "Desktop Client" tests agent can also collect data for the machines that it is run on but you have to select data and diagnostic adapters for that role, too.  
  
> [!NOTE]
>  The table shows only the adapters that can be used with tests in Visual Studio. For additional information about diagnostic data adapters used in Microsoft Test Manager, see [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../dv_TeamTestALM/Setting-Up-Machines-and-Collecting-Diagnostic-Information-Using-Test-Settings.md).  
  
 **Diagnostic Data Adapters for Automated Tests**  
  
|Diagnostic data adapter|Associated topic|  
|-----------------------------|----------------------|  
|**ASP.NET Client Proxy for IntelliTrace and Test Impact:** This proxy allows you to collect information about the http calls from a client to a Web server for the IntelliTrace and Test Impact diagnostic data adapters.|No configuration is required to collect this information.<br /><br /> [How to: Collect IntelliTrace Data to Help Debug Difficult Issues](../dv_TeamTestALM/How-to--Collect-IntelliTrace-Data-to-Help-Debug-Difficult-Issues.md)<br /><br /> [How to: Collect Data to Check Which Tests Should be Run After Code Changes](../Topic/How%20to:%20Collect%20Data%20to%20Check%20Which%20Tests%20Should%20be%20Run%20After%20Code%20Changes.md)|  
|**IntelliTrace :** You can configure the diagnostic data adapter for *IntelliTrace* to collect specific diagnostic trace information to help isolate bugs that are difficult to reproduce. This adapter creates an IntelliTrace file that has an extension of .iTrace that contains this information. When a test fails, you can create a bug. The IntelliTrace file that is saved with the test results is automatically linked to this bug. The data that is collected in the IntelliTrace file increases debugging productivity by reducing the time that is required to reproduce and diagnose an error in the code. From this IntelliTrace file the local session can be simulated on another computer, this reduces the possibility of a bug being non-reproducible.<br /><br /> For more information, see [Using IntelliTrace](../VS_debugger/IntelliTrace.md).|[How to: Collect IntelliTrace Data to Help Debug Difficult Issues](../dv_TeamTestALM/How-to--Collect-IntelliTrace-Data-to-Help-Debug-Difficult-Issues.md)|  
|**ASP.NET profiler :** You can create a test setting that includes ASP.NET profiling, which collects performance data on ASP.NET Web applications. **Note:**  This diagnostic data adapter is for use only with load tests that use websites that require Visual Studio Enterprise.|[How to: Configure ASP.NET Profiler for Load Tests Using Test Settings](../dv_TeamTestALM/How-to--Configure-ASP.NET-Profiler-for-Load-Tests-Using-Test-Settings-in-Visual-Studio.md)<br /><br /> [How to: Create a Test Setting for a Distributed Load Test](../dv_TeamTestALM/How-to--Create-a-Test-Setting-for-a-Distributed-Load-Test.md)|  
|**Code coverage (Visual Studio 2010) :** You can create a test setting that includes code coverage information that is used to investigate how much of your code is covered by tests. **Note:**  This diagnostic data adapter is only applicable to Visual Studio test settings. It is not used for test settings in Microsoft Test Manager. **Note:**  This is for compatibility with Visual Studio 2010 only. <br /><br /> For more information about code coverage, see [Using Code Coverage to Determine How Much Code is being Tested](../VS_IDE/Using-Code-Coverage-to-Determine-How-Much-Code-is-being-Tested.md).|[Code Coverage configuration using Test Settings is deprecated](../Topic/Code%20Coverage%20configuration%20using%20Test%20Settings%20is%20deprecated.md)|  
|**Event log :** You can configure a test setting to include event log collecting, which will be included in the test results.|[How to: Configure Event Log Collection Using Test Settings](assetId:///48d67891-6018-4549-83e3-213d5d824a02)|  
|**Network emulation :** You can specify that you want to place an artificial network load on your test using a test setting. Network emulation affects the communication to and from the machine by emulating a particular network connection speed, such as dial-up. **Note:**  This diagnostic data adapter is only applicable to Visual Studio test settings. It is not used for test settings in Microsoft Test Manager. **Note:**  Network emulation cannot be used to increase the network connection speed.|[How to: Configure Network Emulation Using Test Settings](../dv_TeamTestALM/How-to--Configure-Network-Emulation-Using-Test-Settings-in-Visual-Studio.md)|  
|**System information :** A test setting can be set up to include the system information about the machine that the test is run on. The system information is specified in the test results by using a test setting.|No configuration is required to collect this information.|  
|**Test impact :** You can collect information about which methods of your applications code were used when a test case was running. This information can be used together with changes to the application code made by developers to determine which tests were impacted by those development changes.|[How to: Collect Data to Check Which Tests Should be Run After Code Changes](../Topic/How%20to:%20Collect%20Data%20to%20Check%20Which%20Tests%20Should%20be%20Run%20After%20Code%20Changes.md)|  
|**Video Recorder :** You can create a video recording of your desktop session when you run an automated test. This video recording can be useful to view the user actions for a coded UI test. The video recording can help other team members isolate application issues that are difficult to reproduce.|[How to: Include Recordings of the Screen and Voice During Tests Using Test Settings](../dv_TeamTestALM/How-to--Include-Recordings-of-the-Screen-and-Voice-During-Tests-Using-Test-Settings.md)|  
  
##  <a name="VSTestSettingsDeployment"></a> Test Settings: Deployment  
  
1.  In the **Test Settings** dialog box, choose the **Deployment** page.  
  
2.  To create a separate directory for deployment every time that you run your tests, select **Enable deployment**.  
  
    > [!NOTE]
    >  If you select to do this, you can continue to build your application when you run your tests.  
  
3.  To add a file to the directory you are using to run your tests that you need for the tests, choose **Add file** and then select the file that you want to add.  
  
4.  To add a directory to the directory you are using to run your tests that you need for the tests, choose **Add directory** and then select the directory that you want to add.  
  
    > [!NOTE]
    >  For more information about how to deploy files and directories for individual tests using properties and the DeploymentItem attribute, see [How to: Deploy Files for Tests](../dv_TeamTestALM/How-to--Deploy-Files-for-Tests.md).  
  
##  <a name="VSTestSettingsSetupandCleanupScripts"></a> Test Settings: Setup and Cleanup Scripts  
  
1.  To run scripts before and after your tests, choose the **Setup and Cleanup Scripts** page in the **Test Settings** dialog box.  
  
2.  Type the location of the script file in **Setup script** or choose the ellipsis (**…**) to locate the setup script.  
  
3.  Type the location of the script file in **Cleanup script** or choose the ellipsis (**…**) to locate the cleanup script.  
  
##  <a name="VSTestSettingsHosts"></a> Test Settings: Hosts  
  
1.  To run your tests using a different host, choose the **Hosts** page in the **Test Settings** dialog box.  
  
2.  To run your unit tests in the same process as an ASP.NET site, select **ASP.NET** in **Host type**.  
  
3.  Use the Run test in 32-bit or 64-bit process to select if you want your test to run as 32-bit or 64-bit processes.  
  
     For maximum flexibility, you should compile your test projects with the **Any CPU** configuration. Then you can run on both 32- and 64-bit agents. There is no advantage to compiling test projects with the **64-bit** configuration.  
  
##  <a name="VSTestSettingsTestTimeouts"></a> Test Settings: Test Timeouts  
  
1.  (Optional) To limit the period of time for each test run and individual tests, choose the **Test Timeouts.** page in the **Test Settings** dialog box.  
  
2.  To abort a test run when a time limit is exceeded, select **Abort a test run if the total time exceeds** and then type a value for this limit.  
  
3.  To fail an individual test if a time limit is exceeded, select **Mark an individual test as failed if its execution time exceeds**, and type a value for this limit.  
  
##  <a name="VSTestSettingsUnitTest"></a> Test Settings: Unit Test  
 (Optional) If you have to specify assembly locations that your unit tests need to load, choose **Unit Test**.  
  
1.  For **Root folder for the assemblies to be loaded**, choose **Browse** to locate the folder and populate the text box.  
  
     The root folder that is specified can contain environment variables and represents the directory that will be used as the ApplicationBase of the AppDomain that the tests are run in. All the assemblies in this directory will be loadable by your unit tests. In a production environment, a good practice is to set this to the directory where your code under test assemblies are installed. In a development environment, a good practice is to set this to the directory where your code under test assemblies are built to. This ensures that any references that you have to the product binaries can be loaded and resolved during the discovery and execution of the tests without the need to copy the product binaries around with the tests.  
  
     If no value is set here, the ApplicationBase of the AppDomain that the tests are run in is set to the directory that contains the tests.  
  
2.  Select or clear the check box for **Use the Load Context for assemblies in the test directory**.  
  
     By default, most assemblies are loaded into the correct "Load Context." Usually, you should leave **Use the Load Context for assemblies in the test directory** selected. However, there are some conditions when you might want to turn this off:  
  
     If there are a large number of assemblies in your test directory, and you have specified a location under **Root folder for the assemblies to be loaded**, and your tests are not dependent on being loaded in the Load Context, you could see a performance increase if you do not use the Load Context to load these test assemblies.  
  
     If your tests depend on being loaded in a context other than the Load Context (not typical).  
  
     For more information, see [Best Practices for Assembly Loading](../Topic/Best%20Practices%20for%20Assembly%20Loading.md).  
  
3.  Under **Folders to use when the tests are run**, choose **Add folder**.  
  
     The **Browse For Folder** dialog box is displayed.  
  
4.  Locate the folder to use and choose **OK**.  
  
     The **Folders to use when the tests are run** setting is the setting that you will probably use the most frequently. You can specify multiple paths to folders that assemblies should be resolved from during discovery and execution of the tests. Each of the paths that are specified in this section can contain environment variables. Together with each of the paths that are specified here, there are two options that are associated with it:  
  
     **First option** Select the **Use Load Context** check box to specify that the directory should use the load context when resolving assemblies from the directory (if the load context is not required for the tests to run correctly you might see a performance improvement by clearing this check box).  
  
     **Second option** Select the **Include sub-folders** check box to specify using any sub-folder to include when resolving assemblies from the directory.  
  
5.  Under **Additional folders to use when discovering tests**, choose **Add Folder**.  
  
     The **Browse For Folder** dialog box is displayed.  
  
6.  Locate the folder to use and choose **OK**.  
  
     The **Additional folders to use when discovering tests** option is useful when you are either executing the tests remotely under Team Build or doing an automated run from Microsoft Test Manager. The paths provided here will be used for assembly resolution, but only during test discovery. These paths can contain environment variables. In cases where tests are being scheduled to execute remotely from a build drop and not all of the dependencies of the test assembly are in the same directory, these paths can be used to ensure that MSTest or the Test Controller can find enough of the dependent assemblies to discover the tests and schedule them to the remote machines for execution.  
  
     For runs being scheduled from Microsoft Test Manager, there is an additional token—%BuildDrop%— that can be used to generically refer to the build drop location. This eliminates the need to create or update a Test Settings each time a new build is being tested. Unfortunately this token is not directly supported through Team Build. However, if the build drop location is set in an environment variable named BuildDrop from the build definition, it will have the same result.  
  
     For more information, see [Unit Test Your Code](../VS_IDE/Unit-Test-Your-Code.md).  
  
##  <a name="VSTestSettingsWebTest"></a> Test Settings: Web Test  
 **Required**: Visual Studio Enterprise  
  
 (Optional) To configure properties that control how [Web performance tests](../Topic/Web%20performance%20and%20load%20tests%20in%20Visual%20Studio.md) are run in the test setting, choose **Web Test**.  
  
1.  Select either **Fixed run count**, or **One run per data source row**.  
  
2.  Use the **Browser type** drop-down list to select the Web browser to use with your Web performance test. For example, **Internet Explorer 9.0**.  
  
3.  (Optional) Select [Simulate think times](../Topic/How%20to:%20Set%20Think%20Times%20to%20Simulate%20Human%20Pausing%20in%20a%20Web%20Performance%20Test.md) to enable simulated human pausing.  
  
4.  (Optional) Select **Use request URL’s directory as the default path for cookies**.  
  
     If the **Use request URL’s directory as the default path for cookies** is disabled, then your web tests will follow this behavior:  
  
     If a request, for example www.abc.com/myapp/abc.aspx, sets a cookie in its response and does not specify a path, then the test will use the entire request URL as the Path for that cookie. This means the cookie will be sent only with subsequent requests with URL www.abc.com/myapp/abc.aspx.  
  
     If the **Use request URL’s directory as the default path for cookies** is enabled, then your web tests will follow this behavior:  
  
     If a request, for example www.abc.com/myapp/abc.aspx, sets a cookie in its response and does not specify a path, then the test will use the directory of the request URL as the Path for that cookie. This means the cookie will be sent with all requests with sub path www.abc.com/myapp (for example, www.abc.com/myapp/xyz.aspx).  
  
     This behavior is consistent with Version 1 cookies specified in RFC 2109. For more information, see [Request for Comments: 2109](http://go.microsoft.com/fwlink/?LinkID=90315).  
  
## See Also  
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 6: A Testing Toolbox](http://go.microsoft.com/fwlink/?LinkID=255203)   
 [How to: Add a Test Settings File from Microsoft Visual Studio](../Topic/How%20to:%20Add%20a%20Test%20Settings%20File%20from%20Microsoft%20Visual%20Studio.md)   
 [How to: Edit a Test Settings File from Microsoft Visual Studio](../Topic/How%20to:%20Edit%20a%20Test%20Settings%20File%20from%20Microsoft%20Visual%20Studio.md)   
 [How to: Select the Active Test Settings from Microsoft Visual Studio](../Topic/How%20to:%20Select%20the%20Active%20Test%20Settings%20from%20Microsoft%20Visual%20Studio.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../dv_TeamTestALM/Setting-Up-Machines-and-Collecting-Diagnostic-Information-Using-Test-Settings.md)   
 [Collect more diagnostic data](../dv_TeamTestALM/Collect-more-diagnostic-data-in-manual-tests.md)   
 [Create Test Settings to Run Automated Tests from Visual Studio](../dv_TeamTestALM/Specifying-Test-Settings-for-Visual-Studio-Tests.md)   
 [Using Test Controllers and Test Agents with Load Tests](../dv_TeamTestALM/Using-Test-Controllers-and-Test-Agents-with-Load-Tests.md)   
 [Setting Up Test Machines to Run Tests or Collect Data](../dv_TeamTestALM/Setting-Up-Test-Machines-to-Run-Tests-or-Collect-Data.md)   
 [How to: Create a Test Setting for a Distributed Load Test](../dv_TeamTestALM/How-to--Create-a-Test-Setting-for-a-Distributed-Load-Test.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../dv_TeamTestALM/Specifying-Test-Settings-for-Visual-Studio-Tests.md)   
 [Walkthrough: Using a Test Controller and Test Agents in a Load Test](../dv_TeamTestALM/Walkthrough--Using-a-Test-Controller-and-Test-Agents-in-a-Load-Test.md)   
 [Compatibility of Test Settings with Visual Studio 2010](assetId:///c4f0f924-6a92-4fdb-a16b-6c3ef6f0acca)