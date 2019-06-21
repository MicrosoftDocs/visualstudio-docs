---
title: IntelliSense completion for unimported types
description: How to use IntelliSense completion for types that you haven't imported yet with a `using` directive.
ms.date: 06/20/2019
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jillfra
dev_langs:
  - CSharp
ms.workload: 
  - "dotnet"
---
# IntelliSense completion for unimported types

This refactoring applies to:

- C#

**What:** IntelliSense gives completion for unimported types.

**When:** You want to add a type that already has a dependency in your project but the import statement has not yet been added to your file. 

**Why:** You don't have to manually add the import statement to your file.

## How-to

1. Once you start using a type that has a dependency in your project, IntelliSense will give you suggestions.
2. Press **Tab**. 

   The import statement will be added to your file.

   ![IntelliSense completion for unimported types](media/intellisense-completion-unimported-types.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
