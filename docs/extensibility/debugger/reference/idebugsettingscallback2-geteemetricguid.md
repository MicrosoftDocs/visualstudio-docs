---
description: "Retrieves the unique identifier for an expression evaluator metric given its name."
title: IDebugSettingsCallback2::GetEEMetricGuid
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2::GetEEMetricGuid
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSettingsCallback2::GetEEMetricGuid

Retrieves the unique identifier for an expression evaluator metric given its name.

## Syntax

### [C#](#tab/csharp)
```csharp
HRESULT GetEEMetricGuid(
   ref Guid guidLang,
   ref Guid guidVendor,
   string   pszMetric,
   out Guid pguidValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEEMetricGuid(
   REFGUID guidLang,
   REFGUID guidVendor,
   LPCWSTR pszMetric,
   GUID*   pguidValue
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

`pguidValue`\
[out] Returns the unique identifier of the metric.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
