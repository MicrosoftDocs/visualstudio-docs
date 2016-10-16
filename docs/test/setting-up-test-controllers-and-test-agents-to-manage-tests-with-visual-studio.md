---
title: "Setting Up Test Controllers and Test Agents to Manage Tests with Visual Studio"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5bed0c00-cb8d-456c-a889-66cb55c0e2fc
caps.latest.revision: 35
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
# Setting Up Test Controllers and Test Agents to Manage Tests with Visual Studio
This topic describes how to install and configure test controllers, if you're using Agents for Microsoft Visual Studio 2013, and test agents so you can manage tests in Visual Studio without using Microsoft Test Manager. If you want to set up test controllers for a lab environment using Microsoft Test Manager, see [Setting Up Test Controllers in Lab Environments](../test/setting-up-test-controllers-in-lab-environments.md).  
  
 After you set up your test controllers and test agents, you can assign roles to them in a test setting. You must do this if you are going to distribute tests to multiple machines using Visual Studio. For information about how to assign roles to test controllers and test agents, see [Assigning Roles to a Test Controller and Test Agent for Automated Testing in Visual Studio](../test/assigning-roles-to-a-test-controller-and-test-agent-for-automated-testing-in-visual-studio.md).  
  
 These sections describe how to install and configure test controllers and test agents for testing in Visual Studio:  
  
