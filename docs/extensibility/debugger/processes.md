---
title: "Processes | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], processes"
ms.assetid: a6a1efdc-b243-40c8-a778-6f69f6b018be
caps.latest.revision: 14
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
# Processes
In terms of the debugger architecture, a **process**:  
  
-   Is a container for a set of programs. It is closely analogous to a Windows process, which is a container for a set of threads.  
  
-   Can identify itself by name, identifier, or physical identifier.  
  
-   Can enumerate all running programs (and their threads).  
  
-   Can describe itself, the port it is running in, and the machine that contains it.  
  
-   Can create one or more programs, terminate any of the programs it creates, or cause a program to stop.  
  
-   Is represented by an [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md) interface, which is created when the process is launched. A process is launched by either the session debug manager (SDM) or [LaunchSuspended](../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md).  
  
 The debug package can attach a debug engine (DE) to a process by calling [Attach](../../extensibility/debugger/reference/idebugprocess2-attach.md). This means that the DE attaches to all possible programs running in the process that it can handle. For example, if the common language runtime DE attaches to a process, it attaches only to programs that are running managed code.  
  
## See Also  
 [Programs](../../extensibility/debugger/programs.md)   
 [Threads](../../extensibility/debugger/threads.md)   
 [Debugger Concepts](../../extensibility/debugger/debugger-concepts.md)   
 [Debug Package](../../extensibility/debugger/debug-package.md)   
 [Debug Engine](../../extensibility/debugger/debug-engine.md)   
 [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md)   
 [LaunchSuspended](../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)   
 [Attach](../../extensibility/debugger/reference/idebugprocess2-attach.md)