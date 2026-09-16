---
title: Get Started with GitHub Copilot in Visual Studio
description: Learn how to open GitHub Copilot in Visual Studio and use chat, agent mode, code completions, custom instructions, and other AI features.
ms.date: 09/16/2026
ms.update-cycle: 180-days
ms.topic: get-started
author: RoseHJM
ms.author: rosemalcolm

ms.service: visual-studio-windows
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
ms.custom: copilot-learning-hub, doc-kit-assisted, awp-ai
monikerRange: '>= vs-2022'
---

# Get started with GitHub Copilot

GitHub Copilot provides AI-assisted development features in Visual Studio. It suggests lines or blocks of code, answers questions, and assists with development tasks such as writing unit tests, debugging, and profiling. Use these features directly in Visual Studio.

In this article, you learn how to open Copilot and start using its features in Visual Studio.

:::moniker range="visualstudio"

## Open Copilot in Visual Studio

1. Open Visual Studio.

1. Create a new project, open an existing project, or continue without code to open the IDE.

1. Select the **GitHub Copilot** badge in the upper-right corner of Visual Studio, and then select **Open Chat**.

   If Copilot isn't installed, select **Install Copilot** and follow the installer prompts. For more information, see [Manage Copilot installation and state](visual-studio-github-copilot-install-and-states.md).

1. In the chat window, enter a prompt to start using Copilot.

   If you're not already signed in with a GitHub account, Visual Studio prompts you to sign in. If you don't have a Copilot subscription, [get started with Copilot Free](copilot-free-plan.md). Complete the sign-in or sign-up process in your browser, and then return to Visual Studio.

   :::image type="content" source="media/visualstudio/visual-studio-github-copilot-chat/get-started-with-copilot-free-dialog.png" alt-text="Screenshot of the Get Started with Copilot Free dialog in Visual Studio.":::

Copilot is now ready to use in Visual Studio.

## Start using Copilot

After you sign in, use Copilot in the chat window and throughout the IDE.

- **Use the [Plan agent](copilot-plan-agent.md)**: In the chat window, use the agent picker to select **Plan** and create an implementation plan before making code changes. Copilot explores your codebase with read-only tools, asks clarifying questions when needed, and saves the plan as Markdown in `.copilot/plans/`.

- **Use [agent mode](copilot-agent-mode.md) and [MCP servers](mcp-servers.md)**: In the chat window, select **Ask** and switch to **Agent** to enable agent mode. Use the tools icon to access Model Context Protocol (MCP) servers, configure servers, and choose which tools Copilot can use. For example, to get Copilot assistance with generating targeted code, send "Write unit tests for the methods in this file."
  - In Visual Studio version 18.1 or later, Copilot Chat can connect to cloud agents to run remote coding sessions that create repository issues and pull requests in your connected GitHub repository. You might be prompted to grant repository permissions the first time you start a cloud session or when more permissions are required.

