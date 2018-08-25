---
title: "IDebugExpressionEvaluator2::SetIDebugIDECallback | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugExpressionEvaluator2::SetIDebugIDECallback"
  - "SetIDebugIDECallback"
ms.assetid: f01c40ad-ef4b-477b-8304-602c6972bc88
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugExpressionEvaluator2::SetIDebugIDECallback
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugExpressionEvaluator2::SetIDebugIDECallback](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugexpressionevaluator2-setidebugidecallback).  
  
Enables a debug engine to pass a callback to the expression evaluator during initialization.  
  
## Syntax  
  
```cpp#  
HRESULT SetIDebugIDECallback (  
   IDebugIDECallback * pCallback  
);  
```  
  
```csharp  
int SetIDebugIDECallback (  
   IDebugIDECallback pCallback  
);  
```  
  
#### Parameters  
 `pCallback`  
 [in] Interface for the callback.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)

