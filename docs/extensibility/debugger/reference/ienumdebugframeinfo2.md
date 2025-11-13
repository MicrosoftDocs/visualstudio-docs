---
description: "This interface enumerates FRAMEINFO structures."
title: IEnumDebugFrameInfo2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugFrameInfo2
helpviewer_keywords:
- IEnumDebugFrameInfo2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugFrameInfo2

This interface enumerates [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures.

## Syntax

```
IEnumDebugFrameInfo2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to provide a list of structures that describes the current call stack.

## Notes for Callers
 Visual Studio calls [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md) to obtain this interface whenever a breakpoint, exception, or halt occurs in a program being debugged.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugFrameInfo2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugframeinfo2-next.md)|Retrieves a specified number of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugframeinfo2-skip.md)|Skips a specified number of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugframeinfo2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugframeinfo2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugframeinfo2-getcount.md)|Gets the number of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures in an enumerator.|

## Remarks
 Visual Studio obtains this interface as the first step to handling a breakpoint, exception, or user-generated pause on the program being debugged. The list of [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structures represents the current call stack, with the current function call at the beginning of the list and the oldest function call at the end of the list. Each `FRAMEINFO` represents a stack frame, a context in which expressions can be evaluated and local variables looked at.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md)
- [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md)
