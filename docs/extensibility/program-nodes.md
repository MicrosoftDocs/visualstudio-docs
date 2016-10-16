---
title: "Program Nodes"
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
  - "program nodes, debugging context"
  - "debugging [Debugging SDK], program nodes"
  - "program nodes, adding"
  - "program nodes, superceding"
ms.assetid: 1c5a5c13-c14d-42c3-af11-4c63f1032c8d
caps.latest.revision: 12
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
# Program Nodes
In terms of the debugger architecture, a **program node**:  
  
-   Is a lightweight description of a program.  
  
-   Can identify itself and the process it is running in, and can be attached to, be detached from, and describe the debug engine (DE) that created it, if any.  
  
-   Is represented by an [IDebugProgramNode2](../extensibility/idebugprogramnode2.md) interface, typically created by a DE or port. Program nodes are added to a port by calling [AddProgramNode](../extensibility/idebugportnotify2--addprogramnode.md). When a program node is added to a port, it is added to the process containing the program that this program node represents.  
  
 Sometime after a debug session is started, depending on the implementation of the debug package, program nodes are used to create corresponding programs. When a process is queried for its programs, the programs are enumerated, one for each program node.  
  
 Before a program is attached to, the IDE needs only a lightweight description of the program. This information can be obtained from the program node. Once the program is attached to, the IDE needs to display more detailed information, such as a list of all threads running in the program. This information is obtained from the program itself.  
  
## See Also  
 [Programs](../extensibility/programs.md)   
 [Processes](../extensibility/processes.md)   
 [Debug Engine](../extensibility/debug-engine.md)   
 [Debugger Concepts](../extensibility/debugger-concepts.md)   
 [IDebugProgramNode2](../extensibility/idebugprogramnode2.md)   
 [AddProgramNode](../extensibility/idebugportnotify2--addprogramnode.md)