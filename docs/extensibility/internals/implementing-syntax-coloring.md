---
title: Implementing Syntax Coloring | Microsoft Docs
description: Learn how to implement syntax coloring in Visual Studio by using the language service features of the managed package framework (MPF).
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- syntax coloring, implementing
- editors [Visual Studio SDK], colorizing text
- text, colorizing in editors
ms.assetid: 96e762ca-efd0-41e7-8958-fda4897c8c7a
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Implementing Syntax Coloring
When the language service provides syntax colorization, the parser converts a line of text into an array of colorable items and returns token types corresponding to these colorable items. The parser should return token types that belong to a list of colorable items. [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] displays each colorable item in the code window according to the attributes assigned by the colorizer object to the appropriate token type.

 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] does not specify a parser interface, and parser implementation is completely up to you. However, a default parser implementation is provided in the Visual Studio Language Package project. For managed code, the managed package framework (MPF) provides complete support for colorizing text.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement syntax coloring, see [Walkthrough: Highlighting Text](../../extensibility/walkthrough-highlighting-text.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

## Steps Followed by an Editor to Colorize Text

1. The editor gets the colorizer by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo.GetColorizer%2A> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo> object.

2. The editor calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.GetStateMaintenanceFlag%2A> method to determine whether the colorizer needs the state of each line to be maintained outside the colorizer.

3. If the colorizer requires the state to be maintained outside the colorizer, the editor calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.GetStartState%2A> method to get the state of the first line.

4. For each line in the buffer, the editor calls the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> method, which performs the following steps:

    1. The line of text is passed to a scanner to convert the text into tokens. Each token specifies the token text and the token type.

    2. The token type is converted into an index into a colorable items list.

    3. The token information is used to fill in an array such that each element of the array corresponds to a character in the line. The values stored in the array are the indexes into the colorable items list.

    4. The state at the end of the line is returned for each line.

5. If the colorizer requires the state to be maintained, the editor caches the state for that line.

6. The editor renders the line of text using the information returned from the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> method. This requires the following steps:

    1. For each character in the line, get the colorable item index.

    2. If using the default colorable items, access the editor's colorable items list.

    3. Otherwise, call the language service's <xref:Microsoft.VisualStudio.TextManager.Interop.IVsProvideColorableItems.GetColorableItem%2A> method to obtain a colorable item.

    4. Use the information in the colorable item to render the text into the display.

## Managed Package Framework Colorizer
 The managed package framework (MPF) provides all the classes that are required to implement a colorizer. Your language service class should inherit the <xref:Microsoft.VisualStudio.Package.LanguageService> class and implement the required methods. You must supply a scanner and parser by implementing the <xref:Microsoft.VisualStudio.Package.IScanner> interface, and return an instance of that interface from the <xref:Microsoft.VisualStudio.Package.LanguageService.GetScanner%2A> method (one of the methods that must be implemented in the <xref:Microsoft.VisualStudio.Package.LanguageService> class). For more information, see [Syntax Colorizing in a Legacy Language Service](../../extensibility/internals/syntax-colorizing-in-a-legacy-language-service.md).

## See also
- [How to: Use Built-In Colorable Items](../../extensibility/internals/how-to-use-built-in-colorable-items.md)
- [Custom Colorable Items](../../extensibility/internals/custom-colorable-items.md)
- [Developing a Legacy Language Service](../../extensibility/internals/developing-a-legacy-language-service.md)
- [Syntax Colorizing in a Legacy Language Service](../../extensibility/internals/syntax-colorizing-in-a-legacy-language-service.md)
