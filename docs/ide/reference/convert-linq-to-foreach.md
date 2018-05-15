---
title: Refactor code to convert a LINQ query to a foreach statement
ms.date: 05/15/2018
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
# Refactoring to convert LINQ to a foreach statement

Use this refactoring to convert [LINQ query syntax](/dotnet/csharp/programming-guide/concepts/linq/query-syntax-and-method-syntax-in-linq) to a [foreach](/dotnet/csharp/language-reference/keywords/foreach-in) statement.

This refactoring applies to:

- C#

## How to use it

1. Select the entire LINQ query starting with `from`.

   > [!NOTE]
   > This refactoring can only be used to convert LINQ queries expressed with query syntax and not method syntax.

1. Press **Ctrl**+**.** or click the screwdriver ![screwdriver icon](../media/screwdriver-icon.png) icon in the margin of the code file.

   ![Convert LINQ to foreach quick actions menu](media/convert-linq-to-foreach.png)

1. Select **Convert to 'foreach'**. Or, select **Preview changes** to open the [Preview Changes](../../ide/preview-changes.md) dialog, and then select **Apply**.

## See also

- [LINQ](/dotnet/standard/using-linq)
- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)