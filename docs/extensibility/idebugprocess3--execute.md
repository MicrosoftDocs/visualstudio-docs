---
title: "IDebugProcess3::Execute"
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
  - "IDebugProcess3::Execute"
helpviewer_keywords: 
  - "IDebugProcess3::Execute"
ms.assetid: d831cd81-d7bf-4172-8517-aa699867791f
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
# IDebugProcess3::Execute
Continues running this process from a stopped state. Any previous execution state (such as a step) is cleared and the process starts executing again.  
  
> [!NOTE]
>  This method should be used instead of [Execute](../extensibility/idebugprogram2--execute.md).  
  
## Syntax  
  
```cpp  
HRESULT Execute(  
   IDebugThread2* pThread  
);  
```  
  
```c#  
int Execute(  
   IDebugThread2 pThread  
);  
```  
  
#### Parameters  
 `pThread`  
 [in] An [IDebugThread2](../extensibility/idebugthread2.md) object representing the thread to execute.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## Remarks  
 When the user starts execution from a stopped state in some other process's thread, this method is called on this process. This method is also called when the user selects the **Start** command from the **Debug** menu in the IDE. The implementation of this method may be as simple as calling the [Resume](../extensibility/idebugthread2--resume.md) method on the current thread in the process.  
  
> [!WARNING]
>  Do not send a stopping event or an immediate (synchronous) event to [Event](../extensibility/idebugeventcallback2--event.md) while handling this call; otherwise the debugger may hang.  
  
## See Also  
 [IDebugProcess3](../extensibility/idebugprocess3.md)   
 [IDebugThread2](../extensibility/idebugthread2.md)   
 [Resume](../extensibility/idebugthread2--resume.md)   
 [Event](../extensibility/idebugeventcallback2--event.md)