---
title: "IDebugExpressionEvaluator2::GetService | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugExpressionEvaluator2::GetService"
  - "GetService"
ms.assetid: f8988a9e-9d18-42af-84a7-55f41e9adf63
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugExpressionEvaluator2::GetService
Retrieves a service object given its unique identifier.

## Syntax

```cpp
HRESULT GetService (
   GUID        uid,
   IUnknown ** ppService
);
```

```csharp
int GetService (
   Guid       uid,
   out object ppService
);
```

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