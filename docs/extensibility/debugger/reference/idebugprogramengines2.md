---
description: "This interface is used by program nodes to specify all the possible debug engines (DE) that can debug this program."
title: IDebugProgramEngines2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramEngines2
helpviewer_keywords:
- IDebugProgramEngines2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramEngines2

This interface is used by program nodes to specify all the possible debug engines (DE) that can debug this program.

## Syntax

```
IDebugProgramEngines2 : IUnknown
```

## Notes for Implementers
 A DE or a custom port supplier implements this interface on the same object that implements [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) to support establishing a specific DE to use for a particular program.

## Notes for Callers
 Call [QueryInterface](/cpp/atl/queryinterface) on an `IDebugProgramNode2` interface to obtain this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugProgramEngines2`.

|Method|Description|
|------------|-----------------|
|[EnumPossibleEngines](../../../extensibility/debugger/reference/idebugprogramengines2-enumpossibleengines.md)|Indicates all the possible DEs that can debug this program.|
|[SetEngine](../../../extensibility/debugger/reference/idebugprogramengines2-setengine.md)|Selects the DE to use for debugging this program.|

## Remarks
 Once a DE is chosen by the user, that choice is registered with the program node by calling [SetEngine](../../../extensibility/debugger/reference/idebugprogramengines2-setengine.md). The selected engine becomes the engine returned by [GetEngineInfo](../../../extensibility/debugger/reference/idebugprogramnode2-getengineinfo.md).

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [GetEngineInfo](../../../extensibility/debugger/reference/idebugprogramnode2-getengineinfo.md)
