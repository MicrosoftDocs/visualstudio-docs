---
title: Generate Comparison Operators for IComparable
description: For increased performance, generate Comparison Operators for types that implement IComparable.
ms.date: 05/12/2020
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
---
# Generate Comparison Operators for types that implement IComparable

This code generation applies to:

- C#

**What:** Lets you generate **Comparison** operators for types that implement IComparable.

**When:** You have a type that implements IComparable we will automatically add the comparison operators.

**Why:** If you are implementing a value type, you should consider overriding the **Equals** method to gain increased performance over the default implementation of the Equals method on ValueType.

## How-to

1. Place your cursor either inside the class or on the IComparable keyword.

2. Next, do one of the following:

   - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   - Right-click and select the **Quick Actions and Refactorings** menu.

   - Click the ![screwdriver](../media/screwdriver-icon.png) icon that appears in the left margin.

   ![Generate Comparison Operators](media/generate-comparison-operators.png)

3. Select **Generate Equals(object)** from the drop-down menu.

## See also

- [Code Generation](../code-generation-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
