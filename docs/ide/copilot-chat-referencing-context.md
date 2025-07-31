---
title: 'Manage chat context with references'
description: Use references to set context and get better answers in GitHub Copilot Chat.
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
# Manage chat context with references

Scope your questions to [**GitHub Copilot Chat**](visual-studio-github-copilot-chat.md) by using references to get better answer, in addition to its implicit contextual knowledge.

In this article, you learn how to get better answers by providing more information to Copilot Chat:

- Understand the implicit context Copilot leverages behind the scenes
- Scope the chat to specific files using references
- Review the source used by Copilot to generate the answer
- Use different threads for each of your Copilot chats so you can maintain different contexts in each

## Implicit context

Visual Studio automatically provides context to the chat prompt based on your current activity.

The following information is implicitly included in the chat context:
- The currently selected text in the active editor.
- The current file active in the editor.

Depending on your prompt, Copilot reads the contents of the active file. To explicitly include the contents of another file in the chat context, select the suggested file using the `+` button in the chat view to **Add attachment**.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-implicit-context.png" alt-text="Screenshot of implicit context in Copilot Chat.":::

## <a name="reference-context"></a>Reference: scope Copilot results

You can ask your coding related questions in natural language and GitHub Copilot Chat will answer these in the context of the codebase open in Visual Studio. With references you can get more specific about the information you want Copilot to consider when answering your question.

By selecting a specific context in your codebase, you're able to form better questions easily without having to write out or paste long pieces of information. Specifying the context also enables Copilot to provide you with more relevant answers.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-references.png" alt-text="Screenshot of references in Copilot Chat.":::

### Reference a file

To easily reference a file in GitHub Copilot Chat, simply add a *#* symbol at the beginning of the file name. For example, if you have a file named *BasketService.cs*, refer to it in the chat as *#BasketService.cs*. 

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-hash-reference.png" alt-text="Screenshot of file reference in Copilot Chat.":::

### Reference a method, class, or function

With [Visual Studio 2022 version 17.11](/visualstudio/releases/2022/release-notes), you can now reference a specific method, class, or function in GitHub Copilot Chat.

To easily reference a method, class, or function in GitHub Copilot Chat, simply add a *#* symbol at the beginning of the method, class, or function name. For example, if you have a method named *BasketAddItem*, refer to it in the chat as *#BasketAddItem*.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-references-methods.png" alt-text="Screenshot of references to methods in GitHub Copilot Chat in Visual Studio.":::

### Reference the entire solution

Use *@workspace* to refer to the solution active in the IDE for context. When using *@workspace* for context, Copilot Chat leverages the information about the files, projects, and configurations that are currently open and being worked on within your IDE. This enables Copilot Chat to provide more relevant and context-aware suggestions and answers.

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-at-workspace.gif" alt-text="Screenshot of referencing solution context in Copilot Chat.":::

With Visual Studio 2022 version 17.11, [GitHub Copilot Enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/about-github-copilot/subscription-plans-for-github-copilot) subscribers can now use `@github` in chat to include context from their entire repository and to search the web (if [search is enabled by your admin](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#give-copilot-access-to-bing)). To learn more about the collection of GitHub-specific skills that Copilot can use to answer your question when using `@github`, see [Using GitHub skills for Copilot](https://docs.github.com/en/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide?tool=visualstudio#using-github-skills-for-copilot-preview).

:::image type="content" source="media/vs-2022/copilot-chat-context/copilot-chat-context-at-github.png" alt-text="Screenshot of using GitHub skills in Copilot Chat.":::

## <a name="attach-images"></a>Reference an image

With vision integration for Copilot Chat in Visual Studio 17.14 and later, you can [attach images](visual-studio-github-copilot-chat.md#attach-images-to-chat-prompts) to your chat prompt, providing Copilot with additional context for improved responses. Use images in combination with [scope](#reference-context) and other contextual features such as [slash commands](copilot-chat-context.md#slash-commands) to generate tailored responses.

In the following example, Copilot interprets the attached image to generate a plan and suggest code to create a colorful Breakout game from scratch.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/example-attach-image-chat.png" alt-text="Screenshot of an example scenario of adding an image in Copilot Chat." lightbox="media/vs-2022/visual-studio-github-copilot-chat/example-attach-image-chat.png" :::

### Reference output window

You can now use the output window as context in chat to ask questions and get help with output logs. Supported output windows include Build, Debug, Tests, Source Control, Package Manager, or any other active output window pane.

Reference output logs in chat in one of the following ways:

- Use *#output* to reference it directly in chat.
- Select the ➕ icon in the chat input and add `Output logs` as context.
- Ask Copilot directly, for example, *Check my output logs and help me fix this error*.
- Right-click in the **Output Window** and select **Explain with Copilot** to attach it.

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

## <a name="threads"></a>Organize: manage chat history context with threads 

As you iterate and send multiple chat prompts in a chat session, Copilot uses the history of chat prompts and responses as context for your current chat prompt. This means that you can ask follow-up questions or clarify your previous question without having to repeat the context. For example, you can ask "How does this differ from ...", "Now add a test case", "explain in more detail", and more.

To start over with a new chat session and discard the current context, start a [new thread](#new-thread) in the chat view. This is useful when you want to move to a different topic and avoid the previous context and history.
Use threads to keep conversations focused on the task at hand, and keep the context clear so the answers are based on relevant history. 

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
