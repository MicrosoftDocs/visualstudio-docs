---
title: "Visual Studio Debugger Extensibility | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Visual Studio], Debugging SDK"
  - "Debugging SDK"
ms.assetid: c088b6a2-c3ad-446b-830d-9c6f41b2934b
caps.latest.revision: 32
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Visual Studio Debugger Extensibility
Visual Studio includes a fully interactive source code debugger, providing a powerful and easy-to-use tool for tracking down bugs in your program. The debugger has complete support Visual Basic, C#, C/C++, and JavaScript. However, with the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)], that is available from the [Microsoft Download Center](http://go.microsoft.com/fwlink/?LinkId=214453),, other programming languages can be supported in the debugger with the same rich features.  
  
 The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugger is the common front end (that is, the user interface) to the debugging components that are, in turn, specific to the language being debugged. For new languages, all that is necessary for support by the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugger is to create the necessary back-end components, such as a debug engine (DE). That is where the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] comes in.  
  
 The [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] includes a complete reference to all [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] elements required to create a new DE. In addition, there are samples and tutorials that will help get you started.  
  
 For an end-to-end sample of a language project system with debugging support, see the [IronPython sample](http://msdn.microsoft.com/en-us/4c41695c-12c1-4670-b43b-d8d84c9e4089).  
  
 The following sections describe how to extend the debugger by using the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)].  
  
## In This Section  
 [Getting Started](../../extensibility/debugger/getting-started-with-debugger-extensibility.md)  
 Describes what [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Debugging offers and how to install the SDK.  
  
 [Creating a Custom Debug Engine](../../extensibility/debugger/creating-a-custom-debug-engine.md)  
 Documents the custom DE process, from preparing your program for a DE to detaching the DE.  
  
 [Writing a CLR Expression Evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)  
 Explains whether you must write an expression evaluator.  
  
 [Choosing a Debug Engine Implementation Strategy](../../extensibility/debugger/choosing-a-debug-engine-implementation-strategy.md)  
 Discusses how to implement your DE.  
  
 [Reference](../../extensibility/debugger/reference/reference-visual-studio-debugging-apis.md)  
 Documents the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Debugging API.  
  
 [Samples](../../extensibility/debugger/visual-studio-debugging-samples.md)  
 Contains links to a common language runtime expression evaluator sample and a debug engine sample.