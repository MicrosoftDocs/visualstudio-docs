---
title: "Process Debug Manager | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "machine debug manager"
  - "debugging [Debugging SDK], Machine Debug Manager"
ms.assetid: d0861e0c-b819-490c-9604-5e6d08ac291a
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
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