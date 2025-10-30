---
title: Modules
description: This article describes the definition and role of a module in the debugger architecture in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- modules
- debugging [Debugging SDK], modules
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Modules

In terms of the debugger architecture, a *module*:

- Is a physical container of code, such as an executable file or a DLL.

- Can reload its symbols and describe itself. Module descriptions are displayed in the Modules window of the IDE.

- Is represented by an [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md) interface, created by a debug engine to describe the module.

## See also
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md)
