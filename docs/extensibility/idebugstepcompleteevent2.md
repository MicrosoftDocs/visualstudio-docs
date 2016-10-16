---
title: "IDebugStepCompleteEvent2"
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
  - "IDebugStepCompleteEvent2"
helpviewer_keywords: 
  - "IDebugStepCompleteEvent2 interface"
ms.assetid: eba2b76e-f90d-486b-ae5c-c47f1b8ba2e5
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
# IDebugStepCompleteEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when the program being debugged completes a step into, a step over, or a step out of a line of source code or statement or instruction.  
  
## Syntax  
  
```  
IDebugStepCompleteEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report the completion of a step operation. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../Topic/QueryInterface.md) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report the completion of a step operation. The event is sent by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.  
  
## Remarks  
 Once the step has been completed, the program being debugged is paused once more, and the IDE updates all its windows.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugEvent2](../extensibility/idebugevent2.md)   
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)