---
title: Writing a Common Language Runtime Expression Evaluator
description: Learn about writing an expression evaluator for the common language runtime, which evaluates expressions in the code language being debugged.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- expression evaluators, tutorial
- expression evaluation, samples
- debugging [Debugging SDK], expression evaluators tutorial
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Writing a common language runtime expression evaluator

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, see [CLR expression evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed expression evaluator sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 The expression evaluator (EE) is the part of a debug engine (DE) that handles the syntax and semantics of the programming language that produced the code being debugged. Expressions must be evaluated within the context of a programming language. For example, in some languages, the expression "A+B" means "the sum of A and B." In other languages, the same expression might mean "A or B." Thus, a separate EE must be written for each programming language that generates object code to be debugged in the Visual Studio IDE.

 Some aspects of the Visual Studio debug package must interpret the code in the context of the programming language. For example, when execution halts at a breakpoint, any expressions that the user has typed into a **Watch** window must be evaluated and displayed. The user can change the value of a local variable by typing an expression into a **Watch** window or into the **Immediate** window.

## In this section

[Common language runtime and expression evaluation](../../extensibility/debugger/common-language-runtime-and-expression-evaluation.md) explains that when you are integrating proprietary programming language into the Visual Studio IDE, writing an EE capable of evaluating expressions within the context of the proprietary language allows you to compile to a Microsoft intermediate language (MSIL) without writing a debug engine.

 [Expression evaluator architecture](../../extensibility/debugger/expression-evaluator-architecture.md) discusses how to implement the required EE interfaces and call the common language runtime symbol provider (SP) and binder interfaces.

 [Register an expression evaluator](../../extensibility/debugger/registering-an-expression-evaluator.md) notes that the EE must register itself as a class factory with both the common language runtime and Visual Studio runtime environments.

 [Implement an expression evaluator](../../extensibility/debugger/implementing-an-expression-evaluator.md) describes how the process of evaluating an expression includes the debug engine (DE), the symbol provider (SP), the binder object, and the expression evaluator (EE).

 [Display locals](../../extensibility/debugger/displaying-locals.md) describes how, when execution pauses, the debug package calls the DE to get a list of local variables and arguments.

 [Evaluate a watch window expression](../../extensibility/debugger/evaluating-a-watch-window-expression.md) documents how the Visual Studio debug package calls the DE to determine the current value of each expression in its watch list.

 [Change the value of a local](../../extensibility/debugger/changing-the-value-of-a-local.md) explains that in changing the value of a local, each line of the Locals window has an associated object that provides the name, type, and current value of a local.

 [Implement type visualizers and custom viewers](../../extensibility/debugger/implementing-type-visualizers-and-custom-viewers.md) explains which interface needs to be implemented by which component to support type visualizers and custom viewers.

## Related content
 [Visual Studio debugger extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)
