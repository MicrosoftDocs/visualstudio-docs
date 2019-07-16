---
title: "Stack Frames | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "stack frames, debugging"
  - "debugging [Debugging SDK], stack frames"
  - "stack frames"
ms.assetid: b5e439d4-1e9d-4e13-9cad-bb8b136d4ca8
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Stack Frames
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In terms of the debugger architecture, a **stack frame**:  
  
- Is an abstraction of a stack that provides the execution context of a thread. A thread always executes within a function. A stack frame holds the local variables of the function, and the arguments to it. In order to debug with Visual Studio, the language or environment being debugged must support stack frames.  
  
- Can both identify and describe itself, and can return the associated thread. A stack frame can also return the code context that represents the current instruction pointer, as well as the associated documentation and expression evaluation contexts.  
  
- Has properties that describe the name, type, and value of local variables and arguments, and which appear in various IDE debug windows.  
  
- Is represented by an [IDebugStackFrame2](../../extensibility/debugger/reference/idebugstackframe2.md) interface, typically created by a debug engine (DE) or virtual machine as a consequence of executing a thread.  
  
## See Also  
 [Debugger Contexts](../../extensibility/debugger/debugger-contexts.md)   
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [Debug Engine](../../extensibility/debugger/debug-engine.md)   
 [IDebugStackFrame2](../../extensibility/debugger/reference/idebugstackframe2.md)
