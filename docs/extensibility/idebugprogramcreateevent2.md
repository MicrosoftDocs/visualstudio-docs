---
title: "IDebugProgramCreateEvent2"
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
  - "IDebugProgramCreateEvent2"
helpviewer_keywords: 
  - "IDebugProgramCreateEvent2 interface"
ms.assetid: b19a7934-6179-4a68-9075-bd7dcd640b05
caps.latest.revision: 13
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
# IDebugProgramCreateEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program is attached to.  
  
## Syntax  
  
```  
IDebugProgramCreateEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE or the custom port supplier implements this interface to report that a program has been created, typically at the time the program is attached to. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses the `QueryInterface` method to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE or the custom port supplier creates and sends this event object to report the creation of a program. The DE sends this event by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged. The custom port supplier sends this event using the [IDebugPortEvents2](../extensibility/idebugportevents2.md) interface.  
  
## Remarks  
 The DE or custom port supplier publishes a new [IDebugProgramNode2](../extensibility/idebugprogramnode2.md) interface by calling [PublishProgramNode](../extensibility/idebugprogrampublisher2--publishprogramnode.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugEvent2](../extensibility/idebugevent2.md)   
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)   
 [IDebugPortEvents2](../extensibility/idebugportevents2.md)   
 [IDebugProgram2](../extensibility/idebugprogram2.md)