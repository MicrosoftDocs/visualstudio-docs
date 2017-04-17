---
title: "IDebugEngineProgram2 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugEngineProgram2"
helpviewer_keywords: 
  - "IDebugEngineProgram2 interface"
ms.assetid: 151003a9-2e4d-4acf-9f4d-365dfa6b9596
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
# IDebugEngineProgram2
This interface provides multi-threaded debugging support.  
  
## Syntax  
  
```  
IDebugEngineProgram2 : IUnknown  
```  
  
## Notes for Implementers  
 A debug engine implements this interface to support simultaneous debugging of multiple threads. This interface is implemented on the same object that implements the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface.  
  
## Notes for Callers  
 Use [QueryInterface](/cpp/atl/queryinterface) to obtain this interface from an `IDebugProgram2` interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugEngineProgram2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md)|Stops all threads running in this program.|  
|[WatchForThreadStep](../../../extensibility/debugger/reference/idebugengineprogram2-watchforthreadstep.md)|Watches for execution (or stop watching for execution) to occur on the given thread.|  
|[WatchForExpressionEvaluationOnThread](../../../extensibility/debugger/reference/idebugengineprogram2-watchforexpressionevaluationonthread.md)|Allows (or disallows) expression evaluation to occur on the given thread, even if the program is stopped.|  
  
## Remarks  
 Visual Studio calls this interface in response to an [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md) event and to set the "Watch for Thread Step" and "Watch for Expression Evaluation on Thread" states of the program. [Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md) is called whenever the program is to be stopped; this method gives the program a chance to terminate all threads.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)