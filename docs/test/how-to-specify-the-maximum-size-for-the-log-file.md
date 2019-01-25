---
title: "Log File size for load tests"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, logging"
ms.assetid: 417059bf-37ae-4e7a-b9b0-29bd71f1414f
author: gewarren
ms.author: gewarren
manager: jillfra
ms.prod: visual-studio-dev15
---
# How to: Specify the maximum size for the log file for load tests

By default, the maximum size of the log file that is used for load tests is set to 20 megabytes. You can change this value by editing the configuration file associated with the controller service.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Specify the maximum log file size for load test

1.  Open the *QTCcontroller.exe.config* XML configuration file located in *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\QTCcontroller.exe.config*.

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

- [Modify load test logging settings](../test/modify-load-test-logging-settings.md)
- [Configure ports for test controllers and test agents](../test/configure-ports-for-test-controllers-and-test-agents.md)