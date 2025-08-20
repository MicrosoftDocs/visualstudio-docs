---
title: About GitHub Copilot Completions in Visual Studio
description: Use GitHub Copilot completions in Visual Studio to use AI assistance to generate information about your code, including suggested edits and new code snippets.
ms.date: 5/30/2025
ms.update-cycle: 180-days
ms.topic: overview
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
content_well_notification: 
  - AI-contribution
ai-usage: ai-assisted
---
# What is GitHub Copilot Completions for Visual Studio?

[**GitHub Copilot**](visual-studio-github-copilot-install-and-states.md) in Visual Studio enables enhanced [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md), helping you be more productive and efficient when writing code.

In this article, you learn about Copilot Completions, an AI-powered pair programmer for Visual Studio that provides you with context-aware code completions, suggestions, and even entire code snippets. This powerful tool aids [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md) and helps developers write code more efficiently, reduce the time spent on repetitive tasks, and minimize errors.

For more information on GitHub Copilot Chat in Visual Studio, see [About GitHub Copilot Chat in Visual Studio](visual-studio-github-copilot-chat.md).

## How GitHub Copilot works

GitHub Copilot works by utilizing advanced machine learning models trained on a vast dataset of publicly available code from GitHub repositories. As you type code, the AI analyzes the context and provides relevant suggestions in real-time. You can receive suggestions also by writing a natural language comment describing what you want the code to do.

:::image type="content" source="media/vs-2022/github-copilot-extension-example.gif" alt-text="Animated screenshot that shows the code completion capabilities of the GitHub Copilot extension.":::

You can also use GitHub Copilot to convert comments to code, create unit tests, create SQL queries, and more. 

## Prerequisites

To get started, you need:
+ Visual Studio 2022 [version 17.8](/visualstudio/releases/2022/release-history) or later
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot) <br/>
  <sup>**</sup> You can use [GitHub Copilot for Free](copilot-free-plan.md). Sign up and leverage AI to code faster and more efficiently.

GitHub Copilot supports several programming languages and frameworks, including but not limited to: C#, C++, and Python.

## Get GitHub Copilot for Visual Studio

With Visual Studio version 17.10 or later, the [unified GitHub Copilot extension](visual-studio-github-copilot-install-and-states.md) is available as a recommended component in the Visual Studio Installer. It is installed by default with all workloads, unless you choose to exclude it during installation.

## Using GitHub Copilot for code completions and suggestions

As you type code or comments in the editor, GitHub Copilot provides context-aware code completions and suggestions. GitHub Copilot provides suggestions for numerous languages, but works especially well for Python, JavaScript, TypeScript, Ruby, Go, C# and C++. The following examples are in C#, but other languages will work similarly.

1. Open Visual Studio and create a new C# project.
1. Open a C# file (`Program.cs`) in the editor.
1. In the code editor, type a comment or a method signature to see inline code suggestions from GitHub Copilot.
    
   ```csharp
       // method to add two numbers
   ```

   ```csharp
       int subtractNumbers(
   ```

