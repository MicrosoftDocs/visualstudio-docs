---
title: "Entering Break Mode"
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
  - "break mode"
  - "debugging [Debugging SDK], entering break mode"
ms.assetid: e9a8a241-cd21-4d4e-999a-283554c288b1
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
# Entering Break Mode
The following describes the process that occurs when a breakpoint is encountered after stepping into a function, running to the line of source code that has the cursor in it, or running to a breakpoint.  
  
## Break Mode Process  
  
1.  The debug engine (DE) sends [IDebugBreakpointEvent2](../extensibility/idebugbreakpointevent2.md), [IDebugExceptionEvent2](../extensibility/idebugexceptionevent2.md), or any other stopping event to cause the IDE to enter break mode.  
  
2.  The SDM gets the call stack information from the thread, as follows:  
  
    -   [IDebugThread2::EnumFrameInfo](../extensibility/idebugthread2--enumframeinfo.md)  
  
    -   [IEnumDebugFrameInfo2::GetCount](../extensibility/ienumdebugframeinfo2--getcount.md)  
  
    -   [IEnumDebugFrameInfo2::Next](../extensibility/ienumdebugframeinfo2--next.md)  
  
    -   [IDebugStackFrame2::GetDocumentContext](../extensibility/idebugstackframe2--getdocumentcontext.md) to get the source code information  
  
    -   [IDebugDocumentContext2::GetName](../extensibility/idebugdocumentcontext2--getname.md) to get the file name  
  
    -   [IDebugDocumentContext2::GetStatementRange](../extensibility/idebugdocumentcontext2--getstatementrange.md) to get the statement range  
  
    -   [IDebugStackFrame2::GetCodeContext](../extensibility/idebugstackframe2--getcodecontext.md) to get memory information  
  
## See Also  
 [Calling Debugger Events](../extensibility/calling-debugger-events.md)