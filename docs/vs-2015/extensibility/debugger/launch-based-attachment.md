---
title: "Launch-based Attachment | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debug engines, launching"
  - "debug engines, attaching to programs"
ms.assetid: 362f00ac-1909-4a3a-bacb-c0ceb5549816
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# Launch-based Attachment
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Launch-based attachment to a program is automatic. When the process hosting the program is launched by the SDM, launch-based attachment follows a path similar to that of the manual attachment method. For information, see [Attaching to the Program](../../extensibility/debugger/attaching-to-the-program.md).  
  
## The Attaching Process  
 The main difference is the sequence of events following the **Attach** call, as follows:  
  
1. Send an **IDebugEngineCreateEvent2** event object to the SDM. For details, see [Sending Events](../../extensibility/debugger/sending-events.md).  
  
2. Call the `IDebugProgram2::GetProgramId` method on the **IDebugProgram2** interface passed to the **Attach** method.  
  
3. Send an **IDebugProgramCreateEvent2** event object to notify the SDM that the local **IDebugProgram2** object was created to represent the program to the DE.  
  
4. Send an [IDebugThreadCreateEvent2](../../extensibility/debugger/reference/idebugthreadcreateevent2.md) event object to notify the SDM that a new thread is created for the process that launched.  
  
## See Also  
 [Sending the Required Events](../../extensibility/debugger/sending-the-required-events.md)   
 [Enabling a Program to Be Debugged](../../extensibility/debugger/enabling-a-program-to-be-debugged.md)
