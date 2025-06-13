---
description: "This interface represents a stream of instructions."
title: IDebugDisassemblyStream2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDisassemblyStream2
helpviewer_keywords:
- IDebugDisassemblyStream2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDisassemblyStream2

This interface represents a stream of instructions.

## Syntax

```
IDebugDisassemblyStream2 : IUnknown
```

## Notes for Implementers
 A debug engine implements this interface to support disassembly of a program's code.

## Notes for Callers
 A call to the [GetDisassemblyStream](../../../extensibility/debugger/reference/idebugprogram2-getdisassemblystream.md) method returns this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugDisassemblyStream2`.

|Method|Description|
|------------|-----------------|
|[Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md)|Reads instructions starting from the current position in the disassembly stream.|
|[Seek](../../../extensibility/debugger/reference/idebugdisassemblystream2-seek.md)|Moves the read pointer in the disassembly stream a given number of instructions relative to a specified position.|
|[GetCodeLocationId](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodelocationid.md)|Returns a code location identifier for a particular code context.|
|[GetCodeContext](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcodecontext.md)|Returns a code context object corresponding to a specified code location identifier.|
|[GetCurrentLocation](../../../extensibility/debugger/reference/idebugdisassemblystream2-getcurrentlocation.md)|Returns a code location identifier that represents the current code location.|
|[GetDocument](../../../extensibility/debugger/reference/idebugdisassemblystream2-getdocument.md)|Gets the source document associated with this disassembly stream.|
|[GetScope](../../../extensibility/debugger/reference/idebugdisassemblystream2-getscope.md)|Gets the scope of this disassembly stream.|
|[GetSize](../../../extensibility/debugger/reference/idebugdisassemblystream2-getsize.md)|Gets the size of this disassembly stream.|

## Remarks
 The disassembly stream can be created to represent the entire address space or just a function or module within the space. Each instruction is represented by a [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structure returned by a call to the [Read](../../../extensibility/debugger/reference/idebugdisassemblystream2-read.md) method.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetDisassemblyStream](../../../extensibility/debugger/reference/idebugprogram2-getdisassemblystream.md)
- [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md)
