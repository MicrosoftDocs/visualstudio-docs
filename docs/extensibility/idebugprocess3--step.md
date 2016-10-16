---
title: "IDebugProcess3::Step"
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
  - "IDebugProcess3::Step"
helpviewer_keywords: 
  - "IDebugProcess3::Step"
ms.assetid: 6ad9094c-27cc-4927-8a7c-1b4d97b2e436
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
# IDebugProcess3::Step
Causes the process to step one instruction or statement.  
  
> [!NOTE]
>  This method should be used instead of [Step](../extensibility/idebugprogram2--step.md).  
  
## Syntax  
  
```cpp  
HRESULT Step(  
   IDebugThread2* pThread,  
   STEPKIND       sk,  
   STEPUNIT       step,  
);  
```  
  
```c#  
int Step(  
   IDebugThread2 pThread,   
   enum_STEPKIND sk,   
   enum_STEPUNIT step  
);  
```  
  
#### Parameters  
 `pThread`  
 [in] An [IDebugThread2](../extensibility/idebugthread2.md) object representing the thread being stepped.  
  
 `sk`  
 [in] One of the [STEPKIND](../extensibility/stepkind.md) values.  
  
 `step`  
 [in] One of the [STEPUNIT](../extensibility/stepunit.md) values.  
  
## Return Value  
 If successful, returns S_OK; otherwise returns error code.  
  
## Remarks  
 In case there is any thread synchronization or communication between threads, other threads in the process should run when a particular thread is stepping.  
  
 **Warning** Do not send a stopping event or an immediate (synchronous) event to [Event](../extensibility/idebugeventcallback2--event.md) while handling this call; otherwise the debugger may hang.  
  
## See Also  
 [IDebugProcess3](../extensibility/idebugprocess3.md)   
 [IDebugThread2](../extensibility/idebugthread2.md)   
 [STEPKIND](../extensibility/stepkind.md)   
 [STEPUNIT](../extensibility/stepunit.md)   
 [Event](../extensibility/idebugeventcallback2--event.md)