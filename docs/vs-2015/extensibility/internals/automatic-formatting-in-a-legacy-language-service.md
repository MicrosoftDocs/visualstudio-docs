---
title: "Automatic Formatting in a Legacy Language Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "language services, automatic formatting"
ms.assetid: c210fc94-77bd-4694-b312-045087d8a549
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Automatic Formatting in a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

With automatic formatting, a language service automatically inserts a snippet of code when a user begins to type a known code construct.  
  
## Automatic Formatting Behavior  
 For example, when you type `if`, the language service automatically inserts matching braces, or if you press the ENTER key, the language service forces the insertion point on the new line to the appropriate indent level, depending on whether the preceding line opens up a new scope.  
  
 The command filter used for the rest of the language service can also be used for automatic formatting. You can also highlight matching braces by calling <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.HighlightMatchingBrace%2A>.  
  
## See Also  
 [Developing a Legacy Language Service](../../extensibility/internals/developing-a-legacy-language-service.md)
