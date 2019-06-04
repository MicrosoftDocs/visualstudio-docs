---
title: "Debug Package | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging [Debugging SDK], packages"
ms.assetid: 99947fd4-fb87-4c69-b26c-65634e17d285
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Debug package
The debug package runs in the Visual Studio shell and handles all of the UI. It consumes the Visual Studio debugging interfaces and communicates with the session debug manager (SDM).

 Break events sent through the SDM switch the debugger from run mode to break mode and change the focus to the program where the break occurred. The debug package tracks the stack frame and thread from the information sent to it by the events.

 The debug package has no language or run-time environment dependencies. It is not necessary to implement or modify the debug package.

 The debug package is implemented by *vsdebug.dll*.

## See also
- [Session debug manager](../../extensibility/debugger/session-debug-manager.md)
- [Stack frames](../../extensibility/debugger/stack-frames.md)
- [Threads](../../extensibility/debugger/threads.md)
- [Debugger components](../../extensibility/debugger/debugger-components.md)