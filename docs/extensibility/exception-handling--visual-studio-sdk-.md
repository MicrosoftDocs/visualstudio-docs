---
title: "Exception Handling (Visual Studio SDK)"
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
  - "debugging [Debugging SDK], exception handling"
ms.assetid: 7279dc16-db14-482c-86b8-7b3da5a581d2
caps.latest.revision: 9
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
# Exception Handling (Visual Studio SDK)
The following describes the process that occurs when exceptions are thrown.  
  
## Exception Handling Process  
  
1.  When an exception is first thrown, but before it is handled by the exception handler in the program being debugged, the debug engine (DE) sends an [IDebugExceptionEvent2](../extensibility/idebugexceptionevent2.md) to the session debug manager (SDM) as a stopping event. The `IDebugExceptionEvent2` is sent if only the settings for the exception (specified in the Exceptions dialog box in the debug package) specify that the user wants to stop on first-chance exception notifications.  
  
2.  The SDM calls [IDebugExceptionEvent2::GetException](../extensibility/idebugexceptionevent2--getexception.md) to get the property of exception.  
  
3.  The debug package calls [IDebugExceptionEvent2::CanPassToDebuggee](../extensibility/idebugexceptionevent2--canpasstodebuggee.md) to determine what options to present to the user.  
  
4.  The debug package asks the user how to handle the exception by opening a first-chance exception dialog box.  
  
5.  If user chooses to continue, the SDM calls [IDebugExceptionEvent2::CanPassToDebuggee](../extensibility/idebugexceptionevent2--canpasstodebuggee.md).  
  
    -   If the method returns S_OK, calls [IDebugExceptionEvent2::PassToDebuggee](../extensibility/idebugexceptionevent2--passtodebuggee.md).  
  
         -or-  
  
         If the method returns S_FALSE, the program being debugged is given a second chance to handle the exception.  
  
6.  If the program being debugged has no handler for a second-chance exception, the DE sends an `IDebugExceptionEvent2` to the SDM as **EVENT_SYNC_STOP**.  
  
7.  The debug package asks the user how to handle the exception by opening a first-chance exception dialog box.  
  
8.  The debug package calls [IDebugExceptionEvent2::CanPassToDebuggee](../extensibility/idebugexceptionevent2--canpasstodebuggee.md) to determine what options to present to the user.  
  
9. The debug package asks the user how to handle the exception by opening a second-chance exception dialog box.  
  
10. If the method returns S_OK, calls `IDebugExceptionEvent2::PassToDebuggee`.  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)