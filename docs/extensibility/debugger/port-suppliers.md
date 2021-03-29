---
title: Port Suppliers | Microsoft Docs
description: This article describes the definition and role of a port supplier in the debugger architecture in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- port suppliers
- debugging [Debugging SDK], port suppliers
ms.assetid: a8f3db96-1a13-4e93-9ef6-0861880369e0
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Port suppliers
In the debugger architecture, a *port supplier*:

- Is contained by a server and provides ports on request to that server.

- Can add and remove ports from the containing server.

- Can enumerate all the ports it has supplied to the server.

- Is represented by an [IDebugPortSupplier2](../../extensibility/debugger/reference/idebugportsupplier2.md) interface, which is registered with Visual Studio through the registry. This interface can be obtained by calling [GetPortSupplier](../../extensibility/debugger/reference/idebugcoreserver2-getportsupplier.md).

  [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] provides a default port supplier and a default port. If a custom port needs to be implemented, a custom port supplier also needs to be implemented to supply those custom ports.

## See also
- [Servers](../../extensibility/debugger/servers-visual-studio-sdk.md)
- [Ports](../../extensibility/debugger/ports.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [IDebugPortSupplier2](../../extensibility/debugger/reference/idebugportsupplier2.md)
- [GetPortSupplier](../../extensibility/debugger/reference/idebugcoreserver2-getportsupplier.md)
