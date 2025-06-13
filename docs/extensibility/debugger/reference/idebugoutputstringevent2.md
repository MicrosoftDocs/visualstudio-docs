---
description: "This interface is sent by the debug engine (DE) to the session debug manager (SDM) to output a string."
title: IDebugOutputStringEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugOutputStringEvent2
helpviewer_keywords:
- IDebugOutputStringEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugOutputStringEvent2

This interface is sent by the debug engine (DE) to the session debug manager (SDM) to output a string.

## Syntax

```
IDebugOutputStringEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to send a string to the **Output** window of the IDE. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

## Notes for Callers
 The DE creates and sends this event object to send a string to the **Output** window. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the method of `IDebugOutputStringEvent2`.

|Method|Description|
|------------|-----------------|
|[GetString](../../../extensibility/debugger/reference/idebugoutputstringevent2-getstring.md)|Gets the displayable message.|

## Remarks
 For example, in unmanaged code, the string to be output can originate when the program being debugged sends a string to the Win32 `OutputDebugString` function. This string is intercepted by the DE and sent on to the SDM as the `IDebugOutputStringEvent2` event.

 Use [IDebugMessageEvent2](../../../extensibility/debugger/reference/idebugmessageevent2.md) to send a message that requires a user response.

 Use [IDebugErrorEvent2](../../../extensibility/debugger/reference/idebugerrorevent2.md) to send an error message that does not require a response.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugMessageEvent2](../../../extensibility/debugger/reference/idebugmessageevent2.md)
- [IDebugErrorEvent2](../../../extensibility/debugger/reference/idebugerrorevent2.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
