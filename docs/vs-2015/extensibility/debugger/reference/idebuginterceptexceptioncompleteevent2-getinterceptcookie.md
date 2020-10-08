---
title: "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
helpviewer_keywords: 
  - "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
ms.assetid: 07b20866-e598-4783-9ecc-6aa8625c8804
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Called when the processing of an intercepted exception has completed.  
  
## Syntax  
  
```cpp#  
HRESULT GetInterceptCookie(  
   UINT64* pqwCookie  
);  
```  
  
```csharp  
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
 After the [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md) method has completed handling of an intercepted exception, it sends the [IDebugInterceptExceptionCompleteEvent2](../../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2.md) event. The handler can use the `GetInterceptCookie` method to retrieve the unique value associated with the exception (the same value passed to the `InterceptCurrentException` method).  
  
## See Also  
 [InterceptCurrentException](../../../extensibility/debugger/reference/idebugstackframe3-interceptcurrentexception.md)   
 [IDebugInterceptExceptionCompleteEvent2](../../../extensibility/debugger/reference/idebuginterceptexceptioncompleteevent2.md)
