---
title: "IDebugBeforeSymbolSearchEvent2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugBeforeSymbolSearchEvent2 interface"
ms.assetid: 679fd7b1-765a-41a8-a046-63240c09a499
caps.latest.revision: 8
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
# IDebugBeforeSymbolSearchEvent2
The debug engine (DE) sends this interface to the session debug manager (SDM) to set the status bar message during symbol loads.  
  
## Syntax  
  
```  
IDebugBeforeSymbolSearchEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface when it must set the status bar message during symbol loads. This interface is implemented only by debug engines that work with or are a part of script interpreters. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses **QueryInterface** to access the **IDebugEvent2** interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when it must set the status bar message during symbol loads. The event is sent by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods  
 The following table shows the methods of `IDebugBeforeSymbolSearchEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetModuleName](../extensibility/idebugbeforesymbolsearchevent2--getmodulename.md)|Retrieves the name of the module currently being debugged.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll