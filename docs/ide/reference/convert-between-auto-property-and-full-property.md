---
title: Convert between auto property and full property
description: Learn how to use the Quick Actions and Refactorings menu to convert between an auto-implemented property and a full property.
ms.date: 03/27/2020
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
---
# Convert between auto property and full property

This refactoring applies to:

- C#

**What:** Convert between an auto-implemented property to a full property.

**When:** The logic of the property has changed.

**Why:** You can convert between an auto-implemented property to a full property manually, however this feature will automatically do the work for you. 

## How-to

1. Place your cursor on the property name.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
3. Select from the following two options: 

    Select **Convert to full property**.

    ![Convert auto property to full property](media/convert-auto-property-to-full-property.png)

    Select **Use auto property**. 

    ![Convert full property to auto property](media/convert-full-property-to-auto-property.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
