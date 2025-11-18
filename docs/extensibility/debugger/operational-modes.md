---
title: Operational Modes
description: Learn about the three modes in which the IDE can operate, which are design mode, run mode, and break mode.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- debug engines, modes
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Operational modes

There are three modes in which the IDE can operate, as follows:

- [Design mode](#vsconoperationalmodesanchor1)

- [Run mode](#vsconoperationalmodesanchor2)

- [Break mode](#vsconoperationalmodesanchor3)

  How your custom debug engine (DE) transitions between these modes is an implementation decision that requires you to be familiar with the transition mechanisms. The DE may or may not directly implement these modes. These modes are really debug package modes that switch based on user action or events from the DE. For example, the transition from run mode to break mode is instigated by a stopping event from the DE. The transition from break to either run mode or step mode is instigated by the user performing operations such as Step or Execute. For more information about DE transitions, see [Control of execution](../../extensibility/debugger/control-of-execution.md).

## <a name="vsconoperationalmodesanchor1"></a> Design mode
 Design mode is the nonrunning state of Visual Studio debugging, during which time you can set debugging features in your application.

 Only a few debugging features are used during design mode. A developer may choose to set breakpoints or create watch expressions. The DE is never loaded or called while the IDE is in design mode. Interaction with the DE takes place during run and break modes only.

## <a name="vsconoperationalmodesanchor2"></a> Run mode
 Run mode occurs when a program runs in a debugging session in the IDE. The application runs until termination, until a breakpoint is hit, or until an exception is thrown. When the application runs to termination, the DE transitions into design mode. When a breakpoint is hit or an exception is thrown, the DE transitions to break mode.

## <a name="vsconoperationalmodesanchor3"></a> Break Mode
 Break mode occurs when execution of the debugging program is suspended. Break mode offers the developer a snapshot of the application at the time of the break and allows the developer to analyze the state of the application and change how the application will run. The developer can view and edit code, examine or modify data, restart the application, end execution, or continue execution from the same point.

 Break mode is entered when the DE sends a synchronous stopping event. Synchronous stopping events, also called stopping events, notify the session debug manager (SDM) and the IDE that the application being debugged has stopped executing code. The [IDebugBreakpointEvent2](../../extensibility/debugger/reference/idebugbreakpointevent2.md) and [IDebugExceptionEvent2](../../extensibility/debugger/reference/idebugexceptionevent2.md) interfaces are examples of stopping events.

 Stopping events are continued by a call to one of the following methods, which transition the debugger from break mode to run or step mode:

- [Execute](../../extensibility/debugger/reference/idebugprocess3-execute.md)

- [Step](../../extensibility/debugger/reference/idebugprocess3-step.md)

- [Continue](../../extensibility/debugger/reference/idebugprocess3-continue.md)

### <a name="vsconoperationalmodesanchor4"></a> Step mode
 Step mode occurs when the program steps to the next line of code, or into, over, or out of a function. A step is executed by calling the method [Step](../../extensibility/debugger/reference/idebugprocess3-step.md). This method requires `DWORD`s that specify the [STEPUNIT](../../extensibility/debugger/reference/stepunit.md) and [STEPKIND](../../extensibility/debugger/reference/stepkind.md) enumerations as input parameters.

 When the program successfully steps to the next line of code or into a function, or it runs to the cursor or to a set breakpoint, the DE automatically transitions back to break mode.

## See also
- [Control of execution](../../extensibility/debugger/control-of-execution.md)
