---
title: COM Server and Container Debugging
description: Learn about COM server and container debugging. Debug a COM server and container in the same solution, a server app without container information, or an SDI app.
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "ActiveX control container debugging [Visual Studio]"
  - "debugging ActiveX controls"
  - "COM servers, debugging"
  - "ActiveX controls, debugging"
  - "COM [Visual Studio], debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# COM Server and Container Debugging

COM applications perform a number of tasks outside of the programmer's direct control. Communication between DLLs, usage counts on objects, and Clipboard operations are just a few of the areas where you might encounter unexpected behavior. When this happens, your first step is to track down the source of the problem.

The Visual Studio debugger supports stepping across and into containers and servers. This includes the ability to step across remote procedure calls (RPC).

## <a name="BKMK_COMServerandContainerintheSameSolution"></a> Debugging a COM Server and Container in the Same Solution

You can debug a COM server and container using two projects within the same solution. Set appropriate breakpoints in each project and debug. When the container makes a call into the server that hits a breakpoint, the container will wait until the server code returns (that is, until you finish debugging it).

Debugging a COM container is similar to debugging a standard program. One difference is when you debug an event that generates a callback (such as dragging data over the container application). In this case, you must set a breakpoint in the callback function.

## <a name="BKMK_ServerApplicationWithoutContainerInformation"></a> Debugging a Server Application Without Container Information

If you do not have or do not want to use debugging information for your container application, starting to debug the server application is a three-step process:

1. Start debugging the server as a normal application.

2. Set breakpoints as desired.

3. Start the container application.

## <a name="BKMK_DebuggingaServerandDomainIsolationSDIApplication"></a> Debugging a Server and Domain Isolation (SDI) Application

If you are debugging a server and domain isolation (SDI) server application, you must specify `/Embedding` or `/Automation` in the **Command line arguments** property in the *Project* Property Pages dialog box for C/C++, C#, or Visual Basic projects.

With these command line arguments, the debugger can launch the server application as though it were launched from a container. Starting the container from Program Manager or File Manager will then cause the container to use the instance of the server started in the debugger.

To access the *Project* Property Pages dialog box, right-click your project in Solution Explorer, and then choose Properties from the shortcut menu. To find the Command line arguments property, expand the Configuration Properties category and click the Debugging page.

## Related content

- [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)
