---
description: "Retrieves the value string of an expression evaluator metric given its name."
title: IDebugSettingsCallback2::GetEEMetricString
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2::GetEEMetricString
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSettingsCallback2::GetEEMetricString

Retrieves the value string of an expression evaluator metric given its name.

## Syntax

### [C#](#tab/csharp)
```csharp
private int GetEEMetricString(
   ref Guid   guidLang,
   ref Guid   guidVendor,
   string     pszMetric,
   out string pbstrValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEEMetricString(
   REFGUID guidLang,
   REFGUID guidVendor,
   LPCWSTR pszMetric,
   BSTR*   pbstrValue
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

`pbstrValue`\
[out] Returns the metric value string.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
