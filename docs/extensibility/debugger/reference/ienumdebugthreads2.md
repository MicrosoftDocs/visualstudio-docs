---
description: "This interface enumerates the threads running in the current debug session."
title: IEnumDebugThreads2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugThreads2
helpviewer_keywords:
- IEnumDebugThreads2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugThreads2

This interface enumerates the threads running in the current debug session.

## Syntax

```
IEnumDebugThreads2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent a list of threads in a program.

## Notes for Callers
 Call [EnumThreads](../../../extensibility/debugger/reference/idebugprocess2-enumthreads.md) to obtain this interface representing a list of all threads in all programs running in a process. Call [EnumThreads](../../../extensibility/debugger/reference/idebugprogram2-enumthreads.md) to obtain this interface representing a list of threads running in a program.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugThreads2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugthreads2-next.md)|Retrieves a specified number of threads in the enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugthreads2-skip.md)|Skips a specified number of threads in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugthreads2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugthreads2-clone.md)|Creates an enumerator that contains the same enumeration state as the current one.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugthreads2-getcount.md)|Gets the number of threads in an enumerator.|

## Remarks
 Visual Studio typically obtains this interface to update the **Threads** window as well as to obtain the first thread of the list, in order to call [Execute](../../../extensibility/debugger/reference/idebugprocess3-execute.md), [Continue](../../../extensibility/debugger/reference/idebugprocess3-continue.md), and [Step](../../../extensibility/debugger/reference/idebugprocess3-step.md).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [EnumThreads](../../../extensibility/debugger/reference/idebugprocess2-enumthreads.md)
- [EnumThreads](../../../extensibility/debugger/reference/idebugprogram2-enumthreads.md)
- [Step](../../../extensibility/debugger/reference/idebugprocess3-step.md)
- [Continue](../../../extensibility/debugger/reference/idebugprocess3-continue.md)
- [Execute](../../../extensibility/debugger/reference/idebugprocess3-execute.md)
