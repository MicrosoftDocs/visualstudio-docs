---
title: Move type to matching file refactoring
description: Move a type to a separate file with the same name. Right-click the type, select Quick Actions and Refactorings, and select Move Type to <TypeName>.cs.
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
# Move a type to a matching file refactoring

This refactoring applies to:

- C#

- Visual Basic

**What:** Lets you move the selected type to a separate file with the same name.

**When:** You have multiple classes, structs, interfaces, etc. in the same file which you want to separate.

**Why:** Placing multiple types in the same file can make it difficult to find these types. By moving types to files with the same name, code becomes more readable and easier to navigate.

## How-to

1. Place the cursor inside the name of the type where it is defined. For example:

   ### [C#](#tab/csharp)
   ```csharp
   class Person
   ```

   ### [VB](#tab/vb)
   ```vb
   Class Person
   ```
   ---

2. Next, do one of the following:

   - Press **Ctrl**+**.**
   - Right-click on the type name and select **Quick Actions and Refactorings**

1. Select **Move type to *TypeName*.cs** from the menu, where *TypeName* is the name of the type you've selected.

   The type is moved to a new file in the project that has the same name as the type.

   - C#:

      ![Inline result - C#](media/movetype-result-cs.png)

   - Visual Basic:

      ![Inline result - Visual Basic](media/movetype-result-vb.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
