---
title: Convert foreach loop to LINQ
ms.date: 02/20/2019
ms.topic: reference
author: kendrahavens
ms.author: kehavens
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
---
# Convert foreach loop to LINQ

This refactoring applies to:

- C#

**What:** Lets you easily convert your foreach loops using IEnumerables to LINQ query or LINQ call form (also known as LINQ method).

**When:** When you have a foreach loop that uses an IEnumerable that you prefer to read as a LINQ query.

**Why:** Sometimes users may prefer using LINQ syntax rather that a foreach loop. [LINQ](/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq) makes a query a first-class language construct in C#. LINQ can reduce the amount of code in a file, make it easier to read, and allow different data sources to have similar query expression patterns.

> [!NOTE]
> LINQ syntax is typically less performant than foreach loops. It's good to be aware of any performace trade off you may cause when improving the readability of your code with LINQ.

## Convert foreach loop to LINQ refactoring

1. Place your cursor in the `foreach` keyword.

    ![Foreach using IEnumerable](media/convert-foreach-to-LINQ.png)

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

   ![Convert to LINQ menu](media/convert-foreach-to-LINQ-codefix.png)

3. Select **Convert to LINQ** or **Convert to Linq (call form)**

   ![LINQ query result](media/convert-foreach-to-LINQ-result.png)
   
   ![LINQ call form result](media/convert-foreach-to-LINQ-callform-result.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
- [Tips for .NET Developers](../../ide/visual-studio-2017-for-dotnet-developers.md)