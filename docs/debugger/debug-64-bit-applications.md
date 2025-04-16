---
title: Debug and troubleshoot 64-Bit applications
description: Learn how to debug a 64-bit application with Visual Studio. There are tips for troubleshooting unexpected debugging delays.
ms.date: 04/16/2025
ms.topic: how-to
dev_langs:
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords:
  - debugging [Visual Studio], 64-bit
  - 64-bit debugging
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: "<=vs-2019"
---

# Debug 64-Bit Applications

You can debug a 64-bit application that is running on the local computer or on a remote computer.

To debug a 64-bit application that is running on a remote computer, see [Remote Debugging](../debugger/remote-debugging.md).

To debug 64-bit applications locally, Visual Studio uses a 64-bit worker process (msvsmon.exe) to perform the low-level operations that cannot be done inside of the 32-bit Visual Studio process.

Mixed-mode debugging is not supported for 64-bit processes that use .NET Framework version 3.5 or earlier.

## Debug a 64-bit Application

To try debugging a 64-bit application:

1. Create a Visual Studio solution, for example a C# console application.

2. Set the configuration to 64-bit using the Configuration Manager. For more information, see [How to: Configure Projects to Target Platforms](../ide/how-to-configure-projects-to-target-platforms.md).

3. At this point the 64-bit version of the remote debugger (msvsmon.exe) starts. It runs as long as the solution with the 64-bit configuration is open.

4. Start debugging. You should have the same experience as with a 32-bit configuration. If you get errors, see the Troubleshooting section below.

## Troubleshooting 64-bit debugging

You might see an error: "A 64-bit debugging operation is taking longer than expected." or "A debugger operation is taking longer than expected." In this case, Visual Studio has sent a request to msvsmon.exe, and it has taken a long time for the result of that request to come back.

There are two main causes for this error:

- You have networking security software installed on your computer that has caused the networking stack to be unreliable, and it has dropped packets going over `localhost`. Try disabling all network security software and see whether this resolves it. If so, report to your network security software vendor that the software is interfering with `localhost` traffic. This should not occur with Visual Studio 2019 and later, because those versions don't use sockets for this communication.

- You are running into an issue where Visual Studio becomes unresponsive, or other performance problem. If the problem happens regularly, you can collect dumps of Visual Studio (devenv.exe) and the worker process (msvsmon.exe) and send them to Microsoft. For information about reporting a problem, see [How to Report a Problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio.md).

## Related content

- [64-bit Applications](/dotnet/framework/64-bit-apps)
- [Configuring Programs for 64-Bit](/cpp/build/configuring-programs-for-64-bit-visual-cpp)
- [Visual Studio IDE 64-Bit Support](../ide/visual-studio-ide-64-bit-support.md)
- [Using Dump Files](../debugger/using-dump-files.md)
- [Remote Debugging](../debugger/remote-debugging.md)
