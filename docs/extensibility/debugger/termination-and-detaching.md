---
title: "Termination and Detaching | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "programs, termination events"
  - "debug engines, detaching from programs"
ms.assetid: 268c1e51-6363-45d1-964c-1ab99bdfa4f9
caps.latest.revision: 7
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# Termination and Detaching
The following describes normal termination.  
  
## Discussion  
 After the [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) or [IDebugEntryPointEvent2](../../extensibility/debugger/reference/idebugentrypointevent2.md) interface continues, if there are no breakpoints, exceptions, run-time errors, or infinite loops in the application to be debugged, the program being debugged will run to completion. This is normal termination.  
  
 You must send an [IDebugProgramDestroyEvent2](../../extensibility/debugger/reference/idebugprogramdestroyevent2.md) to implement normal termination. This requires implementing the [IDebugProgramDestroyEvent2::GetExitCode](../../extensibility/debugger/reference/idebugprogramdestroyevent2-getexitcode.md) method.  
  
## See Also  
 [Creating a Custom Debug Engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)