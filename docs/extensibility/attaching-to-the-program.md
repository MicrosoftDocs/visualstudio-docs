---
title: "Attaching to the Program"
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
  - "debug engines, attaching to programs"
ms.assetid: 9a3f5b83-60b5-4ef0-91fe-a432105bd066
caps.latest.revision: 10
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
# Attaching to the Program
After you have registered your programs with the appropriate port, you must attach the debugger to the program you want to debug.  
  
## Choosing How to Attach  
 There are three ways in which the session debug manager (SDM) attempts to attach to the program being debugged.  
  
1.  For programs that are launched by the debug engine through the [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md) method (typical of interpreted languages, for example), the SDM obtains the [IDebugProgramNodeAttach2](../extensibility/idebugprogramnodeattach2.md) interface from the [IDebugProgramNode2](../extensibility/idebugprogramnode2.md) object associated with the program being attached to. If the SDM can obtain the `IDebugProgramNodeAttach2` interface, the SDM then calls the [OnAttach](../extensibility/idebugprogramnodeattach2--onattach.md) method. The `IDebugProgramNodeAttach2::OnAttach` method returns `S_OK` to indicate that it did not attach to the program and that other attempts can be made to attach to the program.  
  
2.  If the SDM can obtain the [IDebugProgramEx2](../extensibility/idebugprogramex2.md) interface from the program being attached to, the SDM calls the [Attach](../extensibility/idebugprogramex2--attach.md) method. This approach is typical for programs that were launched remotely by the port supplier.  
  
3.  If the program cannot be attached through the `IDebugProgramNodeAttach2::OnAttach` or `IDebugProgramEx2::Attach` methods, the SDM loads the debug engine (if not already loaded) by calling the `CoCreateInstance` function and then calls the [Attach](../extensibility/idebugengine2--attach.md) method. This approach is typical for programs launched locally by a port supplier.  
  
     It is also possible for a custom port supplier to call the `IDebugEngine2::Attach` method in the custom port supplier's implementation of the `IDebugProgramEx2::Attach` method. Typically in this case, the custom port supplier launches the debug engine on the remote machine.  
  
 Attachment is achieved when the session debug manager (SDM) calls the [Attach](../extensibility/idebugengine2--attach.md) method.  
  
 If you run your DE in the same process as the application to be debugged, then you must implement the following methods of [IDebugProgramNode2](../extensibility/idebugprogramnode2.md):  
  
-   [GetHostName](../extensibility/idebugprogramnode2--gethostname.md),  
  
-   [GetHostPid](../extensibility/idebugprogramnode2--gethostpid.md)  
  
-   [GetProgramName](../extensibility/idebugprogramnode2--getprogramname.md)  
  
 After the `IDebugEngine2::Attach` method is called, follow these steps in your implementation of the `IDebugEngine2::Attach` method:  
  
1.  Send an [IDebugEngineCreateEvent2](../extensibility/idebugenginecreateevent2.md) event object to the SDM. For more information, see [Sending Events](../extensibility/sending-events.md).  
  
2.  Call the [GetProgramId](../extensibility/idebugprogram2--getprogramid.md) method on the [IDebugProgram2](../extensibility/idebugprogram2.md) object that was passed to the `IDebugEngine2::Attach` method.  
  
     This returns a `GUID` that is used to identify the program. The `GUID` must be stored in the object that represents the local program to the DE, and it must be returned when the `IDebugProgram2::GetProgramId` method is called on the `IDebugProgram2` interface.  
  
    > [!NOTE]
    >  If you implement the `IDebugProgramNodeAttach2` interface, the program's `GUID` is passed to the `IDebugProgramNodeAttach2::OnAttach` method. This `GUID` is used for the program's `GUID` returned by the `IDebugProgram2::GetProgramId` method.  
  
3.  Send an [IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md) event object to notify the SDM that the local `IDebugProgram2` object was created to represent the program to the DE. For details, see [Sending Events](../extensibility/sending-events.md).  
  
    > [!NOTE]
    >  This is not the same `IDebugProgram2` object that was passed into the `IDebugEngine2::Attach` method. The previously passed `IDebugProgram2` object is recognized by the port only and is a separate object.  
  
## See Also  
 [Launch-based Attachment](../extensibility/launch-based-attachment.md)   
 [Sending Events](../extensibility/sending-events.md)   
 [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md)   
 [IDebugProgram2](../extensibility/idebugprogram2.md)   
 [IDebugProgramCreateEvent2](../extensibility/idebugprogramcreateevent2.md)   
 [IDebugProgramNodeAttach2](../extensibility/idebugprogramnodeattach2.md)   
 [OnAttach](../extensibility/idebugprogramnodeattach2--onattach.md)   
 [IDebugProgramNode2](../extensibility/idebugprogramnode2.md)   
 [GetProgramId](../extensibility/idebugprogram2--getprogramid.md)   
 [IDebugProgramEx2](../extensibility/idebugprogramex2.md)   
 [Attach](../extensibility/idebugprogramex2--attach.md)   
 [Attach](../extensibility/idebugengine2--attach.md)