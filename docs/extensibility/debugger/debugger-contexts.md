---
title: Debugger Contexts
description: "Learn how the Visual Studio debug engine operates within distinct contexts: code context, documentation context or position, and expression evaluation context."
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], contexts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugger contexts

In Visual Studio debugging, the debug engine (DE) operates simultaneously within several distinct contexts, as follows:

- The code context, which describes the current location in a program's execution stream.

- The documentation context or position, which describes the current position within a source document.

- The expression evaluation context, which describes the context in which expression evaluation will take place.

## In this section

[Code context](../../extensibility/debugger/code-context.md) discusses code context as an address in a program's instruction stream in today's run-time architectures versus nontraditional languages, where code may not be represented by instructions, but some other means.

 [Document position](../../extensibility/debugger/document-position.md) defines document position in Visual Studio debugging by means of an abstraction of a position in a source file as known to the IDE.

 [Document context](../../extensibility/debugger/document-context.md) discusses what document context represents in Visual Studio debugging in relation to a source file. Also discusses how the symbol handler maps a code context to documentation context.

 [Expression evaluation context](../../extensibility/debugger/expression-evaluation-context.md) provides information on an expression evaluation context in Visual Studio. For example, an expression evaluation context associated with a stack frame provides the context for evaluating local variables, method parameters, and class members.

## Related sections

[Debug concepts](../../extensibility/debugger/debugger-concepts.md) describes the main debugging architectural concepts.

 [Debug components](../../extensibility/debugger/debugger-components.md) provides an overview of the Visual Studio debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).

 [Debug tasks](../../extensibility/debugger/debugging-tasks.md) contains links to various debugging tasks, such as launching a program and evaluating expressions.
