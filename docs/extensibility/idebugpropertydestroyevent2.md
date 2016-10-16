---
title: "IDebugPropertyDestroyEvent2"
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
  - "IDebugPropertyDestroyEvent2"
helpviewer_keywords: 
  - "IDebugPropertyDestroyEvent2 interface"
ms.assetid: 301b7a75-ecfa-46f1-9131-66cf3e4be147
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
# IDebugPropertyDestroyEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a property that is associated with a specific document is about to be destroyed.  
  
## Syntax  
  
```  
IDebugPropertyDestroyEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a property has been destroyed. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../Topic/QueryInterface.md) to access the `IDebugEvent2` interface. This interface is implemented if the DE has previously created a property associated with a script; destroying the property removes the associated script from the IDE.  
  
## Notes for Callers  
 The DE creates and sends this event object to report a property has been destroyed. The event is sent by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the method of `IDebugPropertyDestroyEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetDebugProperty](../extensibility/idebugpropertydestroyevent2--getdebugproperty.md)|Gets the property to be destroyed.|  
  
## Remarks  
 See the Remarks for [IDebugPropertyCreateEvent2](../extensibility/idebugpropertycreateevent2.md) for details on why these events are used.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugEvent2](../extensibility/idebugevent2.md)   
 [IDebugEventCallback2](../extensibility/idebugeventcallback2.md)   
 [IDebugProperty2](../extensibility/idebugproperty2.md)   
 [IDebugPropertyCreateEvent2](../extensibility/idebugpropertycreateevent2.md)