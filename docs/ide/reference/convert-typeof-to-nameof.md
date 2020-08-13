---
title: Convert typeof to nameof
ms.date: 08/12/2020
ms.topic: reference
author: m-redding
ms.author: midumont
manager: jillfra
dev_langs:
  - CSharp
  - VB
ms.workload: 
  - "dotnet"
---
# Convert typeof(someType).Name instances to nameof(someType)

This refactoring applies to:

- C#
- Visual Basic

**What:** Refactoring of instances of typeof(someType).Name to nameof(someType) in C# and instances of GetType(someType).Name to NameOf(someType) in Visual Basic.

**When:**  All instances of typeof(someType).Name where someType isn't a generic type. This exclusion is necessary because this case doesn't return the same string value as nameof(someType). The same is true for the Visual Basic instance.

**Why:** Using nameof rather than the name of the Type avoids the reflection involved with retrieving a Type object, and is a more pragmatic way of writing it.

## How-to

1. Place your cursor somewhere within the typeof(someType).Name instance in visual studio.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
3. Select **Convert typeof to nameof** or **Convert GetType to NameOf**

   ![Convert typeof to nameof](media/converttypeof.PNG)

   ![Convert typeof to nameof](media/convertgettype.PNG)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
