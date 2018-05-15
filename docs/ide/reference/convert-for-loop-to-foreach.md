---
title: Refactor code to convert a for loop to a foreach statement
ms.date: 05/10/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
author: gewarren
ms.author: gewarren
manager: douge
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
---
# Refactoring to convert between a for loop and a foreach statement

This article describes the refactorings that convert between two looping structures. It includes some reasons why you might want to switch between a [for](/dotnet/csharp/language-reference/keywords/for) loop and a [foreach](/dotnet/csharp/language-reference/keywords/foreach-in) statement in your code.

## Convert a for loop to a foreach statement

This refactoring applies to:

- C#

If you have a [for](/dotnet/csharp/language-reference/keywords/for) loop in your code, you can use this refactoring to convert it to a [foreach](/dotnet/csharp/language-reference/keywords/foreach-in) statement.

### Why convert

Reasons you might want to convert a [for](/dotnet/csharp/language-reference/keywords/for) loop to a [foreach](/dotnet/csharp/language-reference/keywords/foreach-in) statement include:

- You don't use the iteration count variable inside the loop except as an index to access the item.

- You want to simplify your code and reduce the likelihood of logic errors in the initializer, condition, and iteration statements.

### How to use it

1. Place your cursor on the first line of the `for` loop.

1. Press **Ctrl**+**.** or click the screwdriver ![Screwdriver icon](../media/screwdriver-icon.png) icon in the margin of the code file.

   ![Convert to foreach menu](media/convert-to-foreach.png)

1. Select **Convert to 'foreach'**. Or, select **Preview changes** to open the [Preview Changes](../../ide/preview-changes.md) dialog, and then select **Apply**.

## Convert a foreach statement to a for loop

This refactoring applies to:

- C#

- Visual Basic

If you have a [foreach (C#)](/dotnet/csharp/language-reference/keywords/foreach-in) or [For Each...Next (Visual Basic)](/dotnet/visual-basic/language-reference/statements/for-each-next-statement) statement in your code, you can use this refactoring to convert it to a [for](/dotnet/csharp/language-reference/keywords/for) loop.

### Why convert

Reasons you might want to convert a [foreach](/dotnet/csharp/language-reference/keywords/foreach-in) statement to a [for](/dotnet/csharp/language-reference/keywords/for) loop include:

- You want to use the iteration count variable inside the loop for more than just accessing the item.

- You are [iterating through a multi-dimensional array](/dotnet/csharp/programming-guide/arrays/using-foreach-with-arrays) and you want more control over the array elements.

### How to use it

1. Place your cursor on the first line of the `foreach` or `For Each` statement.

1. Press **Ctrl**+**.** or click the screwdriver ![Screwdriver icon](../media/screwdriver-icon.png) icon in the margin of the code file.

   ![Convert to for menu](media/convert-to-for.png)

1. Select **Convert to 'for'**. Or, select **Preview changes** to open the [Preview Changes](../../ide/preview-changes.md) dialog, and then select **Apply**.

1. Because the refactoring introduces a new iteration count variable, the **Rename** box appears at the top-right corner of the editor. If you want to choose a different name for the variable, type it in and then press **Enter** or select **Apply** in the **Rename** box. If you don't want to choose a new name, press **Esc** or select **Apply** to dismiss the **Rename** box.

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)