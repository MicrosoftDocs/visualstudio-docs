---
description: "This interface provides access to the ID of the process that owns the object whose address is represented by this interface."
title: IDebugAddress2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAddress2
helpviewer_keywords:
- IDebugAddress2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugAddress2

This interface provides access to the ID of the process that owns the object whose address is represented by this interface.

## Syntax

```
IDebugAddress2 : IDebugAddress
```

## Notes for Implementers
 A symbol provider implements this interface on the same object that implements the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface. This interface provides access to the ID of the process that owns the object that is related to this address.

## Notes for Callers
 Use [QueryInterface](/cpp/atl/queryinterface) to obtain this interface from the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

## Methods in vtable Order
 In addition to the methods inherited from the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface, this interface implements the following method:

|Method|Description|
|------------|-----------------|
|[GetProcessID](../../../extensibility/debugger/reference/idebugaddress2-getprocessid.md)|Retrieves the ID of the process that owns the object represented by this interface.|

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
