---
title: "IDebugStopCompleteEvent2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugStopCompleteEvent2 interface"
ms.assetid: ff3e89f4-61bb-489d-901c-447260100218
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IDebugStopCompleteEvent2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The debug engine (DE) can send this optional event to the session debug manager (SDM) when a program has stopped.  
  
## Syntax  
  
```  
IDebugStopCompleteEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 This is a new interface for [!INCLUDE[vsprvslong](../../../includes/vsprvslong-md.md)]. Prior releases did not support asynchronous stopping.  
  
 [Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md) is called by the SDM in multi-process or multi-program scenarios. When one program sends a stopping event to the SDM, the SDM requests other programs to stop, too.  
  
 It is used to asynchronously inform the SDM that a program has stopped. This is useful for an interpreter debug engine, where sometimes no code is running inside the debugged program, so [Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md) can not be completed synchronously. If a debug engine wants to employ this asynchronous notification, it must return `S_ASYNC_STOP` from [Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
