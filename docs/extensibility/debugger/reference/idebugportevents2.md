---
description: "This interface notifies a listener (typically the session debug manager [SDM] or a debug engine) of process and program creation and destruction on a particular port."
title: IDebugPortEvents2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEvents2
helpviewer_keywords:
- IDebugPortEvents2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPortEvents2

This interface notifies a listener (typically the session debug manager [SDM] or a debug engine) of process and program creation and destruction on a particular port. This information can be used to present a real-time view of the processes and programs running on the port.

## Syntax

```
IDebugPortEvents2 : IUnknown
```

## Notes for Implementers
 Visual Studio typically implements this interface to receive notifications about program creation and destruction. A debug engine can also implement this interface to listen for such port events.

## Notes for Callers
 All [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) interfaces can be queried for an <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer> interface. Then the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer.FindConnectionPoint%2A> method for `IDebugPortEvents2` is called in the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer> interface to get an <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint> interface. Finally, the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise%2A> method in the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint> interface is called to send the events through the [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md) method.

## Methods in Vtable Order
 The following table shows the method of `IDebugPortEvents2`.

|Method|Description|
|------------|-----------------|
|[Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)|Sends events that describe the creation and destruction of processes and programs on the port.|

## Remarks
 `IDebugPortEvents2` is also used by the SDM to debug programs that run in a process that is already being debugged.

 Port events are passed to the SDM by this interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
