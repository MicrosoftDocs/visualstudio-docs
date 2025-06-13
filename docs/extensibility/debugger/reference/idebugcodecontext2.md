---
description: "This interface represents the starting position of a code instruction."
title: IDebugCodeContext2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCodeContext2
helpviewer_keywords:
- IDebugCodeContext2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCodeContext2

This interface represents the starting position of a code instruction. For most run-time architectures today, a code context can be thought of as an address in a program's execution stream.

## Syntax

```
IDebugCodeContext2 : IDebugMemoryContext2
```

## Notes for Implementers
 The debug engine implements this interface to relate the position of a code instruction to a document position.

## Notes for Callers
 Methods on many interfaces return this interface, most typically, [GetCodeContext](../../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md). It is also used extensively with the [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md) interface as well as in breakpoint resolution information.

## Methods in Vtable Order
 In addition to the methods on the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) interface, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetDocumentContext](../../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md)|Gets the document context that corresponds to the active code context.|
|[GetLanguageInfo](../../../extensibility/debugger/reference/idebugcodecontext2-getlanguageinfo.md)|Gets the language information for this code context.|

## Remarks
 The key difference between an `IDebugCodeContext2` interface and an [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) interface is that an `IDebugCodeContext2` is always instruction-aligned. This means that an `IDebugCodeContext2` is always pointing to the beginning of an instruction, whereas an `IDebugMemoryContext2` may point to any byte of memory in the run-time architecture. `IDebugCodeContext2` is incremented by instructions rather than by the basic storage size (typically byte).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [GetDisassemblyStream](../../../extensibility/debugger/reference/idebugprogram2-getdisassemblystream.md)
- [CanSetNextStatement](../../../extensibility/debugger/reference/idebugthread2-cansetnextstatement.md)
- [SetNextStatement](../../../extensibility/debugger/reference/idebugthread2-setnextstatement.md)
- [GetCodeContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getcodecontext.md)
- [GetCodeContext](../../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-next.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
