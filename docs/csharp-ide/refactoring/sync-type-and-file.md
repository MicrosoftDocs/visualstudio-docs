---
title: "Sync type and filename - Refactoring (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "02/27/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 48172dd7-24a5-4884-8a73-f92497ad6a0d
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
dev_langs: 
  - "CSharp"
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

# Sync a type to a filename, or a filename to a type in C# #

<!-- VERSIONLESS -->
**This feature is available in Visual Studio 2017 and later.  Additionally, .NET Standard projects are not yet supported for this refactoring.**

**What:** Lets you rename a type to match the filename, or rename a filename to match the type it contains.

**When:** You have renamed a file or type and haven't yet updated the corresponding file or type to match. 

**Why:** Placing a type in a file with a different name, or vice-versa, it difficult to find what you're looking for.  By renaming either the type or filename, code becomes more readable and easier to navigate.

**How:**

1. Highlight or place the text cursor inside the name of the type to synchronize:

   ![Highlighted code](media/synctype_highlight.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Rename file to *TypeName*.cs** from the Preview window popup, where *TypeName* is the name of the type you have selected.
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Rename type to _Filename_** from the Preview window popup, where *Filename* is the name of the current file.
   * **Mouse**
     * Right-click the code, select the **Quick Actions and Refactorings** menu, and select **Rename file to *TypeName*.cs** from the Preview window popup, where *TypeName* is the name of the type you have selected.
     * Right-click the code, select the **Quick Actions and Refactorings** menu, and select **Rename type to _Filename_** from the Preview window popup, where *Filename* is the name of the current file.

   The type or file will instantly be renamed.  In the example below, the file **MyClass.cs** was renamed to **MyNewClass.cs** to match the type name.

   ![Inline result](media/synctype_result.png)

## See Also  
[Refactoring (C#)](../refactoring-csharp.md)
