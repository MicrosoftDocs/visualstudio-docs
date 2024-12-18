---
title: About GitHub Copilot Completions in Visual Studio
description: Use GitHub Copilot completions in Visual Studio to use AI assistance to generate information about your code, including suggested edits and new code snippets.
ms.date: 12/18/2024
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

- If you're using Visual Studio version 17.10 or later, the [unified GitHub Copilot extension](visual-studio-github-copilot-install-and-states.md#get-github-copilot-for-visual-studio-2022-version-1710-or-later) is available as a recommended component in the Visual Studio Installer. It is installed by default with all workloads, unless you choose to exclude it during installation.
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

1. Hover over the suggestion to see the GitHub Copilot command palette.

    **Accept suggestion**

    Select **Tab** or press `Tab` **to accept** the suggestion or continue typing to reject it.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/copilot-accept-code-suggestions.png" alt-text="Screenshot that shows accepting the GitHub Copilot code suggestions in Visual Studio":::

    **Modify suggestion**

    Select **Alt+/** or press `Alt+/` **to modify** the suggestion from Copilot. You can modify and curate the GitHub Copilot suggestions by adding context in inline chat or by editing the completion.
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/copilot-modify-code-completions.png" alt-text="Screenshot that shows modifying the GitHub Copilot code suggestions in Visual Studio":::
  
   If the command palette doesn't appear, you might have reached the default limit for its display. To change this, go to **Tools** > **Options** > **IntelliCode** > **Advanced**, and adjust the value for **Minimum commits to suppress hint text**.

1. Add following code to see whole line completions from GitHub Copilot.

   ```csharp
       int a = 5;
       int b = 10;
       int sum
   ```
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-extension/github-copilot-whole-line-completions.gif" alt-text="Animated screenshot that shows using the GitHub Copilot completions in Visual Studio.":::

>[!NOTE]
>With Visual Studio 2022 version 17.11, [content exclusion is available for GitHub Copilot Completions](visual-studio-github-copilot-admin.md#github-copilot-completions-in-visual-studio-and-content-exclusions) in Visual Studio. Completions and suggestions won't be available on content excluded by your admin. See [configuring content exclusions for GitHub Copilot](https://docs.github.com/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot?tool=visualstudio) to learn more.

## Exploring GitHub Copilot

To see GitHub Copilot in action, check out the following video tutorial. <br><br>*Video length: 1.19 minutes*

> [!VIDEO https://www.youtube.com/embed/kc_A12G4Elk]

## Next steps

To learn more about the current GitHub Copilot extension for Visual Studio, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
