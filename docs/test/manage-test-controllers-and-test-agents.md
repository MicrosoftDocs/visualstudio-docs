---
title: "Manage test controllers and test agents"
ms.date: 09/18/2018
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Manage test controllers and test agents

If you want to use Visual Studio to run tests remotely, distribute tests across multiple machines, or run load tests, you must configure a test controller, test agents, and test settings file. This topic describes how to manage test controllers and test agents after you install and configure them for the first time.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

If you use Microsoft Test Manager to run tests in lab environments, you manage test controllers and their agents by using the **Test Controller Manager** in the **Lab Center** for Microsoft Test Manager. This topic is applicable only if you use Visual Studio to run tests.

For information about how to install and configure test agents and test controllers to run tests in Visual Studio, see [Configure test agents and controllers](../test/configure-test-agents-and-controllers-for-load-tests.md).

To configure and monitor the test controller and any registered agents, you must have a test settings file in your test project that contains the tests you want to run. Open the test settings file, choose **Role** and choose **Manage Test Controllers** from the drop down for the **Controller** field.

For a load test project, you can also choose **Manage Test Controllers** from the **Load Test** menu.

## Add a test agent to a test controller

You might want to add a test agent to a different test controller or you might have to add a test agent to a test controller that you have just installed.

### To add a test agent to a test controller

1. Choose **Start** > **Test Agent Configuration Tool**.

     The **Configure Test Agent** dialog box is displayed.

    > [!NOTE]
    > You must have a test agent already installed to add it to a test controller. For more information about how to install a test agent, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).

2. You're presented with two options for how the test agent can be run:

   - **Service**: If you do not have to run automated tests that interact with the desktop, such as coded UI tests or creating a video recording when your test runs, under **Run the test agent as**, select **Service**. The test agent will be started as a service. Choose **Next**.

      You can now enter the details about the user when the test agent starts as a service.

      1. Enter the name in **User name**.

      2. Enter the password in **Password**.

        |**Important user account information**|
        |-|
        |-   Null passwords are not supported for user accounts.|
        |-   If you want to use the IntelliTrace collector or the network emulation, the user account must be a member of the Administrators group.|
        |-   If the agent user name is not in the agent service it will try to add it, which requires permissions on the test controller.|
        |-   The user who is trying to use the test controller must be in the test controller's Users account or they will be unable to run the tests against the controller.|

   - **Interactive Process**: If you want to run automated tests that must interact with the desktop, such as coded UI tests or creating a video recording when your test runs, select **Interactive Process**. The test agent will be started as an interactive process instead of a service.

      On the next page, enter the details about the user when the test agent starts as a process, and other options.

      1. Enter the name in **User name**.

      2. Enter the password in **Password**.

        > [!NOTE]
        > If you configure the test agent to run as an interactive process with a different user who is not the currently active user, you must restart the computer and log on as this different user to be able to start the agent. In addition, null passwords are not supported for user accounts. If you want to use the IntelliTrace collector or the network emulation, the user account must be a member of the Administrators group.

      3. To make sure that a computer that has a test agent can run tests after it restarts, you can set up the computer to log on automatically as the test agent use. Select **Log on automatically**. This will store the user name and password in an encrypted form in the registry.

      4. To make sure that the screen saver is disabled because this might interfere with any automated tests that must interact with the desktop, select **Ensure screen saver is disabled**.

        > [!WARNING]
        > There are security risks if you log on automatically or disable the screen saver. By enabling automatic log on, you enable other users to start this computer and to be able to use the account that automatically logs on. If you disable the screen saver, the computer might not prompt for a user to log on to unlock the computer. This lets anyone access the machine if they have physical access to the computer. If you enable these features on a computer, you should make sure that these computers are physically secure. For example, these computers are located in a physically secure lab. (If you clear **Ensure screen saver is disabled**, this does not enable your screen saver.)

3. To register this agent with a different test controller, select **Register with test controller.** Type the name of your test controller followed by **:** and the port number that you are using in **Register the test agent with the following test controller**. For example, type **agent1:6901**.

    > [!NOTE]
    > The default port number is 6901.

4. To save your changes, choose **Apply Settings**. Close the **Configuration summary** dialog box, and then close the **Test Agent Configuration Tool**.

