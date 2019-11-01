---
title: "Code Context | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging [Debugging SDK], contexts"
ms.assetid: 65e4d37a-086b-426e-9394-a3534967fd59
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Code context
In [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugging, a **code context**:

- Provides an abstraction of a position in code as known to the debug engine (DE). For most run-time architectures today, a code context can be thought of as an address in a program's instruction stream. For nontraditional languages, where code may not be represented by instructions, a code context may be represented by some other means.

- Describes the current position in the execution stream of the program you're debugging.

- Exists only when a program has stopped at a breakpoint.

- Has an associated document context.

- Is implemented by an [IDebugCodeContext2](../../extensibility/debugger/reference/idebugcodecontext2.md) interface.

## See also
- [Document context](../../extensibility/debugger/document-context.md)
- [Debugger contexts](../../extensibility/debugger/debugger-contexts.md)