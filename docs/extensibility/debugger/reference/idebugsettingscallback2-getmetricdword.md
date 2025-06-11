---
description: "Retrieves the value of a metric given its name."
title: IDebugSettingsCallback2::GetMetricDword
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2::GetMetricDword
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSettingsCallback2::GetMetricDword

Retrieves the value of a metric given its name.

## Syntax

### [C#](#tab/csharp)
```csharp
private int GetMetricDword(
   string   pszType,
   ref Guid guidSection,
   string   pszMetric,
   out uint pdwValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMetricDword(
   LPCWSTR pszType,
   REFGUID guidSection,
   LPCWSTR pszMetric,
   DWORD*  pdwValue
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

`pdwValue`\
[out] Returns the value of the metric.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
