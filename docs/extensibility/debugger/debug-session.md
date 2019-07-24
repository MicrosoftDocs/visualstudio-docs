---
title: "Debug Session | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging [Debugging SDK], sessions"
ms.assetid: 18d82199-b2d4-47a9-924f-ab64faf60ca1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Debug session
In terms of the debugger architecture, a *session*:

- Is the set of all processes, related or unrelated, that have been launched or attached to from a single instance of the IDE.

- Is implemented by a session debug manager (SDM). For more information, see [Session Debug Manager](../../extensibility/debugger/session-debug-manager.md).

## See also
- [Session debug manager](../../extensibility/debugger/session-debug-manager.md)
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)