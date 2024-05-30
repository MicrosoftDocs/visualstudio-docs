---
title: Convert switch statement to switch expression
description: Learn how to use the Quick Actions and Refactorings menu to convert a switch statement to a C# 8.0 switch expression.
ms.date: 06/19/2019
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
---
# Convert switch statement to switch expression

This refactoring applies to:

- C#

**What:** Convert a [switch statement](/dotnet/csharp/language-reference/keywords/switch) to a C# 8.0 [switch expression](/dotnet/csharp/whats-new/csharp-8#switch-expressions).

**When:** You want to convert a `switch` statement to a `switch` expression and vice versa. 

**Why:** If you are only using expressions, this refactoring enables an easy transition from traditional `switch` statements.

## How-to

1. In your project file, [set the language version to preview](/dotnet/csharp/language-reference/configure-language-version#edit-the-project-file) since `switch` expressions are a new C# 8.0 feature.
2. Place your cursor in the `switch` keyword and press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
3. Select **Convert switch statement to expression**.

   ![Convert switch statement to switch expression](media/convert-switch-statement-to-switch-expression.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