- **Use [built-in agents](copilot-specialized-agents.md#use-built-in-agents)**: Select an agent from the agent picker or enter `@` followed by the agent name to get assistance with debugging, profiling, testing, modernization, and other development tasks.

- **Use [completions](visual-studio-github-copilot-extension.md) and [next edit suggestions](copilot-next-edit-suggestions.md)**: As you code, Copilot provides suggestions directly in the editor. Copilot suggests both new code (shown as gray text) and edits to existing code. By default, Visual Studio prioritizes IntelliSense over Copilot inline completions. Customize keyboard shortcuts for accepting Copilot suggestions in **Tools > Options > Environment > Keyboard**.

- **Use Copilot actions across Visual Studio**: Find Copilot-powered actions and suggestions on the editor context menu, error list, feature search, and other areas of the IDE.

- **Debug with the Debugger Agent**: Start the [Debugger Agent workflow](../debugger/debug-with-copilot.md#agentic-bug-resolution-with-the-debugger-agent) from Copilot Chat or issue context. Start from a GitHub or Azure DevOps issue or a natural-language prompt to reproduce a problem, generate hypotheses, add instrumentation, analyze telemetry, and apply targeted fixes while validating live runtime behavior.

- **Review selected code**: In Visual Studio version 18.8 or later, select code in the editor, select and hold (or right-click) the selection, and then select **Copilot Actions** > **Review Selection**. Copilot adds inline review comments and can apply or generate code suggestions. For more information, see [Review selected code](copilot-chat-context.md#review-selected-code).

## Tailor Copilot chat to your workflow

Customize Copilot for your project and development workflow.

- **Manage [context with references](copilot-chat-context-references.md)**: Use the **+** button to attach more context, such as files or images, or ask Copilot to reference your entire solution.

- **Use the chat history panel to resume sessions**: Browse previous conversations and return to a session by title, message preview, or last updated time. For details, see [Manage chat history with the Chat History panel](copilot-chat-context-references.md#threads).

- **Access different [models](copilot-usage-and-models.md#understand-model-selection)**: Use the model picker in the prompt window to select AI models. Model availability depends on your Copilot plan and, for Copilot Business or Enterprise, your organization's policies.

- **Add custom instructions**: Add reusable [custom instructions](copilot-chat-context.md#use-custom-instructions) in `.github/copilot-instructions.md` and [prompt files](copilot-chat-context.md#use-prompt-files) in `.github/prompts` to customize Copilot responses for your coding style or project needs.

- **Enable built-in .NET and Azure skills**: In Visual Studio version 18.8 or later, if you installed a corresponding .NET or Azure workload, open the tool picker, select the **Skills** tab, and expand **Built-in** to review the available skills. These skills are off by default, so enable only the ones that apply to your tasks. For more information, see [Use built-in .NET and Azure skills](copilot-agent-skills.md#use-built-in-net-and-azure-skills).

- **Monitor Copilot usage**: In Visual Studio version 18.8 or later, open the **Copilot Usage** window to view real-time usage metrics and receive alerts when you approach or reach a limit. For details, see [Manage Copilot usage and alerts](copilot-usage-and-models.md#monitor-usage-and-manage-alerts).

- **Apply organization-level custom instructions**: In Visual Studio version 18.8 or later, when you work in a repository that belongs to a GitHub organization, Copilot automatically applies instructions defined by the organization owner and lists them in **References**. For more information, see [Use organization-level custom instructions](copilot-chat-context.md#use-organization-level-custom-instructions).

- **Create and manage custom agents**: In Visual Studio version 18.4 or later, create and select repository-level custom agents. In Visual Studio version 18.5 or later, use the agent picker to create user-level custom agents, which are stored in `%USERPROFILE%\.github\agents`. For more information, see [Use GitHub Copilot agents in Visual Studio](copilot-specialized-agents.md#create-and-use-custom-agents).

## Helpful resources

To review Copilot features at any time, select **GitHub Copilot Walkthrough** from the **GitHub Copilot** badge in the upper-right corner of Visual Studio.

## Related content

- [GitHub Copilot Trust Center: Learn about security, privacy, compliance, and transparency](https://copilot.github.trust.page)
- [Completions](visual-studio-github-copilot-extension.md)
- [Chat](visual-studio-github-copilot-chat.md)
- [Use GitHub Copilot agents in Visual Studio](copilot-specialized-agents.md)

:::moniker-end

:::moniker range="vs-2022"

## Open Copilot in Visual Studio 2022

1. Open Visual Studio 2022 version 17.10 or later.

1. Create a new project, open an existing project, or continue without code to open the IDE.

1. Select the **GitHub Copilot** badge in the upper-right corner of Visual Studio, and then select **Open Chat Window**.

   If Copilot isn't installed, select **Install Copilot** and follow the installer prompts. For more information, see [Manage Copilot installation and state](visual-studio-github-copilot-install-and-states.md).

1. In the chat window, enter a prompt to start using Copilot.

   If you're not already signed in with a GitHub account, Visual Studio prompts you to sign in. If you don't have a Copilot subscription, [get started with Copilot Free](copilot-free-plan.md). Complete the sign-in or sign-up process in your browser, and then return to Visual Studio.

   :::image type="content" source="media/vs-2022/visual-studio-github-copilot-chat/get-started-with-copilot-free-dialog.png" alt-text="Screenshot of the Get Started with Copilot Free dialog in Visual Studio 2022.":::

Copilot is now ready to use in Visual Studio 2022.

## Start using Copilot

After you sign in, use Copilot in the chat window and throughout the IDE.

- **Use [built-in agents](copilot-specialized-agents.md#use-built-in-agents-in-visual-studio-2022)**: Select **Context**, **GitHub**, **Profiler**, **VS**, or **Workspace** from the agent picker, or enter `@` followed by the agent name.

- **Use [agent mode](copilot-agent-mode.md) and [MCP servers](mcp-servers.md)**: In the chat window, select **Ask** and switch to **Agent** to enable agent mode. Use the tools icon to access MCP servers, configure servers, and choose which tools Copilot can use.

- **Use [completions](visual-studio-github-copilot-extension.md) and [next edit suggestions](copilot-next-edit-suggestions.md)**: As you code, Copilot provides suggestions directly in the editor. By default, Visual Studio prioritizes IntelliSense over Copilot inline completions. Customize keyboard shortcuts for accepting Copilot suggestions in **Tools > Options > Environment > Keyboard**.

- **Use Copilot actions across Visual Studio**: Find Copilot-powered actions and suggestions on the editor context menu, error list, feature search, and other areas of the IDE.

## Tailor Copilot chat to your workflow

Customize Copilot for your project and development workflow.

- **Manage [context with references](copilot-chat-context-references.md)**: Use the **+** button to attach more context, such as files or images, or ask Copilot to reference your entire solution.

- **Access different [models](copilot-usage-and-models.md#understand-model-selection)**: Use the model picker in the prompt window to select AI models. Model availability depends on your Copilot plan and, for Copilot Business or Enterprise, your organization's policies.

- **Add custom instructions**: Add reusable [custom instructions](copilot-chat-context.md#use-custom-instructions) in `.github/copilot-instructions.md` and [prompt files](copilot-chat-context.md#use-prompt-files) in `.github/prompts` to customize Copilot responses for your coding style or project needs.

## Helpful resources

Try building a complete app with the [Hands-on lab: GitHub Copilot in Visual Studio 2022](https://github.com/dotnet-presentations/build-2025-lab300).

## Related content

- [GitHub Copilot Trust Center: Learn about security, privacy, compliance, and transparency](https://copilot.github.trust.page)
- [Completions](visual-studio-github-copilot-extension.md)
- [Chat](visual-studio-github-copilot-chat.md)
- [Use built-in agents in Visual Studio 2022](copilot-specialized-agents.md#use-built-in-agents-in-visual-studio-2022)

:::moniker-end
