---
description: "Adds a port."
title: IDebugPortSupplier2::AddPort | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier2::AddPort
helpviewer_keywords:
- IDebugPortSupplier2::AddPort
ms.assetid: df491161-6bf3-4fcc-b478-b9ec88ec995f
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplier2::AddPort
Adds a port.

## Syntax

```cpp
HRESULT AddPort( 
   IDebugPortRequest2* pRequest,
   IDebugPort2**       ppPort
);
```

```csharp
int AddPort( 
   IDebugPortRequest2 pRequest,
   out IDebugPort2    ppPort
);
```

## Parameters
`pRequest`\
[in] An [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md) object that describes the port to be added.

`ppPort`\
[out] Returns an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object that represents the port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method actually creates the requested port as well as adding it to the port supplier's internal list of active ports. The [CanAddPort](../../../extensibility/debugger/reference/idebugportsupplier2-canaddport.md) method can be called first to avoid possible time-consuming delays.

## See also
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [CanAddPort](../../../extensibility/debugger/reference/idebugportsupplier2-canaddport.md)
