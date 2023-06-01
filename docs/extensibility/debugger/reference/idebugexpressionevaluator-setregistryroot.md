---
description: "This method sets the registry root."
title: IDebugExpressionEvaluator::SetRegistryRoot | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpressionEvaluator::SetRegistryRoot
helpviewer_keywords:
- IDebugExpressionEvaluator::SetRegistryRoot method
ms.assetid: 790886d8-1975-4d3c-9a75-cd86c1faf4ca
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator::SetRegistryRoot

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
This method sets the registry root. Used for side-by-side debugging.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetRegistryRoot(
   string ustrRegistryRoot
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetRegistryRoot ( 
   LPCOLESTR ustrRegistryRoot
);
```
---

## Parameters
`ustrRegistryRoot`\
[in] The new registry root.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The specified registry root is typically set when the expression evaluator is first instantiated and points to the registry key for a specific version of Visual Studio (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*X.Y*, where *X.Y* is a version number).

## See also
- [IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md)
