---
title: "IDebugPortSupplier2::EnumPorts | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugPortSupplier2::EnumPorts"
helpviewer_keywords:
  - "IDebugPortSupplier2::EnumPorts"
ms.assetid: 88b57fd2-eba1-44fa-bd34-cf2ad2b1ff87
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPortSupplier2::EnumPorts
Retrieves a list of all the ports supplied by a port supplier.

## Syntax

```cpp
HRESULT EnumPorts( 
   IEnumDebugPorts2** ppEnum
);
```

```csharp
int EnumPorts( 
   out IEnumDebugPorts2 ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md) object containing a list of ports supplied.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)