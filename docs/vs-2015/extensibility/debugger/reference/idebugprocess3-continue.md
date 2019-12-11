---
title: "IDebugProcess3::Continue | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcess3::Continue"
helpviewer_keywords: 
  - "IDebugProcess3::Continue"
ms.assetid: 57506242-5763-4c08-adb9-8a78ce02cebb
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess3::Continue
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Continues running this process from a stopped state. Any previous execution state (such as a step) is preserved, and the process starts executing again.  
  
> [!NOTE]
> This method should be used instead of [Continue](../../../extensibility/debugger/reference/idebugprogram2-continue.md).  
  
## Syntax  
  
```cpp  
HRESULT Continue(  
   IDebugThread2* pThread  
);  
```  
  
```csharp  
int Continue(  
   IDebugThread2 pThread  
);  
```  
  
#### Parameters  
 `pThread`  
 [in] An [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object representing the thread to be continued.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## Remarks  
 This method is called on this process regardless of how many processes are being debugged, or which process generated the stopping event. The implementation must retain the previous execution state (such as a step) and continue execution as though it had never stopped before completing its prior execution. That is, if a thread in this process was doing a step-over operation and was stopped because some other process stopped, and then `Continue` was called, the specified thread must complete the original step-over operation.  
  
 **Warning** Do not send a stopping event or an immediate (synchronous) event to [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) while handling this call; otherwise the debugger may hang.  
  
## See Also  
 [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)   
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)   
 [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md)
