---
description: "This interface represents a debug port on a machine."
title: IDebugPort2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPort2
helpviewer_keywords:
- IDebugPort2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPort2

This interface represents a debug port on a machine.

## Syntax

```
IDebugPort2 : IUnknown
```

## Notes for Implementers
 A custom port supplier implements this interface to represent a debug port on a machine.

 If the port supports sending port events, it must also implement the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer> interface to support an <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint> interface that in turn provides the [IDebugPortEvents2](../../../extensibility/debugger/reference/idebugportevents2.md) interface.

## Notes for Callers
 Calls to [GetPort](../../../extensibility/debugger/reference/idebugportsupplier2-getport.md) or [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md) return this interface, representing the requested port.

## Methods in Vtable Order
 The following table shows the methods of `IDebugPort2`.

|Method|Description|
|------------|-----------------|
|[GetPortName](../../../extensibility/debugger/reference/idebugport2-getportname.md)|Returns the port name.|
|[GetPortId](../../../extensibility/debugger/reference/idebugport2-getportid.md)|Returns the port identifier.|
|[GetPortRequest](../../../extensibility/debugger/reference/idebugport2-getportrequest.md)|Returns the request used to create a port (if available).|
|[GetPortSupplier](../../../extensibility/debugger/reference/idebugport2-getportsupplier.md)|Returns the port supplier for this port.|
|[GetProcess](../../../extensibility/debugger/reference/idebugport2-getprocess.md)|Returns an interface to the process given the process's identifier.|
|[EnumProcesses](../../../extensibility/debugger/reference/idebugport2-enumprocesses.md)|Enumerates all the processes running on a port.|

## Remarks
 The local port provides access to all the processes and programs running on the local machine. Other ports might represent a serial cable connection to a Windows CE-based device, or a network connection to a non-DCOM computer. The `IDebugPort2` interface is used to find the name and identifier of a port, and enumerate all processes running on the port. Facilities for launching and terminating processes on the port are implemented in the `IDebugPortEx2` interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
