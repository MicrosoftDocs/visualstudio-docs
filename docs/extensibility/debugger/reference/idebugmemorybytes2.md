---
description: "This interface represents bytes of memory."
title: IDebugMemoryBytes2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMemoryBytes2
helpviewer_keywords:
- IDebugMemoryBytes2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugMemoryBytes2

This interface represents bytes of memory.

## Syntax

```
IDebugMemoryBytes2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent bytes in memory.

## Notes for Callers
- [GetMemoryBytes](../../../extensibility/debugger/reference/idebugprogram2-getmemorybytes.md) returns this interface to provide access to system memory. [GetMemoryBytes](../../../extensibility/debugger/reference/idebugproperty2-getmemorybytes.md) and [GetMemoryBytes](../../../extensibility/debugger/reference/idebugreference2-getmemorybytes.md) return this interface to provide access to an object's bytes.

## Methods in Vtable Order
 The following table shows the methods of `IDebugMemoryBytes2`.

|Method|Description|
|------------|-----------------|
|[ReadAt](../../../extensibility/debugger/reference/idebugmemorybytes2-readat.md)|Reads a sequence of bytes, starting at a given location.|
|[WriteAt](../../../extensibility/debugger/reference/idebugmemorybytes2-writeat.md)|Writes `dwCount` bytes, starting at `pStartContext`.|
|[GetSize](../../../extensibility/debugger/reference/idebugmemorybytes2-getsize.md)|Gets the size, in bytes, of the memory represented by this interface.|

## Remarks
 For properties, an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) interface representing an array provides an `IDebugMemoryBytes2` interface to access the values in that array.

 Visual Studio's **Memory View** calls [GetMemoryBytes](../../../extensibility/debugger/reference/idebugprogram2-getmemorybytes.md) to retrieve an `IDebugMemoryBytes2` interface for accessing system memory. The address to be accessed is obtained by parsing the expression entered as an address into the Memory View and then evaluating the parsed expression using [EvaluateSync](../../../extensibility/debugger/reference/idebugexpression2-evaluatesync.md) to get an `IDebugProperty2` interface. A call to [GetMemoryContext](../../../extensibility/debugger/reference/idebugproperty2-getmemorycontext.md) returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) that describes the memory address. This memory context is then passed to [ReadAt](../../../extensibility/debugger/reference/idebugmemorybytes2-readat.md) and [WriteAt](../../../extensibility/debugger/reference/idebugmemorybytes2-writeat.md).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetMemoryBytes](../../../extensibility/debugger/reference/idebugprogram2-getmemorybytes.md)
- [GetMemoryBytes](../../../extensibility/debugger/reference/idebugproperty2-getmemorybytes.md)
- [GetMemoryBytes](../../../extensibility/debugger/reference/idebugreference2-getmemorybytes.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
