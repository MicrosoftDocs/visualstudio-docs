---
title: "Remote Debugger Port Assignments"
description: Understand Visual Studio remote debugger port assignments on 32-bit operating systems, 64-bit operating systems, and Azure. Learn about the discovery port.
ms.date: "10/01/2025"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Remote Debugger Port Assignments

The Visual Studio Remote Debugger can run as an application or as a background service. When it runs as an application, it uses a port that is assigned by default as follows:

::: moniker range=">=visualstudio"
- Visual Studio 2026 and later: 4026
::: moniker-end
- Visual Studio 2022: 4026

- Visual Studio 2019: 4024

- Visual Studio 2017: 4022

- Visual Studio 2015: 4020

- Visual Studio 2013: 4018

- Visual Studio 2012: 4016

::: moniker range=">=visualstudio"
In other words, for older versions of Visual Studio, the number of the port assigned to the remote debugger is incremented by 2 for each release. You can set a different port number if you like. We explain how to set port numbers in a later section.
::: moniker-end
::: moniker range="<=vs-2022"
In other words, the number of the port assigned to the remote debugger is incremented by 2 for each release. You can set a different port number if you like. We explain how to set port numbers in a later section.
::: moniker-end

## The Remote Debugger Port on 32-bit Operating Systems

::: moniker range=">=vs-2022"
TCP 4026 (in Visual Studio 2022 and later versions) is the main port, and is required for all scenarios excluding Azure App Service. You can configure this port from either the command line or the remote debugger window.
::: moniker-end
::: moniker range="vs-2019"
TCP 4024 (in Visual Studio 2019) is the main port, and is required for all scenarios. You can configure this port from either the command line or the remote debugger window.
::: moniker-end

In the remote debugger window, click **Tools > Options**, and set the TCP/IP port number.

On the command line, start the remote debugger with the **/port** switch: **msvsmon /port \<port number>**.

You can find all the remote debugger command line switches in the remote debugging help (press **F1** or click **Help > Usage** in the remote debugger window).

## The Remote Debugger Port on 64-bit Operating Systems

::: moniker range=">=vs-2022"
When the 64-bit version of the remote debugger is started, it uses the main port (4026) by default.  If you debug a 32-bit process, the 64-bit version of the remote debugger starts a 32-bit version of the remote debugger on port 4025 in most cases. If you run the 32-bit remote debugger, it uses 4026, and 4025 isn't used. The exception to this if Remote Tools for Visual Studio 2022 version 17.2 or newer is installed, and the Remote Debugger Configuration Wizard is used to start the remote debugger as a service, then the default 32-bit debugging port is 4040 instead of 4025.
::: moniker-end
::: moniker range="vs-2019"
When the 64-bit version of the remote debugger is started, it uses the main port (4024) by default.  If you debug a 32-bit process, the 64-bit version of the remote debugger starts a 32-bit version of the remote debugger on port 4025 (the main port number incremented by 1). If you run the 32-bit remote debugger, it uses 4024, and 4025 isn't used. 
::: moniker-end

This port is configurable from the command line: **Msvsmon /wow64port \<port number>**.

## Remote Debugger Ports on Microsoft Azure App Service

Remote debugger ports are configurable. Currently, Azure App Service doesn't use the default ports associated with your version of Visual Studio. Azure App Service uses port 4024 for the remote debugger.

## The Discovery Port

UDP 3702 is used for finding running instances of the remote debugger on the network (for example, the **Find** dialog in the **Attach to Process** dialog). It's used only for discovering a machine running the remote debugger, so it's optional if you have some other way of knowing the machine name or IP address of the target computer. This port is a standard port for discovery, so it can't be configured.

The discovery port must be opened as an outbound port (outbound rule).

If you do not want to enable discovery, you can start msvsmon from the command line with discovery disabled:  **Msvsmon /nodiscovery**.

## See also

- [Remote Debugging](../debugger/remote-debugging.md)
