---
title: Convert Anonymous Type to Tuple
description: Learn how to use the Quick Actions and Refactorings menu to convert an anonymous type to a tuple in Visual Studio.
ms.date: 04/05/2022
ms.topic: reference
ms.custom: "ide-ref"
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# Convert anonymous type to tuple

This refactoring applies to:

- C#

- Visual Basic

**What:** Convert an anonymous type to tuple.

**When:** You have an anonymous type that qualifies as a tuple.

**Why:** [Tuples](/dotnet/csharp/tuples) are helpful in keeping your syntax lightweight. This quick action makes it easier to take advantage of this C# feature.

## How-to

1. Place your cursor in an anonymous type.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Convert Anonymous Type to Tuple](media/convert-anon-to-tuple.png)

2. Press **Enter** to accept the refactoring.

   ![Convert Anonymous Type to Tuple accepted](media/convert-anon-to-tuple-complete.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
