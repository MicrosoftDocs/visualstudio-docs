---
title: "Code Context | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], contexts"
ms.assetid: 65e4d37a-086b-426e-9394-a3534967fd59
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Code Context
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] debugging, a **code context**:  
  
- Provides an abstraction of a position in code as known to the debug engine (DE). For most run-time architectures today, a code context can be thought of as an address in a program's instruction stream. For nontraditional languages, where code may not be represented by instructions, a code context may be represented by some other means.  
  
- Describes the current position in the execution stream of the program being debugged.  
  
- Exists only when a program has stopped at a breakpoint.  
  
- Has an associated document context.  
  
- Is implemented by an [IDebugCodeContext2](../../extensibility/debugger/reference/idebugcodecontext2.md) interface.  
  
## See Also  
 [Document Context](../../extensibility/debugger/document-context.md)   
 [Debugger Contexts](../../extensibility/debugger/debugger-contexts.md)
