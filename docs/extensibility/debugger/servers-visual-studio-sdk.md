---
title: Servers (Visual Studio SDK)
description: This article describes the definition and role of a server in the debugger architecture in Visual Studio.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- servers, debugging
- debugging [Debugging SDK], servers
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
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
