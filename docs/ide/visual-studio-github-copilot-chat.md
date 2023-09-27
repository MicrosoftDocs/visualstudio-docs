---
title: About the GitHub Copilot Chat extension for Visual Studio
description: Learn about the fully integrated AI-powered GitHub Copilot Chat extension in Visual Studio, and how you can use the chat interface to ask and receive answers to coding-related questions from right within the IDE.
ms.date: 09/28/2023
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
# What is the GitHub Copilot Chat extension for Visual Studio?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

[GitHub Copilot Chat extension in Visual Studio](https://aka.ms/VSXGHCopilot) is a fully integrated AI-powered chat experience from [GitHub Copilot](visual-studio-github-copilot-extension.md) right within the Visual Studio IDE. It enables you to get coding information and support, such as syntax, programming concepts, test cases, debugging, and more, without leaving the IDE.
  
## Why use Copilot Chat in Visual Studio?

Copilot Chat provides AI assistance to help you make informed decisions and write better code. With tight integration in Visual Studio, Copilot Chat understands what you're working on and can help you with development tasks like:

- **Code explanations**: get in-depth analysis and explanation of how a code block works
- **Code help**: get answers to programming-related questions in natural language or code snippet format
- **Code refinement**: get context-specific code suggestions & recommendations
- **Unit testing**: generate unit tests
- **[Profiling](../debugger/debug-with-copilot.md#ai-assisted-auto-insights)**: optimize code performance
- **[Debugging](../debugger/debug-with-copilot.md#ai-assisted-debugging)**: find issues and get proposed fixes to bugs and [exceptions](../debugger/debug-with-copilot.md#ai-assisted-exceptions).

## Prerequisites

To get started, you need:
+ Visual Studio 2022 [version 17.6](/visualstudio/releases/2022/release-history) or later
+ Active [subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) to [GitHub Copilot for Individuals](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals) or [GitHub Copilot for Business](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-business)

## Install the Visual Studio extension

To install the GitHub Copilot Chat extension in Visual Studio:

1. Open Visual Studio.
1. On the menu bar, select **Extensions** > **Manage Extensions**.
1. In the Search box, enter "GitHub Copilot Chat".
1. Select the **GitHub Copilot Chat** extension, and then select the **Download** button.
1. Restart Visual Studio to complete the installation process.

   > [!NOTE]
   > If you experience authentication issues after installing the extension, see [Troubleshooting authentication issues with GitHub Copilot Chat](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-authentication-issues-with-github-copilot-chat).

## Use Copilot Chat in Visual Studio

You can ask your coding related questions in natural language and GitHub Copilot Chat will answer these in your development context.

There are two places you can ask Copilot these questions; in a [chat window](#ask-questions-in-the-chat-window), or directly inline in the code that you're looking to modify, using [inline code assistance](#ask-questions-in-the-interactive-code-assistant). For questions where your goal is to modify or add to the code file you have open in the editor, the inline code assistant will usually work best, whereas more general coding questions are best answered in the chat pane.

### Ask questions in the chat window

The chat window of Copilot Chat in Visual Studio enables you to ask your questions and see answers in the chat pane. It is usually the best way to work with Copilot on programming help and general coding questions.

1. In Visual Studio, select **View** > **GitHub Copilot Chat**.
1. In the Copilot Chat window, type a coding related question in the **Ask Copilot** text box. Press **Enter** or select **Send** to ask your question.
    
    :::image type="content" source="media/vs-2022/copilot-chat-window-ask-copilot-textbox.png" alt-text="Screenshot of Copilot Chat window.":::

1. If Copilot Chat offers a code suggestion you want to use, select **Copy code block** to copy the code suggestion, or select **Insert** to insert the code suggestion in your code file. Using the insert button lets you preview the code in the target location so you can easily see what's being updated
    
    :::image type="content" source="media/vs-2022/copilot-chat-copy-code-insert-code.png" alt-text="Screenshot of the options to copy code block or insert code for the code suggestions from Copilot Chat.":::

   If you ask a question for help with understanding your code, **Copy code block** and **Insert** options won't be available. 
1. If you select **Insert**, you'll see the code suggestions in normal Visual Studio diff view pattern. You can review and refine what is being proposed and apply to your code by selecting **Accept** or discard by selecting **Cancel**.

    :::image type="content" source="media/vs-2022/copilot-chat-window-diff-view-editor.png" alt-text="Screenshot of code suggestions in diff view in the editor window":::

### Ask questions in the interactive code assistant

The interactive code assistant view of Copilot Chat in Visual Studio enables you to ask your questions and see answers inline with the code in the editor window itself. With inline chat, you don't have to go back and forth to the chat window. It is usually the best way to work with Copilot on questions that add to or update a currently open code file.

1. In Visual Studio, right click in your editor window and select **Ask Copilot** to bring up the interactive code assistant view of Copilot Chat in the editor itself.
    
    :::image type="content" source="media/vs-2022/copilot-chat-inline-ask-copilot.png" alt-text="Screenshot of how to enable inline chat in the editor from right-click context menu.":::

1. Type your coding related question in the **Ask Copilot** text box, and then press **Enter** or select **Send** to ask your question.

    :::image type="content" source="media/vs-2022/copilot-chat-inline-chat.png" alt-text="Screenshot of inline chat interface in the editor window.":::

1. You'll see code suggestions from Copilot Chat in Visual Studio diff view. You can review and refine what is being proposed and apply to your code by selecting **Accept** or discard by selecting **Cancel**.
    
    :::image type="content" source="media/vs-2022/copilot-chat-inline-diff-view.png" alt-text="Screenshot of code suggestions in Visual Studio diff view.":::

## Next steps

To learn more, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot Chat extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
