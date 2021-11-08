---
title: Legacy Language Service Overview | Microsoft Docs
description: Learn about legacy language services in Visual Studio and the features supported by the Managed Package Framework (MPF) language service classes. 
ms.custom: SEO-VS-2020 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- language services [managed package framework], about language services
ms.assetid: bb44e27b-d228-463c-b2cf-cd5c24c7c1b5
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Legacy Language Service Overview
A language service provides editor support that lets you implement certain [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] features. The Managed Package Framework (MPF) language service classes provide full support for frequently-used features and partial support for other features.

## Fully Supported Features in the MPF
 The MPF language service classes support the following features:

- Syntax highlighting

- Outlining

- Commenting blocks of code

- Brace matching

- Code snippets

- Custom document properties

- IntelliSense parameter information

- IntelliSense Quick Info

- IntelliSense member completion

- IntelliSense word completion

## Partially Supported Features in the MPF
 The MPF provides only partial support for the following features. This means that you must implement the methods that are called by the MPF.

- Reformatting code. You supply the code that implements the reformatting.

- Validating breakpoints by identifying valid code spans. You supply the code that identifies the code spans.

- Supporting the debugger **Autos** window for displaying variables. You supply the code that determines what to show in the window.

- Supporting the **Navigation bar** for quick navigation between types and members. You implement and return a helper class that populates the lists in the **Navigation bar** combo boxes.

## Implementation
 You must complete several steps to implement the language service itself and the language service features that you want to support for your language. These steps are discussed in the following topics:

- [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service2.md)

- [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)

- [Syntax Colorizing in a Legacy Language Service](../../extensibility/internals/syntax-colorizing-in-a-legacy-language-service.md)

- [Brace Matching in a Legacy Language Service](../../extensibility/internals/brace-matching-in-a-legacy-language-service.md)

- [Outlining in a Legacy Language Service](../../extensibility/internals/outlining-in-a-legacy-language-service.md)

- [Commenting Code in a Legacy Language Service](../../extensibility/internals/commenting-code-in-a-legacy-language-service.md)

- [Reformatting Code in a Legacy Language Service](../../extensibility/internals/reformatting-code-in-a-legacy-language-service.md)

- [Custom Document Properties in a Legacy Language Service](../../extensibility/internals/custom-document-properties-in-a-legacy-language-service.md)

- [Support for Code Snippets in a Legacy Language Service](../../extensibility/internals/support-for-code-snippets-in-a-legacy-language-service.md)

- [Support for the Navigation Bar in a Legacy Language Service](../../extensibility/internals/support-for-the-navigation-bar-in-a-legacy-language-service.md)

- [Word Completion in a Legacy Language Service](../../extensibility/internals/word-completion-in-a-legacy-language-service.md)

- [Member Completion in a Legacy Language Service](../../extensibility/internals/member-completion-in-a-legacy-language-service.md)

- [Parameter Info in a Legacy Language Service](../../extensibility/internals/parameter-info-in-a-legacy-language-service2.md)

- [Quick Info in a Legacy Language Service](../../extensibility/internals/quick-info-in-a-legacy-language-service.md)

- [Support for the Autos Window in a Legacy Language Service](../../extensibility/internals/support-for-the-autos-window-in-a-legacy-language-service.md)

- [Validating Breakpoints in a Legacy Language Service](../../extensibility/internals/validating-breakpoints-in-a-legacy-language-service.md)

## See also
- [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service1.md)
- [Legacy Language Service Extensibility](../../extensibility/internals/legacy-language-service-extensibility.md)
