---
description: "This method retrieves an object that allows enumeration of the list of persisted ports."
title: IDebugPortSupplier3::EnumPersistedPorts
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier3::EnumPersistedPorts
helpviewer_keywords:
- IDebugPortSupplier3::EnumPersistedPorts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplier3::EnumPersistedPorts

This method retrieves an object that allows enumeration of the list of persisted ports.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumPersistedPorts(
   BSTR_ARRAY           PortNames,
   out IEnumDebugPorts2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumPersistedPorts(
   BSTR_ARRAY         PortNames,
   IEnumDebugPorts2** ppEnum
);
```
---

## Parameters
`PortNames`\
[in] A [BSTR_ARRAY](../../../extensibility/debugger/reference/bstr-array.md) structure that contains a list of port names to find and return among the persisted ports. Only those persisted ports with these names will be returned.

`ppEnum`\
[out] An object that implements the [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Persisted ports are loaded when a port supplier is instantiated, and saved when the port supplier is destroyed.

## See also
- [IDebugPortSupplier3](../../../extensibility/debugger/reference/idebugportsupplier3.md)
- [IEnumDebugPorts2](../../../extensibility/debugger/reference/ienumdebugports2.md)
- [BSTR_ARRAY](../../../extensibility/debugger/reference/bstr-array.md)
