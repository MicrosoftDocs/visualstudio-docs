---
title: Conditional and logic refactorings
description: Learn how to use Quick Actions and Refactorings to convert, invert, split, merge, and simplify conditional statements and logic operators in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Conditional and logic refactorings

Visual Studio provides several refactorings for working with conditional statements and logic operators. You can access these refactorings through the **Quick Actions and Refactorings** menu (**Ctrl**+**.**).

## Convert if statement to switch statement or switch expression

**Applies to:** C#

This refactoring converts an `if` statement to a [switch statement](/dotnet/csharp/language-reference/keywords/switch) or a C# 8.0 [switch expression](/dotnet/csharp/whats-new/csharp-8#switch-expressions), and vice versa. It's useful when an `if` statement would be clearer as a `switch`.

1. Place your cursor in the `if` keyword.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select one of the following options:

    - Select **Convert to 'switch' statement**.

      ![Screenshot of Convert if statement to switch statement.](media/convert-if-to-switch-statement.png)

    - Select **Convert to 'switch' expression**.

      ![Screenshot of Convert if statement to switch expression.](media/convert-if-to-switch-expression.png)

## Convert switch statement to switch expression

**Applies to:** C#

This refactoring converts a [switch statement](/dotnet/csharp/language-reference/keywords/switch) to a C# 8.0 [switch expression](/dotnet/csharp/whats-new/csharp-8#switch-expressions), and vice versa. If you're only using expressions, switch expressions provide a more concise syntax.

1. Place your cursor in the `switch` keyword.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select **Convert switch statement to expression**.

   ![Screenshot of Convert switch statement to switch expression.](media/convert-switch-statement-to-switch-expression.png)

## Invert if statement

**Applies to:** C#, Visual Basic

This refactoring inverts an `if` or `if else` statement without changing the meaning of the code. It's useful when the inverted form is easier to understand.

1. Place your cursor in an `if` or `if else` statement.

    ![Screenshot of Invert if else.](media/invert-if.png)

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

    ![Screenshot of Invert if else code fix.](media/invert-if-codefix.png)

1. Select **Invert if**.

    ![Screenshot of Invert if else result.](media/invert-if-codefix-result.png)

## Invert conditional expressions and conditional AND/OR operators

**Applies to:** C#, Visual Basic

This refactoring inverts a conditional expression or a conditional AND/OR operator. It's useful when the inverted form is easier to understand, and avoids errors from doing the inversion by hand.

1. Place your cursor in a conditional expression or a conditional AND/OR operator.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select **Invert conditional** or **Replace '&&' with '||'**.

    ![Screenshot of the Invert conditional option.](media/invert-conditional.png)

    ![Screenshot of the Replace && with || option.](media/invert-logical-operator.png)

## Split or merge if statements

**Applies to:** C#, Visual Basic

This refactoring splits an `if` statement that uses `&&` or `||` operators into a nested `if` statement, or merges an inner `if` statement with an outer `if` statement.

### Split an if statement

1. Place your cursor in the `if` statement by the `&&` or `||` operator.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

    ![Screenshot of Split If Statement.](../media/split-if-statement.png)

1. Select **Split into nested if statements**.

    ![Screenshot of Split If Statement Complete.](../media/split-if-statement-complete.png)

### Merge an if statement

1. Place your cursor in the inner `if` keyword.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

    ![Screenshot of Merge If Statement](../media/merge-if-statement.png)

1. Select **Merge with outer if statement**.

    ![Screenshot of Merge If Statement Complete.](../media/merge-if-statement-complete.png)

## Simplify conditional expression

**Applies to:** C#

This refactoring simplifies a [conditional expression](/dotnet/csharp/language-reference/operators/conditional-operator) by removing unnecessary code, providing more clarity and concise syntax.

1. Place your cursor on the conditional expression.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select **Simplify conditional expression**.

    ![Screenshot of Simplify conditional expression.](media/simplify-conditional-expression.png)

## Related content

- [Refactoring](../refactoring-in-visual-studio.md)
