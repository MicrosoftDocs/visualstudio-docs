---
title: "Execution Control and State Evaluation | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging [Debugging SDK], execution control"
  - "expression evaluation, control of execution"
ms.assetid: 55adde38-1622-4b51-83cb-ce1b04c1ca7a
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Execution control and state evaluation
Debugging an application requires implementing such execution control features as stepping into functions, stopping at breakpoints, and continuing execution. Visual Studio debugging bases its execution control on events sent between debugger components.

## In this section
 [Program control](../../extensibility/debugger/program-control.md)
 Lists the following routines that occur at the program level: setting the next statement, executing, stepping, continuing, suspending, and resuming.

 [Breakpoint-related methods](../../extensibility/debugger/breakpoint-related-methods.md)
 Defines the bound and pending types of breakpoints that Visual Studio supports.

 [Call stack evaluation](../../extensibility/debugger/call-stack-evaluation.md)
 Discusses implementation of the methods that allow viewing of the stack frames of the call stack during break mode.

 [Expression evaluation](../../extensibility/debugger/expression-evaluation-visual-studio-debugging-sdk.md)
 Explains how the debug engine (DE), expression evaluation (EE), and session debug manager are involved in the parsing and evaluation of an expression entered into one of the windows of the IDE.

 [Control events](../../extensibility/debugger/control-events.md)
 Discusses the interface used to send events during the controlled execution of the program.