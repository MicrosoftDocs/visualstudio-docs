---
title: Get Started with Copilot in Visual Studio 
description: Learn how to get started successfully with using Copilot in Visual Studio.
ms.date: 8/25/2025
ms.update-cycle: 180-days
ms.topic: install-set-up-deploy
author: meghaanand
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot 
monikerRange: '>= vs-2022'
ms.custom: [copilot-learning-hub]
---

# Getting Started with Copilot

Welcome to Copilot, your AI companion, right inside Visual Studio!

Copilot is here to help you code faster and with greater accuracy by suggesting entire lines or blocks of code, answering questions, and assisting with routine tasks such as writing unit tests, debugging and profiling — all directly in your Visual Studio environment.

By the end of this guide, you will be well equipped to explore the best of your personal Copilot in Visual Studio.

## Launch Copilot
1. Open **Visual Studio** (version 17.8 or later).
> Note: Update to the latest version of Visual Studio to get the most out of Copilot.
1. Create a new project, open an existing project, or continue without code.
1. Click on the **GitHub Copilot** badge in the upper right corner of Visual Studio. Then, click **Open Chat Window to Sign In**

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-install-and-states/copilot-state-inactive-sign-in.png" alt-text="GitHub Copilot badge in Visual Studio":::

    > [!NOTE]
    > If you do not have Copilot installed, click "Install Copilot" and make sure you have Copilot installed. For more guidance, see [Manage your GitHub Copilot installation in Visual Studio](visual-studio-github-copilot-install-and-states.md).

1. From the Chat window, click one of the buttons to sign in with an existing account or [**Sign up for Copilot Free**](copilot-free-plan.md). Complete the sign up or sign in process in your browser through GitHub. Return to Visual Studio once you are signed in.
1. Copilot is now ready to use in Visual Studio!

## Start using Copilot
Once you're signed in, you'll be able to interact with Copilot in the Chat window and throughout the IDE.

- **Use Copilot [agent mode](copilot-agent-mode.md) and MCP**: In the Chat window, click on **Ask** and switch to **Agent** to access agent mode. Click the tools icon to access MCP, configure servers, and select any tools you wish for Copilot to access. Send a message like "Write unit tests for the methods in this file" to get direct Copilot assistance with generating the code you need.

- **Explore [Copilot Completions](visual-studio-github-copilot-extension.md) and [Next Edit Suggestions](copilot-next-edit-suggestions.md)**: Code in Visual Studio as you normally do and Copilot will offer intelligent code suggestions directly in your editor. Copilot will suggest both new code in the form of "gray text" as well as edits to your existing code.

- **Discover Copilot actions across Visual Studio**: Uncover Copilot-powered actions and suggestions throughout the IDE - from your editor context menu, Error List, Feature Search, and more!

## Tailor your Copilot Chat to you
Make Copilot work best for you, your project, and whatever you need most in your development workflow.

- **Share references for [context](copilot-chat-context-references.md)**: Click the **+** button to attach any additional desired context, from uploading images to asking Copilot to look at your entire solution.

- **Access different [models](copilot-usage-and-models.md#understand-model-selection)**: Use the model picker in the prompt window to explore the latest AI models, or [bring your own model](https://devblogs.microsoft.com/visualstudio/bring-your-own-model-visual-studio-chat/) to Copilot! Experiment with different models for different scenarios - whether it's answering quick questions, writing documentation, or generating multi-file code edits.

- **Add custom instructions**: Add reusable [custom instructions](copilot-chat-context.md#enable-custom-instructions) in `.github/copilot-instructions.md` and [prompt files](copilot-chat-context.md#use-prompt-files)) to `.github/prompts` to tailor how Copilot responds to you, from honoring your unique coding style to considering special edge cases for your project.

## Next steps

Access the **Copilot Walkthrough** (from the **GitHub Copilot** badge in the upper right corner of Visual Studio) at any time to revisit what you can achieve with Copilot in Visual Studio.

To learn more, consider building a full app from scratch through a [Hands-on lab with GitHub Copilot in Visual Studio 2022](https://github.com/dotnet-presentations/build-2025-lab300).
