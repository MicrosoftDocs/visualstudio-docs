---
description: "Gets the port supplier identifier."
title: IDebugPortSupplier2::GetPortSupplierId
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier2::GetPortSupplierId
helpviewer_keywords:
- IDebugPortSupplier2::GetPortSupplierId
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplier2::GetPortSupplierId

Gets the port supplier identifier.

## Syntax

### [C#](#tab/csharp)
```csharp
HRESULT GetPortSupplierId( 
   out Guid pguidPortSupplier
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPortSupplierId( 
   GUID* pguidPortSupplier
);
```
---

## Parameters
`pguidPortSupplier`\
[out] Returns the GUID of the port supplier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
