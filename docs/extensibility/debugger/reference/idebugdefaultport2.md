---
description: "This interface provides several methods for accessing a port's server and notification facilities."
title: IDebugDefaultPort2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDefaultPort2
helpviewer_keywords:
- IDebugDefaultPort2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDefaultPort2

This interface provides several methods for accessing a port's server and notification facilities.

## Syntax

```
IDebugDefaultPort2 : IDebugPort2
```

## Notes for Implementers
 Visual Studio implements this interface to represent the debug port for accessing programs. A custom port supplier can also implement this interface if it handles remote debugging.

## Notes for Callers
 An argument to methods on the [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md) interface supplies this interface. Calling [QueryInterface](/cpp/atl/queryinterface) on an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) interface can also obtain this interface.

## Methods in Vtable order
 In addition to the methods defined in [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md), this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetPortNotify](../../../extensibility/debugger/reference/idebugdefaultport2-getportnotify.md)|Gets the port notification interface from this port.|
|[GetServer](../../../extensibility/debugger/reference/idebugdefaultport2-getserver.md)|Gets the interface to the server hosting this port.|
|[QueryIsLocal](../../../extensibility/debugger/reference/idebugdefaultport2-queryislocal.md)|Determines whether this port is running on the local machine.|

## Remarks
 The name "`IDebugDefaultPort2`" is a bit of a misnomer, as it does not represent a default port. It could be called "IDebugPort3."

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)
