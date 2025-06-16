---
description: "This interface allows a caller to determine whether a port supplier can preserve ports (by writing them to disk) between invocations of the debugger and then get a list of those preserved ports."
title: IDebugPortSupplier3
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier3
helpviewer_keywords:
- IDebugPortSupplier3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPortSupplier3

This interface allows a caller to determine whether a port supplier can preserve ports (by writing them to disk) between invocations of the debugger and then get a list of those preserved ports.

## Syntax

```
IDebugPortSupplier3 : IDebugPortSupplier2
```

## Notes for Implementers
 A custom port supplier implements this interface to support persisting or saving port information to disk. This interface must be implemented on the same object as the [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md) interface.

## Notes for Callers
 Call [QueryInterface](/cpp/atl/queryinterface) on the `IDebugPortSupplier2` interface to obtain this interface.

## Methods in Vtable order
 In addition to the methods inherited from the [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md) interface, this interface supports the following:

|Method|Description|
|------------|-----------------|
|[CanPersistPorts](../../../extensibility/debugger/reference/idebugportsupplier3-canpersistports.md)|Returns whether the port supplier can persist ports (by writing them to disk) between invocations of the debugger.|
|[EnumPersistedPorts](../../../extensibility/debugger/reference/idebugportsupplier3-enumpersistedports.md)|Returns an object that can be used to enumerate through all ports that were written to disk by this port supplier.|

## Remarks
 If a port supplier can persist ports across invocations, it should implement this interface. Ports should be loaded when the port supplier is instantiated, and written to disk when the port supplier is destroyed.

 A debug engine typically does not interact with a port supplier and will have no use for this interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
