---
title: About GitHub Copilot Chat in Visual Studio
description: Learn about the fully integrated GitHub Copilot Chat in Visual Studio. Use the chat interface to ask coding-related questions from right within the IDE.
ms.date: 09/09/2025
ms.update-cycle: 180-days
ms.topic: overview 
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# What is the GitHub Copilot Chat experience for Visual Studio?

[**GitHub Copilot Completions**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs) and [**GitHub Copilot Chat**](https://aka.ms/VSXGHCopilot) in Visual Studio enable enhanced [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md), helping you be more productive and efficient when writing code.

In this article, you'll learn about using Copilot Chat in Visual Studio, a fully integrated AI-powered chat experience from [GitHub Copilot](visual-studio-github-copilot-extension.md) right within the Visual Studio IDE. It enables you to get coding information and support, such as syntax, programming concepts, context-specific code help, test cases, debugging, and more, without leaving the IDE. [Use the chat interface](#use-copilot-chat-in-visual-studio) to submit your question as prompt and [set intent](copilot-chat-context.md) for better scoped answers.

For more information on the GitHub Copilot Completions in Visual Studio, see [About GitHub Copilot Completions for Visual Studio](visual-studio-github-copilot-extension.md).

## Why use Copilot Chat in Visual Studio?

Copilot Chat provides AI assistance to help you make informed decisions and write better code. With tight integration in Visual Studio, Copilot Chat understands what you're working on and can help you with development tasks like:

- **Code explanations**: get in-depth analysis and explanation of how a code block works
- **Code help**: get answers to programming-related questions in natural language or code snippet format
- **Code refinement**: get context-specific code suggestions & recommendations
- **Unit testing**: generate unit tests
- **[Profiling](../profiling/cpu-insights.md#get-ai-assistance)**: optimize code performance
- **[Debugging](../debugger/debug-with-copilot.md)**: find issues and get proposed fixes to bugs and [exceptions](../debugger/debug-with-copilot.md#debug-an-exception-with-copilot)
- **[Review and commit code](../version-control/git-make-commit.md)**: [generate commit messages](../version-control/git-make-commit.md#generate-commit-messages-with-github-copilot-chat) and [review local changes](../version-control/git-make-commit.md#review-local-changes-with-copilot-chat)

## Prerequisites

To get started, you need:
+ Visual Studio 2022 [version 17.8](/visualstudio/releases/2022/release-history) or later
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot) <br/>
  <sup>**</sup> You can use [GitHub Copilot for Free](copilot-free-plan.md). Sign up and leverage AI to code faster and more efficiently.

## Get GitHub Copilot Chat for Visual Studio

If you're using Visual Studio version 17.10 or later, GitHub Copilot Chat is included in the [new unified GitHub Copilot experience](visual-studio-github-copilot-install-and-states.md) available as a recommended component in the Visual Studio Installer. It is installed by default with all workloads, unless you choose to exclude it during installation.

   > [!NOTE]
   > * If you experience authentication issues after installing the extension, see [Troubleshooting authentication issues with GitHub Copilot Chat](https://docs.github.com/en/copilot/troubleshooting-github-copilot/troubleshooting-authentication-issues-with-github-copilot-chat).
   > * GitHub Copilot is not included in Visual Studio Subscriptions and is a separate subscription managed by GitHub. For questions regarding GitHub Copilot subscriptions and Support, see [Individual Subscriptions](https://docs.github.com/en/billing/managing-billing-for-github-copilot/managing-your-github-copilot-business-subscription) or [Business subscriptions](https://docs.github.com/en/billing/managing-billing-for-github-copilot/managing-your-github-copilot-individual-subscription).

Support for GitHub Copilot Chat will be provided by GitHub and can be reached at https://support.github.com.

## Use Copilot Chat in Visual Studio

You can ask your coding related questions in natural language and GitHub Copilot Chat will answer these in your development context.

There are two places you can ask Copilot these questions; in a [chat window](#ask-questions-in-the-chat-window), or directly inline in the code that you're looking to modify, using [inline chat](#ask-questions-in-the-inline-chat-view). For questions where your goal is to modify or add to the code file you have open in the editor, the inline chat view will usually work best, whereas more general coding questions are best answered in the chat pane.

See [tips to improve Copilot chat](copilot-chat-context.md) results to learn how to use [slash commands](copilot-chat-context.md#slash-commands), [references](copilot-chat-context-references.md#reference-context), [sources used](copilot-chat-context-references.md#find-context), and [threads](copilot-chat-context-references.md#threads) to get better answers with scoped context in Copilot Chat.

>[!NOTE]
>With Visual Studio 2022 version 17.11, [content exclusion is available for GitHub Copilot Chat](visual-studio-github-copilot-admin.md#github-copilot-chat-in-visual-studio-and-content-exclusions) in Visual Studio. Content excluded by your admin will now be ignored in chat's responses. See [configuring content exclusions for GitHub Copilot](https://docs.github.com/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot?tool=visualstudio) to learn more.

### Ask questions in the chat window

The chat window of Copilot Chat in Visual Studio enables you to ask your questions and see answers in the chat pane. It is usually the best way to work with Copilot on programming help and general coding questions.

1. In Visual Studio, select **View** > **GitHub Copilot Chat**.
1. In the Copilot Chat window, type a coding related question in the **Ask Copilot** text box. Press **Enter** or select **Send** to ask your question.
    
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-ask-copilot-textbox.png" alt-text="Screenshot of Copilot Chat window.":::
   
   Use the example starter prompts and the prompt library (book icon) in Visual Studio 2022 version 17.12 and later to start exploring GitHub Copilot Chat.

1. If Copilot Chat offers a code suggestion you want to use, select **Copy code block** to copy the code suggestion, **Insert in new files** to insert the code suggestion in a new file, or select **Preview** to insert the code suggestion in your current code file. Using the **Preview** button lets you preview the code in the target location so you can easily see what's being updated.
    
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-copy-code-insert-in-new-file-preview-options.png" alt-text="Screenshot of the options to copy code block, insert code in new file, or preview code for the code suggestions from Copilot Chat.":::

   If you ask a question for help with understanding your code, **Copy code block** and **Insert in new file** options won't be available.

    1. If you select **Preview**, you'll see the code suggestions in normal Visual Studio diff view pattern. You can review and refine what is being proposed and apply to your code by selecting **Accept** or discard by selecting **Cancel**.

        :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-preview-code-diff-view-editor.png" alt-text="Screenshot of code suggestions in diff view in the editor window." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-preview-code-diff-view-editor.png":::

    1. If you select **Insert in new file**, you'll see the code suggestions in a new file. The file is not saved by default.
    
        :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-insert-in-new-file.png" alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-insert-in-new-file.png":::
    
    Visual Studio 2022 version 17.12 now includes [code referencing in GitHub Copilot](https://github.blog/news-insights/product-news/introducing-code-referencing-for-github-copilot/). This feature in GitHub Copilot notifies you when suggestions match public code. You can view the matching code, its source file, and any associated licensing information directly within Visual Studio. This enables you to make more informed decisions about whether to use the suggested code. 

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/code-referencing.png" alt-text="Screenshot of code referencing for public code.":::

### Ask questions in the inline chat view

The inline chat view of Copilot Chat in Visual Studio enables you to ask your questions and see answers inline with the code in the editor window itself. With inline chat, you don't have to go back and forth to the chat window. It is usually the best way to work with Copilot on questions that add to or update a currently open code file.

1. In Visual Studio, right click in your editor window and select **Ask Copilot** to bring up the inline chat view of Copilot Chat in the editor itself.
    
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-ask-copilot.png" alt-text="Screenshot of how to enable inline chat in the editor from right-click context menu.":::

1. Type your coding related question in the **Ask Copilot** text box, and then press **Enter** or select **Send** to ask your question.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-chat.png" alt-text="Screenshot of inline chat interface in the editor window." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-chat.png" :::

1. You'll see code suggestions from Copilot Chat in Visual Studio diff view. You can review and refine what is being proposed and apply to your code by selecting **Accept** or discard by selecting **Cancel**.
    
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-diff-view.png" alt-text="Screenshot of code suggestions in Visual Studio diff view." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-diff-view.png" :::

1. You can promote your inline chat thread to the chat window by selecting **Continue in chat window**. This'll preserve the record and context of your conversation, and you can continue in the chat window.
    
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/promote-inline-chat-to-chat-window.png" alt-text="Screenshot of how to continue the inline chat thread in the chat window." :::

1. You can close the inline chat view by pressing **Esc**.

### Attach images to chat prompts

With Visual Studio 17.14 and later, you can attach images in chat to add contextual input and generate better responses.
To attach an image to a prompt, paste an image from the clipboard or select the ➕ icon ton in the chat input and then select **Upload Image** to upload an image from File Explorer. Copilot analyzes the image and uses it as additional context to generate a better response.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/attach-image-copilot-chat.png" alt-text="Screenshot of how to attach images in Copilot Chat." lightbox="media/vs-2022/visual-studio-github-copilot-chat/attach-image-copilot-chat.png" :::

Supported image formats: PNG, JPEG, and GIF (single-frame only). You can attach upto three images per prompt.

Example scenarios where adding an image in the prompt provides Copilot additional context:
- UI development, add an image of your design
- Debugging, add a screenshot of the error

### Generate Mermaid diagrams

With the latest release of Visual Studio, Copilot Chat can generate a variety of [Mermaid diagrams](https://mermaid.js.org/intro/#diagram-types), including architectural, flowchart, sequence, class, Gantt, and pie charts, to help you visualize complex data structures and workflows directly in the editor.

Example prompts:

- Create a sequence diagram for the API call flow
- Visualize relationships between entities in this schema
- Create a Mermaid state diagram for the lifecycle of a task 
- I'm new to this project, visualize major components and their relationships to help me onboard 

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/mermaid-syntax-chat.png" alt-text="Screenshot of Mermaid diagram syntax in chat." lightbox="media/vs-2022/visual-studio-github-copilot-chat/mermaid-syntax-chat.png" :::

Copilot uses attached references and related files in your codebase to gather context, then returns the Mermaid syntax in the chat window. Select **Preview** to open a new markdown file and view the diagram. You can save or share the markdown or rendered chart for future use.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/mermaid-diagram-rendering.png" alt-text="Screenshot of Mermaid diagram rendering." lightbox="media/vs-2022/visual-studio-github-copilot-chat/mermaid-diagram-rendering.png" :::

## Next steps

To learn more, consider exploring the following resources:

- [GitHub Copilot: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://resources.github.com/copilot-trust-center/)
- [Support for GitHub Copilot Chat](https://support.github.com)
