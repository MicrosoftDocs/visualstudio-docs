---
title: "Launching the Debugger"
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
  - "debugging [Debugging SDK], launching the debugger"
  - "debugger [Debugging SDK], launching"
ms.assetid: f24da1a1-f923-48b4-989f-18a22b581d1b
caps.latest.revision: 11
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
# Launching the Debugger
Launching the debugger requires sending the correct sequence of methods and events with their proper attributes.  
  
## Sequences of Methods and Events  
  
1.  The session debug manager (SDM) is called by choosing the **Debug** menu, and then choosing **Start**. See [Launching a Program](../extensibility/launching-a-program.md) for more information.  
  
2.  The SDM calls [OnAttach](../extensibility/idebugprogramnodeattach2--onattach.md) method .  
  
3.  Based on the debug engine (DE) process model, the `IDebugProgramNodeAttach2::OnAttach` method returns one of the following methods, which determines what happens next.  
  
     If `S_FALSE` is returned, the debug engine (DE) is to be loaded in process of the virtual machine.  
  
     -or-  
  
     If `S_OK` is returned, the DE is to be loaded in-process of the SDM. The SDM then performs the following tasks:  
  
    1.  Calls [GetEngineInfo](../extensibility/idebugprogramnode2--getengineinfo.md) to get the engine information of the DE.  
  
    2.  Co-creates the DE.  
  
    3.  Calls [Attach](../extensibility/idebugengine2--attach.md).  
  
4.  The DE sends an [IDebugEngineCreateEvent2](../extensibility/idebugenginecreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.  
  
5.  The DE sends an [IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.  
  
6.  The DE sends an [IDebugThreadCreateEvent2](../extensibility/idebugthreadcreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.  
  
7.  The DE sends an [IDebugLoadCompleteEvent2](../extensibility/idebugloadcompleteevent2.md) to the SDM with an `EVENT_SYNC` attribute.  
  
8.  The DE sends an [IDebugEntryPointEvent2](../extensibility/idebugentrypointevent2.md) to the SDM with an `EVENT_SYNC` attribute.  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)   
 [Launching a Program](../extensibility/launching-a-program.md)