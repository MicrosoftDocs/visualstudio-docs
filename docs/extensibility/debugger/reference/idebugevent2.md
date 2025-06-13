---
description: "This interface is used to communicate both critical debug information, such as stopping at a breakpoint, and non-critical information, such as a debugging message."
title: IDebugEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEvent2
helpviewer_keywords:
- IDebugEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugEvent2

This interface is used to communicate both critical debug information, such as stopping at a breakpoint, and non-critical information, such as a debugging message.

## Syntax

```
IDebugEvent2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) and custom port supplier implement this interface on the same object as all other event interfaces.

## Notes for Callers
 Using the interface ID (IID) argument given to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) or [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md), the session debug manager (SDM) calls [QueryInterface](/cpp/atl/queryinterface) on the `IDebugEvent2` interface to obtain the appropriate event interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugEvent2`.

|Method|Description|
|------------|-----------------|
|[GetAttributes](../../../extensibility/debugger/reference/idebugevent2-getattributes.md)|Gets the attributes for this debug event.|

## Remarks
 The more specific event interfaces, such as [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md), do not derive from the IDebugEvent2 interface but are instead implemented as a separate interface on the same object as `IDebugEvent2`.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md)
- [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
