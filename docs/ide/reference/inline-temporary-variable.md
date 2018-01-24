---
title: "Replace a temporary variable with its value in C# | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: reference
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---
# Inline a temporary variable with C# #

**What:** Lets you remove a temporary variable and replace it with its value instead.

**When:** The use of the temporary variable makes the code harder to understand.

**Why:** Removing a temporary variable may make the code easier to read.

**How:**

1. Highlight or place the text cursor inside the temporary variable to be inlined:

   ![Highlighted code](media/inline-highlight-cs.png)

1. Next, do one of the following:
   * **Keyboard**
     * Press **Ctrl+.** to trigger the **Quick Actions and Refactorings** menu.
   * **Mouse**
     * Right-click the code and select the **Quick Actions and Refactorings** menu.

1. Select **Inline temporary variable** from the Preview window popup.

   The variable will be removed and its usages replaced by the value of the variable immediately.

   ![Inline result](media/inline-result-cs.png)

## See also

[Refactoring](../refactoring-in-visual-studio.md)