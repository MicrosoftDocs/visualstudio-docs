---
description: "Retrieves a service object given its unique identifier."
title: IDebugExpressionEvaluator2::GetService
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugExpressionEvaluator2::GetService
- GetService
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator2::GetService

Retrieves a service object given its unique identifier.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetService (
   Guid       uid,
   out object ppService
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetService (
   GUID        uid,
   IUnknown ** ppService
);
```
---

## Parameters
`uid`\
[in] Unique identifier of the service to retrieve.

`ppService`\
[out] Returns an object that represents the service.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This can be consumed by a third-party expression evaluator to obtain services from another expression evaluator. For example, this method could be used to obtain the interface for the visualizer service from the default expression evaluator. Third-party expression evaluators are unlikely to need to implement this interface.

## See also
- [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)
