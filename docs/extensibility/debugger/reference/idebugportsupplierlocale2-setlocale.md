---
description: "Sets the locale for the port supplier."
title: IDebugPortSupplierLocale2::SetLocale
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortSupplierLocale2::SetLocale
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplierLocale2::SetLocale

Sets the locale for the port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetLocale(
   ushort wLangID
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetLocale(
   WORD wLangID
);
```
---

## Parameters
`wLangID`\
Identifier for the locale to set.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortSupplierLocale2](../../../extensibility/debugger/reference/idebugportsupplierlocale2.md)
