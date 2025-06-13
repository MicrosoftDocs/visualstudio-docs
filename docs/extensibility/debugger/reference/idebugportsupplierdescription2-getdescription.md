---
description: "Retrieves the description and description metadata for the port supplier."
title: IDebugPortSupplierDescription2::GetDescription
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortSupplierDescription2::GetDescription
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplierDescription2::GetDescription

Retrieves the description and description metadata for the port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetDescription(
   out enum_PORT_SUPPLIER_DESCRIPTION_FLAGS pdwFlags,
   out string pbstrText
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDescription(
   PORT_SUPPLIER_DESCRIPTION_FLAGS *pdwFlags,
   BSTR *pbstrText
);
```
---

## Parameters
`pdwFlags`\
[out] Metadata flags for the description.

`pbstrText`\
[out] Description of the port supplier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortSupplierDescription2](../../../extensibility/debugger/reference/idebugportsupplierdescription2.md)
