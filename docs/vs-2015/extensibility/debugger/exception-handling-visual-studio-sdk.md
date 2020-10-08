---
title: "Exception Handling (Visual Studio SDK) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], exception handling"
ms.assetid: 7279dc16-db14-482c-86b8-7b3da5a581d2
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# Exception Handling (Visual Studio SDK)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following describes the process that occurs when exceptions are thrown.  
  
## Exception Handling Process  
  
1. When an exception is first thrown, but before it is handled by the exception handler in the program being debugged, the debug engine (DE) sends an [IDebugExceptionEvent2](../../extensibility/debugger/reference/idebugexceptionevent2.md) to the session debug manager (SDM) as a stopping event. The `IDebugExceptionEvent2` is sent if only the settings for the exception (specified in the Exceptions dialog box in the debug package) specify that the user wants to stop on first-chance exception notifications.  
  
2. The SDM calls [IDebugExceptionEvent2::GetException](../../extensibility/debugger/reference/idebugexceptionevent2-getexception.md) to get the property of exception.  
  
3. The debug package calls [IDebugExceptionEvent2::CanPassToDebuggee](../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md) to determine what options to present to the user.  
  
4. The debug package asks the user how to handle the exception by opening a first-chance exception dialog box.  
  
5. If user chooses to continue, the SDM calls [IDebugExceptionEvent2::CanPassToDebuggee](../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md).  
  
    - If the method returns S_OK, calls [IDebugExceptionEvent2::PassToDebuggee](../../extensibility/debugger/reference/idebugexceptionevent2-passtodebuggee.md).  
  
         -or-  
  
         If the method returns S_FALSE, the program being debugged is given a second chance to handle the exception.  
  
6. If the program being debugged has no handler for a second-chance exception, the DE sends an `IDebugExceptionEvent2` to the SDM as **EVENT_SYNC_STOP**.  
  
7. The debug package asks the user how to handle the exception by opening a first-chance exception dialog box.  
  
8. The debug package calls [IDebugExceptionEvent2::CanPassToDebuggee](../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md) to determine what options to present to the user.  
  
9. The debug package asks the user how to handle the exception by opening a second-chance exception dialog box.  
  
10. If the method returns S_OK, calls `IDebugExceptionEvent2::PassToDebuggee`.  
  
## See Also  
 [Calling Debugger Events](../../extensibility/debugger/calling-debugger-events.md)
