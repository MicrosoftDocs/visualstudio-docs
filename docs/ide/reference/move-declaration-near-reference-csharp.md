---
title: "Move variable declaration near reference in C# | Microsoft Docs"
ms.custom: ""
ms.date: "11/27/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: reference
author: "kuhlenh"
ms.author: "kaseyu"
manager: ghogen
dev_langs: 
  - csharp
ms.workload: 
  - "dotnet"
---
# Move declaration near reference in C# #

**What:** Lets you move variable declarations closer to their usage.

**When:** You have variable declarations that can be in a narrower scope.

**Why:** You could leave it as it is, but that may cause readability issues or information hiding. This is a chance to refactor to improve readability.

**How:**

1. Place your cursor in the variable declaration.

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu and select **Move declaration near reference** from the Preview window popup.
   * **Mouse**
     * Right-click the code, select the **Quick Actions and Refactorings** menu and select **Move declaration near reference** from the Preview window popup.

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

[Refactoring](../refactoring-in-visual-studio.md)  
[Preview Changes](../../ide/preview-changes.md)