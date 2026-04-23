---
title: Copilot Completions
description: Get code suggestions and completions from GitHub Copilot in Visual Studio.
ms.date: 04/20/2026
ms.update-cycle: 180-days
ms.topic: overview
author: RoseHJM
ms.author: rosemalcolm
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
ai-usage: ai-assisted
ms.custom: awp-ai
---
# Get started with GitHub Copilot completions

GitHub Copilot acts as an AI-powered pair programmer for Visual Studio that provides you with context-aware code completions, suggestions, and even entire code snippets. It provides these suggestions directly in the editor while you write your code, and it can work with a broad range of programming languages and frameworks.

Copilot provides two kinds of inline suggestions, both of which take your existing code into account:

- **Completions** - As you type in the editor, Copilot provides ghost text suggestions with colorized syntax highlighting at your current cursor location.
- **Next edit suggestions** - Based on your current editing patterns, NES predicts both where your next code edit will be and what changes you'll make.

## How GitHub Copilot works

GitHub Copilot works by using advanced machine-learning models trained on a vast dataset of publicly available code from GitHub repositories. As you type code, AI analyzes the context and provides relevant suggestions in real time. You can also receive suggestions by writing a comment in natural language that describes what you want the code to do.

:::image type="content" source="media/vs-2022/github-copilot-extension-example.gif" alt-text="Animated screenshot that shows code completion capabilities of GitHub Copilot.":::

You can also use GitHub Copilot to convert comments to code, create unit tests, create SQL queries, and more.

## Prerequisites

- [Visual Studio 2026](/visualstudio/releases/2026/release-notes) or [Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) (with the latest servicing release recommended for the most up-to-date features)
- [Sign in to Visual Studio by using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot).
  
> [!NOTE]
> As of April 20, 2026, all GitHub Copilot Pro trials, including existing trials, have been paused. New signups and enrollments for paid individual tiers — including Student, Pro, and Pro+ — are temporarily closed. If you were already on a Copilot trial, you can switch to [Copilot Free](copilot-free-plan.md) or upgrade to a Copilot Pro or Pro+ subscription. For the latest information and support, see https://docs.github.com/en/copilot/get-started/plans.

If you don't yet have a Copilot subscription, you can use [Copilot for free](copilot-free-plan.md) by signing up for the Copilot Free plan and get a monthly limit of inline suggestions and chat interactions.

## Get your first code completions

As you type code or comments in the editor, GitHub Copilot provides ghost text code suggestions: sometimes the completion of the current line, sometimes a whole new block of code. You can accept all, or part of a suggestion, or you can keep typing and ignore the suggestions.

GitHub Copilot provides suggestions for numerous languages, including (but not limited to) C#, C++, and Python. The following examples are in C#, but other languages work similarly.

1. Open Visual Studio and create a new C# project.

1. Open a C# file (`Program.cs`) in the code editor.

1. In the editor, enter a comment or a method signature to see inline code suggestions from Copilot.

   ```csharp
       // method to add two numbers
   ```

   ```csharp
       int subtractNumbers(
   ```

:::moniker range="visualstudio"

4. Press <kbd>Enter</kbd> to open the GitHub Copilot command palette.

   To accept the suggestion, select the <kbd>Tab</kbd> key. To reject the suggestion, select the <kbd>Esc</kbd> key or continue typing.

   :::image type="content" source="media/visualstudio/visual-studio-github-copilot-extension/copilot-accept-code-suggestions.png" alt-text="Screenshot that shows suggestions to accept or modify a GitHub Copilot code suggestion in Visual Studio.":::

:::moniker-end

:::moniker range="vs-2022"

4. Select the arrow in the left margin to see the Copilot command menu.

   To accept the suggestion, select the <kbd>Tab</kbd> key. To reject the suggestion, continue typing.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/copilot-accept-code-suggestions.png" alt-text="Screenshot that shows suggestions to accept or modify a GitHub Copilot code suggestion in Visual Studio.":::

:::moniker-end

