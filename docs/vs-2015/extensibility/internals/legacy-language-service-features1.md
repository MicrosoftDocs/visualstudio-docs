---
title: "Legacy Language Service Features1 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "language services [managed package framework]"
ms.assetid: a646e4f0-767d-4cd1-8e1a-9a2aa210a1b7
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# Legacy Language Service Features
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A managed package framework (MPF) language service can support one or more [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] features, such as syntax highlighting, IntelliSense, and breakpoint validation. Each feature can be implemented independent of the others but all require a parser and a scanner except for syntax highlighting, which requires only a scanner.  
  
## In This Section  
 [Brace Matching in a Legacy Language Service](../../extensibility/internals/brace-matching-in-a-legacy-language-service.md)  
 Describes what is required to support language pair matching, also known as brace matching.  
  
 [Commenting Code in a Legacy Language Service](../../extensibility/internals/commenting-code-in-a-legacy-language-service.md)  
 Describes what is required to support commenting and uncommenting of selected code.  
  
 [Custom Document Properties in a Legacy Language Service](../../extensibility/internals/custom-document-properties-in-a-legacy-language-service.md)  
 Describes what is required to support document properties that are embedded in a source file.  
  
 [Outlining in a Legacy Language Service](../../extensibility/internals/outlining-in-a-legacy-language-service.md)  
 Describes what is required to support outlining through the implementation of hidden regions.  
  
 [Reformatting Code in a Legacy Language Service](../../extensibility/internals/reformatting-code-in-a-legacy-language-service.md)  
 Describes what is required to support reformatting code.  
  
 [Support for Code Snippets in a Legacy Language Service](../../extensibility/internals/support-for-code-snippets-in-a-legacy-language-service.md)  
 Describes what is required to support code snippets, which are segments of code that are inserted and can be edited.  
  
 [Parameter Info in a Legacy Language Service](../../extensibility/internals/parameter-info-in-a-legacy-language-service2.md)  
 Describes what is required to support the IntelliSense Parameter Info operation for displaying a method signature as the method is typed.  
  
 [Quick Info in a Legacy Language Service](../../extensibility/internals/quick-info-in-a-legacy-language-service.md)  
 Describes what is required to support the IntelliSense Quick Info operation for displaying information about an identifier.  
  
 [Member Completion in a Legacy Language Service](../../extensibility/internals/member-completion-in-a-legacy-language-service.md)  
 Describes what is required to support the IntelliSense Member Completion operation for selecting a member of a namespace from a list.  
  
 [Word Completion in a Legacy Language Service](../../extensibility/internals/word-completion-in-a-legacy-language-service.md)  
 Describes what is required to support the IntelliSense Complete Word operation for completing partially typed words.  
  
 [Support for the Autos Window in a Legacy Language Service](../../extensibility/internals/support-for-the-autos-window-in-a-legacy-language-service.md)  
 Describes what a language service can do to support the **Autos** window while you are debugging.  
  
 [Support for the Navigation Bar in a Legacy Language Service](../../extensibility/internals/support-for-the-navigation-bar-in-a-legacy-language-service.md)  
 Describes how to use the **Navigation bar** across the top of the editor view to provide quick navigation to any type or member in the file shown in that view..  
  
 [Syntax Colorizing in a Legacy Language Service](../../extensibility/internals/syntax-colorizing-in-a-legacy-language-service.md)  
 Describes what is required to support syntax highlighting of source code.  
  
 [Validating Breakpoints in a Legacy Language Service](../../extensibility/internals/validating-breakpoints-in-a-legacy-language-service.md)  
 Describes what a language service can do to support validating breakpoints outside a debugger.  
  
## Related Sections  
 [Legacy Language Service Parser and Scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md)  
 Describes the parser and scanner that are required to implement all the features of a language service that uses the managed package framework.  
  
 [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service2.md)  
 Describes what is required to implement a language service by using the MPF.  
  
 [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)  
 Describes the steps that are required to register an MPF-based language service with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].  
  
 [Using IntelliSense](../../ide/using-intellisense.md)  
 Explains how IntelliSense makes language references easy to access.  
  
 [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service1.md)  
 Provides information about how to use the managed package framework (MPF) to implement a full-featured language service in managed code.
