---
title: AI-assistance for developers in Visual Studio
description: Learn about the AI-assisted development tools in Visual Studio, such as GitHub Copilot Completions and Chat, and IntelliCode, and how they can help you write code more efficiently.
ms.date: 2/5/2025
ms.update-cycle: 180-days
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: vs-2022
---
# AI-assisted development in Visual Studio

In this article, you’ll learn about the AI-assisted development capabilities you can use in Visual Studio to enhance your productivity and efficiency such as [GitHub Copilot](visual-studio-github-copilot-install-and-states.md) and [IntelliCode](/visualstudio/intellicode/intellicode-visual-studio).

## How does AI-assisted development help?

The following table describes key ways in which an AI assistant can help you develop in Visual Studio: 

:::row::: 
    :::column span="1"::: 
       **Code faster**
    :::column-end::: 
    :::column span="2"::: 
       Let AI help you:
       + Generating code and entire function suggestions (for example, how to write code to perform a task by describing it in natural language)
       + Predicting what you'll code next based on your programming patterns (completions)
       + Code refactoring through AI-driven context-aware recommendations
    :::column-end::: 
:::row-end:::
:::row::: 
    :::column span="1"::: 
        **Understand code better**
    :::column-end::: 
    :::column span="2":::
       Ask the AI assistant for:
        + Explanations of code sections (for example, when you're trying to understand someone else's code)
        + Answers to your programming questions
    :::column-end::: 
:::row-end:::
:::row::: 
    :::column span="1"::: 
        **Profile and debug quicker** 
    :::column-end::: 
    :::column span="2":::
       Get help profiling and debugging your code:
        +  Optimize performance based on AI suggestions
        +  AI-identified bugs & resolutions
    :::column-end::: 
:::row-end:::

## GitHub Copilot & IntelliCode

GitHub Copilot and IntelliCode assist you in writing code faster and with greater accuracy, help develop a deeper understanding of the codebase, and help with other development tasks such as writing unit tests, debugging, and profiling.

### GitHub Copilot in Visual Studio

[GitHub Copilot in the Visual Studio IDE](visual-studio-github-copilot-install-and-states.md) acts as an AI pair programmer helping you be more productive and efficient when writing code.

