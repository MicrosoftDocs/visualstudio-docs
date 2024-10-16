---
title: Start the Spy++ tool to debug a solution
description: Explore the Spy++ tool in Visual Studio for debugging a solution and start the tool from the integrated development environment (IDE) or from a command prompt.
ms.date: 02/05/2024
ms.topic: how-to
helpviewer_keywords: 
  - Spy++, starting
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Start Spy++

You can start Spy++ either from Visual Studio or at a command prompt.

 When you start Spy++, if a message is displayed to ask permission to make changes to the computer, select **Yes**.

> [!NOTE]
> You can run only one instance of Spy++. If you try to start a second instance, it just causes the currently running instance to get the focus.

## Prerequisites

Spy++ requires the following components. You can select these components from the Visual Studio Installer by selecting the **Individual Components** tab, and then selecting the following components.

* Under Debugging and testing, select **C++ profiling tools**
* Under Development activities, select **C++ core features**

If you made any changes, follow the prompts to install these components.

## Start Spy++ from Visual Studio

On the **Tools** menu, select **Spy++**.

Because Spy++ runs independently, after you start it you can close Visual Studio.

> [!NOTE]
> When you log messages with Spy++, it might cause the operating system to perform more slowly.

## Start Spy++ at a command prompt

1. In a Command Prompt window, change directories to the folder that contains spyxx.exe. Typically, the path to this folder is ..\\*Visual Studio installation folder*\Common7\Tools\\.

2. Enter *spyxx.exe* or, for the 64-bit version, *spyxx_amd64.exe*.

For more information on the 32-bit and 64-bit version of Spy++, see [64-bit operating systems](introducing-spy-increment.md#64-bit-operating-systems).

## Related content

- [Using Spy++](../debugger/using-spy-increment.md)
- [Spy++ reference](../debugger/spy-increment-reference.md)