5. Add the following code to see completions from Copilot:

   ```csharp
       int a = 5;
       int b = 10;
       int sum
   ```
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-whole-line-completions.gif" alt-text="Animated screenshot that shows the use of the GitHub Copilot completions in Visual Studio.":::

## Generate documentation comments

To use automatic generation of documentation comments on your C++ or C# project file, type the comment pattern according to your configuration (for example, `///`). Copilot instantly completes the function description based on the function's content.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/doc-comments-generation.gif" alt-text="Animated screenshot that shows the automatic generation of documentation comments from Copilot." lightbox="media/vs-2022/visual-studio-github-copilot-extension/doc-comments-generation.gif":::

## Tips and tricks

:::moniker range="visualstudio"

### Click to accept code completions

You can accept part of an inline completion by clicking inside the suggestion.

:::image type="content" source="media/visualstudio/visual-studio-github-copilot-extension/click-to-accept.gif" alt-text="Animated screenshot showing an inline Copilot completion where hovering highlights a segment and clicking accepts the completion up to the cursor position.":::

1. When an inline suggestion appears, hover over it. As you move the pointer, Visual Studio highlights the segment that will be accepted.
1. Click at the point in the suggestion where you want to stop accepting text.

If you prefer using the keyboard, you can still accept a completion word by word (<kbd>Ctrl</kbd>+<kbd>Right arrow</kbd>) or line by line (<kbd>Ctrl</kbd>+<kbd>Down arrow</kbd>).

:::moniker-end

### Keyboard shortcuts

