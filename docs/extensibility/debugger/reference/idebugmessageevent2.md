---
description: "This interface is used by the debug engine (DE) to send a message to Visual Studio that requires a response from the user."
title: IDebugMessageEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMessageEvent2
helpviewer_keywords:
- IDebugMessageEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugMessageEvent2

This interface is used by the debug engine (DE) to send a message to Visual Studio that requires a response from the user.

## Syntax

```
IDebugMessageEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface to send a message to Visual Studio that requires a user response. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface.

 The implementation of this interface must communicate Visual Studio's call of [SetResponse](../../../extensibility/debugger/reference/idebugmessageevent2-setresponse.md) to the DE. For example, this can be done with a message posted to the DE's message handling thread, or the object implementing this interface could hold a reference to the DE and call back to the DE with the response passed into `IDebugMessageEvent2::SetResponse`.

## Notes for Callers
 The DE creates and sends this event object to display a message to the user that requires a response. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.

## Methods in Vtable Order
 The following table shows the methods of `IDebugMessageEvent2`.

|Method|Description|
|------------|-----------------|
|[GetMessage](../../../extensibility/debugger/reference/idebugmessageevent2-getmessage.md)|Gets the message to be displayed.|
|[SetResponse](../../../extensibility/debugger/reference/idebugmessageevent2-setresponse.md)|Sets the response, if any, from the message box.|

## Remarks
 The DE will use this interface if it requires a specific response from the user for a particular message. For example, if the DE gets an "Access Denied" message after an attempt to remotely attach to a program, the DE sends this particular message to Visual Studio in an `IDebugMessageEvent2` event with the message box style `MB_RETRYCANCEL`. This allows the user to retry or cancel the attach operation.

 The DE specifies how this message is to be handled by following the conventions of the Win32 function `MessageBox` (see [AfxMessageBox](/cpp/mfc/reference/cstring-formatting-and-message-box-display#afxmessagebox) for details).

 Use the [IDebugErrorEvent2](../../../extensibility/debugger/reference/idebugerrorevent2.md) interface to send messages to Visual Studio that do not require a response from the user.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugErrorEvent2](../../../extensibility/debugger/reference/idebugerrorevent2.md)
