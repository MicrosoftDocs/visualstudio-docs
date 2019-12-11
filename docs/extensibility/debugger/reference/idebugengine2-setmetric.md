---
title: "IDebugEngine2::SetMetric | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEngine2:::SetMetric"
helpviewer_keywords:
  - "IDebugEngine2:::SetMetric"
ms.assetid: dcda4972-c32e-4693-a0e1-25d5c58b9782
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugEngine2::SetMetric
This method sets a registry value known as a metric.

## Syntax

```cpp
HRESULT SetMetric(
   LPCOLESTR pszMetric,
   VARIANT   varValue
);
```

```csharp
int SetMetric(
   string pszMetric,
   object varValue
);
```

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