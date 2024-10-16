---
title: Convert between regular and verbatim string literals
description: Learn how to use the Quick Actions and Refactorings menu to convert between regular string and verbatim string literals.
ms.date: 06/08/2020
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
---
# Convert between regular string and verbatim string literals refactoring

This refactoring applies to:

- C#

**What:** Lets you convert between regular string and verbatim string literals.

**When:** You either want to save space or provide more clarity in your code.

**Why:** Converting a verbatim string literal to a regular string literal can help save space. Converting a regular string literal to a verbatim string literal can provide more clarity.

## How-to

1. Place your caret on either the regular string or verbatim string literal:

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

3. Select from one of the following options:

    Select **Convert to regular string**.

    ![Convert to regular string](media/convert-to-regular-string.png)

    Select **Convert to verbatim string**.

    ![Convert to verbatim string](media/convert-to-verbatim-string.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)