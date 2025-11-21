---
title: About GitHub Copilot Completions in Visual Studio
description: Use GitHub Copilot Completions in Visual Studio to use AI assistance to generate information about your code, including suggested edits and new code snippets.
ms.date: 11/17/2025
ms.update-cycle: 180-days
ms.topic: overview
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
ai-usage: ai-assisted
---
# What is GitHub Copilot Completions in Visual Studio?

[GitHub Copilot](visual-studio-github-copilot-install-and-states.md) in Visual Studio enables enhanced [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md). This ability helps you be more productive and efficient when you're writing code.

In this article, you learn about GitHub Copilot Completions, an AI-powered pair programmer for Visual Studio that provides you with context-aware code completions, suggestions, and even entire code snippets. It helps developers reduce the time spent on repetitive tasks and minimize errors.

For related information about GitHub Copilot Chat, see [What is the GitHub Copilot Chat experience for Visual Studio?](visual-studio-github-copilot-chat.md).

## How GitHub Copilot works

GitHub Copilot works by using advanced machine-learning models trained on a vast dataset of publicly available code from GitHub repositories. As you type code, AI analyzes the context and provides relevant suggestions in real time. You can also receive suggestions by writing a comment in natural language that describes what you want the code to do.

:::image type="content" source="media/vs-2022/github-copilot-extension-example.gif" alt-text="Animated screenshot that shows code completion capabilities of the GitHub Copilot extension.":::

You can also use GitHub Copilot to convert comments to code, create unit tests, create SQL queries, and more.

## Prerequisites

- Install [Visual Studio 2022 version 17.8](/visualstudio/releases/2022/release-history) or later.
- [Sign in to Visual Studio by using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot).
  
  You can use [GitHub Copilot for free](copilot-free-plan.md). Sign up and use AI to code faster and more efficiently.

GitHub Copilot supports several programming languages and frameworks, including (but not limited to) C#, C++, and Python.

## How to get GitHub Copilot for Visual Studio

With Visual Studio 2022 version 17.10 or later, the [unified GitHub Copilot extension](visual-studio-github-copilot-install-and-states.md) is available as a recommended component in the Visual Studio Installer. It's installed by default with all workloads, unless you choose to exclude it during installation.

## Using GitHub Copilot for code completions and suggestions

As you type code or comments in the editor, GitHub Copilot provides context-aware code completions and suggestions. GitHub Copilot provides suggestions for numerous languages, but it works especially well for Python, JavaScript, TypeScript, Ruby, Go, C#, and C++. The following examples are in C#, but other languages work similarly.

1. Open Visual Studio and create a new C# project.

1. Open a C# file (`Program.cs`) in the code editor.

1. In the editor, enter a comment or a method signature to see inline code suggestions from GitHub Copilot.

   ```csharp
       // method to add two numbers
   ```

   ```csharp
       int subtractNumbers(
   ```

1. Hover over the suggestion to see the GitHub Copilot command palette.

   To accept the suggestion, select the <kbd>Tab</kbd> key. To reject the suggestion, continue typing.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/copilot-accept-code-suggestions.png" alt-text="Screenshot that shows suggestions to accept or modify a GitHub Copilot code suggestion in Visual Studio.":::

   If the command palette doesn't appear, you might have reached the default limit for its display. To change this limit, go to **Tools** > **Options** > **IntelliCode** > **Advanced**, and adjust the value for **Minimum commits to suppress hint text**.

1. Add the following code to see completions from GitHub Copilot:

   ```csharp
       int a = 5;
       int b = 10;
       int sum
   ```
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-whole-line-completions.gif" alt-text="Animated screenshot that shows the use of the GitHub Copilot completions in Visual Studio.":::

## Tips and tricks

Here are keyboard shortcuts related to completions:

- Manually trigger a completion: <kbd>Alt</kbd>+<kbd>.</kbd> or <kbd>Alt</kbd>+<kbd>,</kbd>
- Cycle through available completions: <kbd>Alt</kbd>+<kbd>.</kbd> (next) and <kbd>Alt</kbd>+<kbd>,</kbd> (previous)
- Partially accept a completion word by word: <kbd>Ctrl</kbd>+<kbd>Right arrow</kbd>
- Partially accept a completion line by line: <kbd>Ctrl</kbd>+<kbd>Down arrow</kbd>

Customize your completion experience by using settings:

:::moniker range="visualstudio"

- If completions appear too quickly and interrupt your typing, you can adjust the display timing in the **Tools** > **Options** pane. Expand the **All Settings** > **Text Editor** > **Code Completions** > **Preferences** section, and select the **Show code completions only after a pause in typing** checkbox. This setting adds a debounce delay, so completions don't flash and disappear while you're typing quickly.

