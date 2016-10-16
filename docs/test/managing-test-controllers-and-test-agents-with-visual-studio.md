---
title: "Managing Test Controllers and Test Agents with Visual Studio"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.rigadministration"
helpviewer_keywords: 
  - "controllers, managing"
  - "test agents, managing"
  - "agents and controllers, managing"
ms.assetid: 2b20b22e-d4cf-49d6-804c-daa9de8e81c1
caps.latest.revision: 64
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
# Managing Test Controllers and Test Agents with Visual Studio
If you want to use Visual Studio to run tests remotely, distribute tests across multiple machines, or run load tests, you must configure a test controller, test agents, and test settings file. This topic describes how to manage test controllers and test agents after you install and configure them for the first time.  
  
 If you are running load tests, you don’t have to use your resources and set up your own machines to create this load. You can use cloud-based load testing to provide virtual machines in the cloud that generate the load of many users accessing your web site at the same time. All you need is a [Visual Studio Team Services account](http://go.microsoft.com/fwlink/?LinkId=307137). Learn more about this [cloud-based load testing service](http://go.microsoft.com/fwlink/?LinkID=317257).  
  
 If you use [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] to run tests in lab environments, you manage test controllers and their agents by using the **Test Controller Manager** in the **Lab Center** for [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. This topic is applicable only if you use Visual Studio to run tests.  
  
 For information about how to install and configure test agents and test controllers to run tests in Visual Studio, see [Setting Up Test Controllers and Test Agents to Manage Tests with Visual Studio](../test/setting-up-test-controllers-and-test-agents-to-manage-tests-with-visual-studio.md).  
  
 To configure and monitor the test controller and any registered agents, you must have a test settings file in your test project that contains the tests you want to run. Open the test settings file, choose **Role** and choose **Manage Test Controllers** from the drop down for the **Controller** field.  
  
 ![Open your test settings file, select the Role tab](../test/media/managetestcontrollersvs.png "ManageTestControllersVS")  
  
 For a load test project, you can also choose **Manage Test Controllers** from the **LOAD TEST** menu.  
  
 After you install and configure your test controller and test agents, use the following procedures to manage them:  
  
-   [Add a test agent to a test controller](#AddAgent)  
  
-   [Remove a test agent from a test controller](#RemoveAgent)  
  
-   [Change the settings for a test agent](#ChangeAgent)  
  
-   [Configure a test controller](#ChangeController)  
  
-   [Manage agents when you run your tests](#RunningTests)  
  
-   [Determine the test controller used to run tests](#DetermineController)  
  
-   [Loading tests from delay-signed test assemblies](#DelaySigned)  
  
##  <a name="AddAgent"></a> Adding a Test Agent to a Test Controller  
 You might want to add a test agent to a different test controller or you might have to add a test agent to a test controller that you have just installed.  
  
#### To add a test agent to a test controller  
  
1.  Choose **Start**, **All Programs**, **Microsoft Visual Studio**, **Microsoft Visual Studio Test Agent Configuration Tool**.  
  
     The **Configure Test Agent** dialog box is displayed.  
  
    > [!NOTE]
    >  You must have a test agent already installed to add it to a test controller. For more information about how to install a test agent, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
2.  If you want to change the way that the test agent is run, choose **Run Options**.  
  
     You are presented with two options for how the test agent is going to be run:  
  
     **Service** If you do not have to run automated tests that interact with the desktop, such as coded UI tests or creating a video recording when your test runs, under **Run the test agent as**, select **Service**. The test agent will be started as a service. Choose **Next**.  
  
     You can now enter the details about the user when the test agent starts as a service.  
  
    1.  Enter the name in **User name**.  
  
    2.  Enter the password in **Password**.  
  
        |**Important user account information**|  
        |--------------------------------------------|  
        |-   Null passwords are not supported for user accounts.|  
        |-   If you want to use the IntelliTrace collector or the network emulation, the user account must be a member of the Administrators group.|  
        |-   If the agent user name is not in the agent service it will try to add it, which requires permissions on the test controller.|  
        |-   The user who is trying to use the test controller must be in the test controller's Users account or they will be unable to run the tests against the controller.|  
  
     **Interactive Process** If you want to run automated tests that must interact with the desktop, such as coded UI tests or creating a video recording when your test runs, select **Interactive Process**. The test agent will be started as an interactive process instead of a service.  
  
     On the next page, enter the details about the user when the test agent starts as a process, and other options.  
  
    1.  Enter the name in **User name**.  
  
    2.  Enter the password in **Password**.  
  
        > [!NOTE]
        >  If you configure the test agent to run as an interactive process with a different user who is not the currently active user, you must restart the computer and log on as this different user to be able to start the agent. In addition, null passwords are not supported for user accounts. If you want to use the IntelliTrace collector or the network emulation, the user account must be a member of the Administrators group.  
  
        |**Important user account information**|  
        |--------------------------------------------|  
        |-   Null passwords are not supported for user accounts.|  
        |-   If you want to use the IntelliTrace or the network emulation data and diagnostic adapter, the user account must be a member of the Administrators group. If the machine that is running the test agent is using [!INCLUDE[wiprlhext](../debugger/includes/wiprlhext_md.md)] or later versions, or any OS that has Least-Privileged User Account, you have to run it as an administrator also (elevated).|  
        |-   If the agent user name is not in the agent service it will try to add it, which requires permissions on the test controller.|  
        |-   The user who is trying to use the test controller must be in the test controller's Users account or they will be unable to run the tests against the controller.|  
  
    3.  To make sure that a computer that has a test agent can run tests after it restarts, you can set up the computer to log on automatically as the test agent use. Select **Log on automatically**. This will store the user name and password in an encrypted form in the registry.  
  
    4.  To make sure that the screen saver is disabled because this might interfere with any automated tests that must interact with the desktop, select **Ensure screen saver is disabled**.  
  
        > [!CAUTION]
        >  There are security risks if you log on automatically or disable the screen saver. By enabling automatic log on, you enable other users to start this computer and to be able to use the account that automatically logs on. If you disable the screen saver, the computer might not prompt for a user to log on to unlock the computer. This lets anyone access the machine if they have physical access to the computer. If you enable these features on a computer, you should make sure that these computers are physically secure. For example, these computers are located in a physically secure lab. (If you clear **Ensure screen saver is disabled**, this does not enable your screen saver.)  
  
3.  To register this agent with a different test controller, select **Register with test controller.** Type the name of your test controller followed by **:** and the port number that you are using in **Register the test agent with the following test controller**. For example, type **agent1:6901**.  
  
    > [!NOTE]
    >  The default port number is 6901.  
  
4.  To save your changes, choose **Apply Settings**. Close the **Configuration summary** dialog box, and then close the Test Agent Configuration Tool.  
  
5.  > [!CAUTION]
    >  If the agent is currently configured to run on another test controller, you must remove the test agent from that controller. If the test controller is registered with a team project, you can remove the test agent using the **Test Controller Manager** in the **Lab Center** for [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. Otherwise, to remove the test agent, on the **Test** menu in Visual Studio, choose **Manage Test Controllers**.  
  
##  <a name="RemoveAgent"></a> Removing a Test Agent from a Test Controller  
 A test agent must be set to the offline state before it can be removed.  
  
 You can’t use this procedure to remove agents that are registered to a controller as part of a lab environment. To remove these agents from a controller, you must remove the environment using Microsoft Test Manager.  
  
#### To remove a test agent from a test controller  
  
1.  If the test controller is not registered with a team project, follow these steps.  
  
    1.  From Visual Studio open the test settings file for your test project, choose **Role** and choose **Manage Test Controllers** from the drop down for the **Controller** field.  
  
         The **Administer Test Controller** dialog box is displayed.  
  
    2.  In the **Controller** drop-down list, type the name of the computer on which you have set up the test controller. If you have administered a specific test controller previously, you can select the name from the list.  
  
    3.  In the **Agents** pane, select the test agent name. If the agent is still online, choose **Offline.** To remove it, choose **Remove**.  
  
        > [!NOTE]
        >  Removing a test agent just disassociates it from the test controller. To completely uninstall the test agent, use the  **Programs and Features** Control Panel on the test agent computer.  
  
2.  If the test controller is registered with a team project, follow these steps.  
  
    1.  Open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. (Go to Start, All Programs, Microsoft Visual Studio, Microsoft Test Manager.)  
  
    1.  Choose **Lab Center**, **Controllers**.  
  
         The **Test Controller Manager** view is displayed.  
  
    2.  Select your test controller from the list of test controllers.  
  
         Any test agents registered with this test controller are now displayed in the test agents list.  
  
    > [!NOTE]
    >  If a test agent is set up to run as a process that can interact with the desktop, the test agent is displayed in the list with an asterisk preceding the name.  
  
    1.  Select the agent that you want to remove. If the agent is still online, choose **Offline**. To remove it, choose the **Remove** button.  
  
        > [!NOTE]
        >  Removing a test agent just disassociates it from the test controller. To completely uninstall the test agent, use the  **Programs and Features** Control Panel on the test agent computer.  
  
     You cannot move a test agent to another test controller by using the steps in this procedure. To move a test agent to another test controller, remove the test agent from its current test controller. Then you can follow the steps in the procedure to add a test agent to a test controller.  
  
##  <a name="ChangeAgent"></a> Changing the Settings for a Test Agent  
 The status of the test agent can be any one of the following values:  
  
|Status|Description|  
|------------|-----------------|  
|Running Test|Running tests|  
|Ready|Available to run tests or collect data and diagnostics|  
|Offline|Unavailable to run tests or collect data and diagnostics|  
|Disconnected|Test agent is not started|  
  
-   You can change the status and other settings for a test agent using the following procedures.  
  
#### To change the settings of a test agent  
  
1.  If the test agent is registered to a test controller that is registered with a team project, follow these steps:  
  
    1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], choose **Lab Center**, **Controllers**.  
  
2.  If the test agent is registered to a test controller that is not registered with a team project, follow these steps:  
  
    1.  To configure and monitor the test controller and any registered agents for a load test, choose the **LOAD TEST** menu in Visual Studio and point to **Manage Test Controllers**. For any other tests, open the test settings file for your test project in Visual Studio, choose **Role** and choose **Manage Test Controllers** from the drop down for the **Controller** field.  
  
         The **Manage Test Controller** dialog box is displayed.  
  
3.  Select the name of the test controller whose test agents you want to change in the test controller list. If the test controller does not appear in the list, check that the test controller is registered correctly. For more information, see the following procedure about how to configure a test controller.  
  
4.  (Optional) In the **Test Agents** pane, select the test agent computer for which you want to change the properties.  
  
5.  If you are using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], choose **Configure**.  
  
     -or-  
  
     If you are using Visual Studio, choose **Properties**.  
  
6.  Change the following test agent properties as required:  
  
|Test Agent Property|Description|  
|-------------------------|-----------------|  
|**Weighting**|Used to distribute load when you use test agents with different performance levels. For example, a test agent with a weighting of 100 receives two times the load as a test agent with a weighting of 50.|  
|**IP Switching**|Used to configure IP switching. IP switching allows a test agent to send requests to a server by using a range of IP addresses. This simulates calls that come from different client computers.<br /><br /> IP Switching is important if your load test is accessing a Web farm. Most load balancers establish affinity between a client and a particular Web server by using the client's IP address. If all requests seem like they are coming from a single client, the load balancer will not balance the load. To obtain good load balance in the Web farm, make sure that requests come from a range of IP addresses. **Note:**  You can specify a network adapter, or use **(All unassigned)** to automatically select one that is currently not being used. <br /><br /> To use the IP switching feature, the Visual Studio Test Agent service must be running as a user in the Administrators group for that agent computer. This user is selected during agent setup, but can be changed by modifying the properties of the service and restarting it.<br /><br /> To verify that IP switching is working correctly, enable IIS logging on the Web server, use the IIS logging functionality to verify that requests are coming from the IP addresses that you configured.|  
|**Attributes**|Set of name/value pairs that can be used in test agent selection. For example, a test might require a particular OS. You can add attributes in the **Roles** tab of your test settings file and they can be used to select a test agent that has matching attributes. If you want to run a test on multiple machines, create an attribute in the test settings role that is configured to run your tests, and then configure a matching attribute on each test agent that you want to use in that role. For information about adding an attribute to a role in your test settings file, see [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md). **Note:**  This setting is only available for test agents that are registered with a test controller that is not registered to a team project, because these attributes are only used in test settings for Visual Studio.|  
  
 Test agent weight and test agent attribute changes go into effect immediately, but do not affect tests that are running. The IP Address Range takes effect after the test controller is restarted.  
  
1.  (Optional) To change the status of a test agent, select the agent in the list and then select the action from the available choices based on the current status of the agent.  
  
    > [!NOTE]
    >  If your test agent is running as a process, you manage the status of the test agent from the notification area icon that runs on the computer where your test agent is installed. This shows the status of the test agent. You can start, stop or restart the agent if it is running as a process using this tool. To start the test agent as a process if it is not running, choose **Start**, **All Programs**, **Microsoft Visual Studio** , **Microsoft Visual Studio Test Agent**. This adds the notification area icon.  
  
##  <a name="ChangeController"></a> Configuring a Test Controller  
 To configure a test controller, you must use the **Team Test Controller Configuration Tool**. When you configure your test controller, you can register your test controller with a different team project collection, or unregister your test controller from a team project collection.  
  
 If you want to register your test controller with your [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] project collection, the account that you use for the test controller service must be a member of the Project Collection Test Service Accounts group for the Team Project Collection, or the account that you use to run the test controller configuration tool must be a Project Collection Administrator.  
  
> [!NOTE]
>  If you unregister a test controller from a team project collection that has existing environments in a team project collection, the environments are still maintained if you moved that team project collection and re-register the test controller to that moved team project collection.  
  
#### To configure a test controller  
  
1.  To run the tool to reconfigure your test controller at any time, choose **Start**, **All Programs**,  **Microsoft Visual Studio**, **Microsoft Visual Studio Test Controller Configuration Tool**.  
  
     The **Configure Test Controller** dialog box is displayed.  
  
2.  Select the user to use as the logon account for your test controller service.  
  
    > [!NOTE]
    >  Null passwords are not supported for user accounts.  
  
3.  (Optional) If you want to use this test controller with a lab environment by using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you must register the controller with a team project collection for the team project that contains your environments. Select **Register with Team Project Collection**. To find your team project collection, choose **Browse** or you can type the name in **Register the test controller with the following Team Project Collection**. Make sure that you enter the full path. For example, **http://***\<server name>***:8080/tfs/DefaultCollection**.  
  
    > [!NOTE]
    >  For more information about environments, see [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md).  
  
4.  (Optional) If you do not want to use your test controller with a lab environment, but only to run tests from Visual Studio, clear **Register with Team Project Collection**.  
  
5.  (Optional) To configure your test controller for load testing, select **Configure for load testing**. Then type your [!INCLUDE[ssNoVersion](../datatools/includes/ssnoversion_md.md)] instance in **Create load test results database in the following SQL Server instance**.  
  
     For more information about load testing, see [Web performance and load tests in Visual Studio](../test_notintoc/web-performance-and-load-tests-in-visual-studio.md) and [Using Test Controllers and Test Agents with Load Tests](../test/using-test-controllers-and-test-agents-with-load-tests.md).  
  
> [!NOTE]
>  For more trouble shooting information about test controllers, see [Install and configure test agents](../test/install-and-configure-test-agents.md).  
  
##  <a name="DetermineController"></a> Determine the Test Controller Used to Run Your Tests  
 If there is an issue when you run your tests using a test controller, you might need to determine the test controller that is being used to verify that the test controller service is running, or that the test controller computer is started.  
  
 **Running Tests with Visual Studio**  
  
 If you run your tests using Visual Studio, the test controller you use to run your tests is displayed in your test settings. Use the procedure in this topic to view your test settings: [How to: Edit a Test Settings File from Microsoft Visual Studio](../test_notintoc/how-to--edit-a-test-settings-file-from-microsoft-visual-studio.md).  
  
 **Running Tests Using Microsoft Test Manager**  
  
 If you run your tests using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], to use a test controller you must create an environment. When you run your tests, you select one of the following choices:  
  
-   Run: This runs your tests using the environment specified in your test plan.  
  
-   Run with options: You can use this option to run your tests with a different environment.  
  
 To find the environment that is specified in your test plan, use the following topic to view the environments in the **Properties** view for your test plan: [How to: Choose Test Settings and Environments for a Test Plan](../test_notintoc/how-to--choose-test-settings-and-environments-for-a-test-plan.md).  
  
 When you know which environment you are using to run your tests, you can use the following procedure to view the details for this environment.  
  
#### To determine the test controller for your environment  
  
1.  Open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. (Go to Start, All Programs, Microsoft Visual Studio, Microsoft Test Manager.)  
  
2.  Choose **Lab Center**, **Lab**.  
  
     The **Environments** view is displayed.  
  
3.  Select the environment that you use to run your tests from the list and then choose **Open**.  
  
     The environment is displayed. You can now view which test controller is selected for your environment. The test controller name is the same as the computer name that it runs on.  
  
    > [!NOTE]
    >  The test controller service is called Visual Studio Test Controller. If you have issues with the test controller, you might want to verify that the computer is started and this service is running on the computer.  
  
##  <a name="RunningTests"></a> Managing Your Agents when You Run Your Tests with a Test Controller  
 When you add roles for your application to your test settings for Visual Studio, you can add agent properties for each of your roles. This determines which test agents are available for this role. When you run your tests using these test settings, the test controller that is selected for the test settings determines the availability of the required agents. These are the following situations that can occur when the agent availability is determined:  
  
-   There is no agent available for the role that must run the tests. Your tests cannot be run. You can perform one of the following actions and then rerun your tests:  
  
    -   You can wait for an agent to become available for this role to run the tests.  
  
    -   If there are any agents that are offline that can be used for this role, you can restart the agent so that it is available.  
  
    -   You can add another agent with the correct agent properties for that role to the test controller.  
  
    -   You can change the agent properties for this role in the test settings to enable other agents that you want to use.  
  
-   There is no agent available for one or more roles that run diagnostic data adapters. Your tests can be run, but the diagnostic data adapter cannot be run. You can run your tests without the diagnostic data adapter, or you can perform one of the following actions and rerun your tests:  
  
    -   You can wait for an agent to become available for these roles.  
  
    -   If there are any agents that are offline that can be used for this role, you must change the state of the agent to online from **Administer Test Controller** on the **Test** menu. In addition, you might have to restart the agent if it has been disconnected from the controller.  
  
    -   Verify that any agents that you might need for this test run are not busy running tests. You can check the status of any agents from **Administer Test Controller** on the **Test** menu.  
  
    -   You can add another agent with the correct agent properties for the role to the test controller.  
  
    -   You can change the agent properties for the role in the test settings to enable other agents that you want to use.  
  
##  <a name="DelaySigned"></a> Loading Tests from Delay-Signed Assemblies  
 The test controller and test agents can only load test assemblies that are strongly signed assemblies, or unsigned assemblies. Some test assemblies are delay-signed because they need to have access into production assemblies for the application. However, these assemblies are not strongly signed because they are only test assemblies and are not distributed. These assemblies cannot be loaded because they are delay-signed, so you must disable strong name verification for those assemblies on all machines where the assembly will be loaded including the test controller machine. To disable the delay-signed verification, use sn.exe. The public key token of the delay-signed assembly for which strong name verification is requested to be skipped may also need to be included.  
  
 Use the [Sn.exe (Strong Name Tool)](../Topic/Sn.exe%20\(Strong%20Name%20Tool\).md) to disable the delay-signed verification.  
  
 This disables strong-name verification, for the specified assembly only, on the computer on which you run the command. You can do this only if you have sufficient permissions.  
  
 After the test run has completed, re-enable the delayed-signing verification by using the SN.exe command.  
  
 A recommended way to disable and re-enable signing verification is to use the SN.exe commands in scripts. You can disable verification in a setup script and re-enable verification in a cleanup script.  
  
## See Also  
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)   
 [Run manual tests with Microsoft Test Manager](../test/run-manual-tests-with-microsoft-test-manager.md)