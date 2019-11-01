---
title: "Attaching After a Launch | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debug engines, attaching to programs"
ms.assetid: 5a3600a1-dc20-4e55-b2a4-809736a6ae65
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# Attaching After a Launch
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

After a program has been launched, the debug session is ready to attach the debug engine (DE) to said program.  
  
## Design Decisions  
 Because communication is easier within a shared address space, you must decide whether it makes more sense to facilitate the communication between the debug session and the DE, or between the DE and the program. Choose between the following:  
  
- If it makes more sense to facilitate communication between the debug session and the DE, then the debug session co-creates the DE and asks the DE to attach to the program. This leaves the debug session and DE together in one address space, and the run-time environment and program together in another.  
  
- If it makes more sense to facilitate communication between the DE and the program, then the run-time environment co-creates the DE. This leaves the SDM in one address space, and the DE, run-time environment, and program together in another. This is typical of a DE that is implemented with an interpreter to run scripted languages.  
  
    > [!NOTE]
    > How the DE attaches to the program is implementation-dependent. Communication between the DE and the program is also implementation-dependent.  
  
## Implementation  
 Programmatically, when the session debug manager (SDM) first receives the [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program to be launched, it calls the [Attach](../../extensibility/debugger/reference/idebugprogram2-attach.md) method, passing it an [IDebugEventCallback2](../../extensibility/debugger/reference/idebugeventcallback2.md) object, which is later used to pass debug events back to the SDM. The `IDebugProgram2::Attach` method then calls the [OnAttach](../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) method. For more information on how the SDM receives the `IDebugProgram2` interface, see [Notifying the Port](../../extensibility/debugger/notifying-the-port.md).  
  
 If your DE needs to run in the same address space as the program being debugged, typically because the DE is part of an interpreter running a script, the `IDebugProgramNodeAttach2::OnAttach` method returns `S_FALSE`, indicating that it completed the attach process.  
  
 If, on the other hand, the DE runs in the address space of the SDM, the `IDebugProgramNodeAttach2::OnAttach` method returns `S_OK` or the [IDebugProgramNodeAttach2](../../extensibility/debugger/reference/idebugprogramnodeattach2.md) interface is not implemented at all on the [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md) object associated with the program being debugged. In this case, the [Attach](../../extensibility/debugger/reference/idebugengine2-attach.md) method is eventually called to complete the attach operation.  
  
 In the latter case, you must call the [GetProgramId](../../extensibility/debugger/reference/idebugprogram2-getprogramid.md) method on the `IDebugProgram2` object that was passed to the `IDebugEngine2::Attach` method, store the `GUID` in the local program object, and return this `GUID` when the `IDebugProgram2::GetProgramId` method is subsequently called on this object. The `GUID` is used to identify the program uniquely across the various debug components.  
  
 Note that in the case of the `IDebugProgramNodeAttach2::OnAttach` method returning `S_FALSE`, the `GUID` to use for the program is passed to that method and it is the `IDebugProgramNodeAttach2::OnAttach` method that sets the `GUID` on the local program object.  
  
 The DE is now attached to the program and ready to send any startup events.  
  
## See Also  
 [Attaching Directly to a Program](../../extensibility/debugger/attaching-directly-to-a-program.md)   
 [Notifying the Port](../../extensibility/debugger/notifying-the-port.md)   
 [Debugging Tasks](../../extensibility/debugger/debugging-tasks.md)   
 [IDebugEventCallback2](../../extensibility/debugger/reference/idebugeventcallback2.md)   
 [IDebugProgram2](../../extensibility/debugger/reference/idebugprogram2.md)   
 [Attach](../../extensibility/debugger/reference/idebugprogram2-attach.md)   
 [GetProgramId](../../extensibility/debugger/reference/idebugprogram2-getprogramid.md)   
 [IDebugProgramNode2](../../extensibility/debugger/reference/idebugprogramnode2.md)   
 [IDebugProgramNodeAttach2](../../extensibility/debugger/reference/idebugprogramnodeattach2.md)   
 [OnAttach](../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md)   
 [Attach](../../extensibility/debugger/reference/idebugengine2-attach.md)
