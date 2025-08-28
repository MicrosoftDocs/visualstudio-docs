---
title: Get Started with Copilot
description: Learn how to get started with Copilot in Visual Studio.
ms.date: 8/29/2025
ms.update-cycle: 180-days
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
monikerRange: '>= vs-2022'
ms.custom: copilot-learning-hub
---

# Getting Started with Copilot

Welcome to Copilot, your AI companion in Visual Studio!

Copilot helps you code faster and with greater accuracy by suggesting entire lines or blocks of code, answering questions, and assisting with routine tasks such as writing unit tests, debugging and profiling — all directly in your Visual Studio environment.

In this article you learn how to use Copilot and make the most of its features in Visual Studio.

## Launch Copilot

1. Launch Visual Studio (version 17.8 or later). </br>
   <sup>*</sup>It's recommended to update to the latest version of Visual Studio to get the most out of Copilot.
1. Create a new project, open an existing project, or continue without code to launch the IDE.
1. Select the **GitHub Copilot** badge in the upper right corner of Visual Studio, and select **Open Chat Window to Sign In**

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-install-and-states/copilot-state-inactive-sign-in.png" alt-text="GitHub Copilot badge in Visual Studio":::

   If Copilot isn't installed, select **Install Copilot** from the dropdown and follow the installer prompts. For more information, see [Manage Copilot installation and state](visual-studio-github-copilot-install-and-states.md).

1. In the Chat window, choose to sign in with your existing GitHub account or [**Sign up for Copilot Free**](copilot-free-plan.md). Follow the prompts in your browser to complete the sign-in or sign-up process. After you finish, return to Visual Studio to continue using Copilot.

Copilot is now ready to use in Visual Studio!

## Start using Copilot

Once you're signed in, you can use Copilot in the Chat window and throughout the IDE.

- **Use [Agent mode](copilot-agent-mode.md) and [MCP](mcp-servers.md)**: In the Chat window, select **Ask** and switch to **Agent** to enable agent mode. Use the tools icon to access MCP, configure servers, and choose which tools Copilot can use. For example, send "Write unit tests for the methods in this file" to get Copilot assistance with generating targeted code.

- **Use [Completions](visual-studio-github-copilot-extension.md) and [Next Edit Suggestions](copilot-next-edit-suggestions.md)**: As you code, Copilot provides suggestions directly in the editor. Copilot will suggest both new code(shown as gray text) and edits to existing code.

- **Use Copilot actions across Visual Studio**: Find Copilot-powered actions and suggestions in the editor context menu, Error List, Feature Search, and other areas of the IDE.

## Tailor Copilot Chat to your workflow

Customize Copilot for your project and your development workflow.

- **Manage [context with references](copilot-chat-context-references.md)**: Use the **+** button to attach additional context, such as files, images, or ask Copilot to reference your entire solution.

- **Access different [models](copilot-usage-and-models.md#understand-model-selection)**: Use the model picker in the prompt window to select AI models, or [bring your own model](copilot-select-add-models.md#bring-your-own-model-byom) to Copilot! Explore different models for different scenarios, whether it's answering quick questions, writing documentation, or generating multi-file code edits.

- **Add custom instructions**: Add reusable [custom instructions](copilot-chat-context.md#enable-custom-instructions) in `.github/copilot-instructions.md` and [prompt files](copilot-chat-context.md#use-prompt-files) in `.github/prompts` to customize Copilot’s responses for your coding style or project needs.

## Next steps

To review Copilot features at any time, select **GitHub Copilot Walkthrough** from the **GitHub Copilot** badge in the upper right corner of Visual Studio.

Try building a complete app with the [Hands-on lab: GitHub Copilot in Visual Studio 2022](https://github.com/dotnet-presentations/build-2025-lab300).