The following table lists the default keyboard shortcuts for Copilot inline suggestions. You can [customize these shortcuts](#customize-copilot-keyboard-shortcuts) to match your preferences.

- Manually trigger a completion: <kbd>Alt</kbd>+<kbd>.</kbd> or <kbd>Alt</kbd>+<kbd>,</kbd>
- Cycle through available completions: <kbd>Alt</kbd>+<kbd>.</kbd> (next) and <kbd>Alt</kbd>+<kbd>,</kbd> (previous)
- Partially accept a completion word by word: <kbd>Ctrl</kbd>+<kbd>Right arrow</kbd>
- Partially accept a completion line by line: <kbd>Ctrl</kbd>+<kbd>Down arrow</kbd>

### Customize your experience 

:::moniker range="visualstudio"

All inline suggestions settings can be found via **Tools** > **Options** > **Text Editor** > **Inline Suggestions**. You can also access this settings page via shortcuts from the Copilot badge menu, or via the context menu from Copilot inline suggestions margin indicator.

Customize your inline suggestions experience with these settings:

- **Disable automatic completions** - By default, each keystroke triggers inline suggestions. To disable this, go to **Tools** > **Options** > **All Settings** > **Text Editor** > **Inline Suggestions** > **General**, and set **Inline Suggestions Invocation** to **Manual**. You can then manually trigger suggestions with **Alt**+**,** or **Alt**+**.**.
- **Adjust completion timing** - If completions appear too quickly and interrupt your typing, go to **Tools** > **Options** > **All Settings** > **Text Editor** > **Inline Suggestions** > **Preferences**, and select the **Show inline suggestions only after a pause in typing**. This adds a debounce delay, so completions don't flash and disappear while you type.
- **Change the accept suggestion keyboard shortcut** - By default, <kbd>Tab</kbd> key accepts suggestions. You can change it to the <kbd>Right Arrow</kbd> key instead.

For additional settings and options, see the **Inline Suggestions** settings page.

### Customize Copilot keyboard shortcuts

You can customize the keyboard shortcuts for accepting Copilot inline suggestions, including the shortcuts for accepting a full suggestion, the next word, or the next line.

To set up your preferred shortcuts:

1. Go to **Tools** > **Options** > **Environment** > **Keyboard**.
1. Search for the command you want to customize:
   - `Edit.AcceptSuggestion` — accepts the full inline suggestion
   - `Edit.AcceptNextWordinSuggestion` — accepts the next word in the suggestion
   - `Edit.AcceptNextLineinSuggestion` — accepts the next line in the suggestion
1. Remove the existing keybinding.
1. Assign a new shortcut under the **Inline Suggestion Active** scope.

   :::image type="content" source="media/visualstudio/visual-studio-github-copilot-extension/change-copilot-shortcut.png" alt-text="Screenshot showing the Keyboard settings dialog with the Edit.AcceptSuggestion command selected and a custom shortcut assigned under the Inline Suggestion Active scope.":::

For example, in the following image, the default accept shortcut is changed from <kbd>Tab</kbd> to <kbd>Ctrl</kbd>+<kbd>Tab</kbd>. The updated shortcut is reflected in the hint bar in the editor.

:::image type="content" source="media/visualstudio/visual-studio-github-copilot-extension/changed-shortcut-in-editor.png" alt-text="Screenshot showing the updated keyboard shortcut reflected in the Copilot hint bar in the editor.":::

For more information on customizing keyboard shortcuts in Visual Studio, see [Identify and customize keyboard shortcuts](identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md).

### Customize appearance

To customize the appearance of completions, go to **Tools** > **Options** > **Environment** > **Font and Colors**, and  then select **Code Completions** from the **Show settings for** list, and adjust the font type, size, foreground/background color, and style.

Code completions can display with syntax highlighting, making it easier to parse suggested code at a glance. Variables, functions, keywords, strings, and other code elements appear in distinct colors, just like your actual code.

:::image type="content" source="media/visualstudio/visual-studio-github-copilot-extension/colorized-completions.png" alt-text="Screenshot showing colorized code completions with syntax highlighting, displaying different colors for keywords, types, variables, and strings.":::

To differentiate suggestions from your actual code, colorized completions appear with lower opacity and italic styling.

To disable colorization and use the original single-color appearance, go to **Tools** > **Options** > **Text Editor** > **Code Completions**, and clear the **Use colorized text for code completions** checkbox.

:::moniker-end
:::moniker range="vs-2022"

 All inline suggestions settings can be found via **Tools** > **Options** > **GitHub** > **Copilot**. You can also access these settings via shortcuts from the Copilot badge menu, or via the context menu from Copilot inline suggestions margin indicator.

### Customize preferences

- **Adjust completion timing** - If completions appear too quickly and interrupt your typing, go to **Tools** > **Options** > **IntelliCode** > **Advanced**, and select **Wait for pauses in typing before showing whole line completions**. This adds a debounce delay, so completions don't flash and disappear while you type.

- **Disable automatic completions** - By default, each keystroke triggers completions. To disable this, go to **Tools** > **Options** > **IntelliCode** > **General**, and uncheck **Automatically generate code completions in the Editor**.  You can then manually trigger completions with **Alt**+**,**.

:::moniker-end

## Content exclusion

Completions and suggestions aren't available for [content excluded by your admin](visual-studio-github-copilot-admin.md#github-copilot-completions-in-visual-studio-and-content-exclusions). To learn more, see [Excluding content from GitHub Copilot](https://docs.github.com/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot?tool=visualstudio).

## Code referencing

If you or your organization [enable suggestions that match public code](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/managing-copilot-policies-as-an-individual-subscriber#enabling-or-disabling-suggestions-matching-public-code), Copilot notifies you when a completion matches code from a public GitHub repository.

To see detailed information in GitHub Copilot logs in the **Output** window, select **View code matches**. The log entry includes a link to a GitHub.com page where you can view details on license type. It also includes references to similar code in public GitHub repositories.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/code-referencing-copilot-logs.png" alt-text="Screenshot that shows the log entry for a code reference in an output window." lightbox="media/vs-2022/visual-studio-github-copilot-extension/code-referencing-copilot-logs.png":::

Code referencing enables you to make an informed decision on using code attribution or removing the code from your project.


## Related content

- [Next edit suggestions](copilot-next-edit-suggestions.md)
- [Get started with GitHub Copilot](visual-studio-github-copilot-get-started.md)
- [GitHub Copilot Trust Center](https://copilot.github.trust.page)