> [!WARNING]
> If the agent is currently configured to run on another test controller, you must remove the test agent from that controller.

## Remove a test agent from a test controller

A test agent must be set to the offline state before it can be removed.

> [!NOTE]
> You can’t use this procedure to remove agents that are registered to a controller as part of a lab environment. To remove these agents from a controller, you must remove the environment using Microsoft Test Manager.

### To remove a test agent from a test controller

1. If the test controller is not registered with a project, follow these steps.

    1. From Visual Studio open the test settings file for your test project, choose **Role** and choose **Manage Test Controllers** from the drop down for the **Controller** field.

         The **Administer Test Controller** dialog box is displayed.

    2. In the **Controller** drop-down list, type the name of the computer on which you have set up the test controller. If you have administered a specific test controller previously, you can select the name from the list.

    3. In the **Agents** pane, select the test agent name. If the agent is still online, choose **Offline.** To remove it, choose **Remove**.

        > [!NOTE]
        > Removing a test agent just disassociates it from the test controller. To completely uninstall the test agent, use the  **Programs and Features** Control Panel on the test agent computer.

2. If the test controller is registered with a project, remove the agent using Microsoft Test Manager.

## Change the settings for a test agent

The status of the test agent can be any one of the following values:

|Status|Description|
|-|-----------------|
|Running Test|Running tests|
|Ready|Available to run tests or collect data and diagnostics|
|Offline|Unavailable to run tests or collect data and diagnostics|
|Disconnected|Test agent is not started|

You can change the status and other settings for a test agent using the following procedures.

### To change the settings of a test agent

> [!NOTE]
> If the test agent is registered to a test controller that is registered with a project, change the settings in Microsoft Test Manager.

1. To configure and monitor the test controller and any registered agents for a load test, choose the **Load Test** menu in Visual Studio and then choose **Manage Test Controllers**. For any other tests, open the test settings file for your test project in Visual Studio, choose **Role** and choose **Manage Test Controllers** from the drop down for the **Controller** field.

   The **Manage Test Controller** dialog box opens.

1. Select the name of the test controller whose test agents you want to change in the test controller list. If the test controller does not appear in the list, check that the test controller is registered correctly. For more information, see the following procedure about how to configure a test controller.

1. (Optional) In the **Test Agents** pane, select the test agent computer for which you want to change the properties.

1. Choose **Properties**.

1. Change the following test agent properties as required:

|Test Agent Property|Description|
|-|-----------------|
|**Weighting**|Used to distribute load when you use test agents with different performance levels. For example, a test agent with a weighting of 100 receives two times the load as a test agent with a weighting of 50.|
|**IP Switching**|Used to configure IP switching. IP switching allows a test agent to send requests to a server by using a range of IP addresses. This simulates calls that come from different client computers.<br /><br /> IP Switching is important if your load test is accessing a web farm. Most load balancers establish affinity between a client and a particular web server by using the client's IP address. If all requests seem like they are coming from a single client, the load balancer will not balance the load. To obtain good load balance in the web farm, make sure that requests come from a range of IP addresses. **Note:**  You can specify a network adapter, or use **(All unassigned)** to automatically select one that is currently not being used. <br /><br /> To use the IP switching feature, the Visual Studio Test Agent service must be running as a user in the Administrators group for that agent computer. This user is selected during agent setup, but can be changed by modifying the properties of the service and restarting it.<br /><br /> To verify that IP switching is working correctly, enable IIS logging on the web server, use the IIS logging functionality to verify that requests are coming from the IP addresses that you configured.|
|**Attributes**|Set of name/value pairs that can be used in test agent selection. For example, a test might require a particular OS. You can add attributes in the **Roles** tab of your test settings file and they can be used to select a test agent that has matching attributes. If you want to run a test on multiple machines, create an attribute in the test settings role that is configured to run your tests, and then configure a matching attribute on each test agent that you want to use in that role.. **Note:**  This setting is only available for test agents that are registered with a test controller that is not registered to a project, because these attributes are only used in test settings for Visual Studio.|

Test agent weight and test agent attribute changes go into effect immediately, but do not affect tests that are running. The IP Address Range takes effect after the test controller is restarted.

