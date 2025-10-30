---
title: Ports
description: This article describes the definition and role of a port in the debugger architecture in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- ports
- debugging [Debugging SDK], ports
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Ports

In the debugger architecture, a *port*:

- Is a container for a set of processes running on a server. For example, a port might represent a connection to a Windows CE-based device by a serial cable or to a networked non-DCOM machine. One special port, called the local port, contains all the processes running on the local machine.

- Can identify itself by name or identifier.

- Can enumerate all processes running on the port and launch and terminate these processes.

- Is represented by an [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md) interface, which is created by passing an [IDebugPortRequest2](../../extensibility/debugger/reference/idebugportrequest2.md) argument to [AddPort](../../extensibility/debugger/reference/idebugportsupplier2-addport.md).

  Visual Studio supplies a default port that handles all Windows-based processes, both native and managed. A custom port must be set up for connections with external devices that are not Windows-based. To supply such custom ports, you must also set up a custom port supplier.

## See also
- [Servers](../../extensibility/debugger/servers-visual-studio-sdk.md)
- [Processes](../../extensibility/debugger/processes.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [IDebugPort2](../../extensibility/debugger/reference/idebugport2.md)
- [IDebugPortRequest2](../../extensibility/debugger/reference/idebugportrequest2.md)
- [AddPort](../../extensibility/debugger/reference/idebugportsupplier2-addport.md)