-   [Prerequisites](#prereq)  
  
-   [Requirements for Workgroups and Multiple Domains](#workgroup)  
  
-   [Configuring Security for Test Controllers and Test Agents](#security)  
  
-   [Installing a Test Controller](#controller)  
  
-   [Installing a Test Agent](#agent)  
  
-   [Troubleshooting](#troubleshooting)  
  
##  <a name="prereq"></a> Prerequisites  
 Test controllers and test agents have the following software requirement:  
  
 **Operating System**  
  
 To install a test controller or a test agent, the computer must run one of the following operating systems:  
  
 **Controller:**  
  
-   Windows 8, Windows 8.1  
  
-   Windows 7 Service Pack 1  
  
-   Windows Server 2012, Windows Server 2012 R2  
  
-   Windows Server 2008 Release 2, Service Pack 1  
  
 **Agent:**  
  
-   Windows 8, Windows 8.1  
  
-   Windows 7 Service Pack 1  
  
-   Windows XP Service Pack 3  
  
-   Windows Server 2012, Windows Server 2012 R2  
  
-   Windows Server 2008 Release 2, Service Pack 1  
  
 **.NET Framework**  
  
 To install a test controller or test agent, the computer must run the .NET Framework 4.5.  
  
##  <a name="workgroup"></a> Requirements for Workgroups and Multiple Domains  
 If you plan to run your test controllers and test agents on machines that are in a work group and not in a domain, or machines that run in different domains that do not have a two-way trust relationship, you must follow these steps as part of your installation process:  
  
1.  On each computer where you will install a test controller or a test agent, create a local user account that is a member of the Administrators group. Use the same account and password on each machine.  
  
2.  Use this user account for your test controllers when you install and configure them.  
  
3.  Add this account to the TeamTestAgentService group on the test controller machine.  
  
    > [!CAUTION]
    >  When you add this user account to the group, do not include the name of the local machine. For example, do not add the user account as \<machine name>\\<username\>. Just add \<username> as the user account for the group.  
  
4.  Install and configure your test agents using this same account.  
  
    > [!NOTE]
    >  During installation, simple file sharing is automatically turned off for users who connect to a controller from a Windows XP Professional computer in a Work Group. To verify this, open Windows Explorer, choose **Tools**, choose **Folder Options**, choose **Next**, choose the **View** tab, and then choose **Use Simple File Sharing (Recommended)**.  
  
##  <a name="security"></a> Configuring Security for Test Controllers and Test Agents  
 When you install a test controller it creates user groups that provide permissions to complete specific tasks on the test controller, such as administering the test controller, or starting test runs using the test controller. You must add the appropriate users to these groups so you can perform these tasks:  
  
-   Administer tests and configure test components  
  
-   Run tests and view the results  
  
-   Run the test agent service  
  
 This table describes the groups that are created on the test controller machine when you configure a test controller. It also describes the user accounts that you must add to each group.  
  
|User Groups|Permissions|User Accounts|  
|-----------------|-----------------|-------------------|  
|TeamTestControllerAdmins|-   Includes permissions from the TeamTestControllerUsers and TeamTestAgentService groups<br />-   Delete, pause, or postpone any test run<br />-   Add, remove, and change the status of test agents<br />-   Create lab environments.|Add users that need to manage test runs, and administer test controllers and test agents.|  
|TeamTestControllerUsers|-   Includes permissions from the  TeamTestAgentService group<br />-   Start test runs<br />-   View test results|Add users that only need to run tests and view test results.|  
|TeamTestAgentService|This group contains the minimal permissions needed for a test agent to connect to a test controller.<br /><br /> -   Connect to a test controller|Before you configure a test agent, add the user accounts that you will use to run the test agent service. This is the user account that you specify in the Test Agent Configuration Tool when you install a test agent.|  
  
##  <a name="controller"></a> Installing a Test Controller  
 This section describes how to install a test controller when using Agents for Microsoft Visual Studio 2013.  
  
> [!CAUTION]
>  You must not install and run a test controller on a computer that is also a domain controller.  
  
### Required Permissions  
 To install a test controller, you must be a member of the Administrators security group on the computer.  
  
##### To install a test controller  
  
1.  [Agents for Microsoft Visual Studio 2013 Update 5](http://go.microsoft.com/fwlink/p/?LinkId=619264), if you haven't already. Follow the installation instructions on the download page.  
  
2.  Choose **Launch** to configure the test controller that you have installed.  
  
     The **Configure Test Controller** dialog box is displayed.  
  
    > [!NOTE]
    >  You can run this tool to reconfigure your test controller at any time. Choose **Microsoft Visual Studio Test Controller Configuration Tool** from the **All Programs** menu.  
  
3.  Select the user to use as the logon account for your test controller service.  
  
    > [!NOTE]
    >  Null passwords are not supported for user accounts.  
  
    > [!IMPORTANT]
    >  Do not register your test controller with a team project. You should not register a test controller with a team project if you are not using a lab environment to manage your tests.  
  
4.  (Optional) To configure your test controller for load testing, choose **Configure for load testing**.  
  
    1.  Type your [!INCLUDE[ssNoVersion](../datatools/includes/ssnoversion_md.md)] instance in **Create load test results database in the following SQL Server instance**.  
  
        > [!NOTE]
        >  If you do not have SQL Server installed, you can use SQL Express. For more information about how to download and install SQL Express, visit the following [Microsoft Web site](http://go.microsoft.com/fwlink/?LinkId=178451). For more information about sizing considerations, see [Using Test Controllers and Test Agents with Load Tests](../test/using-test-controllers-and-test-agents-with-load-tests.md).  
  
5.  To apply your changes, choose **Apply Settings**.  
  
     A **Configuration summary** dialog box is displayed. It shows the status of each step that is required to configure your test controller.  
  
6.  To close the **Configuration summary** dialog box, choose **Close**. Then choose **Close** again to close the Test Controller Configuration Tool.  
  
     The name of your test controller is the machine name where you installed it.  
  
     The test controller runs as a Windows Service named **Visual Studio Test Controller**. You can start and stop the service and view its properties in the **Services** tool in **Administrative Tools**.  
  
> [!NOTE]
>  When you install a test controller on a computer, the registry entry HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control on that computer is set. This value silently changes the Service Control Manager time-out from 30 seconds to 10 minutes to provide more time for the test controller to start to communicate with [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] services. For more information, see [A service does not start, and events 7000 and 7011 are logged in Windows Server 2003, Windows Server 2008, and Windows Server 2008 R2](http://go.microsoft.com/fwlink/?LinkId=167904).  
  
 If you install the test controller on a computer that runs an operating system with user account control (UAC) the registry key HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\system\ LocalAccountTokenFilterPolicy is set to a value of 1. This disables remote restrictions of UAC to allow remote authentication if a test agent is configured to use a local account. For more information, see [Description of User Account Control and Remote Restrictions](http://go.microsoft.com/fwlink/?LinkId=181060).  
  
##  <a name="agent"></a> Installing a Test Agent  
 You need to install a test agent on each machine where you will deploy your software in test, and on each machine that you will use to collect test data. This section describes how to install a test agent and register it with a test controller.  
  
> [!CAUTION]
>  You should not install test agents on the server that is running Team Foundation Server.  
  
### Required Permissions  
 To install a test agent, you must be a member of the Administrators security group on the computer. When you register a test agent with a test controller, you must also be a member of the Administrators security group on the test controller machine.  
  
> [!CAUTION]
>  If the user that you select to start the service or process for the test agent is the current user, when you add this user to the test controller machine, you must log off or restart the machine.  
  
### Windows XP Prerequisites  
 Before installing an agent on Windows XP, you must install the following:  
  
-   .NET Framework 4  
  
-   MSXML 6.0  
  
-   Windows Imaging Component (WIC)  
  
##### To install a test agent  
  
1.  [Download Agents for Microsoft Visual Studio 2015](http://go.microsoft.com/fwlink/p/?LinkId=619266) or [Agents for Microsoft Visual Studio 2013 Update 5](http://go.microsoft.com/fwlink/p/?LinkId=619264), if you haven't already. Follow the installation instructions on the download page.  
  
2.  Choose **Launch** to configure the test agent after installation.  
  
    > [!NOTE]
    >  You can run this tool to reconfigure your test agent at any time. Choose **All Programs**, **Microsoft Visual Studio**, **Microsoft Visual Studio Test Agent Configuration Tool**.  
  
3.  You are presented with two options for how the test agent will be run:  
  
     **Service** If you do not have to run automated tests that interact with the desktop, such as coded UI tests or creating a video recording when your test runs, under **Run the test agent as**, choose **Service**. The test agent will be started as a service. Choose **Next**.  
  
     You can now enter the details about the user when the test agent starts as a service.  
  
    1.  Type the name in **User name**.  
  
    2.  Type the password in **Password**.  
  
        |**Important user account information**|  
        |--------------------------------------------|  
        |-   Null passwords are not supported for user accounts.|  
        |-   If you want to use the IntelliTrace collector or the network emulation, the user account must be a member of the Administrators group.|  
        |-   If the agent user name is not a member of the TeamTestAgentService group it will be added to this group, which requires permissions on the test controller machine.|  
        |-   The user for the interactive process must be a member of the TeamTestAgentService security group or the process will not be able to run the tests assigned by the controller.|  
  
     **Interactive Process** If you want to run automated tests that must interact with the desktop, such as coded UI tests or creating a video recording when your test runs, choose **Interactive Process**. For information about how to run a test agent as a process, see [How to: Set Up Your Test Agent to Run Tests that Interact with the Desktop](../test/how-to--set-up-your-test-agent-to-run-tests-that-interact-with-the-desktop.md). Choose **Next**.  
  
     You can now enter the details about the user when the test agent starts as a process, and other options.  
  
    1.  Type the name in **User name**.  
  
    2.  Type the password in **Password**.  
  
        > [!NOTE]
        >  If you configure the test agent to run as an interactive process with a different user who is not the currently active user, you must restart the computer and log on as this different user to be able to start the agent.  
  
        |**Important user account information**|  
        |--------------------------------------------|  
        |-   Null passwords are not supported for user accounts.|  
        |-   If you want to use the IntelliTrace or the network emulation data and diagnostic adapter, the user account must be a member of the Administrators group. If the machine that is running the test agent is using [!INCLUDE[wiprlhext](../debugger/includes/wiprlhext_md.md)] or later versions, or any OS that has Least-Privileged User Account, you have to run it as an administrator also (elevated).|  
        |-   If the agent user name is not a member of the TeamTestAgentService group it will be added to this group, which requires permissions on the test controller machine.|  
        |-   The user for the test agent service must be a member of the TeamTestAgentService security group or the service will not be able to run the tests assigned by the controller.|  
  
    3.  To make sure that a computer that has a test agent can run tests after it reboots, you can set up the computer to log on automatically as the test agent. Choose **Log on automatically**. This will store the user name and password in an encrypted form in the registry.  
  
    4.  To make sure that the screen saver is disabled because this might interfere with any automated tests that must interact with the desktop, choose **Ensure screen saver is disabled**.  
  
        > [!CAUTION]
        >  There are security risks if you log on automatically or disable the screen saver. By enabling automatic log on, you enable other users to start this computer and to be able to use the account that automatically logs on. If you disable the screen saver, the computer might not prompt for a user to log on to unlock the computer. This lets anyone access the computer if they have physical access to it. If you enable these features on a computer, you should make sure that these computers are physically secure. For example, these computers are located in a physically secure lab. (If you clear **Ensure screen saver is disabled**, this does not enable your screen saver.)  
  
4.  To register this agent with a test controller, choose **Register with test controller.** Type the name of your test controller followed by a colon (**:**) and the port number that you are using in **Register the test agent with the following test controller**. For example, type **agent1:6901**.  
  
    > [!NOTE]
    >  The default port number is 6901.  
  
5.  To apply your changes, choose **Apply Settings**.  
  
     A **Configuration summary** dialog box is displayed. It shows the status of each step that is required to configure your test agent.  
  
    > [!NOTE]
    >  The last step in the installation process resets the network adapter. This might cause a network outage for brief period of time. This is expected behavior.  
  
6.  To close the **Configuration summary** dialog box, choose **Close**. Then choose **Close** again to close the Test Agent Configuration Tool.  
  
    > [!NOTE]
    >  There is a notification area icon that runs on the computer for a test agent that is running as a process. It shows the status of the test agent. You can start, stop or restart the agent if it is running as a process using this tool. To start the test agent as a process if it is not running, choose **All Programs**, **Microsoft Visual Studio**, **Microsoft Visual Studio Test Agent**.  
  
     The **Visual Studio Agents Setup** dialog box is displayed. From here, you can install any other components that you require on this computer.  
  
##  <a name="troubleshooting"></a> Troubleshooting  
 To configure and monitor the test controller and any registered agents, choose the **LOAD TEST** menu in Visual Studio and point to **Manage Test Controllers**.  
  
> [!NOTE]
>  You must type the name of your test controller computer into the controllers list to manage your test controller. It is not displayed automatically even if your test controller is running on the same computer.  
  
 Agents should be in the ready state. If a test agent is not in the list of test agents, or the test agent is in the disconnected state, you can run the Test Agent Configuration Tool on the computer where the agent is installed and the Test Controller Configuration Tool on the computer where the controller is installed.  
  
> [!NOTE]
>  To run the configuration tools, choose **All Programs**, **Microsoft Visual Studio**, **Microsoft Visual Studio Test Agent Configuration Tool** or **Microsoft Visual Studio Test Controller Configuration Tool** as required.  
  
 Verify the following criteria for the test controller:  
  
-   The user for the test controller is a member of the TeamTestControllerAdmins group or the user for the test controller is a member of the Administrators group.  
  
-   Make sure that it is not configured for a team project collection.  
  
    > [!NOTE]
    >  You might want to run with elevated permissions, or restart your computer, if the test controller is running on the same machine as Visual Studio and you have added the user to the TeamTestControllerAdmins group when this user is the active user.  
  
 Verify the following settings for the test agent:  
  
-   The user for the test agent is a member of the TeamTestAgentService group on the computer where the test agent in installed and on the computer where the test controller is installed.  
  
    > [!NOTE]
    >  If this user is the current user, when you add this user to the test controller machine, you must log off or restart this computer.  
  
-   The correct test controller name and port have been entered.  
  
 You can also examine the %LOCALAPPDATA%\Temp\TestControllerConfigUI.log and TestAgentConfigUI.log files for errors and more details. You can open these files from the link on the Configuration Summary page when you use the Test Agent or Test Controller configuration tools.  
  
 If you are running Windows Firewall, the test controller setup adds the following exceptions to your firewall. Make sure that this exception has been added.  
  
|Exception|Reason|  
|---------------|------------|  
|QTController.exe|Enable communication with the test controller.|  
  
## See Also  
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Assigning Roles to a Test Controller and Test Agent for Automated Testing in Visual Studio](../test/assigning-roles-to-a-test-controller-and-test-agent-for-automated-testing-in-visual-studio.md)   
 [How to: Set Up Your Test Agent to Run Tests that Interact with the Desktop](../test/how-to--set-up-your-test-agent-to-run-tests-that-interact-with-the-desktop.md)   
 [Configuring Ports for Test Controllers and Test Agents](../test/configuring-ports-for-test-controllers-and-test-agents.md)   
 [How to: Specify Timeout Periods for Test Controllers and Test Agents](../test/how-to--specify-timeout-periods-for-test-controllers-and-test-agents.md)