---
title: Invert conditional expressions and logical operations
ms.date: 02/15/2019
ms.topic: reference
author: kendrahavens
ms.author: kendrahavens
manager: jillfra
dev_langs:
  - CSharp
  - VB
ms.workload:
  - "dotnet"
---
# Invert conditional expressions and conditional AND/OR operators

This refactoring applies to:

- C#
- Visual Basic

**What:** Lets you invert a conditional expression or a logical operation.

**When:** When you have a condition expression or logical operation that would be better understood if inverted.

**Why:** Inverting an experssion or operation by hand can take much longer and possibly introduce errors. This refactoring helps

## How-to

1. Place your cursor in a conditional expression or logical operation.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
3. Select **Invert conditional** or **Replace '&&' with '||'**
  ![Invert conditional](media/invert-conditional.png)
  ![Invert conditional](media/invert-logical-operator.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
