---
description: "Retrieves a list of all the ports supplied by a port supplier."
title: IDebugPortSupplier2::EnumPorts
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier2::EnumPorts
helpviewer_keywords:
- IDebugPortSupplier2::EnumPorts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplier2::EnumPorts

Retrieves a list of all the ports supplied by a port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumPorts( 
   out IEnumDebugPorts2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumPorts( 
   IEnumDebugPorts2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md) object containing a list of ports supplied.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)
