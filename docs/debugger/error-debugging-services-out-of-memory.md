---
title: "Error: Debugger Services Ran Out Of Memory | Microsoft Docs"
ms.date: "07/10/2019"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.debug_out_of_memory"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugger"
author: "isadorasophia"
ms.author: "isgarcia"
manager: caslan
ms.workload:
  - "multiple"
---
# Error: Debugging Services Ran Out Of Memory
The Debugging Services ran out of memory and caused debugging to be terminated.

## On Windows
- You can check the process memory graph in the **Diagnostics Tools** window to see if the target application is experiencing huge growth in memory. If so, use the **Memory Usage** tool to diagnose what is the underlying issue, see [Analyze memory usage](../profiling/memory-usage).

- If the target application does not seem to be consuming a lot of memory, use the **Task Manager** window to check out memory usage of Visual Studio (devenv.exe), the worker process (msvsmon.exe), or of VS Code (vsdbg.exe/vsdbg-ui.exe) to determine if this is a debugger problem. If the process running out of memory is devenv.exe, consider reducing the number of Visual Studio extensions running.

## See Also
- [Blog post: Analyze CPU and Memory while Debugging](https://devblogs.microsoft.com/visualstudio/analyze-cpu-memory-while-debugging/)
- [About Memory Management](/windows/win32/memory/about-memory-management)
