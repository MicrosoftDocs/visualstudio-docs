---
description: "Retrieves an expression evaluator local object given the metric name."
title: IDebugSettingsCallback2::GetEELocalObject
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2::GetEELocalObject
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSettingsCallback2::GetEELocalObject

Retrieves an expression evaluator local object given the metric name.

## Syntax

### [C#](#tab/csharp)
```csharp
private int GetEELocalObject(
   ref Guid          guidLang,
   ref Guid          guidVendor,
   string            pszMetric,
   out System.Object ppUnk
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEELocalObject(
   REFGUID     guidLang,
   REFGUID     guidVendor,
   LPCWSTR     pszMetric,
   IUnknown ** ppUnk
);
```
---

## Parameters
`guidLang`\
[in] Unique identifier of the programming language.

`guidVendor`\
[in] Unique identifier of the vendor.

`pszMetric`\
[in] Name of the metric.

`ppUnk`\
[out] Returns the expression evaluator local object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
