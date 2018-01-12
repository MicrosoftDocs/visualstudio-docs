---
title: "Sync type and filename in Visual Basic | Microsoft Docs"
ms.custom: ""
ms.date: "02/27/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.topic: reference
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
dev_langs: 
  - "VB"
ms.workload: 
  - "multiple"
---
# Sync a type to a filename, or a filename to a type in Visual Basic

<!-- VERSIONLESS -->
**This feature is available in Visual Studio 2017 and later.  Additionally, .NET Standard projects are not yet supported for this refactoring.**

**What:** Lets you rename a type to match the filename, or rename a filename to match the type it contains.

**When:** You have renamed a file or type and haven't yet updated the corresponding file or type to match. 

**Why:** Placing a type in a file with a different name, or vice-versa, it difficult to find what you're looking for.  By renaming either the type or filename, code becomes more readable and easier to navigate.

**How:**

1. Highlight or place the text cursor inside the name of the type to synchronize:

   ![Highlighted code](media/synctype-highlight-vb.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Rename file to *TypeName*.vb** from the Preview window popup, where *TypeName* is the name of the type you have selected.
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Rename type to _Filename_** from the Preview window popup, where *Filename* is the name of the current file.
   * **Mouse**
     * Right-click the code, select the **Quick Actions and Refactorings** menu, and select **Rename file to *TypeName*.vb** from the Preview window popup, where *TypeName* is the name of the type you have selected.
     * Right-click the code, select the **Quick Actions and Refactorings** menu, and select **Rename type to _Filename_** from the Preview window popup, where *Filename* is the name of the current file.

   The type or file will instantly be renamed.  In the example below, the file **Employee.vb** was renamed to **Person.vb** to match the type name.

   ![Inline result](media/synctype-result-vb.png)

## See also

[Refactoring](../refactoring-in-visual-studio.md)
