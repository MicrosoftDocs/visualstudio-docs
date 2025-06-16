---
title: Launch-based Attachment
description: Learn about launch-based attachment to a program, which is automatic and follows a path like that of the manual attachment.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debug engines, launching
- debug engines, attaching to programs
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Launch-based attachment

Launch-based attachment to a program is automatic. When the process hosting the program is launched by the SDM, launch-based attachment follows a path similar to that of the manual attachment method. For information, see [Attach to the program](../../extensibility/debugger/attaching-to-the-program.md).

## The attaching process
 The main difference is the sequence of events following the **Attach** call, as follows:

1. Send an **IDebugEngineCreateEvent2** event object to the SDM. For details, see [Send events](../../extensibility/debugger/sending-events.md).

2. Call the `IDebugProgram2::GetProgramId` method on the **IDebugProgram2** interface passed to the **Attach** method.

3. Send an **IDebugProgramCreateEvent2** event object to notify the SDM that the local **IDebugProgram2** object was created to represent the program to the DE.

4. Send an [IDebugThreadCreateEvent2](../../extensibility/debugger/reference/idebugthreadcreateevent2.md) event object to notify the SDM that a new thread is created for the process that launched.

## See also
- [Send the required events](../../extensibility/debugger/sending-the-required-events.md)
- [Enable a program to be debugged](../../extensibility/debugger/enabling-a-program-to-be-debugged.md)
