---
description: "This interface provides host (process) information about a program."
title: IDebugProgramHost2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramHost2
helpviewer_keywords:
- IDebugProgramHost2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramHost2

This interface provides host (process) information about a program.

## Syntax

```
IDebugProgramHost2 : IUnknown
```

## Notes for Implementers
 The debug engine implements this interface on the same object as the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface to provide information about the hosting process. This is an optional interface.

## Notes for Callers
 Call [QueryInterface](/cpp/atl/queryinterface) on an `IDebugProgram2` interface to obtain this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugProgramHost2`.

|Method|Description|
|------------|-----------------|
|[GetHostName](../../../extensibility/debugger/reference/idebugprogramhost2-gethostname.md)|Gets the title, friendly name, or file name of the hosting process of this program.|
|[GetHostId](../../../extensibility/debugger/reference/idebugprogramhost2-gethostid.md)|Gets the process identifier of the hosting process of this program.|
|[GetHostMachineName](../../../extensibility/debugger/reference/idebugprogramhost2-gethostmachinename.md)|Gets the name of the machine the hosting process of this program is running on.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
