---
title: "IDebugEntryPointEvent2 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugEntryPointEvent2"
helpviewer_keywords: 
  - "IDebugEntryPointEvent2 interface"
ms.assetid: a15d1cc3-97b7-438c-8d24-c23149708f42
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
# IDebugEntryPointEvent2
The debug engine (DE) sends this interface to the session debug manager (SDM) when the program is about to execute its first instruction of user code.  
  
## Syntax  
  
```  
IDebugEntryPointEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface as part of its normal operations. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](/visual-cpp/atl/queryinterface) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object when the program being debugged has been loaded and is ready to execute the first instruction of user code. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Remarks  
 [IDebugLoadCompleteEvent2](../../../extensibility/debugger/reference/idebugloadcompleteevent2.md) is sent when the program is about to execute the very first instruction. For example, `IDebugEntryPoint2` is sent when the program is about to execute the user's `main` function.  
  
 When the DE sends `IDebugEntryPointEvent2`, the current code position should be at the first instruction of user code, like `main`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugLoadCompleteEvent2](../../../extensibility/debugger/reference/idebugloadcompleteevent2.md)