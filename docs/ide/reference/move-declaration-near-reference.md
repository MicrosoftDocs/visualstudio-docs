---
title: Move variable declaration near reference
description: Learn how to use the Quick Actions and Refactorings menu to move variable declarations closer to their usage.
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
# Move declaration near reference refactoring

This refactoring applies to:

- C#

- Visual Basic

**What:** Lets you move variable declarations closer to their usage.

**When:** You have variable declarations that can be in a narrower scope.

**Why:** You could leave it as it is, but that may cause readability issues or information hiding. This is a chance to refactor to improve readability.

## How-to

1. Place your cursor in the variable declaration.

1. Next, do one of the following:

   - **Keyboard**
      - Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu and select **Move declaration near reference** from the Preview window popup.
   - **Mouse**
      - Right-click the code, select the **Quick Actions and Refactorings** menu and select **Move declaration near reference** from the Preview window popup.

1. When you're happy with the change, press **Enter** or click the fix in the menu and the changes will be committed.

Example:

```csharp
// Before
int x;
if (condition)
{
    x = 1;
    Console.WriteLine(x);
}

// Move declaration near reference

// After
if (condition)
{
    int x = 1;
    Console.WriteLine(x);
}
```

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
