---
description: "This interface describes a port."
title: IDebugPortRequest2 | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortRequest2
helpviewer_keywords:
- IDebugPortRequest2 interface
ms.assetid: 556e610d-7c4b-44a8-965a-76a9d02b601a
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# IDebugPortRequest2
This interface describes a port. This description is used to add the port to a port supplier.

## Syntax

```
IDebugPortRequest2 : IUnknown
```

## Notes for Implementers
 Visual Studio typically implements this interface in the process of getting a debug port from a port supplier.

## Notes for Callers
 This interface is passed into [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md) to create a debug port. A call to [GetPortRequest](../../../extensibility/debugger/reference/idebugport2-getportrequest.md) returns this interface, representing the request used to create the port in the first place.

## Methods in Vtable Order
 The following table shows the methods of `IDebugPortRequest2`.

|Method|Description|
|------------|-----------------|
|[GetPortName](../../../extensibility/debugger/reference/idebugportrequest2-getportname.md)|Gets the name of the port to create.|

## Remarks
 A debug engine typically does not interact with a port supplier and will have no use for this interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md)
- [GetPortRequest](../../../extensibility/debugger/reference/idebugport2-getportrequest.md)
