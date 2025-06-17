---
title: 'Use agent mode'
description: Use GitHub Copilot Agent to iterate on code in Visual Studio by making code edits, running commands, and reading error/build context.
ms.date: 6/17/2025
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Use Copilot agent mode

With GitHub Copilot's agent mode in Visual Studio, you can use natural language to specify a high-level task. AI will create a plan, make code edits, run terminal commands, invoke tools, and apply changes across your codebase. It monitors outcomes, such as build results, unit test failures, or tool outputs, and iterates as needed.

Unlike *ask mode*, *agent mode* doesn't stop after a single response. It continues executing and refining steps until the goal in your prompt is reached or additional input is required.

## Prerequisites

[Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) or later.

## Use agent mode

In agent mode, Copilot operates autonomously and determines the relevant context for your prompt.

Follow these steps to get started:

1. Open the Copilot Chat window, select **Ask** to expand the mode dropdown, and then select **Agent**.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png" alt-text="Screenshot that shows Copilot agent mode selector." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png":::

1. Enter your prompt, and then select **Send** or press **Enter** to submit it. You can specify a high-level requirement, and you don't have to specify which files to work on.

1. Agent mode might invoke multiple tools to accomplish different tasks. Optionally, select the **Tools** icon to configure which additional tools can be used for responding to your request.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tools-list.png" alt-text="Screenshot that shows additional tools used by agent mode." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tools-list.png":::

1. Copilot requests confirmation before running a terminal command or using a non-builtin tool.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png" alt-text="Screenshot that shows agent command approval." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png":::

1. Copilot automatically detects issues in code edits or terminal commands, and then takes additional actions to resolve them. The process repeats until the issue is resolved.

1. As Copilot processes your request, it streams the suggested code edits directly in the editor. Review the suggested edits and either keep or discard the suggested edits as a whole in **Total Changes** in the chat window, or review individual file diffs and apply them selectively.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png" alt-text="Screenshot that shows the list of suggested edits." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png":::

1. If you want to review individual code changes made by the agent, you can either review the specific change made at each step, or review the cumulative changes from the last time changes were kept or undone.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-stepwise-edits.png" alt-text="Screenshot that shows accessing individual edit diffs with Copilot agent." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-stepwise-edits.png":::

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-cumulative-edits.png" alt-text="Screenshot that shows accessing cumulative edit diffs with Copilot agent." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-cumulative-edits.png":::

1. Continue to iterate on the code changes to refine the edits or implement additional features.

## Agent mode tools

Agent mode can use the following tools:

* Built-in tools
* [MCP tools](mcp-servers.md)

You can view and manage the tools that can be used for responding to a request. Select the **Tools** icon in the chat window to view and manage the tools that are available in agent mode.

:::image type="content" source="media/vs-2022/mcp-servers/copilot-agent-partial-tools.png" alt-text="Screenshot that shows Copilot agent tool selector." lightbox="media/vs-2022/mcp-servers/copilot-agent-partial-tools.png":::

Based on the outcome of a tool, Copilot might invoke other tools to accomplish the overall request. For example, if a code edit results in syntax errors in the file, Copilot might explore another approach and suggest different code changes.

Additional tools added by running MCP servers are not automatically enabled, they are unchecked by default and must be checked to be activated.

## Manage tool approvals

When a tool is invoked, Copilot requests confirmation to run the tool. This is because tools might run locally on your machine and perform actions that modify files or data.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png" alt-text="Screenshot that shows tool confirmation request." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png":::

In the chat window, after a tool invocation, use the **Allow** dropdown options to automatically confirm the specific tool for the current session, solution, or all future invocations.

You can reset tool confirmation selections in **Tools** > **Options** > **GitHub** > **Copilot** > **Tools**.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png" alt-text="Screenshot that shows tool confirmation options." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config.png":::

<!-- TODO: Define what "Reset solution setting does -->

## Accept or discard edits

Copilot lists the files that were edited in the list of **Total Changes** in the Chat window.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png" alt-text="Screenshot that shows the Total Changes list." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png":::

Click on each file to review changes individually, where you can **Keep** or **Undo** edits made to each chunk of code.

Alternatively, in the **Total Changes** list, select **Keep** or **Undo** for all edits made since the last time you clicked **Keep** or **Undo**.

## Revert edits

As you request code edits, you may want to undo some changes. To revert, select **Restore** next to the checkpoint prior to the prompt that included changes you didn't want.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-checkpoint.png" alt-text="Screenshot that shows reverting edits." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-checkpoint.png":::

Currently, Visual Studio Copilot Agent doesn't support stepwise undo/redo.

## Interrupt an agent mode request

To interrupt an ongoing request, you can cancel it.
This stops all running tools and terminal commands.

To stop a build, select **Build** in the top toolbar, and then select **Cancel** or use the **Ctrl + Break** keyboard shortcut.

## Frequently asked questions

#### I don't see Ask and Agent mode in the GitHub Copilot Chat window.

Take the following troubleshooting steps in the order specified:
- Make sure you're using Visual Studio 17.14 or later: check the version at **Help** > **About Visual Studio**. If you're not using version 17.14 or later, launch the Visual Studio Installer and update your build.
- Make sure you've selected the **Enable agent mode in the chat pane** setting in **Tools** > **Options** > **GitHub** > **Copilot Chat**.
- Try restarting Visual Studio.

#### When should I use Ask mode vs. Agent mode?

- Ask mode is excellent when you want 100% confidence that no code edits are made unless you explicitly select **Apply** or copy and paste the code yourself.
- Agent mode can handle the same conceptual questions, generate code examples without applying them, along with its agent capabilities of editing code.
- If you are looking to use MCP capabilities, you must have agent mode selected. 

#### What happened to Copilot Edits in Visual Studio?

- We perceive agent mode to be an evolution of Edits, with greater ability to iterate on errors, use tools, and automatically apply code changes.
- For the initial releases of Visual Studio 2022 version 17.14, Edits mode is still available if you uncheck the **Enable agent mode in the chat pane** setting in **Tools** > **Options** > **GitHub** > **Copilot** > **Copilot Chat**.

#### As an administrator, how do I control use of agent mode for Visual Studio users?

Agent mode in Visual Studio is governed by the **Editor preview features** flag in the GitHub Copilot dashboard for administrators.
If the administrator turns off this setting, users under that subscription won’t be able to use agent mode in Visual Studio.

For more information, see [managing policies and features for copilot in your enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#editor-preview-features).

## Related content

- [GitHub Copilot Edits](copilot-edits.md)
- [GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)
