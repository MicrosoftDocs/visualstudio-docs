---
title: "Log File size for load tests in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, logging"
ms.assetid: 417059bf-37ae-4e7a-b9b0-29bd71f1414f
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Specify the Maximum Size for the Log File for Load Tests

By default, the maximum size of the log file that is used for load tests is set to 20 megabytes. You can change this value by editing the configuration file associated with the controller service.

## Specify the Maximum Log File Size for Load Test

1.  Open the *QTCcontroller.exe.config* XML configuration file located in %ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\QTCcontroller.exe.config.

2.  Locate `<add key="LogSizeLimitInMegs" value="20"/>` entry under the `<appSettings>` tag.

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

3.  Modify `value ="20"` to the maximum allowable size you want to specify for the log file.

    > [!NOTE]
    > Entering a value of "0" specifies that the log file is only limited in size by available disk space.

## See also

- [Modifying Load Test Logging Settings](../test/modify-load-test-logging-settings.md)
- [Configuring Ports for Test Controllers and Test Agents](../test/configure-ports-for-test-controllers-and-test-agents.md)