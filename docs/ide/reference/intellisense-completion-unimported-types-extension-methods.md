---
title: IntelliSense completion for types & extension methods
description: How to use IntelliSense completion for types and extension methods that you haven't imported yet with a `using` directive.
ms.date: 07/27/2020
ms.topic: reference
ms.custom: "ide-ref"
author:mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
  - VB
---
# IntelliSense completion for unimported types and extension methods

This refactoring applies to:

- C#

- Visual Basic

**What:** IntelliSense gives completion for unimported types and extension methods.

**When:** You want to use a type or extension methods that already has a dependency in your project but the using statement has not yet been added to your file.

**Why:** You don't have to manually add the using statement to your file.

## How-to

1. Once you start typing the name of a type or extension method that has a dependency in your project, IntelliSense will give you suggestions. Items from unimported namespaces would have their containing namespace shown as suffix.

   > [!TIP]
   > You can show/hide items from unimported namespaces on demand, using the **Expander button (Alt + A)** that appears at the bottom left of the completion list. To change the default behavior, go to **Tools** > **Options** > **Text Editor** > **C#** (or **Visual Basic**) > **IntelliSense** and look for **Show items from unimported namespaces**.

2. Select and commit an unimported item.

   The using statement will be automatically added to your file.

   ![IntelliSense completion for unimported types](media/intellisense-completion-unimported-types.png)

## See also

- [IntelliSense](../using-intellisense.md)
- [Refactoring](../refactoring-in-visual-studio.md)
