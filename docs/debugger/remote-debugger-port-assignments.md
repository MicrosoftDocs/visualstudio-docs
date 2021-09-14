---
title: "Remote Debugger Port Assignments | Microsoft Docs"
description: Understand Visual Studio remote debugger port assignments on 32-bit operating systems, 64-bit operating systems, and Azure. Learn about the discovery port.
ms.custom: SEO-VS-2020
ms.date: "09/10/2021"
ms.topic: "reference"
ms.assetid: 238bb4ec-bb00-4c2b-986e-18ac278f3959
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Remote Debugger Port Assignments
The Visual Studio Remote Debugger can run as an application or as a background service. When it runs as an application, it uses a port that is assigned by default as follows:
::: moniker range=">=vs-2022"
- Visual Studio 2022: 4026
::: moniker-end
::: moniker range="vs-2019"
- Visual Studio 2019: 4024
::: moniker-end
- Visual Studio 2017: 4022

- Visual Studio 2015: 4020

- Visual Studio 2013: 4018

- Visual Studio 2012: 4016

In other words, the number of the port assigned to the remote debugger is incremented by 2 for each release. You can set a different port number if you like. We will explain how to set port numbers in a later section.

## The Remote Debugger Port on 32-bit Operating Systems

::: moniker range=">=vs-2022"
 TCP 4026 (in Visual Studio 2022) is the main port, and is required for all scenarios. You can configure this from either the command line or the remote debugger window.
::: moniker-end
::: moniker range="vs-2019"
 TCP 4024 (in Visual Studio 2019) is the main port, and is required for all scenarios. You can configure this from either the command line or the remote debugger window.
::: moniker-end
::: moniker range="vs-2017"
 TCP 4022 (in Visual Studio 2017) is the main port, and is required for all scenarios. You can configure this from either the command line or the remote debugger window.
::: moniker-end

 In the remote debugger window, click **Tools > Options**, and set the TCP/IP port number.

 On the command line, start the remote debugger with the **/port** switch: **msvsmon /port \<port number>**.

 You can find all the remote debugger command line switches in the remote debugging help (press **F1** or click **Help > Usage** in the remote debugger window).

## The Remote Debugger Port on 64-bit Operating Systems
::: moniker range=">=vs-2022"
 When the 64-bit version of the remote debugger is started, it uses the main port (4026) by default.  If you debug a 32-bit process, the 64-bit version of the remote debugger starts a 32-bit version of the remote debugger on port 4025. If you run the 32-bit remote debugger, it uses 4026, and 4025 is not used.
::: moniker-end
::: moniker range="vs-2019"
 When the 64-bit version of the remote debugger is started, it uses the main port (4024) by default.  If you debug a 32-bit process, the 64-bit version of the remote debugger starts a 32-bit version of the remote debugger on port 4025 (the main port number incremented by 1). If you run the 32-bit remote debugger, it uses 4024, and 4025 is not used.
::: moniker-end
::: moniker range="vs-2017"
 When the 64-bit version of the remote debugger is started, it uses the main port (4022) by default.  If you debug a 32-bit process, the 64-bit version of the remote debugger starts a 32-bit version of the remote debugger on port 4023 (the main port number incremented by 1). If you run the 32-bit remote debugger, it uses 4022, and 4023 is not used.
:::moniker-end

 This port is configurable from the command line: **Msvsmon /wow64port \<port number>**.

## The Discovery Port
 UDP 3702 is used for finding running instances of the remote debugger on the network (for example, the **Find** dialog in the **Attach to Process** dialog). It is used only for discovering a machine running the remote debugger, so it is  optional if you have some other way of knowing the machine name or IP address of the target computer. This is a standard port for discovery, so the port number cannot be configured.

 If you do not want to enable discovery, you can start msvsmon from the command line with discovery disabled:  **Msvsmon /nodiscovery**.

## Remote Debugger Ports on Azure
 The following ports are used by the remote debugger on Azure. The ports on the cloud service are mapped to the ports on the individual VM. All ports are TCP.

|Connection|Port on Cloud Service|Port on VM|
|-|-|-|
|Microsoft.WindowsAzure.Plugins.RemoteDebugger.Connector|30400|30398|
|Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarder|31400|31398|
|Microsoft.WindowsAzure.Plugins.RemoteDebugger.Forwarderx86|31401|31399|
|Microsoft.WindowsAzure.Plugins.RemoteDebugger.FileUpload|32400|32398|

## See also
- [Remote Debugging](../debugger/remote-debugging.md)
