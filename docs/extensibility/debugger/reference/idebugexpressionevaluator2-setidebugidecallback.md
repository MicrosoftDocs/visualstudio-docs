---
title: "IDebugExpressionEvaluator2::SetIDebugIDECallback | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
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
caps.latest.revision: 8
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugExpressionEvaluator2::SetIDebugIDECallback
Enables a debug engine to pass a callback to the expression evaluator during initialization.  
  
## Syntax  
  
```cpp#  
HRESULT SetIDebugIDECallback (  
   IDebugIDECallback * pCallback  
);  
```  
  
```c#  
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