---
description: "Retrieves a value that corresponds to the specified metric of the expression evaluator."
title: IDebugSettingsCallback2::GetEEMetricDword
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2::GetEEMetricDword
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSettingsCallback2::GetEEMetricDword

Retrieves a value that corresponds to the specified metric of the expression evaluator.

## Syntax

### [C#](#tab/csharp)
```csharp
private int GetEEMetricDword(
   ref Guid guidLang,
   ref Guid guidVendor,
   string   pszMetric,
   out uint pdwValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEEMetricDword(
   REFGUID guidLang,
   REFGUID guidVendor,
   LPCWSTR pszMetric,
   DWORD*  pdwValue
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

`pdwValue`\
[out] Returns the value that corresponds to the metric string.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
