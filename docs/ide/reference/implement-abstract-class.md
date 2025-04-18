---
title: Implement an abstract class
description: Learn how to use the Quick Actions and Refactorings menu to immediately generate the code required to implement an abstract class.
ms.date: 01/26/2018
ms.topic: reference
ms.custom: "ide-ref"
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Implement an abstract class in Visual Studio

This code generation applies to:

- C#

- Visual Basic

**What:** Lets you immediately generate the code required to implement an abstract class.

**When:** You want to inherit from an abstract class.

**Why:** You could manually implement all abstract members one-by-one, however this feature will generate all method signatures automatically.

## How-to

1. Place your cursor on the line where there is a red squiggle that indicates you have inherited from an abstract class, but have not implemented all required members.

   - C#:

       ![Highlighted code C#](media/abstract-highlight-cs.png)

   - Visual Basic:

       ![Highlighted code VB](media/abstract-highlight-vb.png)

2. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Hover over the red squiggle and click the ![error light bulb](media/error-bulb.png) icon that appears.
      - Click the ![error light bulb](media/error-bulb.png) icon that appears in the left margin if the text cursor is already on the line with the red squiggle.

   ![Implement class preview](media/abstract-preview-cs.png)

3. Select **Implement Abstract Class** from the drop-down menu.

   > [!TIP]
   > - Use the **Preview changes** link at the bottom of the preview window [to see all of the changes](../../ide/preview-changes.md) that will be made before making your selection.
   > - Use the **Document**, **Project**, and **Solution** links at the bottom of the preview window to create the proper method signatures across multiple classes that inherit from the abstract class.

   The abstract method signatures are created, and are ready to be implemented.

   - C#:

       ![Implement class result C#](media/abstract-result-cs.png)

   - Visual Basic:

       ![Implement class result VB](media/abstract-result-vb.png)

## See also

- [Code Generation](../code-generation-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
