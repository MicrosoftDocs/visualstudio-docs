---
title: Process Debug Manager
description: Learn about the process debug manager, which is a component of Visual Studio that makes programs available to the session debug manager and the debug engines.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- machine debug manager
- debugging [Debugging SDK], Machine Debug Manager
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Process debug manager

The process debug manager (PDM) is a component of Visual Studio that manages programs and processes, making them available to the session debug manager and the debug engines.

 The PDM manages all the processes that can be debugged. To be debugged, a program must be registered with the PDM. This registration is done at the time the program is launched, either by a port or a debug engine.

## See also
- [Processes](../../extensibility/debugger/processes.md)
- [Debug engine](../../extensibility/debugger/debug-engine.md)
- [Ports](../../extensibility/debugger/ports.md)
- [Programs](../../extensibility/debugger/programs.md)
- [Debugger components](../../extensibility/debugger/debugger-components.md)
