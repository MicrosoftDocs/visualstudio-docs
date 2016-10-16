---
title: "Sending the Required Events"
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
  - "debugging [Debugging SDK], required events"
ms.assetid: 08319157-43fb-44a9-9a63-50b919fe1377
caps.latest.revision: 7
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
# Sending the Required Events
Use this procedure for sending required events.  
  
## Process for Sending Required Events  
 The following events are required, in this order, when creating a debug engine (DE) and attaching it to a program:  
  
1.  Send an [IDebugEngineCreateEvent2](../extensibility/idebugenginecreateevent2.md) event object to the session debug manager (SDM) when the DE is initialized for debugging one or more programs in a process.  
  
2.  When the program to be debugged is attached to, send an [IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md) event object to the SDM. This event may be a stopping event, depending on your engine design.  
  
3.  If the program is attached to when the process is launched, send an [IDebugThreadCreateEvent2](../extensibility/idebugthreadcreateevent2.md) event object to the SDM to notify the IDE of the new thread. This event may be a stopping event, depending on your engine design.  
  
4.  Send an [IDebugLoadCompleteEvent2](../extensibility/idebugloadcompleteevent2.md) event object to the SDM when the program being debugged is finished loading or when attaching to the program is completed. This event must be a stopping event.  
  
5.  If the application to be debugged is launched, send an [IDebugEntryPointEvent2](../extensibility/idebugentrypointevent2.md) event object to the SDM when the first instruction of code in the run-time architecture is about to be executed. This event is always a stopping event. When stepping into the debugging session, the IDE stops on this event.  
  
> [!NOTE]
>  Many languages use global initializers or external, precompiled functions (from the CRT library or _Main) at the beginning of their code. If the language of the program you are debugging contains either of these types of elements before the initial entry point, then this code is run and the entry point event is sent when the user entry point, such as **main** or `WinMain`, is reached.  
  
## See Also  
 [Enabling a Program to Be Debugged](../extensibility/enabling-a-program-to-be-debugged.md)