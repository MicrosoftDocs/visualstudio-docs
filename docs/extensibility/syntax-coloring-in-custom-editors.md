---
title: Syntax Coloring in Custom Editors
description: Learn about syntax coloring in Visual Studio Environment SDK custom editors, which displays specified colors for a given document view.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- editors [Visual Studio SDK], custom - syntax coloring
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Syntax Coloring in Custom Editors

Visual Studio Environment SDK editors, including the core editor, use language services to identify specific syntactical items and display them with specified colors for a given document view.

## Colorization Requirements
 All editors implementing a language service's colorizer must:

1. Use an object implementing <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> to manage the text to be colorized and an object implementing <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> to provide a document view of the text.

2. Obtain an interface to a particular language service by querying the VSPackage's service provider using the languages service's identifying GUID.

3. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer.SetLanguageServiceID%2A> method of the object implementing <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>. This method associates the language service with the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> implementation that the VSPackage uses to manage the text that is to be colorized.

## Core Editor Usage of a Language Service's Colorizer
 When a language service with a colorizer is obtained by an instance of the core editor, the parsing and rendering of text by a language service's colorizer occurs automatically without requiring any further intervention on your part.

 The IDE transparently:

- Calls the colorizer as needed to parse and analyze text as it is added or modified in the implementation of <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>.

- Ensures that the display supplied by the document view provided by the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> implementation is updated and repainted using the information returned by the colorizer.

## Non-core Editor Usage of a Language Service's Colorizer
 Non-core editor instances can also use a language service's syntax colorization service, but they must explicitly retrieve and apply the service's colorizer, and repaint their document views themselves.

 To do this, a non-core editor must:

1. Obtain a language service's colorizer object (which implements <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer2>). The VSPackage does this by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsLanguageInfo.GetColorizer%2A> method on the language service's interface.

2. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> method to request that a particular span of text be colorized.

     The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> method returns an array of values, one for each letter in the text span being colorized. It also identifies the text span as a particular type of colorable item, such as a comment, keyword, or data type.

3. Use the colorization information returned by <xref:Microsoft.VisualStudio.TextManager.Interop.IVsColorizer.ColorizeLine%2A> to repaint and display its text.

> [!NOTE]
> In addition to using a language service's colorizer, a VSPackage can choose to use the general-purpose Visual Studio Environment SDK text-coloring mechanism. For more information on this mechanism, see [Using Fonts and Colors](/previous-versions/visualstudio/visual-studio-2015/extensibility/using-fonts-and-colors?preserve-view=true&view=vs-2015).

## Related content

- [Syntax Coloring in a Legacy Language Service](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/syntax-coloring-in-a-legacy-language-service)
- [Implementing Syntax Coloring](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/implementing-syntax-coloring)
- [How to: Use Built-In Colorable Items](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/how-to-use-built-in-colorable-items)
- [Custom Colorable Items](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/custom-colorable-items)
