---
description: "Retrieves the name of the evaluation context."
title: IDebugExpressionContext2::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpressionContext2::GetName
helpviewer_keywords:
- IDebugExpressionContext2::GetName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionContext2::GetName

Retrieves the name of the evaluation context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName( 
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName( 
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Returns the name of the evaluation context.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name is the description of this evaluation context. It is typically something that can be parsed by an expression evaluator that refers to this exact evaluation context. For example, in C++ the name is as follows:

```
"{ function-name, source-file-name, module-file-name }"
```

## See also
- [IDebugExpressionContext2](../../../extensibility/debugger/reference/idebugexpressioncontext2.md)
