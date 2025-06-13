---
description: "Retrieves the unique identifier of a metric given its name."
title: IDebugSettingsCallback2::GetMetricGuid
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2::GetMetricGuid
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSettingsCallback2::GetMetricGuid

Retrieves the unique identifier of a metric given its name.

## Syntax

### [C#](#tab/csharp)
```csharp
private int GetMetricGuid(
   string   pszType,
   ref Guid guidSection,
   string   pszMetric,
   out Guid pguidValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMetricGuid(
   LPCWSTR pszType,
   REFGUID guidSection,
   LPCWSTR pszMetric,
   GUID*   pguidValue
);
```
---

## Parameters
`pszType`\
[in] Type of the metric.

`guidSection`\
[in] Unique identifier of the section.

`pszMetric`\
[in] Name of the metric.

`pguidValue`\
[out] Returns the unique identifier of the metric.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
