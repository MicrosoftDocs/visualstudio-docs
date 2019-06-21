---
title: Generate parameter
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
# Generate parameter

This refactoring applies to:

- C#

**What:** Automatically generates a method parameter.

**When:** You receive an error from a variable that doesn't exist in the current context you can generate a parameter as a code fix. 

**Why:** You can quickly modify a method signature without losing context.

## How-to

1. Place your cursor in the variable name and press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
1. Select **Generate parameter**.

   ![Generate parameter](media/generate-parameter.png) 

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
