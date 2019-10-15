---
title: "Servers (Visual Studio SDK) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "servers, debugging"
  - "debugging [Debugging SDK], servers"
ms.assetid: 62236d64-7956-448c-9ac3-5528f3edac1d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Servers (Visual Studio SDK)
In the debugger architecture, a *server*:

- Is a container of ports and port suppliers and communicates ports and port suppliers to the session debug manager (SDM) and debug engines.

- Can identify itself by name, and enumerate its ports and port suppliers.

- Is represented by an [IDebugCoreServer2](../../extensibility/debugger/reference/idebugcoreserver2.md) interface, which is only implemented by Visual Studio (one instance of a server for each instance of Visual Studio running).

## See also
- [Ports](../../extensibility/debugger/ports.md)
- [Port suppliers](../../extensibility/debugger/port-suppliers.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [IDebugCoreServer2](../../extensibility/debugger/reference/idebugcoreserver2.md)