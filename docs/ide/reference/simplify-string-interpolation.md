---
title: Simplify string interpolation
ms.date: 02/12/2020
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
---
# Simplify string interpolation refactoring

This refactoring applies to:

- C#

**What:** Lets you simplify a [string interpolation](https://docs.microsoft.com/dotnet/csharp/tutorials/string-interpolation).

**When:** You have a string interpolation that can be simplified.

**Why:** Simplifying a string interpolation can provide more clarity and concise syntax. This refactoring tool will perform the task automatically instead of having to do it manually.

## How-to

1. Place your caret on the string interpolation:

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

3. Select **Simplify interpolation**

    ![Simplify string interpolation](media/simplify-string-interpolation.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)