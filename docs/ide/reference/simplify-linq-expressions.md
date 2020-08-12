---
title: Simplify Linq Expressions
ms.date: 08/12/2020
ms.topic: reference
author: m-redding
ms.author: midumont
manager: jillfra
dev_langs:
  - CSharp
ms.workload: 
  - "dotnet"
---
# Simplify Linq Expressions

This refactoring applies to:

- C#

**What:** Refactoring of instances SomeEnumerableType.Where(someLambda).Single() to SomeEnumerable.Single(someLambda) for Enumerable.Single as well as Enumerable.SingleOrDefault, Enumerable.Last, Enumerable.LastOrDefault, Enumerable.Any, Enumerable.Count, Enumerable.First, Enumerable.FirstOrDefault

**When:**  All instances where the method call Single, SingleOrDefault, etc. does not have any arguments and is preceded by a Where expression. 

**Why:** Using nameof rather than the name of the type avoids reflection, and is a more pragmatic way of writing it.

## How-to

1. Place your cursor somewhere within the SomeEnumerableType.Where(someLambda).Single() instance in visual studio.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
3. Select **Simplify Linq Expression**

   ![Convert typeof to nameof](media/converttypeof.PNG)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
