---
title: "IDebugProviderProgramNode2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProviderProgramNode2"
helpviewer_keywords:
  - "IDebugProviderProgramNode2"
ms.assetid: f0bca1cc-afbe-44cf-b5aa-d078aa685d24
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugProviderProgramNode2
This interface marshals program-related interfaces across process boundaries.

## Syntax

```
IDebugProviderProgramNode2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface on the same object that implements [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) to support marshaling interfaces across process boundaries.

## Notes for Callers
 Call [QueryInterface](/cpp/atl/queryinterface) on an `IDebugProgramNode2` interface to obtain this interface. If this interface cannot be obtained, the DE does not support marshaling of interfaces.

## Methods in Vtable order
 This interface implements the following method:

|Method|Description|
|------------|-----------------|
|[UnmarshalDebuggeeInterface](../../../extensibility/debugger/reference/idebugproviderprogramnode2-unmarshaldebuggeeinterface.md)|Gets a specified interface across process boundaries.|

## Remarks
 This interface is implemented when the DE runs in a separate process space from the program being debugged: for example, when the DE is running in the Visual Studio process space instead of the process space of the program being debugged.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)