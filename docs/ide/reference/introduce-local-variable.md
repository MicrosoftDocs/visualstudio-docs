---
title: Introduce a local variable in Visual Studio
ms.date: 01/26/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Introduce a local variable in Visual Studio

This code generation applies to:

- C#

- Visual Basic

**What:** Lets you immediately generate a local variable to replace an existing expression.

**When:** You have code which could be easily reused later if it were in a local variable.

**Why:** You could copy and paste the code multiple times to use it in various locations, however it would be better to perform the operation once, store the result in a local variable, and use the local variable throughought.

## How-to

1. Highlight the expression that you want to assign to a new local variable.

   - C#:

    ![Highlighted code C#](media/local-highlight-cs.png)

   - Visual Basic:

    ![Highlighted code VB](media/local-highlight-vb.png)

1. Next, do one of the following:

   - **Keyboard**
     - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
     - Right-click and select the **Quick Actions and Refactorings** menu.
     - Click the ![Lightbulb](media/bulb-cs.png) icon which appears in the left margin if the text cursor is already on the line with the red squiggle.

   ![Introduce local preview](media/local-preview-cs.png)

1. Select **Introduce local for (all occurrences of) '*expression*'** from the drop-down menu.

   > [!TIP]
   > Use the **Preview changes** link at the bottom of the preview window [to see all of the changes](../../ide/preview-changes.md) that will be made before making your selection.

   The local variable is created, with the type inferred from its usage. Give the new local variable a new name.

   - C#:

      ![Implement interface result C#](media/local-result-cs.png)

   - Visual Basic:

      ![Implement interface result VB](media/local-result-vb.png)

   > [!NOTE]
   > You can use the **...all occurences of...** menu option to replace every instance of the selected expression, not just the one you have specifically highlighted.

## See also

- [Code Generation](../code-generation-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)