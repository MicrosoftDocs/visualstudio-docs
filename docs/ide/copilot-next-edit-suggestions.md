---
title: Copilot Next Edit Suggestions
description: Use Copilot Next Edit Suggestions (NES) to predict where you'll want to make your next edit and what that edit should be, based on your recent code edits.
ms.date: 5/13/2025
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Copilot Next Edit Suggestions

Next edit suggestions use recent edits you make to anticipate the next edit you might want to make, and the location of that edit. With this new ability, GitHub Copilot suggests revisions to your code, comments, tests, and more.

Inline completions are great at autocompleting a section of code. Copilot NES helps you stay in the logical edit flow, suggesting changes relevant to your current work, and you can simply `Tab` to quickly navigate and accept Copilot's suggestions. Suggestions may span a single symbol, an entire line, or multiple lines, depending on the scope of the potential change.

## Prerequisites

To get started, you need:
+ Visual Studio 2022 [version 17.14](/visualstudio/releases/2022/release-history) or later
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot) <br/>
  <sup>**</sup> You can use [GitHub Copilot for Free](copilot-free-plan.md). Sign up and leverage AI to code faster and more efficiently.

## Get started with NES

To get started with Copilot NES, enable the feature in **Tools > Options > GitHub > Copilot > Copilot Completions > Enable Next Edit Suggestions**.

## Use next edit suggestions

To start getting suggestions from NES, start coding. When Copilot suggests code edits, you can navigate to it with the `Tab` key, and then accept it with the `Tab` key again. You save time by quickly jumping to the next relevant edit, without needing to manually search through files or references yourself. An arrow in the gutter indicates whether an edit suggestion is available.

:::image type="content" source="media/vs-2022/next-edit-suggestions/next-edit-suggestions-arrows.png" alt-text="Screenshot that shows arrows in gutter indicating next edit suggestions.":::

An arrow in the gutter indicates if there is an edit suggestion available. Click the arrow to explore the edit suggestion menu, which includes keyboard shortcuts.

:::image type="content" source="media/vs-2022/next-edit-suggestions/next-edits-menu.png" alt-text="Screenshot that shows the next edits menu." lightbox="media/vs-2022/next-edit-suggestions/next-edits-menu.png":::

If an edit suggestion is below the current editor view, the arrow points down instead of right. Scroll past an edit suggestion and the arrow hints the location of the next edit suggestion, pointing up or down based on where you're in the file.

:::image type="content" source="media/vs-2022/next-edit-suggestions/arrow-upward.png" alt-text="Screenshot that shows arrow pointing upward to indicate next edit suggestion location in file.":::

## Use cases for Next Edit Suggestions

NES is helpful in various scenarios, not only making obvious repetitive changes, but also logical changes. Here are some examples: 

### Catch and correct mistakes

- NES helps with mistakes like typos, for example, if you wrote `bol` instead of `bool`.

  :::image type="content" source="media/vs-2022/next-edit-suggestions/fix-typo.png" alt-text="Screenshot that shows NES suggesting typo correction.":::

- Copilot can also help with more challenging mistakes in logic, like an inverted ternary expression or a comparison that should use `||` instead of `&&`.

  :::image type="content" source="media/vs-2022/next-edit-suggestions/ternary-expression.png" alt-text="Screenshot that shows NES suggesting the correction for an expression.":::

### Change in intent

NES suggests changes to the rest of your code that match a change in intent. For example, when refactoring a `Point` class to `Point3D`.

:::image type="content" source="media/vs-2022/next-edit-suggestions/change-in-intent-point-example.gif" alt-text="Animated screenshot that shows NES suggestions for change in intent updates." lightbox="media/vs-2022/next-edit-suggestions/change-in-intent-point-example.gif":::

### Update code syntax

NES helps with repetitive changes like updating code synx to modern C++ using Standard library (STL) reference. For example, when updating all `printf()` to `std::cout`, also update other syntax such as `fgets()`.

:::image type="content" source="media/vs-2022/next-edit-suggestions/update-code-syntax.gif" alt-text="Animated screenshot that shows NES suggesting code syntax updates" lightbox="media/vs-2022/next-edit-suggestions/update-code-syntax.gif":::

### Refactor

- Rename a variable once in a file, and NES will suggest updating it throughout the file. If you introduce a new name or naming pattern, Copilot suggests updates to subsequent code to match.

  :::image type="content" source="media/vs-2022/next-edit-suggestions/rename-variable-edits.png" alt-text="Screenshot that shows NES suggesting edits when a variable is renamed":::
  
-  Match code style. After you paste some code, NES suggests adjustments to match it with the style of the surrounding code.

## Related content

- [GitHub Copilot Completions](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
