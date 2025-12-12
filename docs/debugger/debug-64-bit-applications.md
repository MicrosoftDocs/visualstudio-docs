---
title: A 64-bit debugger operation is taking longer than expected
description: Learn tips for troubleshooting unexpected debugging delays.
ms.date: 05/30/2025
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
---

# Error: A 64-bit debugger operation is taking longer than expected

You might see one of the following errors:

- "A 64-bit debugging operation is taking longer than expected." or
- "A debugger operation is taking longer than expected." 

In these scenarios, Visual Studio sent a request to msvsmon.exe, and it's taken a long time for the result of that request to come back.

The most common causes for this error are:

- You have networking security software installed on your computer that has caused the networking stack to be unreliable, and it's dropped packets going over `localhost`. Try disabling all network security software and see whether this resolves it. If so, report to your network security software vendor that the software is interfering with `localhost` traffic. This shouldn't occur with Visual Studio 2019 and later, because those versions don't use sockets for this communication.

- You're running into an issue where Visual Studio becomes unresponsive, or other performance problem. If the problem happens regularly, you can [collect dumps](../debugger/using-dump-files.md) of Visual Studio (devenv.exe) and the worker process (msvsmon.exe) and send them to Microsoft. For information about reporting a problem, see [How to Report a Problem with Visual Studio](../ide/how-to-report-a-problem-with-visual-studio.md).

::: moniker range=">= vs-2022"
- If you're using a version of Visual Studio prior to Visual Studio 2022, you may be trying to debug a 64-bit application while running in the 32-bit Visual Studio process. To resolve, follow instructions to [debug a 64-bit application](/previous-versions/visualstudio/visual-studio-2017/debugger/debug-64-bit-applications?view=vs-2017&preserve-view=true).
::: moniker-end


## Related content

- [64-bit Applications](/dotnet/framework/64-bit-apps)
- [Configuring Programs for 64-Bit](/cpp/build/configuring-programs-for-64-bit-visual-cpp)
- [Visual Studio IDE 64-Bit Support](../ide/visual-studio-ide-64-bit-support.md)
- [Using Dump Files](../debugger/using-dump-files.md)
- [Remote Debugging](../debugger/remote-debugging.md)