(Optional) To change the status of a test agent, select the agent in the list and then select the action from the available choices based on the current status of the agent.

> [!NOTE]
> If your test agent is running as a process, you manage the status of the test agent from the notification area icon that runs on the computer where your test agent is installed. This shows the status of the test agent. You can start, stop or restart the agent if it is running as a process using this tool.

## Configure a test controller

To configure a test controller, you must use the **Team Test Controller Configuration Tool**. When you configure your test controller, you can register your test controller with a different project collection, or unregister your test controller from a project collection.

If you want to register your test controller with your Team Foundation Server project collection, the account that you use for the test controller service must be a member of the Project Collection Test Service Accounts group for the Project Collection, or the account that you use to run the test controller configuration tool must be a Project Collection Administrator.

> [!NOTE]
> If you unregister a test controller from a project collection that has existing environments in a project collection, the environments are still maintained if you moved that project collection and re-register the test controller to that moved project collection.

### To configure a test controller

1. To run the tool to reconfigure your test controller at any time, choose **Start** > **Test Controller Configuration Tool**.

     The **Configure Test Controller** dialog box is displayed.

2. Select the user to use as the logon account for your test controller service.

    > [!NOTE]
    > Null passwords are not supported for user accounts.

4. (Optional) If you do not want to use your test controller with a lab environment, but only to run tests from Visual Studio, clear **Register test controller with Team Project Collection**.

5. (Optional) To configure your test controller for load testing, select **Configure test controller for load testing**. Enter the SQL Server instance under **Create load test results database in the following SQL Server instance**.

> [!NOTE]
> For more trouble shooting information about test controllers, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).

## Manage your agents when you run your tests with a test controller

When you add roles for your application to your test settings for Visual Studio, you can add agent properties for each of your roles. This determines which test agents are available for this role. When you run your tests using these test settings, the test controller that is selected for the test settings determines the availability of the required agents. These are the following situations that can occur when the agent availability is determined:

- There is no agent available for the role that must run the tests. Your tests cannot be run. You can perform one of the following actions and then rerun your tests:

  - You can wait for an agent to become available for this role to run the tests.

  - If there are any agents that are offline that can be used for this role, you can restart the agent so that it is available.

  - You can add another agent with the correct agent properties for that role to the test controller.

  - You can change the agent properties for this role in the test settings to enable other agents that you want to use.

- There is no agent available for one or more roles that run diagnostic data adapters. Your tests can be run, but the diagnostic data adapter cannot be run. You can run your tests without the diagnostic data adapter, or you can perform one of the following actions and rerun your tests:

  - You can wait for an agent to become available for these roles.

  - If there are any agents that are offline that can be used for this role, you must change the state of the agent to online from **Administer Test Controller** on the **Test** menu. In addition, you might have to restart the agent if it has been disconnected from the controller.

  - Verify that any agents that you might need for this test run are not busy running tests. You can check the status of any agents from **Administer Test Controller** on the **Test** menu.

  - You can add another agent with the correct agent properties for the role to the test controller.

  - You can change the agent properties for the role in the test settings to enable other agents that you want to use.

## Load tests from delay-signed assemblies

The test controller and test agents can only load test assemblies that are strongly signed assemblies, or unsigned assemblies. Some test assemblies are delay-signed because they need to have access into production assemblies for the application. However, these assemblies are not strongly signed because they are only test assemblies and are not distributed. These assemblies cannot be loaded because they are delay-signed, so you must disable strong name verification for those assemblies on all machines where the assembly will be loaded including the test controller machine. To disable the delay-signed verification, use *sn.exe*. The public key token of the delay-signed assembly for which strong name verification is requested to be skipped may also need to be included.

Use *Sn.exe* (Strong Name tool) to disable the delay-signed verification.

This disables strong-name verification, for the specified assembly only, on the computer on which you run the command. You can do this only if you have sufficient permissions.

After the test run has completed, re-enable the delayed-signing verification by using the *SN.exe* command.

A recommended way to disable and re-enable signing verification is to use the *SN.exe* commands in scripts. You can disable verification in a setup script and re-enable verification in a cleanup script.

## See also

- [Install and configure test agents](../test/lab-management/install-configure-test-agents.md)
