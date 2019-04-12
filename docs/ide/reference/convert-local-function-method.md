---
title: Convert a local function to a method
ms.date: 02/19/2019
ms.topic: reference
author: kendrahavens
ms.author: kehavens
manager: jillfra
dev_langs:
  - CSharp
  - VB
ms.workload:
  - "dotnet"
---
# Convert a local function to a method

This refactoring applies to:

- C#
- Visual Basic

**What:** Convert a local function to a method.

**When:** You have a local function that you want to define outside of your current local context.

**Why:** You want to convert a local function to a method so that you can call it outside your local context. You might want to convert to a method when your local function is getting too long. Defining it in a separate method makes your code easier to read.

## Convert local function to method refactoring

1. Place your cursor in a local function.

    ![Convert local function to method](media/convert-local-function-to-method.png)

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.

    ![Convert local function to method code fix](media/convert-local-function-to-method-codefix.png)

2. Press Enter to accept the refactoring.

    ![Convert local function to method result](media/convert-local-function-to-method-result.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Tips for .NET Developers](../../ide/visual-studio-2017-for-dotnet-developers.md)
