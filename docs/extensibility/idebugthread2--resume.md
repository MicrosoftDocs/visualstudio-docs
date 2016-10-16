---
title: "IDebugThread2::Resume"
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
  - "IDebugThread2::Resume"
helpviewer_keywords: 
  - "IDebugThread2::Resume"
ms.assetid: 36aad682-b0b9-40a2-b3fc-f0e61d41cdbc
caps.latest.revision: 10
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
# IDebugThread2::Resume
Resumes execution of a thread.  
  
## Syntax  
  
```cpp#  
HRESULT Resume (   
   DWORD *pdwSuspendCount  
);  
```  
  
```c#  
int Resume (   
   out uint pdwSuspendCount  
);  
```  
  
#### Parameters  
 `pdwSuspendCount`  
 [out] Returns the suspend count after the resume operation.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Each call to this method decrements the suspend count until it reaches 0 at which time, execution is actually resumed. This suspend count is displayed in the **Threads** debug window.  
  
 For each call to this method, there must be a previous call to the [Suspend](../extensibility/idebugthread2--suspend.md) method. The suspend count determines how many times the `IDebugThread2::Suspend` method has been called so far.  
  
## See Also  
 [IDebugThread2](../extensibility/idebugthread2.md)   
 [Suspend](../extensibility/idebugthread2--suspend.md)