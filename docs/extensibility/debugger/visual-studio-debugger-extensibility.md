---
title: Visual Studio Debugger Extensibility | Microsoft Docs
description: This article describes Visual Studio debugger extensibility and provides links to articles about Visual Studio debugging.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Visual Studio], Debugging SDK
- Debugging SDK
ms.assetid: c088b6a2-c3ad-446b-830d-9c6f41b2934b
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Visual Studio debugger extensibility
Visual Studio includes a fully interactive source code debugger, providing a powerful and easy-to-use tool for tracking down bugs in your program. The debugger has complete support for Visual Basic, C#, C/C++, and JavaScript. However, with the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)], that is available from the [Microsoft Download Center](https://www.microsoft.com/download/details.aspx?id=21835), other programming languages can be supported in the debugger with the same rich features.

 The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugger is the common front end (that is, the user interface) to the debugging components that are, in turn, specific to the language being debugged. For new languages, all that is necessary for support by the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugger is to create the necessary back-end components, such as a debug engine (DE). This point is where the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] comes in.

 The [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] includes a complete reference to all [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] elements required to create a new DE. In addition, there are samples and tutorials that will help get you started.

 For a complete sample of a language project system with debugging support, see the [IronPython sample](https://www.microsoft.com/download/details.aspx?id=55984).

 The following sections describe how to extend the debugger by using the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)].

## In this section
 [Get started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md)
 Describes what [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Debugging offers and how to install the SDK.

 [Create a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)
 Documents the custom DE process, from preparing your program for a DE to detaching the DE.

 [Write a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
 Explains whether you must write an expression evaluator.

 [Choose a debug engine implementation strategy](../../extensibility/debugger/choosing-a-debug-engine-implementation-strategy.md)
 Discusses how to implement your DE.

 [Reference](../../extensibility/debugger/reference/reference-visual-studio-debugging-apis.md)
 Documents the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Debugging API.

 [Samples](../../extensibility/debugger/visual-studio-debugging-samples.md)
 Contains links to a common language runtime expression evaluator sample and a debug engine sample.
