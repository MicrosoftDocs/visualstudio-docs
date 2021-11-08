---
title: Legacy Language Service Essentials | Microsoft Docs
description: Learn about the essential features available in legacy language services that allow you to integrate a programming language into Visual Studio.
ms.custom: SEO-VS-2020 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- languages, integrating into Visual Studio
- language services, integrating programming languages
- Visual Studio, integrating programming languages
- programming languages, integrating into Visual Studio
ms.assetid: c15e0ccb-e7c5-4dbb-affb-fe3d3244debe
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Legacy Language Service Essentials
You must provide a language service to integrate a programming language into Visual Studio. This topic explains the features available in legacy language services.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement a language service, see [Editor and Language Service Extensions](../../extensibility/editor-and-language-service-extensions.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

 Legacy language services  provide the following features:

|Feature|Description|
|-------------|-----------------|
|Syntax coloring|Causes the editor view to display different colors and font styles for the different elements of a language. This differentiation can make it easier to read and edit files.<br /><br /> For general information, see [Syntax Coloring in a Legacy Language Service](../../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md).<br /><br /> For information about this feature in the managed package framework (MPF), see [Syntax Colorizing in a Legacy Language Service](../../extensibility/internals/syntax-colorizing-in-a-legacy-language-service.md).|
|Statement completion|Completes a statement or keyword that the user has started typing. Statement completion helps users enter difficult statements more easily, with less typing and fewer chances for error.<br /><br /> For general information, see [Statement Completion in a Legacy Language Service](../../extensibility/internals/statement-completion-in-a-legacy-language-service.md).<br /><br /> For information about this feature in the MPF, see [Word Completion in a Legacy Language Service](../../extensibility/internals/word-completion-in-a-legacy-language-service.md).|
|Brace matching|Highlights paired characters such as braces. When the user types a closing character such as "}", brace matching highlights the corresponding opening character, such as "{". When there are several levels of enclosing characters, this feature helps users confirm that the enclosing characters are paired correctly.<br /><br /> For information about this feature in the MPF, see [Brace Matching in a Legacy Language Service](../../extensibility/internals/brace-matching-in-a-legacy-language-service.md).|
|Parameter information tooltips|Displays a list of possible signatures for the overloaded method that the user is currently typing.<br /><br /> For general information, see [Parameter Info in a Legacy Language Service](../../extensibility/internals/parameter-info-in-a-legacy-language-service1.md).<br /><br /> For information about this feature in the MPF, see [Parameter Info in a Legacy Language Service](../../extensibility/internals/parameter-info-in-a-legacy-language-service2.md).|
|Error markers|Displays a wavy red underline, also known as a squiggly, under text that is syntactically incorrect. Error markers usually are used to make users aware of misspelled keywords, unclosed parentheses, invalid characters, and similar errors.<br /><br /> In the MPF classes, error markers are handled automatically in the <xref:Microsoft.VisualStudio.Package.AuthoringSink.AddError%2A> method of the <xref:Microsoft.VisualStudio.Package.AuthoringSink> class.|

 Many of these features require the language service to parse source code. You often can reuse the tokenizing and parsing code for your compiler or interpreter.

 The following features are related to support for programming languages but are not part of language services:

| Feature | Description |
|-----------------------| - |
| Expression evaluators | Supports the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] debugger by validating breakpoints and supplying a list of expressions to be displayed in the **Autos** debug window.<br /><br /> For more information, see [Language Service Support for Debugging](../../extensibility/internals/language-service-support-for-debugging.md). |
| Symbol-browsing tools | Supports **Object Browser**, **Class View**, **Call Browser**, and **Find Symbol Results**. |
