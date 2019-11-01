---
title: "How to: Start Spy++ | Microsoft Docs"
ms.date: "12/16/2018"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Spy++, starting"
ms.assetid: 1d36813a-dc2a-4fda-9b3d-a38928a62ced
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Start Spy++

You can start Spy++ either from Visual Studio or at a command prompt.

 When you start Spy++, if a message is displayed to ask permission to make changes to the computer, select **Yes**.

> [!NOTE]
> You can run only one instance of Spy++. If you try to start a second instance, it just causes the currently running instance to get the focus.

## Prerequisites

Spy++ requires the following components. You can select these components from the Visual Studio Installer by selecting the **Individual Components** tab, and then selecting the following components.

* Under Debugging and testing, select **C++ profiling tools**
* Under Development activities, select **Visual Studio C++ core features**

If you made any changes, follow the prompts to install these components.

## Start Spy++ from Visual Studio

On the **Tools** menu, select **Spy++**.

Because Spy++ runs independently, after you start it you can close Visual Studio.

> [!NOTE]
> When you log messages with Spy++, it may cause the operating system to perform more slowly.

## Start Spy++ at a command prompt

1. In a Command Prompt window, change directories to the folder that contains spyxx.exe. Typically, the path to this folder is ..\\*Visual Studio installation folder*\Common7\Tools\\.

2. Enter **spyxx.exe**.

## See also
- [Using Spy++](../debugger/using-spy-increment.md)
- [Spy++ Views](../debugger/spy-increment-views.md)
- [Spy++ Reference](../debugger/spy-increment-reference.md)