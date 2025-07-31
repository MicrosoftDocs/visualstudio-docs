---
title: 'Customize chat responses'
description: Use custom instructions and prompt files to customize responses and use slash commands to set quick context for common tasks.
ms.date: 7/31/2025
ms.topic: how-to 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
helpviewer_keywords: 
  - copilot chat context
  - context, copilot chat
monikerRange: '>= vs-2022'
---
# Customize chat responses and set context

You can ask [**GitHub Copilot Chat**](visual-studio-github-copilot-chat.md) to give you code suggestions, explain code, generate unit tests, and suggest code fixes. Chat in Visual Studio can give you responses and generate code that matches your coding practices and project requirements, if you give it the right context. Instead of repeatedly adding this information in every chat prompt, you can store this context in files and automatically include it in every chat request.

In this article, you learn how to get better answers by providing more information to Copilot Chat:
+ Use [slash commands](#slash-commands) to quickly specify common tasks like `/explain` to get code explanations
+ Use the [guided chat experience](#prompting-guidance) to refine context
+ Use [custom instructions](#enable-custom-instructions) and [prompt files](#use-prompt-files) to customize responses

Learn more about [AI-assisted development in Visual Studio](../ide/ai-assisted-development-visual-studio.md) and how to [use Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio).

## Prerequisites

To get started using GitHub Copilot Chat in Visual Studio, you need:
+ Visual Studio 2022 [version 17.10](/visualstudio/releases/2022/release-history) or later
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot) <br/>
  <sup>**</sup> You can sign up for [GitHub Copilot for Free](copilot-free-plan.md).

Support for GitHub Copilot Chat will be provided by GitHub and can be reached at https://support.github.com.

## Prompting guidance

The guided chat experience in Visual Studio 17.12 and later helps refine your prompts to clarify context for better answers. GitHub Copilot Chat now guides you with clarifying questions when context is unclear.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-guided-chat.png" alt-text="Screenshot of guided chat experience with GitHub Copilot Chat.":::

## Enable custom instructions

The custom instructions feature enables you to automatically add pre-specified contextual details to your chat questions. Copilot Chat uses these instructions tailored to your specific context, such as, the way your team works, the tools you use, or the specifics of your project, when generating responses. 

To configure custom instructions:
1. [Create/add](https://docs.github.com/en/enterprise-cloud@latest/copilot/customizing-copilot/adding-custom-instructions-for-github-copilot) a custom instructions file `.github/copilot-instructions.md` in the root of your repository.
1. Enable the feature in Visual Studio via **Tools** > **Options** > **GitHub** > **Copilot** > select **(Preview) Enable custom instructions to be loaded from .github/copilot-instructions.md files and added to requests.**.

Custom instructions are not visible in the Chat view or inline chat. However, when used by Copilot, the`.github/copilot-instructions.md` file is listed in the References list of a response.

## Use prompt files

You can now create reusable prompt files in your repository to run or share your frequently used prompts.

To create a prompt file:
1. Write your prompts as you normally would in the prompt box, using `#` references to include specific information from your solution, such as methods, classes, and files. You can even reference other prompt files for shared instructions.
1. Copy the prompt into a markdown file, and save it with the `.prompt.md` extension in the `.github/prompts` folder at the root of your repository.

To use a prompt file:
1. Type `#prompt:` in chat input to reference any prompt files from your `.github/prompts` folder, or click the ➕ icon in the chat input to add it as context.
1. Add any extra details, or simply enter the prompt as is.

:::image type="content" source="media/vs-2022/copilot-chat-context/prompt-files.png" alt-text="Screenshot of using prompt files in GitHub Copilot Chat.":::

## <a name="slash-commands"></a>Use slash commands to set context for common tasks

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
| /tests| Create unit tests for the selected code.<br>  Example: select desired code and enter `/tests using XUnit Framework`| Yes | Yes |

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-slash-commands.png" alt-text="Screenshot of slash commands in inline chat view and chat windows.":::

With Visual Studio 2022 version 17.13, as the user types a slash command, the command expands out the prompt in natural language to display the context the command will use.

## Next steps

- [GitHub Copilot experience for Visual Studio](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
- [Send us suggestions, feedback, and issues](how-to-report-a-problem-with-visual-studio.md)
- [Support for GitHub Copilot Chat](https://support.github.com)
- [How to use GitHub Copilot: Prompts, tips, and use cases](https://github.blog/developer-skills/github/how-to-write-better-prompts-for-github-copilot/)
