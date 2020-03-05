---
title: "IDebugLoadCompleteEvent2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugLoadCompleteEvent2"
helpviewer_keywords: 
  - "IDebugLoadCompleteEvent2"
ms.assetid: 37eb7360-28e9-4273-862a-4c17f22af690
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugLoadCompleteEvent2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program is loaded, but before any code is executed.  
  
## Syntax  
  
```  
IDebugLoadCompleteEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a program has been successfully loaded. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report that a program has been successfully loaded. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Remarks  
 This event is a stopping event and must have the `EVENT_STOPPING` flag set on the event attributes.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
