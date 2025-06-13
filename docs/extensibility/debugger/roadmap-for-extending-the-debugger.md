---
title: Roadmap for Extending the Debugger
description: Visual Studio debugging documentation includes samples, a reference, and several scenarios that demonstrate typical ways to customize the debugger.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], roadmap
- Debugging SDK, roadmap
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Roadmap for extending the debugger

This documentation provides guide and reference information for extending the Visual Studio debugger with the Visual Studio SDK.

 Visual Studio debugging documentation includes samples, a comprehensive reference, and several representative scenarios that demonstrate typical ways to customize the debugger.

 Your compiler and its output determine what's required to set up debugging in your product. If your compiler:

- Targets the Windows native operating system and writes a *.PDB* file, you can debug programs with the native code debug engine (DE), which is integrated into Visual Studio. You don't need to implement a DE or expression evaluator. The expression evaluator is written for the syntax of the C++ programming language.

- Produces Microsoft intermediate language (MSIL) output, you can debug programs with the managed code debug engine DE, which is also integrated into Visual Studio. Thus, you need only implement an expression evaluator. A sample expression evaluator is provided for you. For more information, see the following topics:

   [Expression evaluation](../../extensibility/debugger/expression-evaluation-visual-studio-debugging-sdk.md)

   [Evaluating expressions](../../extensibility/debugger/evaluating-expressions.md)

   [Expression evaluation context](../../extensibility/debugger/expression-evaluation-context.md)

   [Expression evaluation in break mode](../../extensibility/debugger/expression-evaluation-in-break-mode.md)

   [Write a common language runtime expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)

- Targets a proprietary operating system or some other run-time environment, you need to write your own DE. A tutorial that creates a simple DE using ATL COM is provided. For more information, see the following topics:

   [Create a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)

   [Tutorial: Build a debug engine using ATL COM](/previous-versions/bb147024(v=vs.90))

   [Implement a port supplier](../../extensibility/debugger/implementing-a-port-supplier.md)

   [Samples](../../extensibility/debugger/visual-studio-debugging-samples.md)

## Related content
- [Get started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md)