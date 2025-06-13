---
description: "Retrieves the value string of the metric given its name."
title: IDebugSettingsCallback2::GetMetricString
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSettingsCallback2::GetMetricString
- GetMetricString
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSettingsCallback2::GetMetricString

Retrieves the value string of the metric given its name.

## Syntax

### [C#](#tab/csharp)
```csharp
private int GetMetricString(
    string     pszType,
    ref Guid   guidSection,
    string     pszMetric,
    out string pbstrValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMetricString(
    LPCWSTR pszType,
    REFGUID guidSection,
    LPCWSTR pszMetric,
    BSTR*   pbstrValue
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

`pbstrValue`\
[out] Returns the value string of the metric.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
