---
description: "Stops and cleans up the expression evaluator."
title: IDebugExpressionEvaluator2::Terminate
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Terminate
- IDebugExpressionEvaluator2::Terminate
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator2::Terminate

Stops and cleans up the expression evaluator.

## Syntax

### [C#](#tab/csharp)
```csharp
int Terminate ();
```
### [C++](#tab/cpp)
```cpp
HRESULT Terminate (
    void
);
```
---

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
Tells the expression evaluator when it is being cleaned up.

## Example
The following example shows how to implement this method for a **ExpressionEvaluatorPackage** object that exposes the [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md) interface.

```cpp
STDMETHODIMP ExpressionEvaluatorPackage::Terminate(void)
{
    // scan the namespaces contained and delete
    EEExtensionMethodCache **ppChild = NULL;
    m_HashExtensionMethodCache.ResetHashIterator();
    while (ppChild = m_HashExtensionMethodCache.IterateHash())
    {
        delete *ppChild;
    }
    return VBEEImplicitVariables::Terminate();
}
```

## See also
- [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)
