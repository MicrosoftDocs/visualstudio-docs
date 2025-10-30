---
title: Visual Studio Debugger Extensibility
description: This article describes Visual Studio debugger extensibility and provides links to articles about Visual Studio debugging.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- debugging [Visual Studio], Debugging SDK
- Debugging SDK
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Visual Studio debugger extensibility

Visual Studio includes a fully interactive source code debugger, providing a powerful and easy-to-use tool for tracking down bugs in your program. The debugger has complete support for Visual Basic, C#, C/C++, and JavaScript. However, with the Visual Studio SDK, that is available from the [Microsoft Download Center](https://dotnet.microsoft.com/download/visual-studio-sdks), other programming languages can be supported in the debugger with the same rich features.

 The Visual Studio debugger is the common front end (that is, the user interface) to the debugging components that are, in turn, specific to the language being debugged. For new languages, all that is necessary for support by the Visual Studio debugger is to create the necessary back-end components, such as a debug engine (DE). This point is where the Visual Studio SDK comes in.

 The Visual Studio SDK includes a complete reference to all Visual Studio elements required to create a new DE. In addition, there are samples and tutorials that will help get you started.

 For a complete sample of a language project system with debugging support, see the [IronPython sample](https://www.microsoft.com/download/details.aspx?id=55984).

 The following sections describe how to extend the debugger by using the Visual Studio SDK.

## In this section

[Get started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md) describes what Visual Studio Debugging offers and how to install the SDK.

 [Create a custom debug engine](../../extensibility/debugger/creating-a-custom-debug-engine.md) documents the custom DE process, from preparing your program for a DE to detaching the DE.

 [Write a CLR expression evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md) explains whether you must write an expression evaluator.

 [Choose a debug engine implementation strategy](../../extensibility/debugger/choosing-a-debug-engine-implementation-strategy.md) discusses how to implement your DE.

 [Reference](../../extensibility/debugger/reference/reference-visual-studio-debugging-apis.md) documents the Visual Studio Debugging API.

 [Samples](../../extensibility/debugger/visual-studio-debugging-samples.md) contains links to a common language runtime expression evaluator sample and a debug engine sample.
