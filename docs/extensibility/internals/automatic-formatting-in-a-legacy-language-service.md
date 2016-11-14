---
title: "Automatic Formatting in a Legacy Language Service | Microsoft Docs"
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
  - "language services, automatic formatting"
ms.assetid: c210fc94-77bd-4694-b312-045087d8a549
caps.latest.revision: 10
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
# Automatic Formatting in a Legacy Language Service
With automatic formatting, a language service automatically inserts a snippet of code when a user begins to type a known code construct.  
  
## Automatic Formatting Behavior  
 For example, when you type `if`, the language service automatically inserts matching braces, or if you press the ENTER key, the language service forces the insertion point on the new line to the appropriate indent level, depending on whether the preceding line opens up a new scope.  
  
 The command filter used for the rest of the language service can also be used for automatic formatting. You can also highlight matching braces by calling <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.HighlightMatchingBrace%2A>.  
  
## See Also  
 [Developing a Legacy Language Service](../../extensibility/internals/developing-a-legacy-language-service.md)