---
title: "Walkthrough: Using a Test Controller and Test Agents in a Load Test"
ms.custom: na
ms.date: "10/10/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "test agent, using with load tests"
  - "test controller, using with load tests"
ms.assetid: 4d7816a7-0168-4eeb-b4bc-bb7ba0fb54a3
caps.latest.revision: 44
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Walkthrough: Using a Test Controller and Test Agents in a Load Test
Here you'll learn how to create and run a load test that's distributed across several machines. You'll configure a test setting that uses a test controller and test agents, and you'll add diagnostic and data adapters to the test setting.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
-   "Microsoft Visual Studio Agents" CD  
  
-   (Optional) A second machine to install the test controller and test agent. Otherwise, you can install the test controller and agent on the same machine that has Visual Studio.  
  
-   A simple load test that you can experiment with. If you don't have a load test, create one using these walkthroughs first:  
  
    -   [Record and run a web performance test](assetId:///bd0a82fd-cec0-4861-bc09-e1b0b2d258ef)  
  
    -   [Create and run a load test](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4)  
  
 You'll then:  
  
-   Set up a test controller and a test agent.  
  
-   Create a test setting that uses the test controller and data and diagnostic adapters.  
  
-   Run the load test across the distributed machines.  
  
## Install a Test Controller  
 To install a test controller, you must be a member of the **Administrators** security group on the machines. For more information about installing test controllers, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
#### To install a test controller to use for the distributed load test  
  
1.  On either the machine that has Visual Studio Enterprise, or preferably on a second machine that you can install the test controller on, load the "Microsoft Visual Studio Agents" CD and then start setup.exe located in the root folder.  
  
2.  On the **Visual Studio Agents Setup** page, choose **Install Visual Studio Test Controller**.  
  
     The **Microsoft Visual Studio Test Controller Installation** page appears.  
  
3.  Choose **Next**.  
  
     The **Start** page is displayed.  
  
4.  Review the **License Terms**, select **I have read and accept the license terms**, if appropriate, and then choose **Next**.  
  
     The **Options** page is displayed.  
  
5.  (Optional) To install it in a different location, choose **Browse** to select a different installation folder.  
  
6.  Choose **Install** to start the installation.  
  
     The **Installing Components** page is displayed. When the installation is finished, the **Finish Page** is displayed.  
  
7.  To configure the test controller that you have installed, select **Configure test controller now**. Then choose **Configure** to start the Test Controller Configuration tool.  
  
     The **Configure Test Controller** dialog box is displayed.  
  
8.  Select the user to use as the logon account for your test controller service.  
  
     **Important user account information:**  
  
    -   Null passwords are not supported for user accounts.  
  
    -   If you want to use the IntelliTrace or the network emulation data and diagnostic adapter, the user account must be a member of the Administrators group.  
  
    -   If the agent user name is not in the agent service it will try to add it, which requires permissions on the test controller.  
  
    -   The user trying to use the test controller must be in the test controller's Users account or they will not be able to run the tests against the controller.  
  
9. To configure your test controller for load testing, select **Configure for load testing**.  
  
10. Type your [!INCLUDE[ssNoVersion](../datatools/includes/ssnoversion_md.md)] instance in **Create load test results database in the following SQL Server instance**.  
  
    > [!NOTE]
    >  If you do not have SQL Server installed, you can use SQL Express included with Visual Studio. See [How to: Create a Load Test Results Repository Using SQL](../test/how-to--create-a-load-test-results-repository-using-sql.md). For more information about sizing considerations, see [Using Test Controllers and Test Agents with Load Tests](../test/using-test-controllers-and-test-agents-with-load-tests.md).  
  
11. To apply your changes, choose **Apply Settings**.  
  
     A **Configuration summary** dialog box is displayed. It shows the status of each steps that is required to configure your test controller.  
  
12. To close the **Configuration summary** dialog box, choose **Close**. Then choose **Close** again to close the Test Controller Configuration Tool.  
  
     The **Visual Studio Agents Setup** dialog box is shown. From here, you can install any other components that you require on this computer.  
  
## Install a Test Agent  
 To install a test agent, you must be a member of the **Administrators** security group on the computer.  
  
 The user whom you add to start the service or process for the test agent must also be a member of the TeamTestAgentService group on the computer for the test controller for this agent.  
  
> [!NOTE]
>  If this user is the current user, when you add this user to the test controller machine, you must log off or restart the computer.  
>   
>  For more information about installing test agents, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
#### To install a test agent to add additional stress on your load test  
  
1.  On either the machine that has Visual Studio, or preferably the second machine that you installed the test controller on, load the "Microsoft Visual Studio Agents" CD and then start setup.exe located in the root folder.  
  
    > [!NOTE]
    >  You can optionally install the test agent on a third machine too. A Test controller can control several agents on different machines.  
  
     The **Visual Studio Agents** page appears.  
  
2.  Choose **Install Visual Studio Test Agent**.  
  
     The **Microsoft Visual Studio Test Agent Installation** page appears.  
  
3.  Choose **Next**.  
  
     The **Start** page is shown.  
  
4.  Review the **License Terms**, select **I have read and accept the license terms**, if appropriate, and then choose **Next**.  
  
     The **Options** page is displayed.  
  
5.  (Optional) Choose **Browse** to select a different installation folder.  
  
6.  Choose **Install** to start the installation.  
  
     The **Installing Components** page is displayed. The test agent install requires performance tools to be installed to collect performance data when tests are run. When the installation is finished, the **Finish Page** is displayed.  
  
7.  To configure the test agent you have installed, select **Configure test agent now**. Then choose **Configure** to start the Test Agent Configuration tool.  
  
     The **Configure Test Agent** dialog box is displayed.  
  
8.  Choose **Run Options**.  
  
9. Under **Run the test agent as**, select **Service**.  
  
10. Choose **Next**.  
  
11. Enter the details about the user when the test agent starts as a service.  
  
    1.  Type the name in **User name**.  
  
    2.  Type the password in **Password**.  
  
         Make sure that user account is a member of the Administrators group in order to be able to use the IntelliTrace collector and network emulation you will specify in the procedure Modify the Test Setting to Include Diagnostic Data Adapters.  
  
        > [!NOTE]
        >  Null passwords are not supported for user accounts.  
  
12. To register this agent with the test controller you installed, select **Register with test controller.** In **Register the test agent with the following test controller**, type the name of the machine you installed the test controller on and optionally follow it with a colon (**:**) and the port number that you are using. For example, type **Contoller1:6901**.  
  
    > [!NOTE]
    >  The default port number is 6901.  
  
13. To apply your changes, choose **Apply Settings**.  
  
     A **Configuration summary** dialog box is displayed. It shows the status of each step that is required to configure your test agent.  
  
    > [!NOTE]
    >  The last step in the installation process resets the network adapter. This may cause a network outage for brief period of time. This is expected behavior.  
  
14. To close the **Configuration summary** dialog box, choose **Close**. Then choose **Close**, to close the Test Agent Configuration Tool.  
  
    > [!NOTE]
    >  There is a notification area icon that runs on the computer for a test agent that is running as a process. It shows the status of the test agent. You can start, stop or restart the agent if it is running as a process using this tool. To start the test agent as a process if it is not running, choose **Start**, and then choose **All Programs**. Point to **Microsoft Visual Studio** and then choose **Microsoft Visual Studio Test Agent**.  
  
## Open or Create a load Test  
 With the test controller and test agent installed, you can now start Visual Studio and specify the load test you want to stress using the test agent.  
  
#### To prepare the walkthrough by opening or creating a load test  
  
1.  Start Visual Studio.  
  
2.  Open the ColorWebApp solution containing the load test that results from conducting the steps in the three walkthroughs mentioned at the top of this topic in the prerequisites section.  
  
     -or-  
  
     Create a Web performance and load test project with a simple load test that you can experiment with.  
  
     The remaining steps assume a Web application named ColorWebApp and a Web performance test named ColorWebAppTest.webtest  
  
## Create a new Test Setting that Uses the Test Controller and Test Agents and Data and Diagnostic adapters  
 In this procedure, you will create a test setting to include the test controller you installed, specify a role and what data and diagnostic adapters the test agent will use. For more information about creating a test setting for a distributed load test, see [How to: Create a Test Setting for a Distributed Load Test](../test/how-to--create-a-test-setting-for-a-distributed-load-test.md).  
  
#### To add a test settings for a distributed load test  
  
1.  In Solution Explorer, right-click **Solution Items** and then point to **Add**, and then choose **New Item**.  
  
     The **Add New Item** dialog box appears.  
  
2.  In the **Installed Templates** pane, choose **Test Settings**.  
  
3.  In the **Name** box, type **TestSettingDistributedLoadTestWalkthrough**.  
  
4.  Choose **Add**.  
  
     The new test TestSettingDistributedLoadTestWalkthrough.testsettings file appears in Solution Explorer, under the **Solution Items** folder.  
  
     The **Test Settings** dialog box is displayed. The **General** page is selected.  
  
     You can now edit and save test settings values.  
  
    > [!NOTE]
    >  Each test settings that you create is listed as a choice for the **Select Active Test Settings** and **Edit Test Settings** options on the **Test** menu.  
  
5.  Under **Name**, type the name for the test settings.  
  
6.  Under **Description**, type **Distributed load test settings**.  
  
7.  Leave **Default naming scheme** selected.  
  
8.  Choose **Roles**.  
  
     The **Roles** page is displayed.  
  
9. To run the ColorWebAppTest Web performance test remotely use the **Test execution method** drop-down list and select **Remote execution**.  
  
10. In the **Controller** drop-down list, type the computer name of the test controller you created in the Setup a Test Controller procedure.  
  
    > [!NOTE]
    >  Because this is the first time you are adding a controller, there are not any controllers listed in the drop down list. The list is populated by previous controllers you have specified in other test settings.  
  
11. Under **Roles**, choose **Add**.  
  
12. In the highlighted row under the **Name** column, type **Distributed load test**.  
  
13. Choose **Data and Diagnostics**.  
  
     The **Data and Diagnostics** page is displayed.  
  
14. Under **Role**, verify that the Distributed load test role is selected.  
  
15. Under **Data and Diagnostic for select role**, select the **IntelliTrace** and **System Information** adapters.  
  
     For information about these adapters and other adapters you can use in a distributed load test, see [How to: Create a Test Setting for a Distributed Load Test](../test/how-to--create-a-test-setting-for-a-distributed-load-test.md).  
  
16. Choose **Hosts**.  
  
17. (Optional) If your machine is running under a 64-bit version of Microsoft Windows, and you compiled the ColorWebAppTest.webtest using the **Any CPU** configuration, use the **Run test in 32 bit or 64 bit process** drop down list and select Run tests in 64 bit process on 64 bit machine.  
  
    > [!TIP]
    >  For maximum flexibility, you should compile your Web performance and load test projects with the **Any CPU** configuration. Then you can run on both 32 and 64 bit agents. There is no advantage to compiling Web performance and load test projects with the **64-bit** configuration.  
  
18. To save the new test settings, choose **Apply**.  
  
19. Choose **Close**.  
  
20. On the Test menu, select **Select Active Test Settings** and then choose **TestSettingDistributedLoadTestWalkthrough.testsettings**.  
  
## Running the Distributed Load Test and Viewing the Data and Diagnostic Adapter Reports  
 You can now run the distributed load test and analyze the IntelliTrace and system information reports that are generated.  
  
#### To run the load test  
  
1.  With load test open in the **Load Test Editor**, choose the **Run** button. Your load test starts to run.  
  
2.  After a load test completes, in the Load Test Analyzer's toolbar, choose **View Data and Diagnostic attachments**.  
  
     The **Choose Diagnostic Data Adapter Attachment** dialog box is displayed. Note that the name of the agent is displayed as a prefix to the adapter, for example [AgentMachine1]: SystemInformation.xml.  
  
     [AgentMachine1\]: QTAgent32_100216_085903820_3320.iTrace  
  
3.  Select the diagnostic data adapter attachment that you want to analyze and choose **OK**.  
  
     The information collect by the agent is displayed accordingly.  
  
## See Also  
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Create a Test Setting for a Distributed Load Test](../test/how-to--create-a-test-setting-for-a-distributed-load-test.md)   
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Using Test Controllers and Test Agents with Load Tests](../test/using-test-controllers-and-test-agents-with-load-tests.md)   
 [Configuring Test Controllers and Test Agents for Load Testing](../test/configuring-test-controllers-and-test-agents-for-load-testing.md)   
 [Q: Can I change my load tests to use 64-bit processing?](assetId:///7041cbcf-9ab1-4579-98ff-8f296aeaded4#CreateRunLoadTest_QA_64-bit)   
 [Load Test Analyzer Overview](../test/load-test-analyzer-overview.md)   
 [Getting Started with Load and Web Performance Test Walkthroughs](assetId:///5d754a49-565c-4f1b-9e5f-ac40ae3fff27)   
 [Running Load Tests](../test_notintoc/running-load-tests.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)