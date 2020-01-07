---
title: Wrap and align call chains
description: Learn how to wrap and align chains of method calls.
ms.date: 08/13/2019
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
---
# Wrap and align call chains

This refactoring applies to:

- C#

**What:** Lets you wrap and align chains of method calls.

**When:** You have a long chain consisting of several method calls in one statement.

**Why:** Reading a long list is easier when they're wrapped or indented according to user preference.

## How-to

1. Place your cursor in any of the call chains.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
3. Select **Wrap call chain** or **Wrap and align call chain** to accept the refactoring.

   ![Wrap and Align Call Chains](media/wrap-call-chain.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