1. Hover over the suggestion to see the GitHub Copilot command palette.

    **Accept suggestion**

    Select **Tab** or press `Tab` **to accept** the suggestion or continue typing to reject it.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/copilot-accept-code-suggestions.png" alt-text="Screenshot that shows accepting the GitHub Copilot code suggestions in Visual Studio":::

    **Modify suggestion**

    Select **Alt+/** or press `Alt+/` **to modify** the suggestion from Copilot. You can modify and curate the GitHub Copilot suggestions by adding context in inline chat or by editing the completion.
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/copilot-modify-code-completions.png" alt-text="Screenshot that shows modifying the GitHub Copilot code suggestions in Visual Studio":::
  
   If the command palette doesn't appear, you might have reached the default limit for its display. To change this, go to **Tools** > **Options** > **IntelliCode** > **Advanced**, and adjust the value for **Minimum commits to suppress hint text**.

1. Add following code to see completions from GitHub Copilot.

   ```csharp
       int a = 5;
       int b = 10;
       int sum
   ```
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-whole-line-completions.gif" alt-text="Animated screenshot that shows using the GitHub Copilot completions in Visual Studio.":::

## Tips and tricks

Keyboard shortcuts related to completions:

   - Manually trigger a completion using <kbd>Alt</kbd>+<kbd>,</kbd>
   - Cycle through available completions using <kbd>Alt</kbd>+<kbd>.</kbd> (next) and <kbd>Alt</kbd>+<kbd>,</kbd> (previous)
   - Partially accept a completion word by word using <kbd>Ctrl</kbd>+<kbd>Right Arrow</kbd>
   - Partially accept a completion line by line using <kbd>Ctrl</kbd>+<kbd>Down Arrow</kbd>

Customize your completions experience with settings:

   - If you feel like completions appear too quickly and interrupt your typing, go to **Tools** -> **Options** -> **IntelliCode** -> **Advanced** and enable **Wait for pauses in typing before showing whole line completions**. This setting adds a debounce delay, so completions won’t flash and disappear while you're typing quickly. 
   - By default, completions are automatically triggered by each keystroke you type. To disable automatic completions, go to **Tools** -> **Options** -> **IntelliCode** -> **General** and turn off **Automatically generate code completions in the Editor**. Then, use <kbd>Alt</kbd>+<kbd>,</kbd> to manually trigger completions.

## Content exclusions

With Visual Studio 2022 version 17.11, [content exclusion is available for GitHub Copilot Completions](visual-studio-github-copilot-admin.md#github-copilot-completions-in-visual-studio-and-content-exclusions) in Visual Studio. Completions and suggestions won't be available on content excluded by your admin. See [configuring content exclusions for GitHub Copilot](https://docs.github.com/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot?tool=visualstudio) to learn more.

## Code referencing

With Visual Studio 2022 version 17.13, code referencing is available for GitHub Copilot Completions in Visual Studio. If you or your organization have [enabled suggestions that match public code](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/managing-copilot-policies-as-an-individual-subscriber#enabling-or-disabling-suggestions-matching-public-code), Copilot will notify you when you accept a completion that matches code from a public GitHub repository. 

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-completions-code-referencing.png" alt-text="Screenshot that shows using the GitHub Copilot completions code referencing in Visual Studio." lightbox="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-completions-code-referencing.png"::::::

Select **View code matches** to see detailed information in GitHub Copilot logs in the **Output** window. The log entry includes a link to a GitHub.com page where you can view details on license type  and references to similar code in public GitHub repositories. 

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/code-referencing-copilot-logs.png" alt-text="Screenshot that shows the code reference log entry in Output Window." lightbox="media/vs-2022/visual-studio-github-copilot-extension/code-referencing-copilot-logs.png":::

Code referencing enables you to make an informed decision on using code attribution or removing the code from your project.

## Completions model

GPT-4o Copilot code completions model is available for GitHub Copilot in Visual Studio version 17.14 Preview 2 or later.
To try the new model for better suggestions and performance, select **GPT-4o Copilot** from the **Copilot Completions Model** dropdown in **Tools > Options > GitHub > Copilot > Copilot Completions**. You can also access **Settings > Options** from the Copilot badge in the upper right corner of the IDE.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/completions-model-picker.png" alt-text="Screenshot that shows the Completions Model Picker.":::

If you don’t see the new GPT-4o model in the dropdown, try restarting Visual Studio to retrieve the latest model list.

### Access

- If you're a Copilot Pro user, the new model is available for you in 17.14 Preview 2 and later.
- If you're a Copilot Business or Enterprise user, your administrator needs to enable this model for your organization by opting in to [**Editor preview features**](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#about-policies-for-github-copilot) in the Copilot policy settings on *github.com*.
- If you're a [Copilot Free](copilot-free-plan.md) user, using this model counts towards your 2,000 free monthly completions.

## Doc comments generation

To use automatic doc comments generation on your C++ or C# project file, type the comment pattern according to your settings configuration, for example, `///`, and Copilot instantly completes the function description based on the function's content.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/doc-comments-generation.gif" alt-text="Animated screenshot that shows the automatic docs comment generation with Copilot feature." lightbox="media/vs-2022/visual-studio-github-copilot-extension/doc-comments-generation.gif":::

## Exploring GitHub Copilot

To see GitHub Copilot in action, check out the following video tutorial. <br><br>*Video length: 1.19 minutes*

> [!VIDEO https://www.youtube.com/embed/kc_A12G4Elk]

## Next steps

To learn more about the current GitHub Copilot extension for Visual Studio, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
