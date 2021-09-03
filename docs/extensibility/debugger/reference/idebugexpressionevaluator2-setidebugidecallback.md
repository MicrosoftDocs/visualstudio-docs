---
description: "Enables a debug engine to pass a callback to the expression evaluator during initialization."
title: IDebugExpressionEvaluator2::SetIDebugIDECallback | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugExpressionEvaluator2::SetIDebugIDECallback
- SetIDebugIDECallback
ms.assetid: f01c40ad-ef4b-477b-8304-602c6972bc88
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator2::SetIDebugIDECallback
Enables a debug engine to pass a callback to the expression evaluator during initialization.

## Syntax

```cpp
HRESULT SetIDebugIDECallback (
   IDebugIDECallback * pCallback
);
```

```csharp
int SetIDebugIDECallback (
   IDebugIDECallback pCallback
);
```

## Parameters
`pCallback`\
[in] Interface for the callback.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)
