---
title: Unused values and parameters
ms.date: 02/15/2019
ms.topic: reference
author: kendrahavens
ms.author: kendrahavens
manager: jillfra
dev_langs:
  - CSharp
  - VB
ms.workload:
  - "dotnet"
---
# Unused expression values and parameters

This refactoring applies to:

- C#
- Visual Basic

**What:** Unused expression values or parameters are faded out.

**When:** When you have paramters or expression values that are never actually used.

**Why:** Sometimes it's difficult to tell if a value or parameter is no longer being used. By fading out these values you get a visual cue of what code you can delete.

## How-to

1. Have any expression value or parameter that isn't used.
2. The unused expression value or parameter will appear faded out.

  ![Unused parameter](media/unused-parameter.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
