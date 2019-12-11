---
title: Generate a constructor quick action
ms.date: 01/26/2018
ms.topic: reference
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Generate a constructor in Visual Studio

This code generation applies to:

- C#

- Visual Basic

**What:** Lets you immediately generate the code for a new constructor on a class.

**When:** You introduce a new constructor and want to properly declare it automatically, or you modify an existing constructor.

**Why:** You could declare the constructor before using it, however this feature will generate it, with the proper parameters, automatically. Furthermore, modifying an existing constructor requires updating all the callsites unless you use this feature to update them automatically.

**How:** There are several ways to generate a constructor:

- [Generate constructor and pick members](#pick)
- [Generate constructor from selected fields](#selection)
- [Generate constructor from new usage](#usage)
- [Add parameter to existing constructor](#addparameter)
- [Create and initialize field/property from a constructor parameter](#create)

## <a id = "pick"></a> Generate constructor and pick members (C# only)

1. Place your cursor in any empty line in a class:

   ![Cursor in empty line](media/constructor1-highlight-cs.png)

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Click the ![screwdriver](media/screwdriver.png) icon that appears in the left margin if the text cursor is already on the empty line in the class.

   ![Generate constructor preview](media/constructor1-preview-cs.png)

1. Select **Generate constructor** from the drop-down menu.

   The **Pick members** dialog box opens.

1. Pick the members you want to include as constructor parameters. You can order them using the up and down arrows. Choose **OK**.

   ![Pick members dialog](media/constructor1-dialog-cs.png)

   > [!TIP]
   > You can check the **Add null checks** checkbox to automatically generate null checks for your constructor parameters.

   The constructor is created with the specified parameters.

   ![Generate constructor result](media/constructor1-result-cs.png)

## <a id="selection"></a> Generate constructor from selected fields (C# only)

1. Highlight the members you wish to have in your generated constructor:

   ![Highlight members](media/constructor2-highlight-cs.png)

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Click the ![screwdriver](media/screwdriver.png) icon that appears in the left margin if the text cursor is already on the line with the selection.

      ![Generate Constructor preview](media/constructor2-preview-cs.png)

1. Select **Generate constructor 'TypeName(...)'** from the drop-down menu.

   The constructor is created with the selected parameters.

   ![Generate Constructor result](media/constructor2-result-cs.png)

## <a id="usage"></a> Generate constructor from new usage (C# and Visual Basic)

1. Place your cursor on the line where there is a red squiggle. The red squiggle indicates a call to a constructor that doesn't yet exist.

   - C#:

       ![Highlighted code C#](media/constructor-highlight-cs.png)

   - Visual Basic:

       ![Highlighted code VB](media/constructor-highlight-vb.png)

2. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Hover over the red squiggle and click the ![error light bulb](media/error-bulb.png) icon that appears.
      - Click the ![error light bulb](media/error-bulb.png) icon that appears in the left margin if the text cursor is already on the line with the red squiggle.

      ![Generate constructor preview](media/constructor-preview-cs.png)

3. Select **Generate constructor in '*TypeName*'** from the drop-down menu.

   > [!TIP]
   > Use the **Preview changes** link at the bottom of the preview window [to see all of the changes](../../ide/preview-changes.md) that will be made before making your selection.

   The constructor is created, with any parameters inferred from its usage.

   - C#:

       ![Generate method result C#](media/constructor-result-cs.png)

   - Visual Basic:

       ![Generate method result VB](media/constructor-result-vb.png)

## <a id="addparameter"></a> Add parameter to existing constructor (C# only)

1. Add a parameter to an existing constructor call.

2. Place your cursor on the line where there is a red squiggle indicating you've used a constructor that doesn't yet exist.

    ![Generate constructor highlight](media/constructor4-highlight-cs.png)

3. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Hover over the red squiggle and click the ![error light bulb](media/error-bulb.png) icon that appears.
      - Click the ![error light bulb](media/error-bulb.png) icon that appears in the left margin if the text cursor is already on the line with the red squiggle.

      ![Generate constructor preview](media/constructor4-preview-cs.png)

4. Select **Add parameter to 'TypeName(...)'** from the drop-down menu.

   The parameter is added to the constructor, with its type inferred from its usage.

   ![Generate constructor result](media/constructor4-result-cs.png)

You can also add a parameter to an existing method. For more information, see [Add parameter to a method](add-parameter.md).

## <a id="create"></a> Create and initialize a field or property from a constructor parameter (C# only)

1. Find an existing constructor, and add a parameter:

   ![Generate constructor highlight](media/constructor5-highlight-cs.png)

1. Place your cursor inside the newly added parameter.

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click and select the **Quick Actions and Refactorings** menu.
      - Click the ![screwdriver](media/screwdriver.png) icon that appears in the left margin if the text cursor is already on the line with the added parameter.

   ![Generate constructor preview](media/constructor5-preview-cs.png)

1. Select **Create and initialize property** or **Create and initialize field** from the drop-down menu.

   The field or property is declared and automatically named to match your types. A line of code is also added to initialize the field or property in the constructor body.

   ![Generate constructor result](media/constructor5-result-cs.png)

## See also

- [Code generation](../code-generation-in-visual-studio.md)
- [Preview changes](../../ide/preview-changes.md)