---
title: "Session Debug Manager | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "session debug manager, unifying session views"
  - "session debug manager, broadcasting"
  - "debugging [Debugging SDK], session debug manager"
  - "session debug manager"
  - "session debug manager, debug engine multiplexing"
  - "session debug manager, delegating"
ms.assetid: fbb1928d-dddc-43d1-98a4-e23b0ecbae09
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Session Debug Manager
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The session debug manager (SDM) manages any number of debug engines (DE) debugging any number of programs in multiple processes on any number of machines. In addition to being a debug engine multiplexer, the SDM provides a unified view of the debug session to the IDE.  
  
## Session Debug Manager Operation  
 The session debug manager (SDM) manages the DE. There may be more than one debug engine running on a machine at the same time. To multiplex the DEs, the SDM wraps a number of interfaces from the DEs and exposes them to the IDE as a single interface.  
  
 To increase performance, some interfaces are not multiplexed. Instead, they are used directly from the DE, and calls to these interfaces do not go through the SDM. For example, interfaces used with memory, code, and document contexts are not multiplexed, because they refer to a specific instruction, memory, or document in a specific program debugged by a specific DE. No other DE needs to be involved in that level of communication.  
  
 This is not true of all contexts. Calls to the expression evaluation context interface go through the SDM. During expression evaluation, the SDM wraps the [IDebugExpression2](../../extensibility/debugger/reference/idebugexpression2.md) interface that it gives to the IDE because when that expression is evaluated, it may involve multiple DEs that are debugging programs in the same process that might be running on the same thread.  
  
 The SDM typically acts as a delegation mechanism, but it might act as a broadcast mechanism. For example, during expression evaluation, the SDM acts as a broadcast mechanism to notify all DEs that they can run code on a specified thread. Similarly, when the SDM receives a stopping event, it broadcasts to all programs that they should stop running. When a step is called, the SDM broadcasts to all the programs that they can continue running. Breakpoints are also broadcast to every DE.  
  
 The SDM does not track the current program, thread, or stack frame. The process, program, and thread information is sent to the SDM in conjunction with specific debugging events.  
  
## See Also  
 [Debug Engine](../../extensibility/debugger/debug-engine.md)   
 [Debugger Components](../../extensibility/debugger/debugger-components.md)   
 [Debugger Contexts](../../extensibility/debugger/debugger-contexts.md)
