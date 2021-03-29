---
title: Entering Break Mode | Microsoft Docs
description: Learn about the process that occurs for a breakpoint encountered in a function, running to the line of source code at the cursor, or running to a breakpoint.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- break mode
- debugging [Debugging SDK], entering break mode
ms.assetid: e9a8a241-cd21-4d4e-999a-283554c288b1
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Enter break mode
The following information describes the process that occurs when a breakpoint is encountered after stepping into a function, running to the line of source code that has the cursor in it, or running to a breakpoint.

## Break mode process

1. The debug engine (DE) sends [IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md), [IDebugExceptionEvent2](../../extensibility/debugger/reference/idebugexceptionevent2.md), or any other stopping event to cause the IDE to enter break mode.

2. The SDM gets the call stack information from the thread, as follows:

    - [IDebugThread2::EnumFrameInfo](../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md)

    - [IEnumDebugFrameInfo2::GetCount](../../extensibility/debugger/reference/ienumdebugframeinfo2-getcount.md)

    - [IEnumDebugFrameInfo2::Next](../../extensibility/debugger/reference/ienumdebugframeinfo2-next.md)

    - [IDebugStackFrame2::GetDocumentContext](../../extensibility/debugger/reference/idebugstackframe2-getdocumentcontext.md) to get the source code information

    - [IDebugDocumentContext2::GetName](../../extensibility/debugger/reference/idebugdocumentcontext2-getname.md) to get the file name

    - [IDebugDocumentContext2::GetStatementRange](../../extensibility/debugger/reference/idebugdocumentcontext2-getstatementrange.md) to get the statement range

    - [IDebugStackFrame2::GetCodeContext](../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md) to get memory information

## See also
- [Calling debugger events](../../extensibility/debugger/calling-debugger-events.md)
