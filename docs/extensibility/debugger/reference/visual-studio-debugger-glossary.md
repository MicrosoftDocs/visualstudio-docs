---
title: Visual Studio Debugger Glossary
description: This article explains several terms used in the Visual Studio Debugging SDK, such as bound breakpoint, causality, and code context.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- glossary [Debugging SDK]
- debugging [Debugging SDK], glossary
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Visual Studio Debugger Glossary

The following are terms used in the Visual Studio Debugging SDK.

## Terms
 bound breakpoint
 An abstraction for a breakpoint set in code. There is a one-to-one relationship between a bound breakpoint and a breakpoint instruction in the code stream. When code unloads, bound breakpoints may unbind.

 causality
 Provides the ability to track a logical thread of execution across multiple physical threads, processes, and machines, and to reconstruct the call stack of that logical thread at any given point in that thread's lifetime.

 code context
 Provides an abstraction of a position in code known to the debug engine. For most run-time architectures, a code context is an address in a program's instruction stream. For nontraditional languages, in which code may not be represented by instructions, a code context may be represented by other means.

 code path
 Represents a point of execution in the code where a branch is taken or a function call is made. A stack trace is essentially a list of function call code paths.

 debug engine (DE)
 A component that allows debugging of a run-time architecture. A debug engine works in conjunction with the interpreter or operating system and provides debugging services such as execution control, breakpoints, and expression evaluation.

 document context
 Provides an abstraction of a position in a source file document known to the debug engine. For most languages, a document context is a position in a source file. For nontraditional languages, for which the source file may not be text, a document context might be represented by some other means. See also *document position*.

 document position
 Provides an abstraction of a position in a source file known to the IDE. For most languages, a document position is a position in a source file. For nontraditional languages, a document position might be represented in other ways. See also *document context*.

 error breakpoint
 An abstraction for describing an error in a pending breakpoint. An error breakpoint may describe an error in the location of the pending breakpoint, the expression associated with the pending breakpoint, or other information that prevents the pending breakpoint from binding to a code location.

 evaluation context
 Provides an abstraction of a programming context for expression evaluation. Typically, an evaluation context is a scope. When doing expression evaluation in an expression context, the expression context provides scope rules that match its point of creation. For example, an expression context created in a stack frame will provide the context for evaluating local variables, method parameters, class members (if applicable), and global variables.

 intercepted exception
 An exception that is intercepted by a debug engine, even if no exception handling mechanism is in place in the current stack frame.

 JustMyCode
 The concept of debugging only the code that belongs to a user and ignoring all intermediate code such as system code—even if source code is available for that system code.

 pending breakpoint
 Provides an abstraction for breakpoints before, during, and after code is loaded and a way to virtualize breakpoints. A pending breakpoint:

- Contains all the information needed to bind a breakpoint to code in one or more programs.

- May bind to multiple code locations in one or more programs.

- Never binds itself to code.

  Each time code loads, all pending breakpoints in a program are checked to see if they can bind. A pending breakpoint is said to contain all bound breakpoints that it binds.

  process
  A physical Win32 process. A process can contain multiple programs. See also *program*.

  program
  A single namespace running inside a particular run-time architecture. See also *process*.

  session debug manager (SDM)
  Manages any number of debug engines debugging any number of programs in multiple processes on any number of machines. At the basic level, the SDM is a multiplexer of debug engines. Additionally, the SDM provides a unified view of the debugging session to the IDE.

  stack frame
  Represents the state of computation on a particular frame and particular level of nested function calls.

  thread
  The generalized notion of stack-based instruction execution running in at least one program.

  warning breakpoint
  An abstraction for describing a warning in a pending breakpoint. A warning breakpoint describes a reason why the pending breakpoint has not yet bound to a code location. This may be that the code has not loaded yet for the location described by the pending breakpoint, or for some other reason.

## See also
- [Visual Studio Debugger Extensibility](../../../extensibility/debugger/visual-studio-debugger-extensibility.md)
