---
title: "Preview Changes | Microsoft Docs"
ms.custom: ""
ms.date: "12/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e15c00f6-3e22-49b8-8269-69e4c8be8040
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
f1_keywords: 
  - "vs.codefix.previewchanges"
translation.priority.ht: 
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

# Preview Changes

When using various *Quick Actions* or *Refactoring* tools in Visual Studio, it is often possible to preview changes that are going to be made to your project prior to accepting them.  The **Preview Changes** window is where this is done.  For example, here is the **Preview Changes** window showing what will be changed during a Rename refactor in a C# project:

![Preview Changes](media/previewchanges.png)

The top half of the window shows the specific lines that will be changed, each with a checkbox.  You can check or uncheck each checkbox if you want to selectively apply the refactoring to only specific lines.

The bottom half of the window shows the formatted code from the project that will be changed, with the affected areas highlighted.  Selecting the specific line in the top half of the window will highlight the corresponding line in the bottom half.  This allows you to quickly skip to the appropriate line and see the surrounding code.

After reviewing the changes, click the **Apply** button to commit those changes, or click the **Cancel** button to leave things as they were.

## See Also  
[Refactoring in Visual Studio](../ide/refactoring-in-visual-studio.md)
