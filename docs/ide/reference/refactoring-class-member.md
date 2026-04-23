---
title: Class and member refactorings
description: Learn how to use Quick Actions and Refactorings to change method signatures, pull members up, make classes abstract, make members static, convert local functions, and work with static local functions in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
f1_keywords:
  - vs.csharp.refactoring.remove
  - vs.csharp.refactoring.reorder
  - vs.csharp.refactoring.make.local.function.static
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Class and member refactorings

Visual Studio provides several refactorings for reorganizing class members and modifying method signatures. You can access these refactorings through the **Quick Actions and Refactorings** menu (**Ctrl**+**.**).

## Change method signature

**Applies to:** C#, Visual Basic

This refactoring lets you remove, reorder, or add a method's parameters, automatically updating all call sites.

1. Highlight or place the text cursor inside the name of the method to modify, or one of its usages:

   - C#:

       ![Screenshot of Highlighted code C#.](media/changesignature-highlight-cs.png)

   - VB:

       ![Screenshot of Highlighted code Visual Basic.](media/changesignature-highlight-vb.png)

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl+R**, then **Ctrl+V**. (Your keyboard shortcut may be different based on which profile you've selected.)
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Change Signature** from the Preview window popup.
   - **Mouse**
      - Select **Edit > Refactor > Remove Parameters**.
      - Select **Edit > Refactor > Reorder Parameters**.
      - Right-click the code, select the **Quick Actions and Refactorings** menu and select **Change Signature** from the Preview window popup.

1. In the **Change Signature** dialog that pops up, you can use the buttons on the right side to change the method signature:

   ![Screenshot of Change Signature dialog.](media/change-signature.png)

   | Button | Description
   | ------ | ---
   | **Up/Down** | Move the selected parameter up and down the list
   | **Add** | Add a new parameter to the list
   | **Remove** | Remove the selected parameter from the list
   | **Restore** | Restore the selected, crossed-out parameter to the list

   > [!TIP]
   > Use the **Preview reference changes** checkbox to [see what the result will be](../../ide/preview-changes.md) before committing to it.

1. Selecting **Add** in the **Change Signature** dialog opens the **Add Parameter** dialog. The **Add Parameter** dialog allows you to add a type name and a parameter name. You can choose to make the parameter required or optional with a default value. You can then add a value at the call site and choose a named argument for that value or you can introduce a TODO variable. The TODO variable puts a TODO in your code so you can visit each error and go through each call site independently and decide what to pass. For optional parameters you have the option to omit the call site completely.

    ![Screenshot of Add Parameter dialog - C#.](media/add-parameter-dialog.png)

1. When you are finished adding a parameter, press **OK** to preview the changes.

    ![Screenshot of Change Signature dialog showing added parameter.](media/change-signature.png)

## Pull members up

**Applies to:** C#, Visual Basic

This refactoring pulls members up to the base type so that other implementations of the interface inherit those members as well.

1. Place your cursor in any member of an implemented interface.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Pull Members up.](media/pull-members-up.png)

1. Select **Pull Members up to base type**.

1. In the dialog, select what members you would like to add to the selected interface.

   ![Screenshot of Pull Member up.](media/pull-members-up-dialog.png)

1. Choose **OK**. The selected members are pulled up to the interface.

   ![Screenshot of Pull Member up completed.](media/pull-members-up-completed.png)

## Make class abstract

**Applies to:** C#, Visual Basic

This refactoring automatically marks a class as abstract when you write an abstract method in a class that isn't abstract.

1. Place your caret on the abstract method.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select **Make class 'abstract'**.

    ![Screenshot of Make class abstract.](media/make-class-abstract.png)

## Make member static

**Applies to:** C#

This refactoring converts a non-static member to static, improving readability by making it clear that the code is isolated.

1. Place your caret on the member name.

1. Press **Ctrl**+**.** (period) to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Make member static.](media/make-member-static.png)

1. Select **Make static**.

## Convert local function to method

**Applies to:** C#

This refactoring converts a local function to a class method, useful when the function needs to be called outside its containing method.

1. Place your cursor in the local function.

    ![Screenshot of Convert a local function to a method code sample.](media/convert-local-function-to-method.png)

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

    ![Screenshot of Convert local function to method code fix sample.](media/convert-local-function-to-method-codefix.png)

1. Press **Enter** to accept the refactoring.

    ![Screenshot of Convert local function to method result sample.](media/convert-local-function-to-method-result.png)

## Static local function refactorings

**Applies to:** C#

This section covers two related features: making a local function static, and passing variables explicitly into static local functions.

### Make local function static

This refactoring makes a local function static and passes in variables defined outside the function to the function's declaration and calls. Static local functions improve readability by isolating code and preventing pollution of a class with a static function that's only called in a single method.

1. Place your caret on the local function name.

1. Press **Ctrl**+**.** (period) to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Make local function static.](media/make-local-function-static.png)

1. Select **Make local function 'static'.**

### Pass variable explicitly in a static local function

This Quick Action passes a variable explicitly into a local static function, useful when you want a local function to be static but still use variables initialized outside of it.

1. Place your caret on the variable where it's used in the static local function.

1. Press **Ctrl**+**.** (period) to trigger the **Quick Actions and Refactorings** menu.

   ![Screenshot of Pass variable explicitly in static local function.](media/pass-variable-explicitly-static-local-function.png)

1. Select **Pass variable explicitly in local static function**.

## Related content

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
