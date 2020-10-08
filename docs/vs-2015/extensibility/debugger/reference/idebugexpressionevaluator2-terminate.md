---
title: "IDebugExpressionEvaluator2::Terminate | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "Terminate"
  - "IDebugExpressionEvaluator2::Terminate"
ms.assetid: 38265100-4d80-4902-833a-07bb569f9ba8
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugExpressionEvaluator2::Terminate
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Stops and cleans up the expression evaluator.  
  
## Syntax  
  
```cpp#  
HRESULT Terminate (  
    void  
);  
```  
  
```csharp  
int Terminate ();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Tells the expression evaluator when it is being cleaned up.  
  
## Example  
 The following example shows how to implement this method for a **ExpressionEvaluatorPackage** object that exposes the [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md) interface.  
  
```cpp#  
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
  
## See Also  
 [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)
