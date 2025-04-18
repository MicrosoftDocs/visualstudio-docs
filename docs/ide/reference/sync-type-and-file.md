---
title: Rename a filename to match a type
description: Learn how to use the Quick Actions and Refactorings menu to rename a type to match the filename, or rename a filename to match the type it contains.
ms.date: 01/26/2018
ms.topic: reference
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
dev_langs:
- CSharp
- VB
---
# Sync a type to a filename, or a filename to a type refactoring

This refactoring applies to:

- C#

- Visual Basic

**What:** Lets you rename a type to match the filename, or rename a filename to match the type it contains.

**When:** You have renamed a file or type and haven't yet updated the corresponding file or type to match.

**Why:** Placing a type in a file with a different name, or vice-versa, makes it difficult to find what you're looking for. By renaming either the type or filename, code becomes more readable and easier to navigate.

> [!NOTE]
> This refactoring is not yet available for .NET Standard and .NET Core projects.

## How-to

1. Highlight or place the text cursor inside the name of the type to synchronize:

   - C#:

       ![Highlighted code - C#](media/synctype-highlight-cs.png)

   - Visual Basic:

       ![Highlighted code - Visual Basic](media/synctype-highlight-vb.png)

2. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Rename file to *TypeName*.cs** from the Preview window popup, where *TypeName* is the name of the type you have selected.
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Rename type to _Filename_** from the Preview window popup, where *Filename* is the name of the current file.
   - **Mouse**
      - Right-click the code, select the **Quick Actions and Refactorings** menu, and select **Rename file to *TypeName*.cs** from the Preview window popup, where *TypeName* is the name of the type you have selected.
      - Right-click the code, select the **Quick Actions and Refactorings** menu, and select **Rename type to _Filename_** from the Preview window popup, where *Filename* is the name of the current file.

   The type or file is renamed.

   - C#: In the example below, the file **MyClass.cs** was renamed to **MyNewClass.cs** to match the type name.

       ![Inline result C#](media/synctype-result-cs.png)

   - Visual Basic: In the example below, the file **Employee.vb** was renamed to **Person.vb** to match the type name.

       ![Inline result Visual Basic](media/synctype-result-vb.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
