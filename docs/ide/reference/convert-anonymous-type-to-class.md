---
title: Convert Anonymous Type to Class
description: Learn how to use the Quick Actions and Refactorings menu to convert an anonymous type to a class in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 03/10/2020
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jmartens
ms.technology: vs-ide-general
dev_langs:
  - CSharp
  - VB
ms.workload:
  - "dotnet"
monikerRange: '>= vs-2019'
---
# Convert anonymous type to class

This refactoring applies to:

- C#

- Visual Basic

**What:** Convert an anonymous type to class.

**When:** You have an anonymous type that you want to continue to build on in a class.

**Why:** Anonymous types are useful if you're only using them locally. As your code grows, it's nice to have an easy way to promote them to a class.

## How-to

1. Place your cursor in an anonymous type.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Convert Anonymous Type to Class](media/convert-anon-to-class.png)

2. Press **Enter** to accept the refactoring.

   ![Convert Anonymous Type to Class accepted](media/convert-anon-to-class-complete.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
