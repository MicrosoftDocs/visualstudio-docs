---
description: "This interface gives access to information about the server the process is running in."
title: IDebugCoreServer3
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3
helpviewer_keywords:
- IDebugCoreServer3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCoreServer3

This interface gives access to information about the server the process is running in.

## Syntax

```
IDebugCoreServer3 : IDebugCoreServer2
```

## Notes for Implementers
 Visual Studio implements this interface.

## Notes for Callers
 Use [QueryInterface](/cpp/atl/queryinterface) to obtain this interface from an [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md) interface. A call to [GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md) can also return this interface. This interface is used most often by a custom port supplier to launch programs on a server (either local or remote).

## Methods in Vtable Order
 In addition to the methods on the [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md) interface, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetServerName](../../../extensibility/debugger/reference/idebugcoreserver3-getservername.md)|Retrieves the name of the server.|
|[GetServerFriendlyName](../../../extensibility/debugger/reference/idebugcoreserver3-getserverfriendlyname.md)|Retrieves a friendly version of the server name|
|[EnableAutoAttach](../../../extensibility/debugger/reference/idebugcoreserver3-enableautoattach.md)|Tells specific debug engines to automatically attach to processes when those processes start.|
|[DiagnoseWebDebuggingError](../../../extensibility/debugger/reference/idebugcoreserver3-diagnosewebdebuggingerror.md)|Retrieves a specific error code when automatic attach fails.|
|[CreateInstanceInServer](../../../extensibility/debugger/reference/idebugcoreserver3-createinstanceinserver.md)|Creates an instance of a debug engine on the server.|
|[QueryIsLocal](../../../extensibility/debugger/reference/idebugcoreserver3-queryislocal.md)|Retrieves a flag indicating whether the server is on the same machine as the caller.|
|[GetConnectionProtocol](../../../extensibility/debugger/reference/idebugcoreserver3-getconnectionprotocol.md)|Retrieves a value indicating the protocol being used to communicate with the server.|
|[DisableAutoAttach](../../../extensibility/debugger/reference/idebugcoreserver3-disableautoattach.md)|Disables all auto-attach settings for all debug engines this server knows about.|

## Remarks
 A custom port supplier receives the [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md) interface on a call to [Event](../../../extensibility/debugger/reference/idebugportevents2-event.md). The `IDebugCoreServer3` interface can be obtained from that interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md)
