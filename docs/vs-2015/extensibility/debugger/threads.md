---
title: "Threads | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], threads"
  - "threading [Debugging SDK]"
ms.assetid: 2243d24a-c3d2-41d1-abbb-6db21a2db9ee
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Threads
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In terms of the debugger architecture, a **thread**:  
  
- Is the fundamental unit of computation. A thread sequentially executes its instructions within the context of a single call stack, moving from one code context to the next.  
  
- Can identify itself and the program it is running in, and can be named, suspended, and resumed. A thread can also enumerate its associated stack frames and, under some conditions, can be moved to another stack frame. Given the context of a stack frame, a thread can return its associated logical thread, if any. A thread has properties, such as a suspend count, that can be displayed in the Threads window of the IDE.  
  
- Is represented by an [IDebugThread2](../../extensibility/debugger/reference/idebugthread2.md) interface, typically created by a debug engine (DE) or virtual machine as a consequence of executing a program.  
  
## See also  
 [Programs](../../extensibility/debugger/programs.md)   
 [Stack Frames](../../extensibility/debugger/stack-frames.md)   
 [Debug Engine](../../extensibility/debugger/debug-engine.md)   
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [Session Debug Manager](../../extensibility/debugger/session-debug-manager.md)
