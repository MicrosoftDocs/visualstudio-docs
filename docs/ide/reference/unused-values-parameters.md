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

**What:** Unused parameters are faded out and unused expression values have a warning.

**When:** You have parameters or expression values that are never used.

**Why:** Sometimes it's difficult to tell if a value or parameter is no longer being used. By fading out these values or giving a warning, you get a visual cue of what code you can delete.

## How-to

1. Have any expression value or parameter that isn't used.
2. The unused parameter appears faded out. The unused expression value receives a warning.

  ![Unused parameter](media/unused-parameter.png)
  ![Unused value](media/unused-value.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
