---
title: "IDebugThread2::Suspend"
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
  - "IDebugThread2::Suspend"
helpviewer_keywords: 
  - "IDebugThread2::Suspend"
ms.assetid: 1e20be85-aa12-48de-bb83-0bf0976e99ae
caps.latest.revision: 9
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
# IDebugThread2::Suspend
Suspends a thread.  
  
## Syntax  
  
```cpp#  
HRESULT Suspend (   
   DWORD *pdwSuspendCount  
);  
```  
  
```c#  
HRESULT Suspend (   
   out uint pdwSuspendCount  
);  
```  
  
#### Parameters  
 `pdwSuspendCount`  
 [out] Returns the suspend count after the suspend operation.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Each call to this method increments the suspend count above 0. This suspend count is displayed in the **Threads** debug window.  
  
 For each call to this method, there must be a later call to the [Resume](../extensibility/idebugthread2--resume.md) method.  
  
## See Also  
 [IDebugThread2](../extensibility/idebugthread2.md)   
 [Resume](../extensibility/idebugthread2--resume.md)