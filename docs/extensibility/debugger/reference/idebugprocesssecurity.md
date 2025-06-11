---
description: "IDebugProcessSecurity is implemented by a port supplier to warn the user that attaching to the process is unsafe."
title: IDebugProcessSecurity
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProcessSecurity interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProcessSecurity

`IDebugProcessSecurity` is implemented by a port supplier to warn the user that attaching to the process is unsafe.

## Syntax

```
IDebugProcessSecurity : IUnknown
```

## Methods in Vtable Order
 The following table shows the methods of `IDebugProcessSecurity`.

|Method|Description|
|------------|-----------------|
|[GetUserName](../../../extensibility/debugger/reference/idebugprocesssecurity-getusername.md)|Gets the user name from the port supplier.|
|[QueryCanSafelyAttach](../../../extensibility/debugger/reference/idebugprocesssecurity-querycansafelyattach.md)|Warns a user that attaching to the debugging process is unsafe.|

## Remarks
 Implement this interface to show a warning and allow the user to cancel if the process to which you are attaching can be considered unsafe.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Ports](../../../extensibility/debugger/ports.md)
- [Port Suppliers](../../../extensibility/debugger/port-suppliers.md)
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
