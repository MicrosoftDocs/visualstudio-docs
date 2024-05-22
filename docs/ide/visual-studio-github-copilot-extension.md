---
title: About GitHub Copilot Completions in Visual Studio
description: Use GitHub Copilot completions in Visual Studio to use AI assistance to generate information about your code, including suggested edits and new code snippets.
ms.date: 5/22/2024
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
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
+ Active [subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) to [GitHub Copilot for Individuals](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals) or [GitHub Copilot for Business](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-business)
+ [Sign in to Visual Studio with the GitHub account](work-with-github-accounts.md) that has an active GitHub Copilot subscription

  > [!TIP]
  > GitHub Copilot is free for verified students and for maintainers of popular open source projects on GitHub. If you are not a student or maintainer of a popular open source project, you can [try GitHub Copilot for free with a one-time 30-day trial](https://github.com/settings/copilot). After the free trial, you will need a [paid subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) for continued use.

GitHub Copilot supports several programming languages and frameworks, including but not limited to: C#, C++, and Python.

## Get GitHub Copilot for Visual Studio

- If you're using Visual Studio version 17.10 Preview 3 or later, the [unified GitHub Copilot extension](visual-studio-github-copilot-install-and-states.md#get-github-copilot-for-visual-studio-2022-version-1710-preview-3-or-later) is available as a recommended component in the Visual Studio Installer. It is installed by default with all workloads, unless you choose to exclude it during installation.
- If you're using Visual Studio versions 17.9 or earlier, [install the GitHub Copilot extension](visual-studio-github-copilot-install-and-states.md#install-github-copilot-chat).

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

1. Hover over the suggestion to see the GitHub Copilot command palette. You can select **Tab** or press `Tab` to accept the suggestion or continue typing to reject it. If alternate suggestions are available, you can select **next suggestion** or use the `Alt + .` keyboard shortcut to cycle through them.
  
  :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-code-suggestions.gif" alt-text="Animated screenshot that shows using the GitHub Copilot code suggestions in Visual Studio":::

1. Add following code to see whole line completions from GitHub Copilot.

   ```csharp
       int a = 5;
       int b = 10;
       int sum
   ```
  
  :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-whole-line-completions.gif" alt-text="Animated screenshot that shows using the GitHub Copilot completions in Visual Studio":::

## Exploring GitHub Copilot

To see GitHub Copilot in action, check out the following video tutorial. <br><br>*Video length: 1.19 minutes*

> [!VIDEO https://www.youtube.com/embed/kc_A12G4Elk]

## Next steps

To learn more about the current GitHub Copilot extension for Visual Studio, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)