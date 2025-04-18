---
title: Use lambda expression or block body
description: Learn how to use the Quick Actions and Refactorings menu to refactor a lambda expression to use an expression body or a block body.
ms.date: 02/14/2019
ms.topic: reference
ms.custom: "ide-ref"
author: mikadumont 
ms.author: midumont 
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
---
# Use expression body or block body for lambda expressions

This refactoring applies to:

- C#

**What:** Lets you refactor a lambda expression to use an expression body or a block body.

**When:** You prefer lambda expressions to use either an expression body or a block body.

**Why:** Lambda expressions can be refactored to improve readability according to your user preference.

## Lambda expression body or block body refactoring

1. Place your cursor on the right of a lambda operator.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

  ![Use lambda expression/block body](media/block-body-lambda.png)

3. Select **Use block body for lambda expressions** or **Use expression body for lambda expressions**.

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Productivity features](../productivity-features.md)
