---
title: Convert switch statement to switch expression
ms.date: 06/19/2019
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jillfra
dev_langs:
  - CSharp
ms.workload: 
  - "dotnet"
---
# Convert switch statement to switch expression

This refactoring applies to:

- C#

**What:** Convert switch statement to switch expression.

**When:** You want to convert a `switch` statement to a `switch` expression and vice versa. 

**Why:** If you are only using expressions this will allow an easy transition from traditional switch statements.

## How-to

1. In your project file make sure the language version is set to preview since switch expressions are a new C# 8.0 feature.
2. Place your cursor in the switch keyword and press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
3. Select **Convert switch statement to expression**.

   ![Convert switch statement to switch expression](media/convert-switch-statement-to-switch-expression.png) 

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
