---
title: Modules | Microsoft Docs
description: This article describes the definition and role of a module in the debugger architecture in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- modules
- debugging [Debugging SDK], modules
ms.assetid: c4cf2809-dbdb-4e75-9273-b3d3d77b67d0
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Modules
In terms of the debugger architecture, a *module*:

- Is a physical container of code, such as an executable file or a DLL.

- Can reload its symbols and describe itself. Module descriptions are displayed in the Modules window of the IDE.

- Is represented by an [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md) interface, created by a debug engine to describe the module.

## See also
- [Debugger concepts](../../extensibility/debugger/debugger-concepts.md)
- [IDebugModule2](../../extensibility/debugger/reference/idebugmodule2.md)
