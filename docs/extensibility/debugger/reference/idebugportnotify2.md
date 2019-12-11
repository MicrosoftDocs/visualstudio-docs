---
title: "IDebugPortNotify2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPortNotify2"
helpviewer_keywords:
  - "IDebugPortNotify2 interface"
ms.assetid: 43278b79-bf16-4c08-bcf1-6f7f7a17feab
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugPortNotify2
This interface registers or unregisters a program that can be debugged with the port it is running on.

## Syntax

```
IDebugPortNotify2 : IUnknown
```

## Notes for Implementers
 A custom port supplier implements this interface to support adding and removing programs from the port. It is typically implemented on the same object that implements the [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) interface.

## Notes for Callers
 A call to [QueryInterface](/cpp/atl/queryinterface) on the `IDebugPort2` interface returns this interface. Also, a call to [GetPortNotify](../../../extensibility/debugger/reference/idebugdefaultport2-getportnotify.md) returns this interface. A debug engine can see this interface as a parameter to [WatchForProviderEvents](../../../extensibility/debugger/reference/idebugprogramprovider2-watchforproviderevents.md).

## Methods in Vtable Order
 The following table shows the methods of `IDebugPortNotify2`.

|Method|Description|
|------------|-----------------|
|[AddProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md)|Registers a program that can be debugged with the port it is running on.|
|[RemoveProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md)|Unregisters a program that can be debugged from the port it is running on.|

## Remarks
 Unless a debug port has a way to know when programs are loaded or unloaded, a custom port supplier must implement this interface. All programs that are loaded for debugging through a particular port are tracked using this interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)