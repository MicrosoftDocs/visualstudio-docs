---
title: Timeout Periods for Test Controllers and Test Agents
description: Learn how to change the timeout values for the test controller and the test agent by editing the associated XML configuration files.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - agents, configuring
  - agetns, timeouts
  - controllers, configuring
  - controllers, timeouts
ms.assetid: 777d0db5-0073-458a-a2a3-58b1c1f24c60
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Specify timeout periods for test controllers and test agents

Both the test controller and the test agent have several timeout settings that specify how long they should wait for responses from one another, or from a data source before failing with an error. Under certain circumstances, it might be necessary to edit the timeout values to meet the needs of your topology or other environment issues. To edit the timeout values, edit the XML configuration file that is associated with either the test controller or test agent, as covered in the following procedures.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

To edit a test controller or a test agent’s various timeout settings, modify the following configuration files using the key names and values in the tables:

- Test controller: *QTController.exe.config*

    |Key name|Description|Value|
    |-|-----------------|-|
    |AgentConnectionTimeoutInSeconds|Number of seconds to wait for agent ping request before connection is considered lost.|"n" seconds.|
    |AgentSyncTimeoutInSeconds|When you start a synchronizing test run, number of seconds to wait for all agents to sync before aborting the run.|"n" seconds.|
    |AgentInitializeTimeout|Number of seconds to wait for all agents and their data collectors to initialize at the beginning of a test run, before aborting the test run. This value should be reasonably large if using data collectors.|"n" seconds. Default: "120" (two minutes).|
    |AgentCleanupTimeout|Number of seconds to wait for all agents and their data collectors to clean up, before completing the test run. This value should be reasonably large if using data collectors.|"n" seconds. Default: "120" (two minutes).|

- Test Agent: *QTAgentService.exe.config*

    |Key name|Description|Value|
    |-|-----------------|-|
    |ControllerConnectionPeriodInSeconds|Number of seconds between attempts to connect to the controller.|"n" seconds. Default: "30" (thirty seconds).|
    |RemotingTimeoutSeconds|Maximum time a remoting call can last in seconds.|"n" seconds. Default: "600" (ten minutes).|
    |StopTestRunCallTimeoutInSeconds|Number of seconds to wait for call to stop the test run.|"n" seconds. Default: "120" (two minutes).|
    |GetCollectorDataTimeout|Number of seconds to wait for the data collector.|"n" seconds. Default: "300" (five minutes).|

## To specify agent timeout options for a test controller

1. Open the *QTCcontroller.exe.config* XML configuration file located in *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE*.

2. Locate `<appSettings>` tag.

    ```xml
    <appSettings>
      <add key="LogSizeLimitInMegs" value="20"/>
      <add key="AgentConnectionTimeoutInSeconds" value="120"/>
      <add key="AgentSyncTimeoutInSeconds" value="300"/>
      <add key="ControllerServicePort" value="6901"/>
      <add key="ControllerUsersGroup" value="TeamTestControllerUsers"/>
      <add key="ControllerAdminsGroup" value="TeamTestControllerAdmins"/>
      <add key="CreateTraceListener" value="no"/>
    </appSettings>
    ```

3. Edit an existing value for one of the test controller’s timeout keys. For example, you can change the default value for the key `AgentConnectionTimeoutInSeconds` from two minutes to three minutes:

    ```xml
    <add key="AgentConnectionTimeoutInSeconds" value="180"/>
    ```

    -or-

    Add an additional key and specify a timeout value. For example, you can add the `AgentInitializeTimeout` key in the `<appSettings>` section and specify a value of five minutes:

    ```xml
    <appSettings>
            <add key="AgentInitializeTimeout" value="300"/>
    </appSettings>
    ```

## To specify agent timeout options for a test agent

1. Open the *QTAgentService.exe.config* XML configuration file located in *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE*.

2. Locate `<appSettings>` tag.

    ```xml
    <appSettings>
      <appSettings>
      <add key="LogSizeLimitInMegs" value="20"/>
      <add key="AgentServicePort" value="6910"/>
      <add key="ControllerConnectionPeriodInSeconds" value="30"/>
      <add key="StopTestRunCallTimeoutInSeconds" value="120"/>
      <add key="CreateTraceListener" value="no"/>
      <add key="GetCollectorDataTimeout" value="300"/>
    </appSettings>  </appSettings>
    ```

3. Edit an existing value for one of the test agent’s timeout keys. For example, you can change the default value for the key `ControllerConnectionPeriodInSeconds` from thirty seconds to one minute:

    ```xml
    <add key="ControllerConnectionPeriodInSeconds" value="60"/>
    ```

    -or-

    Add an additional key and specify a timeout value. For example, you can add the `RemotingTimeoutSeconds` key in the `<appSettings>` section and specify a value of fifteen minutes:

    ```xml
    <appSettings>
            <add key=" RemotingTimeoutSeconds " value="900"/>
    </appSettings>
    ```

## See also

- [Install and configure test agents](../test/lab-management/install-configure-test-agents.md)
- [Modify load test logging settings](../test/modify-load-test-logging-settings.md)
- [Configure ports for test controllers and test agents](../test/configure-ports-for-test-controllers-and-test-agents.md)
- [How to: Bind a test controller or test agent to a network adapter](../test/how-to-bind-a-test-controller-or-test-agent-to-a-network-adapter.md)
