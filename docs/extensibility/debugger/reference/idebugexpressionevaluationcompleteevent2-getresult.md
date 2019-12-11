---
title: "IDebugExpressionEvaluationCompleteEvent2::GetResult | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugExpressionEvaluationCompleteEvent2::GetResult"
helpviewer_keywords:
  - "IDebugExpressionEvaluationCompleteEvent2::GetResult"
ms.assetid: d9ad3e22-b6b2-421e-9a43-6bb8c70d12a9
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugExpressionEvaluationCompleteEvent2::GetResult
Gets the result of expression evaluation.

## Syntax

```cpp
HRESULT GetResult( 
   IDebugProperty2** ppResult
);
```

```csharp
int GetResult( 
   out IDebugProperty2 ppResult
);
```

## Parameters
`ppResult`
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the result of the expression evaluation.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The returned [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object contains the value of the evaluated expression. Note that this value could be a complex value such as an array but the final result must be a numerical or string value that is displayed to the user.

## See also
- [IDebugExpressionEvaluationCompleteEvent2](../../../extensibility/debugger/reference/idebugexpressionevaluationcompleteevent2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)