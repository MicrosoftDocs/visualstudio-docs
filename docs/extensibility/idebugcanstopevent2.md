---
title: "IDebugCanStopEvent2"
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
  - "IDebugCanStopEvent2"
helpviewer_keywords: 
  - "IDebugBreakpointRequest2 interface"
ms.assetid: 784bd5b1-4a3f-4455-b313-c4c9a82555a5
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
# IDebugCanStopEvent2
This interface is used to ask the session debug manager (SDM) whether to stop at the current code location.  
  
## Syntax  
  
```  
IDebugCanStopEvent2 : IUknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to support stepping through source code. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](../Topic/QueryInterface.md) to access the `IDebugEvent2` interface).  
  
 The implementation of this interface must communicate the SDM's call of [CanStop](../extensibility/idebugcanstopevent2--canstop.md) to the debug engine. For example, this can be done with a message posted to the debug engine's message handling thread or the object implementing this interface could hold a reference to the debug engine and call back into the debug engine with the flag passed into `IDebugCanStopEvent2::CanStop`.  
  
## Notes for Callers  
 The DE can send this method each time the DE is asked to continue execution and the DE is stepping through code. This event is sent by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugCanStopEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetReason](../extensibility/idebugcanstopevent2--getreason.md)|Gets the reason for this event.|  
|[CanStop](../extensibility/idebugcanstopevent2--canstop.md)|Specifies whether the program being debugged should stop at the location of this event (and send an event that describes the reason for stopping) or just continue execution.|  
|[GetDocumentContext](../extensibility/idebugcanstopevent2--getdocumentcontext.md)|Gets the document context that describes the location of this event.|  
|[GetCodeContext](../extensibility/idebugcanstopevent2--getcodecontext.md)|Gets the code context that describes the location of this event.|  
  
## Remarks  
 The DE sends this interface if the user steps into a function and the DE finds no debug information there or debug information exists but the DE does not know if the source code can be displayed for that location.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugStepCompleteEvent2](../extensibility/idebugstepcompleteevent2.md)   
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)