- By default, each of your keystrokes automatically triggers completions. You can disable automatic completions in the **Tools** > **Options** pane. Expand the **All Settings** > **Text Editor** > **Code Completions** > **General** section, and set the **Code Completion Invocation** option to **Manual**. After you make this adjustment, you can manually trigger completions by using the **Alt**+**,** keyboard shortcut.

:::moniker-end
:::moniker range="<=vs-2022"

- If you feel that completions appear too quickly and interrupt your typing, you can adjust the display timing in the **Tools** > **Options** dialog. Expand the **IntelliCode** > **Advanced** section and select the **Wait for pauses in typing before showing whole line completions** checkbox. This setting adds a debounce delay, so completions don't flash and disappear while you're typing quickly.

- By default, each of your keystrokes automatically triggers completions. You can disable automatic completions in the **Tools** > **Options** dialog. Expand the **IntelliCode** > **General** section and clear the **Automatically generate code completions in the Editor** checkbox.  After you make this adjustment, you can manually trigger completions by using the **Alt**+**,** keyboard shortcut.

:::moniker-end

## Content exclusion

With Visual Studio 2022 version 17.11, [content exclusion is available for GitHub Copilot Completions](visual-studio-github-copilot-admin.md#github-copilot-completions-in-visual-studio-and-content-exclusions). Completions and suggestions aren't available for content that your admin excludes. To learn more, see [Excluding content from GitHub Copilot](https://docs.github.com/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot?tool=visualstudio).

## Code referencing

With Visual Studio 2022 version 17.13, code referencing is available for GitHub Copilot Completions. If you or your organization [enabled suggestions that match public code](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/managing-copilot-policies-as-an-individual-subscriber#enabling-or-disabling-suggestions-matching-public-code), Copilot notifies you when you accept a completion that matches code from a public GitHub repository.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-completions-code-referencing.png" alt-text="Screenshot that shows GitHub Copilot Completions code referencing in Visual Studio." lightbox="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-completions-code-referencing.png"::::::

To see detailed information in GitHub Copilot logs in the **Output** window, select **View code matches**. The log entry includes a link to a GitHub.com page where you can view details on license type. It also includes references to similar code in public GitHub repositories.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/code-referencing-copilot-logs.png" alt-text="Screenshot that shows the log entry for a code reference in an output window." lightbox="media/vs-2022/visual-studio-github-copilot-extension/code-referencing-copilot-logs.png":::

Code referencing enables you to make an informed decision on using code attribution or removing the code from your project.

## Completions model

The GPT-4o Copilot model for code completions is available for GitHub Copilot in Visual Studio version 17.14 Preview 2 or later.

To try the new model for better suggestions and performance:

:::moniker range="visualstudio"

1. In the **Tools** > **Options** pane, expand the **All Settings** > **Text Editor** > **Code Completions** > **General** section.

1. Set the **Copilot Completions Model** option to **GPT-4o Copilot**.

   If the GPT-4o model isn't listed, try restarting Visual Studio to retrieve the latest model list.

   :::image type="content" source="media/visualstudio/completions-model-picker.png" border="false" alt-text="Screenshot that shows how to select the Copilot completions model.":::

:::moniker-end
:::moniker range="<=vs-2022"

1. In the **Tools** > **Options** dialog, expand the **GitHub** > **Copilot** section.

1. In the **Copilot Completions** group, set the **Copilot Completions Model** option to **GPT-4o Copilot**.

   If you don't see the GPT-4o model in the dropdown list, try restarting Visual Studio to retrieve the latest model list.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/completions-model-picker.png" border="false" alt-text="Screenshot that shows the dropdown list for selecting a completions model.":::

1. Select **OK**.

You can also access **Settings** > **Options** from the Copilot badge at the top right in the editor.

:::moniker-end

### Access

- If you're a Copilot Pro user, the new model is available for you in 17.14 Preview 2 and later.
- If you're a Copilot Business or Enterprise user, your administrator needs to enable this model for your organization by opting in to [editor preview features](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#about-policies-for-github-copilot) in the Copilot policy settings on GitHub.com.
- If you're a [Copilot Free](copilot-free-plan.md) user, using this model counts toward your 2,000 free monthly completions.

## Generation of documentation comments

To use automatic generation of documentation comments on your C++ or C# project file, type the comment pattern according to your configuration (for example, `///`). Copilot instantly completes the function description based on the function's content.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/doc-comments-generation.gif" alt-text="Animated screenshot that shows the automatic generation of documentation comments from Copilot." lightbox="media/vs-2022/visual-studio-github-copilot-extension/doc-comments-generation.gif":::

## Exploring GitHub Copilot

To see GitHub Copilot in action, check out the following video tutorial.

*Video length is 1 minute and 19 seconds.*

> [!VIDEO https://www.youtube.com/embed/kc_A12G4Elk]

## Related content

To learn more about the GitHub Copilot extension for Visual Studio, consider exploring the following resources:

- [GitHub Copilot quickstart](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot feature page](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://copilot.github.trust.page)