- **[GitHub Copilot Completions in Visual Studio](visual-studio-github-copilot-extension.md)**, adds enhanced AI-assistance to the development process by generating whole lines or blocks of code based on the context provided by you. It leverages AI models trained on billions of lines of open-source code to provide autocomplete-style code suggestions as you code, in real-time, right in the editor. It helps you write code faster and with less work. 

    You can get suggestions from GitHub Copilot in the IDE either by starting to write the code you want to use, or by writing a function signature or a natural language comment in your code file describing what you want the code to do. You can choose to use the suggested code by accepting it.

    The following image shows the code generation capabilities of GitHub Copilot in Visual Studio. In this example, you add a natural language comment in the code file, and GitHub Copilot generates the code suggestion for you in gray text. If you choose to use the code, you can select **Tab** to insert it into your code file:

    :::image type="content" source="media/vs-2022/github-copilot-completions-visual-studio.gif" alt-text="Animated screenshot that shows the code completion capabilities of the GitHub Copilot extension." lightbox="media/vs-2022/github-copilot-completions-visual-studio.gif":::

    Get started with [GitHub Copilot Completions in Visual Studio](visual-studio-github-copilot-extension.md#using-github-copilot-for-code-completions-and-suggestions). Note that it requires Visual Studio 2022 17.8 or later. 

- **[GitHub Copilot Chat in Visual Studio](visual-studio-github-copilot-chat.md)** is a fully integrated AI-powered chat experience from GitHub Copilot right within the Visual Studio IDE. It enables you to interact with GitHub Copilot using a chat interface within the IDE. By asking coding-related questions in natural language, you can receive context-specific code suggestions, get an in-depth analysis and explanation of how a code block works, generate unit tests, find issues and get proposed fixes. It enables you to get coding information and support without leaving the IDE, helping you make informed decisions and write better code.  
  
  The following image shows the chat window and the inline (Interactive Code Assistant **Ask Copilot**) view of GitHub Copilot Chat in Visual Studio. In this example, you **Ask Copilot** to generate a test function using the Chat window or the Interactive Code Assistant. If Copilot Chat offers a code suggestion that you want to use, you can accept to insert the code into your code file:

  :::image type="content" source="media/vs-2022/copilot-chat-visual-studio.gif" alt-text="Animated screenshot that shows the capabilities of the GitHub Copilot Chat extension." lightbox="media/vs-2022/copilot-chat-visual-studio.gif":::

  Get started with [GitHub Copilot Chat in Visual Studio](visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio). Note that it requires Visual Studio 2022 17.8 or later.

### IntelliCode in Visual Studio

IntelliCode uses the context of your code combined with patterns it has learned from thousands of public open-source code to provide AI-driven enhancements to [Intellisense](using-intellisense.md) with [suggestions](/visualstudio/intellicode/intellicode-suggestions), [context-aware code completions](/visualstudio/intellicode/intellicode-visual-studio#context-aware-code-completions), [whole line completions](/visualstudio/intellicode/visual-studio-whole-line-completions), and [API usage examples](https://devblogs.microsoft.com/visualstudio/intellicode-api-usage-examples). By using artificial intelligence, IntelliCode uses your current code context and patterns to dynamically rank suggestions at the top of the completion list with a star icon next to them, helping you write accurate code faster.

The following image shows IntelliCode completions in Visual Studio:

:::image type="content" source="media/vs-2022/intellicode-completions-visual-studio.gif" alt-text="Animated screenshot that shows IntelliCode completions." lightbox="media/vs-2022/intellicode-completions-visual-studio.gif":::

Get started with [IntelliCode](/visualstudio/intellicode/).

## AI capabilities side-by-side

The following table compares the capabilities of GitHub Copilot (and GitHub Copilot Chat) and IntelliCode.

>[!IMPORTANT]
>You can use BOTH GitHub Copilot and IntelliCode together. You do not have to choose between them.

| **AI-assistance feature** | **GitHub Copilot** | **IntelliCode** |
|---------------------------|:--------------------:|:-----------------:|
| Available as |[Built-in by default in all workloads](visual-studio-github-copilot-install-and-states.md#install-copilot-using-the-visual-studio-installer) & available through the Visual Studio Installer in Visual Studio version 17.10 and later <br/>| Built-in by default in most [workloads](../install/modify-visual-studio.md#change-workloads-or-individual-components) & available through the Visual Studio Installer |
| Subscription-based | **Yes** <br/>[Learn more](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot)| No |
| User interface   | Inline <br/>Chat window | Inline |
| Context-aware AI-assisted [IntelliSense](using-intellisense.md) | **Yes** <br/>[Learn more](visual-studio-github-copilot-extension.md#exploring-github-copilot) | **Yes** <br/>[Learn more](#intellicode-in-visual-studio) |
| Whole-line completions in gray text | **Yes** <br/>[Learn more](visual-studio-github-copilot-extension.md#exploring-github-copilot) | **Yes** <br/>[Learn more](#intellicode-in-visual-studio) |
| Whole function & multi-line completions in gray text | **Yes** <br/>[Learn more](visual-studio-github-copilot-extension.md#how-github-copilot-works) | No |
| Repeated edits detection | No | **Yes** <br/>[Learn more](intellicode-suggestions.md)|
| Convert Natural language comments to code| **Yes** <br/>[Learn more](visual-studio-github-copilot-extension.md#how-github-copilot-works) | No |
| Solve code problems with Natural language driven dev assistance | **Yes**, with Copilot Chat. <br/>[Learn more](visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio)| No |
| Code debugging | **Yes**, with Copilot Chat. <br/>[Learn more](../debugger/debug-with-copilot.md)| No |
| Measure app performance through profiling | **Yes**, with Copilot Chat. <br/>[Learn more](https://devblogs.microsoft.com/visualstudio/simplified-code-refinement-and-debugging-with-github-copilot-chat/#cpu-usage-auto-insights-in-the-profiler) | No |
| API usage examples | No | **Yes** <br/>[Learn more](https://devblogs.microsoft.com/visualstudio/intellicode-api-usage-examples/)|
| Languages supported | Supports several programming languages and frameworks, including but not limited to: C#, C++, Python, JavaScript, and TypeScript| C#, XAML, C++, JavaScript, TypeScript, Visual Basic |

## Next steps

To learn more, consider exploring the following resources:

- [GitHub Copilot Completions](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat](visual-studio-github-copilot-chat.md)
- [GitHub Copilot: Compare plans](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
