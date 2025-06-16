---
title: 'Tips & Tricks for GitHub Copilot Chat in Visual Studio'
description: Use slash commands, references, and threads to form better questions and get better answers with scoped context in GitHub Copilot Chat.
ms.date: 6/16/2025
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
# Get better answers by setting the context for GitHub Copilot Chat in Visual Studio

You can ask [**GitHub Copilot Chat**](visual-studio-github-copilot-chat.md) to give you code suggestions, explain code, generate unit tests, and suggest code fixes. In addition to your prompt, Copilot uses additional context, like the code in your current file and the chat history, to generate a response.

In this article, you learn how to get better answers by providing more information to Copilot Chat:
+ Use [slash commands](#slash-commands) to quickly specify common tasks like `/explain` to get code explanations.
+ Use the [guided chat experience](#prompting-guidance) and [custom instructions](#enable-custom-instructions) to refine context.
+ [Attach images](#attach-images) to your prompt to provide additional context and better illustrate your ideas.
+ Scope the chat to specific files using [references](#reference).
+ Review the [source used](#find-context) by Copilot to generate the answer.
+ Use different [threads](#threads) for each of your Copilot chats so you can maintain different contexts in each.

Learn more about [AI-assisted development in Visual Studio](../ide/ai-assisted-development-visual-studio.md) and how to [use Copilot Chat in Visual Studio](../ide/visual-studio-github-copilot-chat.md#use-copilot-chat-in-visual-studio).

## Prerequisites

To get started using GitHub Copilot Chat in Visual Studio, you need:
+ Visual Studio 2022 [version 17.10](/visualstudio/releases/2022/release-history) or later
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot) <br/>
  <sup>**</sup> You can use [GitHub Copilot for Free](copilot-free-plan.md).

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
| /tests| Create unit tests for the selected code.<br>  Example: select desired code and enter `/tests using XUnit Framework`| Yes | Yes | 

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-slash-commands.png" alt-text="Screenshot of slash commands in inline chat view and chat windows.":::

With Visual Studio 2022 version 17.13, as the user types a slash command, the command expands out the prompt in natural language to display the context the command will use.

## <a name="attach-images"></a>Attach images to a chat prompt

With vision integration for Copilot Chat in Visual Studio 17.14 Preview 1 and later, you can [attach images](visual-studio-github-copilot-chat.md#attach-images-to-chat-prompts) to your chat prompt, providing Copilot with additional context for improved responses. Use images in combination with [scope](#reference) and other contextual features such as slash commands to generate tailored responses.

In the following example, Copilot interprets the attached image to generate a plan and suggest code to create a colorful Breakout game from scratch.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/example-attach-image-chat.png" alt-text="Screenshot of an example scenario of adding an image in Copilot Chat." lightbox="media/vs-2022/visual-studio-github-copilot-chat/example-attach-image-chat.png" :::

## <a name="reference"></a>Reference: scope Copilot results to a particular file or entire solution

You can ask your coding related questions in natural language and GitHub Copilot Chat will answer these in the context of the codebase open in Visual Studio. With references you can get more specific about the information you want Copilot to consider when answering your question.

By selecting a specific context in your codebase, you're able to form better questions easily without having to write out or paste long pieces of information. Specifying the context also enables Copilot to provide you with more relevant answers.

### Reference a file

To easily reference a file in GitHub Copilot Chat, simply add a *#* symbol at the beginning of the file name. For example, if you have a file named *BasketService.cs*, refer to it in the chat as *#BasketService.cs*. 

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-hash-reference.png" alt-text="Screenshot of references in Copilot Chat.":::

### Reference a method, class, or function

With [Visual Studio 2022 version 17.11](/visualstudio/releases/2022/release-notes), you can now reference a specific method, class, or function in GitHub Copilot Chat.

To easily reference a method, class, or function in GitHub Copilot Chat, simply add a *#* symbol at the beginning of the method, class, or function name. For example, if you have a method named *BasketAddItem*, refer to it in the chat as *#BasketAddItem*.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-references-methods.png" alt-text="Screenshot of references to methods in GitHub Copilot Chat in Visual Studio.":::

### Reference the entire solution

Use *@workspace* to refer to the solution active in the IDE for context. When using *@workspace* for context, Copilot Chat leverages the information about the files, projects, and configurations that are currently open and being worked on within your IDE. This enables Copilot Chat to provide more relevant and context-aware suggestions and answers.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-at-workspace.gif" alt-text="Screenshot of referencing solution context in Copilot Chat.":::

With Visual Studio 2022 version 17.11, [GitHub Copilot Enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/about-github-copilot/subscription-plans-for-github-copilot) subscribers can now use `@github` in chat to include context from their entire repository and to search the web (if [search is enabled by your admin](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#give-copilot-access-to-bing)). To learn more about the collection of GitHub-specific skills that Copilot can use to answer your question when using `@github`, see [Using GitHub skills for Copilot](https://docs.github.com/en/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide?tool=visualstudio#using-github-skills-for-copilot-preview).

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-at-github.png" alt-text="Screenshot of using GitHub skills in Copilot Chat.":::

### Reference output window

You can now use the output window as context in chat to ask questions and get help with output logs.
Reference output logs in chat in one of the following ways:

1. Use *#output* to reference it directly in chat.
1. Select the `+` icon in the chat input and add `Output logs` as context.
1. Ask Copilot directly, for example, Check my output logs and help me fix this error.
1. Right-click in the **Output Window** and select **Explain with Copilot** to attach it.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-output-window.png" alt-text="Screenshot of output window as context in Copilot Chat.":::

### Usage examples
Here are some examples of using references for context control:

| **Example** | **Context used by Copilot to form the question** |
|---------------------------|:--------------------:|
| What is the purpose of #MyFile.cs: 66-72?| Exact section of the file |
| Where are the tests in #BasketService.cs?| BasketService.cs |
| /explain the #AddItemToBasket in #BasketService.cs| AddItemToBasket method in BasketService.cs |
| Is there a delete basket method in this @workspace| Current solution open in the IDE |
| I have a test method named #TestCalculator. How can I ensure that it's being executed correctly?| TestCalculator method |
| Could you explain the differences between classes #BasketService and #OrderService?| BasketService class and OrderService class |
| In my @workspace where is #AddItemToBasket? | Current solution open in the IDE |

## <a name="find-context"></a>Review the sources used by Copilot Chat

Copilot Chat displays the context it used after every result, so that you can tell what was taken into account when answering your question. When you ask a Copilot Chat a question and get a response in the chat window, a **References** dropdown appears below the response. The entries in the **References** dropdown list show you the context referenced by Copilot Chat to generate that response. This information can help you modify your question to get better and more relevant answers.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-references-used-dropdown.png" alt-text="Screenshot of References used dropdown in Copilot Chat." lightbox="media/vs-2022/copilot-chat-context/copilot-chat-references-used-dropdown.png":::

## <a name="threads"></a>Organize: isolate chats with Copilot into threads  

If you’re using Copilot Chat extensively to ask questions as you code, you can organize your conversations in a way that keeps them on-topic. Copilot Chat for Visual Studio now provides an easy way to start new conversations (threads) to keep them focused on the task at hand, and keep the context clear so the answers are based on relevant history. 

### <a name="new-thread"></a>New chat thread

Select **Create new thread** or <kbd>Ctrl</kbd>+<kbd>N</kbd> in the chat window to start a new thread.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-new-thread-conversation.png" alt-text="Screenshot of Create new thread icon in Copilot Chat.":::

### <a name="switch-thread"></a>Switch chat thread

You can select between multiple ongoing threads to provide the right historical context for your question. You can use <kbd>Ctrl</kbd>+<kbd>PgDown</kbd> for previous thread or <kbd>Ctrl</kbd>+<kbd>PgUp</kbd> for next thread in the chat window. <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>T</kbd> expands the thread dropdown.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-switch-threads.png" alt-text="Screenshot of switching between ongoing threads in Copilot Chat.":::

### <a name="promote-inline"></a>Promote inline chat to the chat window

With [Visual Studio 2022 version 17.11](/visualstudio/releases/2022/release-notes), you can now preserve the history of your [inline chat](visual-studio-github-copilot-chat.md#ask-questions-in-the-inline-chat-view) by promoting it to the [chat window](visual-studio-github-copilot-chat.md#ask-questions-in-the-chat-window). Select **Continue in chat window...** to maintain a record and context of the conversation, and continue in the chat window.

:::image type="content" source="media/vs-2022/copilot-chat-context/promote-inline-chat-to-chat-window.png" alt-text="Screenshot of promoting ongoing thread in inline chat to the chat window.":::

### Best practices

Copilot Chat uses the chat history to get context about your request. To give Copilot only the relevant history:

* Use threads to start a new conversation for a new task.
* Delete requests that are no longer relevant or that didn’t give you the desired result.

Keep the chat conversation open and continue to iterate and prompt Copilot to improve the suggested solution. Copilot has both the context of the generated code and your current conversation history. As you keep asking additional questions, Copilot further refines the response according to your requirements. See [Prompt engineering for GitHub Copilot](https://docs.github.com/en/copilot/using-github-copilot/prompt-engineering-for-github-copilot) for strategies on effective prompting to improve your Copilot results.

## Next steps

- [GitHub Copilot experience for Visual Studio](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
- [Send us suggestions, feedback, and issues](how-to-report-a-problem-with-visual-studio.md)
- [Support for GitHub Copilot Chat](https://support.github.com)
- [How to use GitHub Copilot: Prompts, tips, and use cases](https://github.blog/developer-skills/github/how-to-write-better-prompts-for-github-copilot/)
