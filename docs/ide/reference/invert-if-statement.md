---
title: Invert if statement
description: Learn how to use the Quick Actions and Refactorings menu to invert an if or if else statement without changing the meaning of the code.
ms.custom: SEO-VS-2020
ms.date: 02/19/2019
ms.topic: reference
author: kendrahavens
ms.author: kehavens
manager: jmartens
ms.technology: vs-ide-general
dev_langs:
  - CSharp
  - VB
ms.workload:
  - "dotnet"
---
# Invert if statement

This refactoring applies to:

- C#
- Visual Basic

**What:** Lets you invert an `if` or `if else` statement without changing the meaning of the code.

**When:** When you have an `if` or `if else` statement that would be better understood when inverted.

**Why:** Inverting an `if` or `if else` statement by hand can take much longer and possibly introduce errors. This code fix helps you do this refactoring automatically.

## Invert if statement refactoring

1. Place your cursor in an `if` or `if else` statement.

    ![Invert if else](media/invert-if.png)

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

    ![Invert if else code fix](media/invert-if-codefix.png)

3. Select **Invert if**.

    ![Invert if else result](media/invert-if-codefix-result.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Tips for .NET Developers](../csharp-developer-productivity.md)
