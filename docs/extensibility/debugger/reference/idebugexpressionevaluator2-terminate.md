---
description: "Stops and cleans up the expression evaluator."
title: IDebugExpressionEvaluator2::Terminate | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Terminate
- IDebugExpressionEvaluator2::Terminate
ms.assetid: 38265100-4d80-4902-833a-07bb569f9ba8
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
# IDebugExpressionEvaluator2::Terminate

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
