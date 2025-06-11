---
description: "This interface lets the session debug manager (SDM) attach to a program and get the program node associated with a program."
title: IDebugProgramEx2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramEx2
helpviewer_keywords:
- IDebugProgramEx2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramEx2

This interface lets the session debug manager (SDM) attach to a program and get the program node associated with a program.

## Syntax

```
IDebugProgramEx2 : IUnknown
```

## Notes for Implementers
 A custom port supplier implements this interface on the same object as the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface in order to let the SDM attach to a program while at the same time allowing the port supplier to track all sessions attached to the program. The custom port supplier can implement this interface if it chooses.

## Notes for Callers
 The SDM calls [QueryInterface](/cpp/atl/queryinterface) on an `IDebugProgram2` interface to obtain this interface to track sessions that have attached to programs.

## Methods in Vtable Order
 The following table shows the methods of `IDebugProgramEx2`.

|Method|Description|
|------------|-----------------|
|[Attach](../../../extensibility/debugger/reference/idebugprogramex2-attach.md)|Attaches a program to a session.|
|[GetProgramNode](../../../extensibility/debugger/reference/idebugprogramex2-getprogramnode.md)|Gets the program node associated with a program.|

## Remarks
 This interface is private between the SDM and the program.

## Requirements
 Header: Portpriv.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
