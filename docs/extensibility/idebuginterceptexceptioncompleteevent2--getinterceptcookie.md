---
title: "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
helpviewer_keywords: 
  - "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
ms.assetid: 07b20866-e598-4783-9ecc-6aa8625c8804
caps.latest.revision: 11
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
# IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie
Called when the processing of an intercepted exception has completed.  
  
## Syntax  
  
```cpp#  
HRESULT GetInterceptCookie(  
   UINT64* pqwCookie  
);  
```  
  
```c#  
int GetInterceptCookie(  
   out ulong pqwCookie  
);  
```  
  
#### Parameters  
 `pqwCookie`  
 [out] Unique value that is associated with the exception that was intercepted.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns error code.  
  
## Remarks  
 After the [InterceptCurrentException](../extensibility/idebugstackframe3--interceptcurrentexception.md) method has completed handling of an intercepted exception, it sends the [IDebugInterceptExceptionCompleteEvent2](../extensibility/idebuginterceptexceptioncompleteevent2.md) event. The handler can use the `GetInterceptCookie` method to retrieve the unique value associated with the exception (the same value passed to the `InterceptCurrentException` method).  
  
## See Also  
 [InterceptCurrentException](../extensibility/idebugstackframe3--interceptcurrentexception.md)   
 [IDebugInterceptExceptionCompleteEvent2](../extensibility/idebuginterceptexceptioncompleteevent2.md)