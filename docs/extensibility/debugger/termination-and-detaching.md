---
title: "Termination and Detaching | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "programs, termination events"
  - "debug engines, detaching from programs"
ms.assetid: 268c1e51-6363-45d1-964c-1ab99bdfa4f9
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Termination and detaching
The following section describes normal termination.

## Discussion
 After the [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) or [IDebugEntryPointEvent2](../../extensibility/debugger/reference/idebugentrypointevent2.md) interface continues, if there are no breakpoints, exceptions, run-time errors, or infinite loops in the application to be debugged, the program being debugged runs to completion. This process is normal termination.

 You must send an [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md) to implement normal termination. Normal termination requires running the [IDebugProgramDestroyEvent2::GetExitCode](../../extensibility/debugger/reference/idebugprogramdestroyevent2-getexitcode.md) method.

## See also
- [Creating a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)