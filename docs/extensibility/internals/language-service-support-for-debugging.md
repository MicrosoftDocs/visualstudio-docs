---
title: "Language Service Support for Debugging | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "debugger, language support"
  - "language services, debugging support"
ms.assetid: 7a44067f-a410-4a6a-84d2-bda5184140bc
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Language Service Support for Debugging
A language service can provide features that support a debugger through the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageDebugInfo> interface. These features include validating breakpoints and supplying a list of expressions to the **Autos** window.

 However, you need to have an expression evaluator to debug your language. The expression evaluator is responsible for evaluating expressions to produce values while debugging. For information about implementing CLR expression evaluators, please see:

- [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators)

- [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample)

## Compiler Output
 The type of compiler determines what you need to do to implement debugging for your language. If your compiler targets the Windows operating system and writes a .pdb file, you can debug programs with the native code debugging engine that is integrated into Visual Studio. If your compiler produces Microsoft intermediate language (MSIL), you can debug programs with the managed code debugging engine, which is also integrated into Visual Studio. If your compiler targets a proprietary operating system or a different runtime environment, you need to write your own debugging engine.

 For more information on implementing debugging for your language, see [Getting Started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md) in the Visual Studio Debugging SDK.