---
title: "Attaching Directly to a Program | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debug engines, attaching to programs"
ms.assetid: ad2b7db8-821c-440c-ba07-c55c6a395e0f
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Attaching Directly to a Program
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Users who want to debug programs in a process that is already running typically follow this process:  
  
1. In the IDE, choose the **Debug Processes** command from the **Tools** menu.  
  
    The **Processes** dialog box appears.  
  
2. Choose a process and click the **Attach** button.  
  
    The **Attach to Process** dialog box appears, listing all debug engines (DEs) installed on the machine.  
  
3. Specify the DEs to use to debug the selected process, and then click **OK**.  
  
   The debug package starts a debug session and passes the list of DEs to it. The debug session in turn passes this list, along with a callback function, to the selected process, and then asks the process to enumerate its running programs.  
  
   Programmatically, in response to the user request, the debug package instantiates the session debug manager (SDM) and passes the list of selected DEs to it. Along with the list, the debug package passes the SDM an [IDebugEventCallback2](../../extensibility/debugger/reference/idebugeventcallback2.md) interface. The debug package passes the list of DEs to the selected process by calling [IDebugProcess2::Attach](../../extensibility/debugger/reference/idebugprocess2-attach.md). The SDM then calls [IDebugProcess2::EnumPrograms](../../extensibility/debugger/reference/idebugprocess2-enumprograms.md) on the port to enumerate the programs running in the process.  
  
   From this point on, each debug engine is attached to a program exactly as detailed in [Attaching After a Launch](../../extensibility/debugger/attaching-after-a-launch.md), with two exceptions.  
  
   For efficiency, DEs that are implemented to share an address space with the SDM are grouped so that each DE has a set of programs it will attach to. In this case, [IDebugProcess2](../../extensibility/debugger/reference/idebugprocess2.md) calls [IDebugEngine2::Attach](../../extensibility/debugger/reference/idebugengine2-attach.md) and passes it an array of programs to attach to.  
  
   The second exception is that the startup events sent by a DE attaching to a program that is already running do not typically include the entry point event.  
  
## See Also  
 [Sending Startup Events After a Launch](../../extensibility/debugger/sending-startup-events-after-a-launch.md)   
 [Debugging Tasks](../../extensibility/debugger/debugging-tasks.md)
