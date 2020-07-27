---
title: IntelliSense completion for unimported types and extension methods
description: How to use IntelliSense completion for types and extension methods that you haven't imported yet with a `using` directive.
ms.date: 03/10/2020
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jillfra
dev_langs:
  - CSharp
  - VB

ms.workload: 
  - "dotnet"
---
# IntelliSense completion for unimported types and extension methods

This refactoring applies to:

- C#

- Visual Basic

**What:** IntelliSense gives completion for unimported types and extension methods.

**When:** You want to use a type or extension methods that already has a dependency in your project but the import statement has not yet been added to your file. 

**Why:** You don't have to manually add the import statement to your file.

## How-to

1. Once you start typing the name of a type or extension method that has a dependency in your project, IntelliSense will give you suggestions.
2. Press **Tab**. 

   The import statement will be added to your file.

   ![IntelliSense completion for unimported types](media/intellisense-completion-unimported-types.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
