---
title: Razor editor code actions
description: Learn how to use Generate Method, Remove unnecessary directives, and Sort and Consolidate Usings in Razor files in Visual Studio.
ms.date: 05/13/2026
ms.topic: reference
author: nitinme
ms.author: nitinme
ms.subservice: general-ide
---
# Razor editor code actions in Visual Studio

These code actions are available when you edit Razor files in Visual Studio.

**Applies to:** `.razor` files and ASP.NET Core MVC Razor view files (`.cshtml`)

## Generate method

You can generate a method directly from a method call in a Razor file.

1. Place your cursor on a method call that has no matching definition.
1. Press **Ctrl**+**.** to open **Quick Actions and Refactorings**.
1. Select **Generate method**.

Visual Studio creates a method signature based on the call site so you can continue implementing logic.

## Remove unnecessary directives

Unused Razor directives are faded in the editor. You can remove them by using a code action.

1. Place your cursor on a faded `@using` directive.
1. Press **Ctrl**+**.** to open **Quick Actions and Refactorings**.
1. Select **Remove unnecessary directives**.

In MVC Razor views, this cleanup also applies to unnecessary `@addTagHelper` directives.

## Sort and Consolidate Usings

Use this code action to organize Razor `@using` directives.

1. Open a Razor file that contains multiple `@using` directives.
1. Press **Ctrl**+**.** to open **Quick Actions and Refactorings**.
1. Select **Sort and Consolidate Usings**.

This action alphabetizes Razor `@using` directives and removes duplicates.

## Related content

- [Quick Actions](../quick-actions.md)
- [Generate a method](generate-method.md)
- [Code cleanup refactorings](refactoring-code-cleanup.md)
