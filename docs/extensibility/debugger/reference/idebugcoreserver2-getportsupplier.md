---
description: "Retrieves a specific port supplier."
title: IDebugCoreServer2::GetPortSupplier
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer2::GetPortSupplier
helpviewer_keywords:
- IDebugCoreServer2::GetPortSupplier
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer2::GetPortSupplier

Retrieves a specific port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPortSupplier( 
   ref Guid                guidPortSupplier,
   out IDebugPortSupplier2 ppPortSupplier
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPortSupplier( 
   REFGUID               guidPortSupplier,
   IDebugPortSupplier2** ppPortSupplier
);
```
---

## Parameters
`guidPortSupplier`\
[in] GUID of the port supplier to be retrieved.

`ppPortSupplier`\
[out] Returns an [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md) object representing the desired port supplier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
