---
title: "Sending Startup Events After a Launch | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], startup events"
ms.assetid: 306ea0b4-6d9e-4871-8d8d-a4032d422940
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# Sending Startup Events After a Launch
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Once the debug engine (DE) is attached to the program, it sends a series of startup events back to the debug session.  
  
 Startup events sent back to the debug session include the following:  
  
- An engine creation event.  
  
- A program creation event.  
  
- Thread creation and module load events.  
  
- A load complete event, sent when the code is loaded and ready to run, but before any code is executed  
  
  > [!NOTE]
  > When this event is continued, global variables are initialized and startup routines run.  
  
- Possible other thread creation and module load events.  
  
- An entry point event, which signals that the program has reached its main entry point, such as **Main** or `WinMain`. This event is not typically sent if the DE attaches to a program that is already running.  
  
  Programmatically, the DE first sends the session debug manager (SDM) an [IDebugEngineCreateEvent2](../../extensibility/debugger/reference/idebugenginecreateevent2.md) interface, which represents an engine creation event, followed by an [IDebugProgramCreateEvent2](../../extensibility/debugger/reference/idebugprogramcreateevent2.md), which represents a program creation event.  
  
  This is typically followed by one or more [IDebugThreadCreateEvent2](../../extensibility/debugger/reference/idebugthreadcreateevent2.md) thread creation events and [IDebugModuleLoadEvent2](../../extensibility/debugger/reference/idebugmoduleloadevent2.md) module load events.  
  
  When the code is loaded and ready to run, but before any code is executed, the DE sends the SDM an [IDebugLoadCompleteEvent2](../../extensibility/debugger/reference/idebugloadcompleteevent2.md) load complete event. Finally, if the program is not already running, the DE sends an [IDebugEntryPointEvent2](../../extensibility/debugger/reference/idebugentrypointevent2.md) entry point event, signaling that the program has reached its main entry point and is ready for debugging.  
  
## See Also  
 [Control of Execution](../../extensibility/debugger/control-of-execution.md)   
 [Debugging Tasks](../../extensibility/debugger/debugging-tasks.md)
