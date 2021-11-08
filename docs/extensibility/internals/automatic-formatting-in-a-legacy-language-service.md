---
title: Automatic Formatting in a Legacy Language Service | Microsoft Docs
description: Learn about automatic formatting in a legacy language service, that automatically inserts a snippet of code when you begin to type a known code construct.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- language services, automatic formatting
ms.assetid: c210fc94-77bd-4694-b312-045087d8a549
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Automatic formatting in a legacy language service
With automatic formatting, a language service automatically inserts a snippet of code when a user begins to type a known code construct.

## Automatic formatting behavior
 For example, when you type *if*, the language service automatically inserts matching braces, or if you press the ENTER key, the language service forces the insertion point on the new line to the appropriate indent level, depending on whether the preceding line opens up a new scope.

 The command filter used for the rest of the language service can also be used for automatic formatting. You can also highlight matching braces by calling <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.HighlightMatchingBrace%2A>.

## See also
- [Develop a legacy language service](../../extensibility/internals/developing-a-legacy-language-service.md)
