---
title: Get Started with GitHub Copilot
description: Learn how to get started with GitHub Copilot in Visual Studio.
ms.date: 2/18/2026
ms.update-cycle: 180-days
ms.topic: get-started
author: RoseHJM
ms.author: rosemalcolm
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
ms.custom: copilot-learning-hub
---

# Get started with GitHub Copilot

Welcome to GitHub Copilot, your AI companion in Visual Studio!

Copilot helps you code faster and with greater accuracy by suggesting entire lines or blocks of code. Copilot also answers questions and assists you with routine tasks such as writing unit tests, debugging, and profiling. You can use all these features directly in your Visual Studio environment.

In this article, you learn how to use Copilot and make the most of its features in Visual Studio.

## Open Copilot

1. Open Visual Studio (version 17.8 or later).
   *Update to the latest version of Visual Studio to get the most out of Copilot.*

1. Create a new project, open an existing project, or continue without code to open the IDE.

1. Select the **GitHub Copilot** badge in the upper-right corner of Visual Studio, and select **Open Chat Window**.

   :::image type="content" source="media/visualstudio/copilot-badge-open-chat-window.png" alt-text="Screenshot of the GitHub Copilot badge in Visual Studio.":::

   If Copilot isn't installed, select **Install Copilot** from the dropdown list and follow the installer prompts. For more information, see [Manage Copilot installation and state](visual-studio-github-copilot-install-and-states.md).

1. In the chat window, enter a prompt to start using Copilot.

   If you're not already signed in with a GitHub account, Visual Studio prompts you to sign in. You can also [get started with Copilot Free](copilot-free-plan.md) if you don't have a Copilot subscription. Complete the sign-in or sign-up process in your browser, and then return to Visual Studio.

   :::moniker range="vs-2022"

      :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/get-started-with-copilot-free-dialog.png" alt-text="Screenshot of the Get Started with Copilot Free dialog in Visual Studio.":::

   :::moniker-end

   :::moniker range="visualstudio"

      :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/get-started-with-copilot-free-dialog.png" alt-text="Screenshot of the Get Started with Copilot Free dialog in Visual Studio.":::

   :::moniker-end

Copilot is now ready to use in Visual Studio.

## Start using Copilot

After you sign in, use Copilot in the chat window and throughout the IDE.

- **Use [agent mode](copilot-agent-mode.md) and [MCP servers](mcp-servers.md)**: In the chat window, select **Ask** and switch to **Agent** to enable agent mode. Use the tools icon to access Model Context Protocol (MCP) servers, configure servers, and choose which tools Copilot can use. For example, to get Copilot assistance with generating targeted code, send "Write unit tests for the methods in this file."

- **Use [completions](visual-studio-github-copilot-extension.md) and [next edit suggestions](copilot-next-edit-suggestions.md)**: As you code, Copilot provides suggestions directly in the editor. Copilot suggests both new code (shown as gray text) and edits to existing code.

- **Use Copilot actions across Visual Studio**: Find Copilot-powered actions and suggestions on the editor context menu, error list, feature search, and other areas of the IDE.

## Tailor Copilot chat to your workflow

Customize Copilot for your project and your development workflow.

- **Manage [context with references](copilot-chat-context-references.md)**: Use the **+** button to attach more context, such as files or images, or ask Copilot to reference your entire solution.

- **Access different [models](copilot-usage-and-models.md#understand-model-selection)**: Use the model picker in the prompt window to select AI models, or [bring your own model](copilot-select-add-models.md#bring-your-own-model-byom) to Copilot. Explore different models for different scenarios, whether it's answering quick questions, writing documentation, or generating multiple-file code edits.

- **Add custom instructions**: Add reusable [custom instructions](copilot-chat-context.md#use-custom-instructions) in `.github/copilot-instructions.md` and [prompt files](copilot-chat-context.md#use-prompt-files) in `.github/prompts` to customize Copilot responses for your coding style or project needs.

## Helpful resources

To review Copilot features at any time, select **GitHub Copilot Walkthrough** from the **GitHub Copilot** badge in the upper-right corner of Visual Studio.

Try building a complete app with the [Hands-on lab: GitHub Copilot in Visual Studio 2022](https://github.com/dotnet-presentations/build-2025-lab300).

## Related content

- [GitHub Copilot Trust Center: Learn about security, privacy, compliance, and transparency](https://copilot.github.trust.page)
- [Completions](visual-studio-github-copilot-extension.md)
- [Chat](visual-studio-github-copilot-chat.md)