---
title: Generate parameter refactoring
description: Learn how to use the Quick Actions and Refactorings menu to automatically generate a method parameter.
ms.date: 03/10/2020
ms.topic: reference
ms.custom: "ide-ref"
author:mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Generate parameter

This refactoring applies to:

- C#

- Visual Basic

**What:** Automatically generates a method parameter.

**When:** You reference a variable in a method that doesn't exist in the current context and receive an error; you can generate a parameter as a code fix. 

**Why:** You can quickly modify a method signature without losing context.

## How-to

1. Place your cursor in the variable name and press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select **Generate parameter**.

   ![Generate parameter](media/generate-parameter.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
