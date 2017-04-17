---
title: "IDebugPropertyCreateEvent2 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugPropertyCreateEvent2"
helpviewer_keywords: 
  - "IDebugPropertyCreateEvent2 interface"
ms.assetid: 33b3082b-a42e-488a-a1e4-dadf506f922c
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
# IDebugPropertyCreateEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when it creates a property that is associated with a specific document.  
  
## Syntax  
  
```  
IDebugPropertyCreateEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a property has been created. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface. This interface is implemented if the DE has created a property associated with a script that has been loaded or created and if that script needs to appear in the IDE.  
  
## Notes for Callers  
 The DE creates and sends this event object to report a property has been created. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the method of the `IDebugPropertyCreateEvent2` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetDebugProperty](../../../extensibility/debugger/reference/idebugpropertycreateevent2-getdebugproperty.md)|Gets the new property.|  
  
## Remarks  
 If a property has a specific document or script associated with it, the DE can send this event to the SDM in order to update the **Script Documents** window with the name of the document. The SDM will call [GetExtendedInfo](../../../extensibility/debugger/reference/idebugproperty2-getextendedinfo.md) with the argument `guidDocument` to retrieve a `VARIANT` containing an [IUnknown](/cpp/atl/iunknown) pointer. The SDM will call [QueryInterface](/cpp/atl/queryinterface) on this pointer to retrieve the [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) interface that is used to update the **Script Documents** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)