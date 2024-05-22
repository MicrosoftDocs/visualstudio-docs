---
title: 'Tips & Tricks for GitHub Copilot Chat in Visual Studio'
description: Use slash commands, references, and threads to form better questions and get better answers with scoped context in GitHub Copilot Chat.
ms.date: 5/22/2024
ms.topic: how-to 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
helpviewer_keywords: 
  - copilot chat context
  - context, copilot chat
monikerRange: '>= vs-2022'
---
# Get better answers by setting the context for GitHub Copilot Chat in Visual Studio

You can use [**GitHub Copilot Chat**](visual-studio-github-copilot-chat.md) in Visual Studio to get coding information and support, such as syntax, programming concepts, context-specific code help, test cases, debugging, and more, without leaving the IDE. Copilot Chat is integrated into Visual Studio, which means it can understand what you're working on by gathering useful clues from what you have in the IDE. 

In this article, you'll learn how to get better answers by providing more information to Copilot Chat including:
+ Use [slash commands](#slash-commands) to quickly specify common tasks like `/explain` to get code explanations.
+ Scope the chat to specific files using [references](#reference).
+ Review the [source used](#find-context) by Copilot to generate the answer.
+ Use different [threads](#threads) for each of your Copilot chats so you can maintain different contexts in each.

Learn more about [AI-assisted development in Visual Studio](../ide/ai-assisted-development-visual-studio.md) and how to [use Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio).

## Prerequisites

To get started using GitHub Copilot Chat in Visual Studio, you need:
+ An active [subscription](https://docs.github.com/en/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot) to either [GitHub Copilot for Individuals](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-individuals) or [GitHub Copilot for Business](https://docs.github.com/copilot/overview-of-github-copilot/about-github-copilot-for-business)
+ Visual Studio 2022 [version 17.6](/visualstudio/releases/2022/release-history) or later installed
+ [GitHub Copilot installed](visual-studio-github-copilot-install-and-states.md) in Visual Studio
+ [GitHub Copilot Chat extension installed](visual-studio-github-copilot-chat.md#get-github-copilot-chat-for-visual-studio) in Visual Studio

Support for GitHub Copilot Chat will be provided by GitHub and can be reached at https://support.github.com.

## <a name="slash-commands"></a>Use slash commands in Copilot Chat for common tasks

Slash commands in Copilot Chat help you set the intent quickly for common development tasks. By using specific slash commands to form your question, you can get better answers without having to write out long questions. 

You can use slash commands in a [chat window](visual-studio-github-copilot-chat.md#ask-questions-in-the-chat-window), or directly inline in the code that you're looking to modify, using [inline code assistance](visual-studio-github-copilot-chat.md#ask-questions-in-the-inline-chat-view). Commands that help modify or add to the code file you have open in the editor will work both in the inline code assistant and the chat windows whereas commands for more general coding questions work only in the chat pane.

| **Command** | **Usage** | **Chat window** | **Inline chat** |
|---------------------------|--------------------|:----------:|:----------:|
| /doc| Add comments for specified or selected code. <br>  Examples: <br>- `/doc DeleteBasketAsync method in BasketService.cs`</br>- select desired code and enter `/doc`| Yes | Yes |
| /explain | Get code explanations. <br><br>  Examples: <br> - `/explain the AddItemToBasket method in BasketService.cs`</br>- select desired code and enter `/explain`| Yes | Yes |
| /fix | Propose a fix for problems in the selected code. <br>  Examples: <br> - `/fix the SetQuantities method in BasketService.cs`</br>- select desired code and enter `/fix`| Yes | Yes |
| /generate | Generate code to answer specified question. <br> Example: `/generate code to add two numbers in Calculator.cs`| Yes | Yes | 
| /help | Get help on using Copilot Chat. <br> Example: `/help`| Yes | Yes | 
| /optimize | Analyze and improve running time of the selected code. <br> Examples:<br> - `/optimize the AddItemToBasket method in BasketService.cs`</br>- select desired code and enter `/optimize`| Yes | Yes |
| /tests| Create unit tests for the selected code.<br>  Example: select desired code and enter `/tests`| Yes | Yes | 

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-slash-commands.png" alt-text="Screenshot of slash commands in inline chat view and chat windows.":::

## <a name="reference"></a>Reference: scope Copilot results to a particular file or entire solution

You can ask your coding related questions in natural language and GitHub Copilot Chat will answer these in the context of the codebase open in Visual Studio. With references you can get more specific about the information you want Copilot to consider when answering your question. By selecting a specific context in your codebase, you're able to form better questions easily without having to write out or paste long pieces of information. Specifying the context also enables Copilot to provide you with more relevant answers.

To easily reference a file, simply add a *#* symbol at the beginning of the file name. For example, if you have a file named *BasketService.cs*, refer to it in the chat as *#BasketService.cs*. 

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-hash-reference.png" alt-text="Screenshot of references in Copilot Chat.":::

Use *#solution* to refer to the solution active in the IDE for context.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-hash-solution-reference.gif" alt-text="Screenshot of referencing solution context in Copilot Chat.":::

Here are some examples of using references for context control:

| **Example** | **Context used by Copilot to form the question** |
|---------------------------|:--------------------:|
| What is the purpose of #MyFile.cs: 66-72?| Exact section of the file |
| Where are the tests in #BasketService.cs?| BasketService.cs |
| /explain the AddItemToBasket method in #BasketService.cs| AddItemToBasket method in BasketService.cs |
| Is there a delete basket method in this #solution| Current Solution open in the IDE|


## <a name="find-context"></a>Review the sources used by Copilot Chat

Copilot Chat displays the context it used after every result, so that you can tell what was taken into account when answering your question. When you ask a Copilot Chat a question and get a response in the chat window, a **References** dropdown appears below the response. The entries in the **References** dropdown list show you the context referenced by Copilot Chat to generate that response. This information can help you modify your question to get better and more relevant answers.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-references-used-dropdown.png" alt-text="Screenshot of References used dropdown in Copilot Chat." lightbox="media/vs-2022/copilot-chat-context/copilot-chat-references-used-dropdown.png":::

## <a name="threads"></a>Organize: isolate chats with Copilot into threads  

If you’re using Copilot Chat extensively to ask questions as you code, you can organize your conversations in a way that keeps them on-topic. Copilot Chat for Visual Studio now provides an easy way to start new conversations (threads) to keep them focused on the task at hand, and keep the context clear so the answers are based on relevant history. 

You can start a new thread by selecting the **Create new thread** in the chat window.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-new-thread-conversation.png" alt-text="Screenshot of Create new thread icon in Copilot Chat.":::

You can select between multiple ongoing threads to provide the right historical context for your question.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-switch-threads.png" alt-text="Screenshot of switching between ongoing threads in Copilot Chat.":::

## Next steps

- [GitHub Copilot extension for Visual Studio](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat extension for Visual Studio](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
- [Send us suggestions, feedback, and issues](how-to-report-a-problem-with-visual-studio.md)
- [Support for GitHub Copilot Chat](https://support.github.com)
