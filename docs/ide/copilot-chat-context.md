---
title: Improved context in GitHub Copilot Chat
description: Use slash commands, solution context, and hash references to get better answers with scoped context in GitHub Copilot Chat.
ms.date: 10/28/2023
ms.topic: how-to 
author: anandmeg
ms.author: meghaanand
ms.manager: jmartens
ms.technology: vs-ai-tools
helpviewer_keywords: 
  - copilot chat context
  - context, copilot chat
monikerRange: vs-2022
---
# Get better answers with improved context in GitHub Copilot Chat

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

[**GitHub Copilot Chat**](visual-studio-github-copilot-chat.md) in Visual Studio enables you to get coding information and support, such as syntax, programming concepts, context-specific code help, test cases, debugging, and more, without leaving the IDE. With tight integration in Visual Studio, Copilot Chat understands what you're working on by gathering useful context data from Visual Studio. 

In this article, you'll learn about the [slash commands](#use-slash-commands) and the new context experience features in Copilot Chat, such as [solution context](#solution-context-for-deeper-answers) and [hash references](#control-context-with-hash-references). These new features enable you to scope your questions with improved intent and context to get better answers.

Learn more about [AI-assisted development in Visual Studio](../ide/ai-assisted-development-visual-studio.md) and how to [use Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio).

## Prerequisites

To get started, you need:
+ Visual Studio 2022 [version 17.6](/visualstudio/releases/2022/release-history) or later
+ Active [subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) to [GitHub Copilot for Individuals](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals) or [GitHub Copilot for Business](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-business)
+ [**GitHub Copilot** extension](visual-studio-github-copilot-extension.md#installation-instructions) in Visual Studio
+ [**GitHub Copilot Chat** extension](visual-studio-github-copilot-chat.md#install-the-visual-studio-extension) in Visual Studio

## Use slash commands

Slash commands help set the intent for common development tasks without having to write out long questions to form better questions to get better answers. 

You can use slash commands in a [chat window](visual-studio-github-copilot-chat.md#ask-questions-in-the-chat-window), or directly inline in the code that you're looking to modify, using [inline code assistance](visual-studio-github-copilot-chat.md#ask-questions-in-the-interactive-code-assistant). Commands that help modify or add to the code file you have open in the editor will work both in the inline code assistant and the chat windows whereas commands for more general coding questions work only in the chat pane.

| **Command** | **Usage** | **Chat window** | **Interactive code assistant** | **Example** |
|---------------------------|:--------------------:|:-----------------:|
| /askvs| Ask questions related to Visual Studio | Yes | No | /askvs How do I connect Visual Studio to a Git Repository?|
| /clear| Clear the chat window | Yes | No | /clear |
| /createtest| Create unit tests for the selected code| Yes | Yes | select desired code and type /createtest |
| /doc| Add comments for specified or selected code | Yes | Yes | - /doc DeleteBasketAsync method in BasketService.cs</br> - select desired code and type /doc|
| /explain | Explain the code | Yes | Yes | - /explain the AddItemToBasket method in BasketService.cs</br> - select desired code and type /explain|
| /fix | Propose a fix for problems in the selected code | Yes | Yes | - /fix the SetQuantities method in BasketService.cs</br> - select desired code and type /fix|
| /generate | Generate code to answer specified question | Yes | Yes | /generate code to add two numbers in Calculator.cs |
| /help | Get help on Copilot Chat | Yes | No | /help |
| /optimize | Analyze and improve running time of the selected code | Yes | Yes | - /optimize the AddItemToBasket method in BasketService.cs</br> - select desired code and type /optimize|

## Enable context experience

To enable the new context experience features for GitHub Copilot Chat, follow these steps:

1. Open Visual Studio.
1. On the menu bar, select **Tools** > **Options** > **GitHub** > **Copilot chat**. You can also search for "Copilot chat" in the search box.
1. Select **Enable new context experience** > **OK**.

### Solution context for deeper answers

With solution context, GitHub Copilot Chat grounds itself in the solution open in your current instance of Visual Studio. This enables you to ask questions that are scoped to the project you're working on. For example, if you have an E-commerce app open in Visual Studio, you can ask questions such as “Where can I find the code that manages the shopping cart in this codebase?” or “How can I add a wish list to this shopping cart manager? " and Copilot Chat will provide you with answers in the context of your open project.

This is especially helpful when you're working on a large and complex codebase or onboarding onto a new project. With solution context, you can ask questions using natural language in Copilot Chat to get in-depth analysis and explanations of how code works in your specific project.

### Control context with hash references

You can ask your coding related questions in natural language and GitHub Copilot Chat will answer these in the context of the codebase open in Visual Studio. With hash references you can get more specific about the information you want Copilot to consider when answering your question. By selecting a specific context in your codebase, you're able to form better questions easily without having to write out or paste long pieces of information. Specifying the context also enables Copilot to provide you with more relevant answers.

:::image type="content" source="media/vs-2022/copilot-chat-context-hash-reference.png" alt-text="Screenshot of hash references in Copilot Chat.":::

**Examples**

| **Example** | **Context used by Copilot to form the question** |
|---------------------------|:--------------------:|
| What is the purpose of #MyFile.cs: 66-72?| Exact section of the file |
| Where are the tests in #BasketService.cs?| BasketService.cs |
| /explain the AddItemToBasket method in #BasketService.cs| AddItemToBasket method in BasketService.cs |

## Related links

To learn more, consider exploring the following resources:

- [GitHub Copilot extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot Chat extension: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
