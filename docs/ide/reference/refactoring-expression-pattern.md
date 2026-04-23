---
title: Expression and pattern refactorings
description: Learn how to use Quick Actions and Refactorings to apply new(), pattern matching, and lambda expression body or block body refactorings in Visual Studio.
ms.date: 04/03/2026
ms.topic: reference
ms.custom: awp-ai
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
---
# Expression and pattern refactorings

Visual Studio provides several refactorings for modernizing C# syntax with newer language features. You can access these refactorings through the **Quick Actions and Refactorings** menu (**Ctrl**+**.**).

## Use new()

**Applies to:** C#

This refactoring uses `new()` (target-typed new expressions) so you don't have to write repetitive code by repeating the type twice. It's useful when you can't use `var` or have a code style preference to not use `var`.

1. Place your caret on the field declaration.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select **Use 'new(…)'**:

    ![Screenshot of Use 'new(...)'.](media/use-new.png)

## Use pattern matching

**Applies to:** C#

This refactoring applies [C# pattern matching](/dotnet/csharp/whats-new/csharp-9#pattern-matching-enhancements) capabilities to make code more clear and concise.

1. Place your caret inside the statement.

1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

1. Select **Use pattern matching**.

    ![Screenshot of Make class abstract.](media/use-pattern-matching-not-syntax.png)

## Use expression body or block body for lambda expressions

**Applies to:** C#

This refactoring converts a lambda expression to use either an expression body or a block body, according to your preference.

1. Place your cursor on the right of a lambda operator.
1. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

  ![Screenshot of Use lambda expression/block body.](media/block-body-lambda.png)

1. Select **Use block body for lambda expressions** or **Use expression body for lambda expressions**.

## Related content

- [Refactoring](../refactoring-in-visual-studio.md)
