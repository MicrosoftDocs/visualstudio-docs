---
description: "This interface represents a position in the address space of the machine running the program being debugged."
title: IDebugMemoryContext2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMemoryContext2
helpviewer_keywords:
- IDebugMemoryContext2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugMemoryContext2

This interface represents a position in the address space of the machine running the program being debugged.

## Syntax

```
IDebugMemoryContext2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent an address in memory.

## Notes for Callers
 A call to [GetMemoryContext](../../../extensibility/debugger/reference/idebugproperty2-getmemorycontext.md) or [GetMemoryContext](../../../extensibility/debugger/reference/idebugreference2-getmemorycontext.md) returns this interface. Also, calls to [Add](../../../extensibility/debugger/reference/idebugmemorycontext2-add.md) and [Subtract](../../../extensibility/debugger/reference/idebugmemorycontext2-subtract.md) return new copies of this interface after the appropriate arithmetic operation has been applied.

## Methods in Vtable Order
 The following table shows the methods of `IDebugMemoryContext2`.

|Method|Description|
|------------|-----------------|
|[GetName](../../../extensibility/debugger/reference/idebugmemorycontext2-getname.md)|Gets the user-displayable name for this context.|
|[GetInfo](../../../extensibility/debugger/reference/idebugmemorycontext2-getinfo.md)|Gets information that describes this context.|
|[Add](../../../extensibility/debugger/reference/idebugmemorycontext2-add.md)|Adds a specified value to the current context's address to create a new context.|
|[Subtract](../../../extensibility/debugger/reference/idebugmemorycontext2-subtract.md)|Subtracts a specified value from the current context's address to create a new context.|
|[Compare](../../../extensibility/debugger/reference/idebugmemorycontext2-compare.md)|Compares two contexts in the manner indicated by compare flags.|

## Remarks
 Visual Studio's **Memory** window calls [GetMemoryContext](../../../extensibility/debugger/reference/idebugproperty2-getmemorycontext.md) to obtain the `IDebugMemoryContext2` interface that contains the evaluated expression used for the memory address. This context is then passed to [ReadAt](../../../extensibility/debugger/reference/idebugmemorybytes2-readat.md) and [WriteAt](../../../extensibility/debugger/reference/idebugmemorybytes2-writeat.md) to specify the address to read or write.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetMemoryContext](../../../extensibility/debugger/reference/idebugproperty2-getmemorycontext.md)
- [GetMemoryContext](../../../extensibility/debugger/reference/idebugreference2-getmemorycontext.md)
- [ReadAt](../../../extensibility/debugger/reference/idebugmemorybytes2-readat.md)
- [WriteAt](../../../extensibility/debugger/reference/idebugmemorybytes2-writeat.md)
