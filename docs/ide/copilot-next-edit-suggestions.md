---
title: Copilot Next Edit Suggestions
description: Use GitHub Copilot next edit suggestions (NES) to predict where you'll want to make your next edit and what that edit should be, based on your recent code edits.
ms.date: 2/4/2026
ms.update-cycle: 180-days
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Get started with GitHub Copilot next edit suggestions

GitHub Copilot acts as an AI-powered pair programmer, automatically offering inline suggestions to complete your code, comments, tests, and more. Copilot provides two kinds of inline suggestions, both of which take your existing code into account: completions and next edit suggestions.

Copilot next edit suggestions (NES) use your recent edits to anticipate the next edit that you might want to make, and the location of that edit.

Inline [completions](visual-studio-github-copilot-extension.md) are great at autocompleting a section of code. NES helps you stay in the logical edit flow by suggesting changes that are relevant to your current work. You can use the <kbd>Tab</kbd> key to quickly move through and accept suggestions. Suggestions might span a single symbol, an entire line, or multiple lines, depending on the scope of the potential change.

## Prerequisites

- [Visual Studio 2026](/visualstudio/releases/2026/release-notes) or [Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) (with the latest servicing release recommended for the most up-to-date features)
- [Sign in to Visual Studio by using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot).
  
  If you don't yet have a Copilot subscription, you can use [Copilot for free](copilot-free-plan.md) by signing up for the Copilot Free plan and get a monthly limit of inline suggestions and chat interactions.

## Enable NES

:::moniker range="visualstudio"

To get started with Copilot NES, enable the feature in **Tools** > **Options** > **All Settings** > **Text Editor** > **Code Completions** > **General**, and select **Copilot Next Edit Suggestions (Next-edit predictions from Copilot)** in **Code Completions Providers**.

:::moniker-end

:::moniker range="<=vs-2022"

To get started with Copilot NES, enable the feature in the **Tools** > **Options** > **GitHub** > **Copilot** and select **Enable Next Edit Suggestions** in **Copilot Completions**.

:::moniker-end

## Start using NES

To start getting suggestions from NES, start coding. When the feature suggests a code edit, you can move to it by using the <kbd>Tab</kbd> key, and then accept it by using the <kbd>Tab</kbd> key again. You save time by quickly jumping to the next relevant edit, without needing to manually search through files or references yourself. An arrow in the gutter indicates whether an edit suggestion is available.

:::image type="content" source="media/vs-2022/next-edit-suggestions/next-edit-suggestions-arrows.png" alt-text="Screenshot that shows arrows in the gutter to indicate edit suggestions.":::

Select the arrow to explore the edit suggestion menu, which includes keyboard shortcuts.

:::image type="content" source="media/vs-2022/next-edit-suggestions/next-edits-menu.png" alt-text="Screenshot that shows the menu for edit suggestions." lightbox="media/vs-2022/next-edit-suggestions/next-edits-menu.png":::

If an edit suggestion is below the current editor view, the arrow points down instead of right. Scroll past an edit suggestion, and the arrow hints the location of the next edit suggestion by pointing up or down, based on where you are in the file.

:::image type="content" source="media/vs-2022/next-edit-suggestions/arrow-upward.png" alt-text="Screenshot that shows an arrow pointing upward to indicate the location of the next edit suggestion in a file.":::

## Understand use cases

NES is helpful in various scenarios by suggesting not only obvious repetitive changes, but also logical changes. Here are some examples.

### Catch and correct mistakes

NES helps with mistakes like typos; for example, if you wrote `bol` instead of `bool`.

:::image type="content" source="media/vs-2022/next-edit-suggestions/fix-typo.png" alt-text="Screenshot that shows NES suggesting a typo correction.":::

The feature can also help with more challenging mistakes in logic, like an inverted ternary expression or a comparison that should use `||` instead of `&&`.

:::image type="content" source="media/vs-2022/next-edit-suggestions/ternary-expression.png" alt-text="Screenshot that shows NES suggesting a correction for an expression.":::

### Match a change in intent

NES suggests changes to the rest of your code that match a change in intent. The following example shows suggestions after the refactoring of a `Point` class to `Point3D`.

:::image type="content" source="media/vs-2022/next-edit-suggestions/change-in-intent-point-example.gif" alt-text="Animated screenshot that shows NES suggestions for changes in intent updates." lightbox="media/vs-2022/next-edit-suggestions/change-in-intent-point-example.gif":::

### Update code syntax

NES helps with repetitive changes, such as updating code syntax to modern C++ by using the Standard Library (STL). For example, when you update all `printf()` instances to `std::cout`, you also need to update syntax such as `fgets()`.

:::image type="content" source="media/vs-2022/next-edit-suggestions/update-code-syntax.gif" alt-text="Animated screenshot that shows NES suggesting code syntax updates." lightbox="media/vs-2022/next-edit-suggestions/update-code-syntax.gif":::

### Refactor

If you rename a variable once in a file, NES suggests updating it throughout the file. If you introduce a new name or naming pattern, the feature suggests updates to subsequent code to match.

:::image type="content" source="media/vs-2022/next-edit-suggestions/rename-variable-edits.png" alt-text="Screenshot that shows NES suggesting edits when a variable is renamed.":::
  
After you paste some code, NES suggests adjustments to match it with the style of the surrounding code.

## Hide NES

You can hide suggestions from NES in Visual Studio and review them only when you choose.

:::moniker range="visualstudio"

To disable automatic completions, go to **Tools** > **Options** > **All Settings** > **Inline Suggestions** > **General**, and select **Manual** from the **Inline Suggestions Invocation**. You can then manually trigger suggestions with **Alt**+**,** or **Alt**+**.**

:::moniker-end
:::moniker range="<=vs-2022"

To manage when suggestions are displayed, go to **Tools** > **Options** > **GitHub** > **Copilot** > **Copilot Completions**, and select **Collapse Next Edit Suggestions**.

:::moniker-end

Your edits still trigger NES, but when a suggestion is available, only the margin indicator appears in the gutter. This indicator points to the relevant line. The suggestion itself remains hidden until you choose to view it.

:::image type="content" source="media/vs-2022/next-edit-suggestions/next-edit-suggestions-collapse.png" alt-text="Screenshot that shows a gutter arrow when NES is hidden.":::

To view a hidden suggestion, select the margin indicator or select the <kbd>Tab</kbd> key. The suggestion then appears. You can select the <kbd>Tab</kbd> key again to accept the suggestion or select the <kbd>Esc</kbd> key to dismiss it. After you accept a suggestion, any related suggestions appear automatically. Unrelated new suggestions remain hidden until you choose to view them.

In the following example, after a change from `Point` to `Point3D`, an NES suggestion becomes available but doesn't appear immediately. The margin indicator and hint bar highlight a suggestion on line 4, which appears after selection of the indicator.

:::image type="content" source="media/vs-2022/next-edit-suggestions/next-edit-suggestions-collapse-mode.gif" alt-text="Animated screenshot that shows the flow of the NES collapse mode.":::

## Related content

- [GitHub Copilot Completions](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
