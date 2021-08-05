---
title: Debug Package | Microsoft Docs
description: Learn how the debug package runs in Visual Studio shell and handles UI by consuming the debugging interfaces and communicating with the session debug manager.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- debugging [Debugging SDK], packages
ms.assetid: 99947fd4-fb87-4c69-b26c-65634e17d285
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
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
