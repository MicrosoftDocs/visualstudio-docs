---
description: "Retrieves a list of all available ports."
title: IDebugCoreServer2::EnumPorts
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer2::EnumPorts
helpviewer_keywords:
- IDebugCoreServer2::EnumPorts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer2::EnumPorts

Retrieves a list of all available ports.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumPorts( 
   out IEnumDebugPorts2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumPorts( 
   IEnumDebugPorts2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md) object that contains a list of all ports from all port suppliers.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)
