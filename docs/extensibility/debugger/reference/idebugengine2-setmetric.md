---
description: "This method sets a registry value known as a metric."
title: IDebugEngine2::SetMetric
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2:::SetMetric
helpviewer_keywords:
- IDebugEngine2:::SetMetric
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::SetMetric

This method sets a registry value known as a metric.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetMetric(
   string pszMetric,
   object varValue
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetMetric(
   LPCOLESTR pszMetric,
   VARIANT   varValue
);
```
---

## Parameters
`pszMetric`\
[in] The metric name.

`varValue`\
[in] Specifies the metric value.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A metric is a registry value used to change a debug engine's behavior or to advertise supported functionality. This method can forward the call to the appropriate form of the [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md) function, `SetMetric`.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)
