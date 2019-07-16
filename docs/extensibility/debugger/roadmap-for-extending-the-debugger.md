---
title: "Roadmap for Extending the Debugger | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugging [Debugging SDK], roadmap"
  - "Debugging SDK, roadmap"
ms.assetid: 1f4096a8-f7aa-4dfa-84e1-6d59263e70bb
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Roadmap for extending the debugger
This documentation provides guide and reference information for extending the [!INCLUDE[vs_current_short](../../code-quality/includes/vs_current_short_md.md)] debugger with the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)].

 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugging documentation includes samples, a comprehensive reference, and several representative scenarios that demonstrate typical ways to customize the debugger.

 Your compiler and its output determine what's required to set up debugging in your product. If your compiler:

- Targets the Windows native operating system and writes a *.PDB* file, you can debug programs with the native code debug engine (DE), which is integrated into [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. You don't need to implement a DE or expression evaluator. The expression evaluator is written for the syntax of the C++ programming language.

- Produces Microsoft intermediate language (MSIL) output, you can debug programs with the managed code debug engine DE, which is also integrated into [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. Thus, you need only implement an expression evaluator. A sample expression evaluator is provided for you. For more information, see the following topics:

   [Expression evaluation](../../extensibility/debugger/expression-evaluation-visual-studio-debugging-sdk.md)

   [Evaluating expressions](../../extensibility/debugger/evaluating-expressions.md)

   [Expression evaluation context](../../extensibility/debugger/expression-evaluation-context.md)

   [Expression evaluation in break mode](../../extensibility/debugger/expression-evaluation-in-break-mode.md)

   [Write a common language runtime expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)

- Targets a proprietary operating system or some other run-time environment, you need to write your own DE. A tutorial that creates a simple DE using ATL COM is provided. For more information, see the following topics:

   [Create a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)

   [Tutorial: Build a debug engine using ATL COM](https://msdn.microsoft.com/library/9097b71e-1fe7-48f7-bc00-009e25940c24)

   [Implement a port supplier](../../extensibility/debugger/implementing-a-port-supplier.md)

   [Samples](../../extensibility/debugger/visual-studio-debugging-samples.md)

## See also
- [Get started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md)