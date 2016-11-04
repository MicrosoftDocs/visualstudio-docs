---
title: "IDebugExpressionEvaluator2::GetService | Microsoft Docs"
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
  - "IDebugExpressionEvaluator2::GetService"
  - "GetService"
ms.assetid: f8988a9e-9d18-42af-84a7-55f41e9adf63
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
# IDebugExpressionEvaluator2::GetService
Retrieves a service object given its unique identifier.  
  
## Syntax  
  
```cpp#  
HRESULT GetService (  
   GUID        uid,  
   IUnknown ** ppService  
);  
```  
  
```c#  
int GetService (  
   Guid       uid,  
   out object ppService  
);  
```  
  
#### Parameters  
 `uid`  
 [in] Unique identifier of the service to retrieve.  
  
 `ppService`  
 [out] Returns an object that represents the service.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This can be consumed by a third-party expression evaluator to obtain services from another expression evaluator. For example, this method could be used to obtain the interface for the visualizer service from the default expression evaluator. Third-party expression evaluators are unlikely to need to implement this interface.  
  
## See Also  
 [IDebugExpressionEvaluator2](../../../extensibility/debugger/reference/idebugexpressionevaluator2.md)