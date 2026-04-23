---
title: Extract and inline refactorings
description: Learn how to use Quick Actions and Refactorings to extract methods, local functions, base classes, and interfaces, or inline methods and temporary variables in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
f1_keywords:
  - vs.csharp.refactoring.extractmethod
  - vs.csharp.refactoring.extractinterface
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Extract and inline refactorings

Visual Studio provides several refactorings for extracting code into new constructs or inlining code to simplify your codebase. You can access these refactorings through the **Quick Actions and Refactorings** menu (**Ctrl**+**.**).

## Extract method

**Applies to:** C#, Visual Basic

This refactoring turns a fragment of code into its own method, reducing duplication when the same code needs to be called from multiple places.

1. Highlight the code to be extracted:

   - C#:

       ![Screenshot of C# code for the Program class. In the Main function of that class, a line of code is highlighted.](media/extractmethod-highlight-cs.png)

   - Visual Basic:

       ![Screenshot of Visual Basic code for the Main Sub. In that Sub, a line of code is highlighted.](media/extractmethod-highlight-vb.png)

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl+R**, then **Ctrl+M**. (Your keyboard shortcut may be different based on which profile you've selected.)
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Extract Method** from the Preview window popup.
   - **Mouse**
      - Select **Edit > Refactor > Extract Method**.
      - Right-click the code and select **Refactor > Extract > Extract Method**.
      - Right-click the code, select the **Quick Actions and Refactorings** menu and select **Extract Method** from the Preview window popup.

   The method will be immediately created. You can now rename the method by typing the new name.

   > [!TIP]
   > You can also update comments and other strings to use this new name, as well as [preview changes](../../ide/preview-changes.md) before saving, using the checkboxes in the **Rename** box that appears at the top right of your IDE.

   - C#:

      ![Screenshot of C# code for the Program class. A method name is highlighted and the Rename popup window is open.](media/extractmethod-rename-cs.png)

   - Visual Basic:

      ![Screenshot of Visual Basic code for the Main Sub. A method name is highlighted and the Rename popup window is open.](media/extractmethod-rename-vb.png)

1. When you're happy with the change, choose the **Apply** button or press **Enter** and the changes will be committed.

## Extract local function

**Applies to:** C#

This refactoring turns a fragment of code from an existing method into a local function, useful when the extracted code only needs to be called within the same method.

1. Highlight the code to be extracted.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select **Extract local function**.

    ![Screenshot of the Visual Studio code window with a line highlighted. The Quick Actions and Refactorings menu is open and Extract local function is selected.](media/extract-local-function.png)

## Extract base class

**Applies to:** C#, Visual Basic

This refactoring extracts members from a selected class to a new base class, useful when you want to share members across classes through inheritance.

1. Place your caret on either the class name or a highlighted member.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select **Pull member(s) up to new base class**.

    ![Screenshot of Extract base class dialog.](media/extract-base-class.png)

The new **Extract Base Class** dialog will open where you can specify the name for the base class and location of where it should be placed. You can select the members that you want to transfer to the new base class and choose to make the members abstract by selecting the checkbox in the Make abstract column.

## Extract interface

**Applies to:** C#, Visual Basic

This refactoring creates an interface using existing members from a class, struct, or interface, enabling other types to share a common signature.

1. Place your cursor in the class name.

   - C#:

       ![Screenshot of Highlighted code for Extract Interface - C#.](media/extractinterface-highlight-cs.png)

   - Visual Basic:

       ![Screenshot of Highlighted code - Visual Basic.](media/extractinterface-highlight-vb.png)

1. Next, do one of the following actions:

   - **Keyboard**
      - Press **Ctrl+R**, then **Ctrl+I**. (Your keyboard shortcut may be different based on which profile you've selected.)
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Extract Interface** from the Preview window popup.
   - **Mouse**
      - Select **Edit > Refactor > Extract Interface**.
      - Right-click the name of the class, select the **Quick Actions and Refactorings** menu and select **Extract Interface** from the Preview window popup.

1. In the **Extract Interface** dialog box that pops up, enter the information asked:

   ![Screenshot of Extract Interface.](media/extractinterface-dialog-same-file.png)

   | Field | Description |
   | - | - |
   | **New interface name** | The name of the interface to be created. The name will default to I*ClassName*, where *ClassName* is the name of the class you selected above. |
   | **New file name** | The name of the generated file that will contain the interface. As with the interface name, this name will default to I*ClassName*, where *ClassName* is the name of the class you selected above. You can also select the option to **Add to current file**. |
   | **Select public members to form interface** | The items to extract into the interface. You may select as many as you wish. |

1. Choose **OK**.

   The interface is created in the file of the name specified. Additionally, the class you selected implements that interface.

   - C#:

      ![Screenshot of Resulting Class - C#.](media/extractinterface-class-cs.png)

      ![Screenshot of Resulting Interface - C#.](media/extractinterface-interface-cs.png)

   - Visual Basic:

      ![Screenshot of Resulting Class - Visual Basic.](media/extractinterface-class-vb.png)

      ![Screenshot of Resulting Interface - Visual Basic.](media/extractinterface-interface-vb.png)

## Inline method

**Applies to:** C#, Visual Basic

This refactoring replaces usages of a static, instance, or extension method within a single statement body with its implementation, with an option to remove the original method declaration.

1. Place your caret on the usage of the method.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select from one of the following options:

   Select **Inline `<QualifiedMethodName>`** to remove the inline method declaration:

    ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'Inline 'CreateWidget()' selected and C# code changes shown.](media/inline-method-remove-declaration.png)

   Select **Inline and keep `<QualifiedMethodName>`** to preserve the original method declaration:

    ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'Inline and keep 'CreateWidget()' selected and C# code changes shown.](media/inline-method-preserve-declaration.png)

## Inline temporary variable

**Applies to:** C#, Visual Basic

This refactoring removes a temporary variable and replaces it with its value instead, simplifying code when the temporary variable makes the code harder to understand.

1. Highlight or place the text cursor inside the temporary variable to be inlined:

   - C#:

       ![Screenshot of Highlighted code for Inline Temporary Variable - C#.](media/inline-highlight-cs.png)

   - Visual Basic:

       ![Screenshot of Highlighted code- Visual Basic.](media/inline-highlight-vb.png)

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   - **Mouse**
      - Right-click the code and select the **Quick Actions and Refactorings** menu.

1. Select **Inline temporary variable** from the Preview window popup.

   The variable is removed and its usages replaced by the value of the variable.

   - C#:

      ![Screenshot of Inline result - C#.](media/inline-result-cs.png)

   - Visual Basic:

      ![Screenshot of Inline result - Visual Basic.](media/inline-result-vb.png)

## Related content

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
