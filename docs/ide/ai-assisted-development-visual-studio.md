---
title: AI-assisted development in Visual Studio
description: Learn about the AI-assisted development tools in Visual Studio, such as Intellicode, GitHub Copilot, and Github Copilot Chat, and how they can help you write code more efficiently.
ms.date: 09/25/2023
ms.topic: overview 
ms.custom: template-overview
author: anandmeg
ms.author: meghaanand
ms.manager: jmartens
ms.technology: vs-ai-tools
ms.workload:
- multiple
monikerRange: vs-2022
---
# What is AI-assisted development in Visual Studio?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this article, you’ll learn about the AI-assisted development capabilities you can use in Visual Studio to enhance your productivity and efficiency such as [GitHub Copilot](visual-studio-github-copilot-extension.md) and [IntelliCode](/visualstudio/intellicode/intellicode-visual-studio).

## How does AI-assisted development help?

AI-assisted development enables you to code faster through **code generation**, **code completion**, and **code prediction**.

Additionally, AI-assisted development is available for:

- **Coding help**: get AI-assisted code explanations
- **Profiling**: optimizing your code performance
- **Debugging**: use AI to identify & resolve issues
- **Code refactoring**: AI-driven context-aware suggestions & recommendations
- **Code reviews/analysis**: find issues faster

## GitHub Copilot & IntelliCode

GitHub Copilot and IntelliCode assist developers in writing code faster and with greater accuracy, help develop a deeper understanding of the codebase, and help with other development tasks such as writing unit tests, debugging, and profiling.

### GitHub Copilot in Visual Studio

GitHub Copilot is an AI pair programmer available as two extensions in the Visual Studio Marketplace.

- **[GitHub Copilot extension in Visual Studio](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs)**, adds enhanced AI-assistance to the development process by generating whole lines or blocks of code based on the context provided by the developer. It leverages AI models trained on billions of lines of open-source code to provide autocomplete-style code suggestions as you code, in real-time, right in the editor. You can get suggestions from GitHub Copilot in the IDE either by starting to write the code you want to use, or by writing a function signature or a natural language comment in your code file describing what you want the code to do. It helps you write code faster and with less work. 

  The following image shows the code completion capabilities of GitHub Copilot in Visual Studio:

  :::image type="content" source="media/vs-2022/github-copilot-completions-visual-studio.gif" alt-text="Animated screenshot that shows the code completion capabilities of the GitHub Copilot extension." lightbox="media/vs-2022/github-copilot-completions-visual-studio.gif":::

  Get started with the [GitHub Copilot in Visual Studio](visual-studio-github-copilot-extension.md). Note that it requires Visual Studio 2022 17.5.5 or later. 

- **[GitHub Copilot Chat extension in Visual Studio]()** is a fully integrated AI-powered chat experience from GitHub Copilot right within the Visual Studio IDE. It enables developers to interact with GitHub Copilot using a chat interface within the IDE. By asking coding-related questions in natural language, developers can receive context-specific code suggestions, get an in-depth analysis and explanation of how a code block works, generate unit test, find issues and get proposed fixes. It enables you to get coding information and support without leaving the IDE, helping you make informed decisions and write better code.  
  
  The following image shows the chat window and the inline (Interactive Code Assistant **Ask Copilot**) view of GitHub Copilot Chat in Visual Studio:

  :::image type="content" source="media/vs-2022/copilot-chat-visual-studio.gif" alt-text="Animated screenshot that shows the capabilities of the GitHub Copilot Chat extension." lightbox="media/vs-2022/copilot-chat-visual-studio.gif":::

  All [GitHub Copilot for Individuals](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals) users have access to GitHub Copilot Chat. [Learn more](https://github.blog/2023-09-20-github-copilot-chat-beta-now-available-for-all-individuals/#how-developers-can-access-github-copilot-chat-beta).
  All [GitHub Copilot for Business](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-business) have access to a limited GitHub Copilot Chat beta. [Learn more](https://github.blog/2023-07-20-github-copilot-chat-beta-now-available-for-every-organization/).

### IntelliCode in Visual Studio

IntelliCode uses the context of your code combined with patterns it has learned from thousands of public open-source code to provide provide AI-driven enhancements to [Intellisense](using-intellisense.md) with [suggestions](/visualstudio/intellicode/intellicode-suggestions), [context-aware code completions](/visualstudio/intellicode/intellicode-visual-studio#context-aware-code-completions), [whole line completions](/visualstudio/intellicode/visual-studio-whole-line-completions), and [API usage examples](https://devblogs.microsoft.com/visualstudio/intellicode-api-usage-examples). By using artificial intelligence, IntelliCode uses the developer’s current code context and patterns to dynamically rank suggestions at the top of the completion list with a star icon next to them, helping developers write accurate code faster. Get started with [IntelliCode](/visualstudio/intellicode/).

:::image type="content" source="media/vs-2022/intellicode-completions-visual-studio.gif" alt-text="Animated screenshot that shows IntelliCode completions." lightbox="media/vs-2022/intellicode-completions-visual-studio.gif":::

## AI capabilities side-by-side

The following table compares the capabilities of GitHub Copilot (and GitHub Copilot Chat) and IntelliCode.

>[!IMPORTANT]
>You can use BOTH GitHub Copilot and IntelliCode together. You do not have to choose between them.

| **AI-assistance feature** | **GitHub Copilot** | **IntelliCode** |
|---------------------------|--------------------|-----------------|
| Extension | Downloadable extensions: <br/>- GitHub Copilot completions ([get started](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs)) <br/>- GitHub Copilot Chat ([get started](https://marketplace.visualstudio.com/items?itemName=VisualStudioExptTeam.VSGitHubCopilot)) | Built-in by default in most [workloads](../install/modify-visual-studio.md#change-workloads-or-individual-components) & available through the Visual Studio Installer |
| [Subscription-based](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) | Yes | No |
| User interface   | Inline <br/>Chat window | Inline |
| Context-aware AI-assisted [IntelliSense](using-intellisense.md) | Yes | Yes |
| Whole-line completions in gray text | Yes | Yes |
| Whole function & multi-line completions in gray text | Yes | No |
| Whole-line completions in gray text | Yes | Yes |
| Repeated edits detection | No | Yes |
| Convert Natural language comments to code| Yes | No |
| Solve code problems with Natural language driven dev assistance | Yes, with Chat extension enabled | No |
| [Code debugging](../debugger/debug-with-copilot.md) | Yes, with Chat extension enabled | No |
| [Measure app performance through profiling](https://devblogs.microsoft.com/visualstudio/simplified-code-refinement-and-debugging-with-github-copilot-chat/#cpu-usage-auto-insights-in-the-profiler) | Yes, with Chat extension enabled | No |
| [Measure app performance through profiling](https://devblogs.microsoft.com/visualstudio/simplified-code-refinement-and-debugging-with-github-copilot-chat/#cpu-usage-auto-insights-in-the-profiler) | Yes | Yes |
| API usage examples | No | Yes |
| Languages supported | Supports several programming languages and frameworks, including but not limited to: C#, C++, Python, JavaScript, and TypeScript| C#, XAML, C++, Javascript, Typescript, Visual Basic |

## Next steps

To learn more, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot Chat extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
