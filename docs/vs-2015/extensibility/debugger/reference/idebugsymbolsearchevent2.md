---
title: "IDebugSymbolSearchEvent2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugSymbolSearchEvent2"
helpviewer_keywords: 
  - "IDebugSymbolSearchEvent2"
ms.assetid: 9b946d55-ff85-44eb-b40a-efbf8282eafd
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugSymbolSearchEvent2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface is sent by the debug engine (DE) to indicate that the debugging symbols for a module being debugged have been loaded.  
  
## Syntax  
  
```  
IDebugSymbolSearchEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a module's symbols have been loaded. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report that a module's symbols have been loaded. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The `IDebugSymbolSearchEvent2` interface exposes the following method.  
  
|Method|Description|  
|------------|-----------------|  
|[GetSymbolSearchInfo](../../../extensibility/debugger/reference/idebugsymbolsearchevent2-getsymbolsearchinfo.md)|Retrieves information about the results of a symbol search.|  
  
## Remarks  
 This event will be sent even if the symbols failed to load. Calling `IDebugSymbolSearchEvent2::GetSymbolSearchInfo` allows the handler of this event to determine if the module actually has any symbols.  
  
 Visual Studio typically uses this event to update the status of loaded symbols in the **Modules** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
