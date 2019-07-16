---
title: "IDebugExpressionEvaluator::SetRegistryRoot | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugExpressionEvaluator::SetRegistryRoot"
helpviewer_keywords:
  - "IDebugExpressionEvaluator::SetRegistryRoot method"
ms.assetid: 790886d8-1975-4d3c-9a75-cd86c1faf4ca
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugExpressionEvaluator::SetRegistryRoot
This method sets the registry root. Used for side-by-side debugging.

## Syntax

```cpp
HRESULT SetRegistryRoot ( 
   LPCOLESTR ustrRegistryRoot
);
```

```csharp
int SetRegistryRoot(
   string ustrRegistryRoot
);
```

## Parameters
`ustrRegistryRoot`\
[in] The new registry root.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The specified registry root is typically set when the expression evaluator is first instantiated and points to the registry key for a specific version of Visual Studio (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*X.Y*, where *X.Y* is a version number).

## See also
- [IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md)