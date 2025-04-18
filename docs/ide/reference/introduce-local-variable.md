---
title: Introduce a local variable
description: Generate a local variable to replace an existing expression. Select the expression, right-click and select the Quick Actions and Refactorings menu, select Introduce local for (all occurrences) of 'expression'.
ms.date: 01/26/2018
ms.topic: reference
ms.custom: "ide-ref"
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Introduce a local variable in Visual Studio

This code generation applies to:

- C#

- Visual Basic

**What:** Lets you immediately generate a local variable to replace an existing expression.

**When:** You have code which could be easily reused later if it were in a local variable.

**Why:** You could copy and paste the code multiple times to use it in various locations, however it would be better to perform the operation once, store the result in a local variable, and use the local variable throughout.

## How-to

1. Highlight the expression that you want to assign to a new local variable.

   - C#:

       ![Highlighted code C#](media/local-highlight-cs.png)

   - Visual Basic:

       ![Highlighted code VB](media/local-highlight-vb.png)

2. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Click the ![Screenshot of the screwdriver icon that appears in the left margin of the Quick Actions and Refactorings menu.](media/screwdriver.png) icon that appears in the left margin if the text cursor is already on the line with the highlighted expression.

   ![Introduce local preview](media/local-preview-cs.png)

3. Select **Introduce local for (all occurrences) of 'expression'** from the drop-down menu.

   > [!TIP]
   > Use the **Preview changes** link at the bottom of the preview window [to see all of the changes](../../ide/preview-changes.md) that will be made before making your selection.

   The local variable is created, with the type inferred from its usage. Give the new local variable a new name.

   - C#:

       ![Implement interface result C#](media/local-result-cs.png)

   - Visual Basic:

       ![Implement interface result VB](media/local-result-vb.png)

   > [!NOTE]
   > You can use the **...all occurrences of...** menu option to replace every instance of the selected expression, not just the one you have specifically highlighted.

## See also

- [Code generation](../code-generation-in-visual-studio.md)
- [Preview changes](../../ide/preview-changes.md)
