---
title: Extract local function
description: Turn a fragment of code into its own method by selecting the code and typing Ctrl+R, Ctrl+M.
ms.date: 02/19/2020
ms.topic: reference
author: mikadumont
ms.author: midumont
manager: jillfra
dev_langs:
- CSharp
ms.workload:
- dotnet
---
# Extract local function refactoring

This refactoring applies to:

- C#

**What:** Lets you turn a fragment of code from an existing method into a local function.

**When:** You have a fragment of existing code in some method that needs to be called from a local function.

**Why:** You could copy/paste that code, but that would lead to duplication. A better solution is to refactor that fragment into its own local function.

## How-to

1. Highlight the code to be extracted.

2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu. 

3. Select **Extract local function**.

    ![Extract local function](media/extract-local-function.png)

## See also

- [Refactoring](../refactoring-in-visual-studio.md)
- [Preview Changes](../../ide/preview-changes.md)
