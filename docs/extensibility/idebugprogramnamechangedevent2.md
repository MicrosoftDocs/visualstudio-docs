---
title: "IDebugProgramNameChangedEvent2"
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
  - "IDebugProgramNameChangedEvent2 interface"
ms.assetid: be1f1cd5-0b2f-435c-a052-dca28a7c978d
caps.latest.revision: 6
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
# IDebugProgramNameChangedEvent2
Sent from the debug engine (DE) to the session debug manager (SDM) when the name of a program changes.  
  
## Syntax  
  
```  
IDebugProgramNameChangedEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that the name of the program has changed. The [IDebugEvent2](../extensibility/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../Topic/QueryInterface.md) to access the **IDebugEvent2** interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report a program name change. The DE sends this event by using the [IDebugEventCallback2](../extensibility/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged. The custom port supplier sends this event using the I interface.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll