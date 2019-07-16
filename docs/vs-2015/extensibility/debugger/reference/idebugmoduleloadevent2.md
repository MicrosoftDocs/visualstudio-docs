---
title: "IDebugModuleLoadEvent2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugModuleLoadEvent2"
helpviewer_keywords: 
  - "IDebugModuleLoadEvent2 interface"
ms.assetid: 7d26fb23-5d49-4ba7-b7c5-3aed4d7be81e
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugModuleLoadEvent2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a module is loaded or unloaded.  
  
## Syntax  
  
```  
IDebugModuleLoadEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a module has been loaded or unloaded. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report a module has been loaded or unloaded. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the method of `IDebugModuleLoadEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetModule](../../../extensibility/debugger/reference/idebugmoduleloadevent2-getmodule.md)|Gets the module that is being loaded or unloaded.|  
  
## Remarks  
 Visual Studio uses this event to keep the **Modules** window up to date.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
