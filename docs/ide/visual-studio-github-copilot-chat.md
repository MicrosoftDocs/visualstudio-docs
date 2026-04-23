---
title: About GitHub Copilot Chat in Visual Studio
description: Learn about the fully integrated GitHub Copilot Chat in Visual Studio. Use chat to ask coding-related questions from right within the IDE.
ms.date: 02/19/2026
ms.update-cycle: 180-days
ms.topic: overview 
ai-usage: ai-assisted
ms.custom: awp-ai
author: RoseHJM
ms.author: rosemalcolm
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# What is GitHub Copilot Chat for Visual Studio?

[**GitHub Copilot completions**](https://marketplace.visualstudio.com/items?itemName=GitHub.copilotvs) and [**GitHub Copilot Chat**](https://aka.ms/VSXGHCopilot) in Visual Studio enable enhanced [AI-assisted development in Visual Studio](ai-assisted-development-visual-studio.md), helping you be more productive and efficient when you write code.

In this article, you learn about using Copilot Chat in Visual Studio, a fully integrated AI-powered chat experience from [GitHub Copilot](visual-studio-github-copilot-extension.md) within the Visual Studio IDE. With the extension, you get coding information and support, such as syntax, programming concepts, context-specific code help, test cases, debugging, and more, without leaving the IDE. [Use the chat interface](#use-copilot-chat-in-visual-studio) to submit your question as a prompt and [set intent](copilot-chat-context.md) for better scoped answers.

For more information on the GitHub Copilot completions in Visual Studio, see [About GitHub Copilot completions for Visual Studio](visual-studio-github-copilot-extension.md).

## Why use Copilot Chat in Visual Studio?

Copilot Chat provides AI assistance to help you make informed decisions and write better code. With tight integration in Visual Studio, Copilot Chat understands what you're working on and can help you with development tasks like:

- **Code explanations**. Get in-depth analysis and explanation of how a code block works.
- **Code help**. Get answers to programming-related questions in natural language or code snippet format.
- **Code refinement**. Get context-specific code suggestions and recommendations.
- **Unit testing**. Generate unit tests.
- **[Profiling](../profiling/profile-with-copilot-agent.md)**. Optimize code performance.
- **[Debugging](../debugger/debug-with-copilot.md)**. Find issues and get proposed fixes to bugs and [exceptions](../debugger/debug-with-copilot.md#debug-an-exception-with-copilot).
- **[Review and commit code](../version-control/git-make-commit.md)**. [Generate commit messages](../version-control/git-make-commit.md#generate-commit-messages-with-github-copilot-chat) and [review local changes](../version-control/git-make-commit.md#review-local-changes-with-copilot-chat).

## Prerequisites

- Visual Studio 2022 [version 17.8](/visualstudio/releases/2022/release-history) or later.

- [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot). You can use [GitHub Copilot for free](copilot-free-plan.md).

> [!NOTE]
> As of April 20, 2026, all GitHub Copilot Pro trials, including existing trials, have been paused. New signups and enrollments for paid individual tiers — including Student, Pro, and Pro+ — are temporarily closed. If you were already on a Copilot trial, you can switch to [Copilot Free](copilot-free-plan.md) or upgrade to a Copilot Pro or Pro+ subscription. For the latest information and support, see https://docs.github.com/en/copilot/get-started/plans.


## Get GitHub Copilot Chat for Visual Studio

If you use Visual Studio version 17.10 or later, GitHub Copilot Chat is included in the [unified GitHub Copilot experience](visual-studio-github-copilot-install-and-states.md). The extension is available as a recommended component in the Visual Studio Installer. Copilot Chat is installed by default with all workloads, unless you choose to exclude it during installation.

GitHub Copilot isn't included in Visual Studio Subscriptions. Instead, it's a separate subscription managed by GitHub. For questions regarding GitHub Copilot subscriptions and support, see the GitHub pages for [business subscriptions](https://docs.github.com/en/billing/managing-billing-for-github-copilot/managing-your-github-copilot-business-subscription) and [individual subscriptions](https://docs.github.com/en/billing/managing-billing-for-github-copilot/managing-your-github-copilot-individual-subscription).

## Use Copilot Chat in Visual Studio

You can ask your coding related questions in natural language. GitHub Copilot Chat answers these questions in your development context.

There are two places you can ask Copilot these questions: in a [chat window](#ask-questions-in-the-chat-window), or with [inline chat](#ask-questions-in-the-inline-chat-view) in the code that you want to modify. If your goal is to modify or add to the code file you have open in the editor, the inline chat view usually works best. For more general coding questions, the chat window is the better option.

To get better answers with scoped context in Copilot Chat, see the [tips to improve Copilot chat results](copilot-chat-context.md). You can learn how to use [slash commands](copilot-chat-context.md#slash-commands), [references](copilot-chat-context-references.md#reference-context), [sources used](copilot-chat-context-references.md#find-context), and [threads](copilot-chat-context-references.md#threads).

> [!NOTE]
> [Content exclusion is available for GitHub Copilot Chat](visual-studio-github-copilot-admin.md#github-copilot-chat-in-visual-studio-and-content-exclusions). Content excluded by your admin is ignored in responses from chat. For more information, see [Configuring content exclusions for GitHub Copilot](https://docs.github.com/copilot/managing-github-copilot-in-your-organization/configuring-content-exclusions-for-github-copilot?tool=visualstudio).

:::moniker range="visualstudio"

### Ask questions in the chat window

Ask your questions and see answers in the chat window. We recommend this tool for programming help and general coding questions.

1. In Visual Studio, select **View** > **GitHub Copilot Chat**.
1. In the chat window, type a coding related question in the **Ask Copilot** text box. Select **Enter** or select **Send** to ask your question.

    :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-window.png" alt-text="Screenshot of the Copilot Chat window.":::

1. If Copilot Chat offers a code suggestion that you want to use, you have the following options. Select **Copy code block** to copy the code suggestion, **Add to new file** to insert the code suggestion in a new file, or **Apply** to insert the code suggestion in your current code file. If you select **Apply**, you can preview the code in the target location so you can easily see what's being updated.  

    :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-copy-code-insert-in-new-file-preview-options.png" alt-text="Screenshot of the options to copy code block, insert code in new file, or insert code in the current file.":::

    If you ask a question for help with understanding your code, the **Copy code block** and **Insert in new file** options isn't available.

   1. If you choose to add the changes to the current file, you see the code suggestions in the normal diff view pattern. You can review and refine what's being proposed, and apply to your code by selecting **Tab**, or discard by selecting **Esc**.

      :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-window-preview-code-diff-view-editor.png" alt-text="Screenshot of code suggestions in diff view in the editor window." lightbox="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-window-preview-code-diff-view-editor.png":::

   1. If you select **Add to new file**, you see the code suggestions in a new file. The changes aren't saved by default.

      :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-window-insert-in-new-file.png" alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-window-insert-in-new-file.png":::
  
    The [code referencing feature in GitHub Copilot](https://github.blog/news-insights/product-news/introducing-code-referencing-for-github-copilot/) notifies you when suggestions match public code. You can view the matching code, its source file, and any associated licensing information directly within Visual Studio. You can then make more informed decisions about whether to use the suggested code.

    :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/code-referencing.png" alt-text="Screenshot of code referencing for public code.":::

:::moniker-end

:::moniker range="vs-2022"

### Ask questions in the chat window

Ask your questions and see answers in the chat window. We recommend this tool for programming help and general coding questions.

1. In Visual Studio, select **View** > **GitHub Copilot Chat**.
1. In the chat window, type a coding related question in the **Ask Copilot** text box. Select **Enter** or select **Send** to ask your question.
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window.png" alt-text="Screenshot of the Copilot Chat window.":::  

    To start exploring GitHub Copilot Chat, use the example starter prompts and the prompt library (book icon) in Visual Studio 2022 version 17.12 and later.

1. If Copilot Chat offers a code suggestion that you want to use, you have the following options. Select **Copy code block** to copy the code suggestion, **Insert in new files** to insert the code suggestion in a new file, or **Preview** to insert the code suggestion in your current code file. If you select **Preview**, you can preview the code in the target location so you can easily see what's being updated.
  
    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-copy-code-insert-in-new-file-preview-options.png" alt-text="Screenshot of the options to copy code block, insert code in new file, or preview code for the code suggestions from Copilot Chat.":::

    If you ask a question for help with understanding your code, the **Copy code block** and **Insert in new file** options aren't available.

    1. If you select **Preview**, you see the code suggestions in normal diff view pattern in Visual Studio. You can review and refine what's being proposed, and apply to your code by selecting **Accept**, or discard by selecting **Cancel**.

        :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-preview-code-diff-view-editor.png" alt-text="Screenshot of code suggestions in diff view in the editor window." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-preview-code-diff-view-editor.png":::

    1. If you select **Insert in new file**, you see the code suggestions in a new file. The file isn't saved by default.
  
       :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-insert-in-new-file.png" alt-text="Screenshot of code suggestions in new file in the editor." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-window-insert-in-new-file.png":::

    Visual Studio 2022 version 17.12 now includes [code referencing in GitHub Copilot](https://github.blog/news-insights/product-news/introducing-code-referencing-for-github-copilot/). This feature in GitHub Copilot notifies you when suggestions match public code. You can view the matching code, its source file, and any associated licensing information directly within Visual Studio. You can then make more informed decisions about whether to use the suggested code.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/code-referencing.png" alt-text="Screenshot of code referencing for public code.":::

:::moniker-end

### Ask questions in the inline chat view

You can ask your questions and see answers inline with the code in the editor window itself. With inline chat, you don't have to go back and forth to the chat window. We recommend this method to work with Copilot on questions that add to or update a currently open code file.

:::moniker range="visualstudio"

1. In Visual Studio, to bring up the inline chat view of Copilot Chat in the editor itself, right-click in your editor window and select **Chat**.

    :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-inline-ask-copilot.png" alt-text="Screenshot of how to enable inline chat in the editor from the context menu.":::

1. Type your coding related question in the **Ask Copilot** text box, and then select **Enter** or select **Send** to ask your question.

    :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-inline-chat.png" alt-text="Screenshot of the  inline chat interface in the editor window." lightbox="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-inline-chat.png" :::

1. You see code suggestions from Copilot Chat in the diff view. You can review and refine what's being proposed. To apply the suggestions to your code, select **Tab**. To discard the suggestions, select **Esc**.

    :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-inline-diff-view.png" alt-text="Screenshot of code suggestions in Visual Studio diff view." lightbox="media/visualstudio/visual-studio-github-copilot-chat/copilot-chat-inline-diff-view.png" :::

1. You can promote your inline chat thread to the chat window by selecting **Copilot Actions** > **Add to Chat**. This feature preserves the record and context of your conversation, and you can continue in the chat window.

    :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/promote-inline-chat-to-chat-window.png" alt-text="Screenshot of how to continue the inline chat thread in the chat window." :::

1. Close the inline chat view by selecting **Esc**.

:::moniker-end

:::moniker range="vs-2022"

1. In Visual Studio, to bring up the inline chat view of Copilot Chat in the editor itself, right-click in your editor window and select **Ask Copilot**.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-ask-copilot.png" alt-text="Screenshot of how to enable inline chat in the editor from the context menu.":::

1. Type your coding related question in the **Ask Copilot** text box, and then select **Enter** or select **Send** to ask your question.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-chat.png" alt-text="Screenshot of inline chat interface in the editor window." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-chat.png" :::

1. You see code suggestions from Copilot Chat in the diff view. You can review and refine what's being proposed. To apply the suggestions to your code, select **Accept**. To discard the suggestions, select **Cancel**.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-diff-view.png" alt-text="Screenshot of code suggestions in Visual Studio diff view." lightbox="media/vs-2022/visual-studio-github-copilot-chat/copilot-chat-inline-diff-view.png" :::

1. You can promote your inline chat thread to the chat window by selecting **Continue in chat window**. This feature preserves the record and context of your conversation, and you can continue in the chat window.

    :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/promote-inline-chat-to-chat-window.png" alt-text="Screenshot of how to continue the inline chat thread in the chat window." :::

1. Close the inline chat view by selecting **Esc**.

:::moniker-end

### Attach images to chat prompts

With Visual Studio 17.14 and later, you can attach images in chat to add contextual input and generate better responses.

To attach an image to a prompt, paste an image from the clipboard or select the ➕ icon in the chat input. Then select **Upload Image** to upload an image from File Explorer. Copilot analyzes the image and uses it as more context to generate a better response.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/attach-image-copilot-chat.png" alt-text="Screenshot of how to attach images in Copilot Chat." lightbox="media/vs-2022/visual-studio-github-copilot-chat/attach-image-copilot-chat.png" :::

This feature can be handy when Copilot is helping you with UI development (for example, you attach an image of your design). The feature is also useful for debugging (for example, you attach a screenshot of the error).

Use any of the following image formats: PNG, JPEG, and GIF (single-frame only). You can attach up to three images per prompt.

:::moniker range="visualstudio"

### Preview Markdown content

You can preview any Markdown content generated by Copilot Chat directly in the Visual Studio Markdown editor.

:::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/preview-markdown.png" alt-text="Screenshot of the Preview button in the Copilot Chat window for Markdown content." lightbox="media/visualstudio/visual-studio-github-copilot-chat/preview-markdown.png" :::

When Copilot Chat generates Markdown content, select the **Preview** button at the upper-right corner of the chat window to see a rendered preview. From there, you can edit and save the Markdown content as needed. This feature is helpful when you want to quickly visualize and work on Markdown files without manually copying and pasting.

:::moniker-end

### Generate Mermaid diagrams

Copilot Chat can generate various [Mermaid diagrams](https://mermaid.js.org/intro/#diagram-types), including architectural, flowchart, sequence, class, Gantt, and pie charts. You can then visualize complex data structures and workflows directly in the editor.

For example, you might use one or more of the following prompts:

- "Create a sequence diagram for the API call flow."
- "Visualize relationships between entities in this schema."
- "Create a Mermaid state diagram for the lifecycle of a task."
- "I'm new to this project, visualize major components and their relationships to help me onboard."

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/mermaid-syntax-chat.png" alt-text="Screenshot of Mermaid diagram syntax in chat." lightbox="media/vs-2022/visual-studio-github-copilot-chat/mermaid-syntax-chat.png" :::

Copilot uses attached references and related files in your codebase to gather context, and then returns the Mermaid syntax in the chat window. Select **Preview** to open a new Markdown file and view the diagram. You can save or share the Markdown or rendered chart for future use.

:::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/mermaid-diagram-rendering.png" alt-text="Screenshot of Mermaid diagram rendering." lightbox="media/vs-2022/visual-studio-github-copilot-chat/mermaid-diagram-rendering.png" :::

> [!TIP]
> You can use the [Markdown preview controls](markdown-preview.md) to switch between preview modes and zoom in on complex Mermaid diagrams.

## Related content

- [GitHub Copilot: Getting started](https://docs.github.com/copilot/getting-started-with-github-copilot?tool=visualstudio)
- [GitHub Copilot: Your AI pair programmer](https://github.com/features/copilot)
- [GitHub Copilot Trust Center](https://copilot.github.trust.page)
- [Support for GitHub Copilot Chat](https://support.github.com)
