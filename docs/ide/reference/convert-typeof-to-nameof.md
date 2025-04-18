---
title: Convert typeof to nameof
description: Learn how to use the Quick Actions and Refactorings menu in Visual Studio to convert typeof to nameof in C# and GetType to NameOf in Visual Basic.
ms.date: 08/12/2020
ms.topic: reference
ms.custom: "ide-ref"
author: m-redding
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Convert `typeof` to `nameof`

This refactoring applies to:

- C#
- Visual Basic

**What:** Lets you convert an instance of `typeof(<QualifiedType>).Name` to `nameof(<QualifiedType>)` in C# and an instance of `GetType(<QualifiedType>).Name` to `NameOf(<QualifiedType>)` in Visual Basic.

**When:**  All instances of `typeof(<QualifiedType>).Name` where `someType` isn't a generic type. This exclusion is necessary because this case doesn't return the same string value as `nameof(<QualifiedType>)`. The same is true for the Visual Basic instance.

**Why:** Using `nameof` rather than the name of the `type` avoids the reflection involved with retrieving a `type` object, and is a more pragmatic way of writing it.

## How-to

1. Place your cursor within the `typeof(<QualifiedType>).Name` instance for C# or the `GetType(<QualifiedType>).Name` in Visual Basic.

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

3. Select from one of the following options:

    - C#
      <br>Select **Convert 'typeof' to 'nameof'**:
      ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'typeof' to 'nameof' selected, and C# code changes shown.](media/convert-type-of.PNG)

    - Visual Basic
      <br>Select **Convert 'GetType' to 'NameOf'**:
      ![Screenshot of the Quick Actions and Refactorings menu in Visual Studio with Convert 'GetType' to 'NameOf' selected and Visual Basic code changes shown.](media/convert-get-type.PNG)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
