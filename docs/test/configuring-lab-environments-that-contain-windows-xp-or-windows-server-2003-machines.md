---
title: "Configuring Lab Environments that Contain Windows XP or Windows Server 2003 Machines"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: e646c59c-47e4-47a5-bf9f-67f375ad1915
caps.latest.revision: 8
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
# Configuring Lab Environments that Contain Windows XP or Windows Server 2003 Machines
You can use lab environments that contain virtual and physical machines that run Windows XP or Windows Server 2003. However, those lab environments will have some issues during configuration that other lab environments don't have.  These issues require you to perform additional steps when you configure and make changes to lab environments that contain Windows XP or Windows Server 2003 machines.  
  
> [!NOTE]
>  Windows Server 2003 machines are only supported using [!INCLUDE[vs2012_upd02](../test/includes/vs2012_upd02_md.md)].  
  
 The following table lists the issues that you might encounter when you configure lab environments that contain Windows XP machines:  
  
|Issue|Solution|  
|-----------|--------------|  
|**Creating a lab environment:**<br /><br /> Creating a lab environment will fail if the environment contains Windows XP or Windows Server 2003 machines.|See the section: [Creating Lab Environments that Include Windows XP Machines](#createxplab)|  
|**Editing a lab environment**<br /><br /> Editing a lab environment will fail if the environment contains Windows XP or Windows Server 2003 machines.|See the section: [Reconfiguring Lab Environments that Include Windows XP Machines](#reconlab)|  
|**Repairing a lab environment:**<br /><br /> Repairing a lab environment will fail if the environment contains Windows XP or Windows 2003 Server machines.|See the section: [Reconfiguring Lab Environments that Include Windows XP Machines](#reconlab)|  
|**Configuring a lab environment to run as a service:**<br /><br /> If a lab environment contains Windows XP or Windows Server 2003 machines and is configured to run coded UI tests, reconfiguring the environment to run as a service will cause an error.|See the section: [Reconfiguring Lab Environments that Include Windows XP Machines](#reconlab)|  
|**Changing a test controller**<br /><br /> If a lab environment contains Windows XP or Windows Server 2003 machines, changing the test controller for the environment will cause an error.|See the section: [Reconfiguring Lab Environments that Include Windows XP Machines](#reconlab)|  
|**Changing the settings for a test controller**<br /><br /> If a lab environment contains Windows XP or Windows Server 2003 machines, changing the settings for the test controller in Microsoft Test Manager using the **Test Controller Manager** tab will cause an error.|See the section: [Reconfiguring Lab Environments that Include Windows XP Machines](#reconlab)|  
  
##  <a name="createxplab"></a> Creating a lab environment that uses Windows XP or Windows Server 2003 machines  
 To create a lab environment that contains Windows XP or Windows Server 2003 machines, follow these steps:  
  
1.  **Create your lab environment:**  
  
     Create your lab environment using Microsoft Test Manager. See [Creating Lab Environments](../test/creating-lab-environments.md). When you finish creating the environment using the **New Environment** wizard, Lab Management will attempt to install test agents on your machines. However, Lab Management will fail to install test agents on your Windows XP or Windows Server 2003 machines and the **Status** of your lab environment will display **Not Ready**.  
  
2.  **Manually install test agents on your Windows XP or Windows Server 2003 machines:**  
  
     Manually install a test agent on each Windows XP or Windows Server 2003 machine in your environment. See the section: [Manually Installing Test Agents in Lab Environments](#installagent).  
  
3.  **Verify your test agents:**  
  
     Open your lab environment in Microsoft Test Manager.  
  
    1.  Open Microsoft Test Manager  
  
    2.  Choose **Lab Center** from the drop-down menu.  
  
    3.  Choose the **Lab** tab.  
  
    4.  Highlight your lab environment in the **Environments** list, and then choose the **Open** on the toolbar.  
  
4.  Choose the **Verify** button. A set of verifications will run.  
  
5.  Choose the **Finish** button.  
  
     Lab Management will attempt to reinstall test agents on the machines in your lab environment, and will display an error or warning. However, if the procedure is successful, the **Status** of the environment will change to **Ready** and you can use the environment.  
  
##  <a name="reconlab"></a> Reconfiguring a lab environment that uses Windows XP or Windows Server 2003 machines  
 This section describes how to reconfigure an existing lab environment that contains Windows XP or Windows Server 2003 machines. You must complete these steps in the following scenarios:  
  
-   Repairing your environment.  
  
-   Editing your environment.  
  
-   Changing the test controller that is used in your environment.  
  
-   Reconfiguring the test controller that is used in your environment.  
  
-   Reconfiguring an environment to run test agents as a service after they have been configured to run coded UI tests.  
  
1.  **Reconfigure your test controller:**  
  
     Optional: If you need to reconfigure your test controller, reconfigure the test controller before you complete the steps below. For information about configuring a test controller in a lab environment, see [Setting Up Test Controllers in Lab Environments](../test/setting-up-test-controllers-in-lab-environments.md).  
  
2.  **Manually uninstall the test agents on your Windows XP or Windows Server 2003 machines:**  
  
    1.  Log on to the Windows XP machine.  
  
    2.  In **Control Panel**, open **Add/Remove Programs**.  
  
    3.  If **Microsoft Visual Studio Agents** is on the list of programs, uninstall it. Otherwise, continue to the next step.  
  
3.  **Manually install test agents on your Windows XP or Windows Server 2003 machines:**  
  
     Manually install a test agent on each Windows XP or Windows Server 2003 machine in your environment. See the section: [Manually Installing Test Agents in Lab Environments](#installagent).  
  
4.  **Verify your test agents:**  
  
     Open your lab environment in Microsoft Test Manager.  
  
    1.  Open Microsoft Test Manager  
  
    2.  Choose **Lab Center** from the drop-down menu.  
  
    3.  Choose the **Lab** tab.  
  
    4.  Highlight your lab environment in the **Environments** list, and then choose the **Open** on the toolbar.  
  
5.  **Reconfigure the settings for the test controller and UI tests**  
  
     Optional: If you need to change the test controller, or the settings for running coded UI tests, choose the **Advanced** tab, and then reconfigure those settings.  
  
6.  Choose the **Verify** button. A set of verifications will run.  
  
7.  Choose the **Finish** button.  
  
     Lab Management will attempt to reinstall test agents on the machines in your lab environment, and will display an error or warning. However, if the procedure is successful, the **Status** of the environment will change to **Ready** and you can use the environment.  
  
##  <a name="installagent"></a> Manually installing test agents in lab environments  
 This section describes how to install a test agent on a machine that is part of a lab environment using the Visual Studio 2012 Agents installation software instead of Microsoft Test Manager. You must perform this step on every Windows XP or Windows Server 2003 machine in your lab environment.  
  
### Required permissions  
 To install a test agent, you must be a member of the Administrators security group on the computer. When you register a test agent with a test controller, you must also be a member of the Administrators security group on the test controller machine.  
  
##### To manually install a test agent  
  
1.  Load the "Visual Studio Agents" CD or a downloaded ISO image and then launch setup.exe, which is located in the root folder.  
  
     The Visual Studio Test Agent installation wizard appears. Follow the steps in the wizard.  
  
2.  When the wizard finishes the installation, choose **Configure test agent now**.  
  
    > [!NOTE]
    >  You can run this tool to reconfigure your test agent at any time. Choose **All Programs**, **Microsoft Visual Studio**, **Microsoft Visual Studio Test Agent Configuration Tool**.  
  
3.  Choose **Run Options** and then choose one of the following options. These options will determine how your test agent is run:  
  
     **Service:** If you do not have to run automated tests that interact with the desktop, such as coded UI tests or creating a video recording when your test runs, under **Run the test agent as**, choose **Service** and then choose **Next**.  
  
    1.  Under **Run test agent as a service**, in the **User name** and **Password** fields, specify the logon credentials that you used to create your lab environment. In the **Lab Center** of Microsoft Test Manager, these are the credentials that were used in the **Machines** tab of **New Environment** wizard.  
  
     **Interactive Process:** If you want to run automated tests that interact with the desktop, such as coded UI tests or creating a video recording when your test runs, choose **Interactive Process** and then choose **Next**. For information about how to run a test agent as a process, see [How to: Set Up Your Test Agent to Run Tests that Interact with the Desktop](../test/how-to--set-up-your-test-agent-to-run-tests-that-interact-with-the-desktop.md).  
  
    1.  Under **Run test agent as an interactive process**, in the **User name** and **Password** fields, specify the logon credentials that you used to create your lab environment. In the **Lab Center** of Microsoft Test Manager, these are the credentials that were used in the **Machines** tab of **New Environment** wizard.  
  
    2.  If you configure the test agent to run as an interactive process with a different user account than the one that was used to log on to the machine, you must restart the machine and log on with account that you entered in the Test Agent Configuration Tool. This must be done so the test agent service can start.  
  
    3.  To make sure that a computer that has a test agent can run tests after it reboots, you can set up the computer to log on automatically as the test agent. Choose **Log on automatically**. This will store the user name and password in an encrypted form in the registry.  
  
    4.  To make sure that the screen saver is disabled because this might interfere with any automated tests that must interact with the desktop, choose **Ensure screen saver is disabled**.  
  
        > [!CAUTION]
        >  There are security risks if you log on automatically or disable the screen saver. By enabling automatic log on, you enable other users to start this computer and to be able to use the account that automatically logs on. If you disable the screen saver, the computer might not prompt for a user to log on to unlock the computer. This lets anyone access the computer if they have physical access to it. If you enable these features on a computer, you should make sure that these computers are physically secure. For example, these computers are located in a physically secure lab. (If you clear **Ensure screen saver is disabled**, this does not enable your screen saver.)  
  
4.  Choose **Register with test controller.** Type the name of your test controller followed by a colon (**:**) and the port number that you are using in **Register the test agent with the following test controller**. For example, type **agent1:6901**.  
  
    > [!NOTE]
    >  The default port number is 6901.  
  
5.  To apply your changes, choose **Apply Settings**.  
  
     A **Configuration summary** dialog box is displayed. It shows the status of each step that is required to configure your test agent.  
  
    > [!NOTE]
    >  The last step in the installation process resets the network adapter. This might cause a network outage for brief period of time. This is expected behavior.  
  
6.  To close the **Configuration summary** dialog box, choose **Close**. Then choose **Close** again to close the Test Agent Configuration Tool.  
  
## See Also  
 [Troubleshooting Lab Management](../test/troubleshooting-lab-management.md)   
 [Creating Lab Environments](../test/creating-lab-environments.md)