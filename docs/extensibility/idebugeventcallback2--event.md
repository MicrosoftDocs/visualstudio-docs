---
title: "IDebugEventCallback2::Event"
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
  - "IDebugEventCallback2::Event"
helpviewer_keywords: 
  - "IDebugEventCallback2::Event"
ms.assetid: e5a3345b-d460-4e40-8f5b-3111c56a2ed9
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
# IDebugEventCallback2::Event
Sends notification of debug events.  
  
## Syntax  
  
```cpp#  
HRESULT Event(   
   IDebugEngine2*  pEngine,  
   IDebugProcess2* pProcess,  
   IDebugProgram2* pProgram,  
   IDebugThread2*  pThread,  
   IDebugEvent2*   pEvent,  
   REFIID          riidEvent,  
   DWORD           dwAttrib  
);  
```  
  
```c#  
int Event(   
   IDebugEngine2  pEngine,  
   IDebugProcess2 pProcess,  
   IDebugProgram2 pProgram,  
   IDebugThread2  pThread,  
   IDebugEvent2   pEvent,  
   ref Guid       riidEvent,  
   uint           dwAttrib  
);  
```  
  
#### Parameters  
 `pEngine`  
 [in] An [IDebugEngine2](../extensibility/idebugengine2.md) object that represents the debug engine (DE) that is sending this event. A DE is required to fill out this parameter.  
  
 `pProcess`  
 [in] An [IDebugProcess2](../extensibility/idebugprocess2.md) object that represents the process in which the event occurs. This parameter is filled in by the session debug manager (SDM). A DE always passes a null value for this parameter.  
  
 `pProgram`  
 [in] An [IDebugProgram2](../extensibility/idebugprogram2.md) object that represents the program in which this event occurs. For most events, this parameter is not a null value.  
  
 `pThread`  
 [in] An [IDebugThread2](../extensibility/idebugthread2.md) object that represents the thread in which this event occurs. For stopping events, this parameter cannot be a null value as the stack frame is obtained from this parameter.  
  
 `pEvent`  
 [in] An [IDebugEvent2](../extensibility/idebugevent2.md) object that represents the debug event.  
  
 `riidEvent`  
 [in] GUID that identifies which event interface to obtain from the `pEvent` parameter.  
  
 `dwAttrib`  
 [in] A combination of flags from the [EVENTATTRIBUTES](../extensibility/eventattributes.md) enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 When calling this method, the `dwAttrib` parameter must match the value returned from the [GetAttributes](../extensibility/idebugevent2--getattributes.md) method as called on the event object passed in the `pEvent` parameter.  
  
 All debug events are posted asynchronously, regardless of whether an event itself is asynchronous or not. When a DE calls this method, the return value does not indicate whether the event was processed, only whether the event was received. In fact, under most circumstances, the event has not been processed when this method returns.  
  
## See Also  
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)   
 [IDebugEngine2](../extensibility/idebugengine2.md)   
 [IDebugProcess2](../extensibility/idebugprocess2.md)   
 [IDebugProgram2](../extensibility/idebugprogram2.md)   
 [IDebugThread2](../extensibility/idebugthread2.md)   
 [IDebugEvent2](../extensibility/idebugevent2.md)   
 [EVENTATTRIBUTES](../extensibility/eventattributes.md)