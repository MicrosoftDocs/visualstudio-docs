---
title: Use Agent Mode
description: Use the GitHub Copilot agent to iterate on code in Visual Studio by making code edits, running commands, and reading error/build context.
ms.date: 7/28/2025
ms.update-cycle: 180-days
ms.topic: get-started
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# Get started with GitHub Copilot agent mode

With the GitHub Copilot agent mode in Visual Studio, you can use natural language to specify a high-level task. AI creates a plan, makes code edits, runs terminal commands, invokes tools, and applies changes across your codebase. It monitors outcomes, such as build results, unit-test failures, or tool outputs, and iterates as needed.

Unlike *ask mode*, agent mode doesn't stop after a single response. It continues running and refining steps until you reach the goal in your prompt or more input is required.

## Prerequisites

You need [Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) or later.

## Use agent mode

In agent mode, Copilot operates autonomously and determines the relevant context for your prompt.

Follow these steps to get started:

1. Open the Copilot Chat window, select **Ask** to expand the mode dropdown, and then select **Agent**.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png" alt-text="Screenshot that shows the Copilot agent mode selector." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-dropdown.png":::

1. Enter your prompt, and then select **Send** or select the <kbd>Enter</kbd> key to submit it. You can specify a high-level requirement, and you don't have to specify which files to work on.

1. Agent mode might invoke multiple tools to accomplish different tasks. Optionally, select the **Tools** icon to configure which additional tools the agent can use for responding to your request.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tools-list.png" alt-text="Screenshot that shows additional tools that agent mode uses." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tools-list.png":::

1. Copilot requests confirmation before running a terminal command or using a tool that isn't built in.

    :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png" alt-text="Screenshot that shows agent command approval." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png":::

1. Copilot automatically detects issues in code edits or terminal commands, and then takes action. The process repeats until the issues are resolved.

1. As Copilot processes your request, it streams the suggested code edits directly in the editor. Review the suggested edits and either:

   - Keep or discard the suggested edits as a whole in **Total changes** in the chat window.

     :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png" alt-text="Screenshot that shows a list of suggested edits." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png":::

   - Review individual file diffs and apply them selectively.

1. If you want to review individual code changes that the agent made, you can either:

   - Review the specific change at each step.

     :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-stepwise-edits.png" alt-text="Screenshot that shows accessing individual edit diffs with the Copilot agent." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-stepwise-edits.png":::

   - Review the cumulative changes from the last time that changes were kept or undone.

     :::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-cumulative-edits.png" alt-text="Screenshot that shows accessing cumulative edit diffs with the Copilot agent." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-cumulative-edits.png":::

1. Continue to iterate on the code changes to refine the edits or implement more features.

## Understand agent mode tools

Agent mode can use the following tools for responding to a request:

- Built-in tools
- [Model Context Protocol (MCP) tools](mcp-servers.md)

To view and manage the tools that are available in agent mode, select the **Tools** icon in the chat window.

:::image type="content" source="media/vs-2022/mcp-servers/copilot-agent-partial-tools.png" alt-text="Screenshot that shows the tool selector for the Copilot agent." lightbox="media/vs-2022/mcp-servers/copilot-agent-partial-tools.png":::

Based on the outcome of a tool, Copilot might invoke other tools to accomplish the overall request. For example, if a code edit results in syntax errors in the file, Copilot might explore another approach and suggest different code changes.

Additional tools that you add by running MCP servers are not automatically enabled. Their checkboxes are cleared by default, and you must select them to activate the tools.

## Manage tool approvals

When Copilot invokes a tool, it requests confirmation to run the tool. The reason is that tools might run locally on your machine and perform actions that modify files or data.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png" alt-text="Screenshot that shows a tool confirmation request." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-command-approval.png":::

In the chat window, after a tool invocation, use the **Allow** dropdown options to automatically confirm the specific tool for the current session or solution, or all future invocations.

You can reset tool confirmation selections in **Tools** > **Options** > **GitHub** > **Copilot** > **Tools**.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config-options.png" alt-text="Screenshot that shows tool confirmation options." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-tool-config-options.png":::

## Accept or discard edits

Copilot lists the edited files in the **Total changes** list in the chat window.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png" alt-text="Screenshot that shows a list of edited files." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-keep-undo.png":::

Select each file to review changes individually. You can keep or undo edits made to each chunk of code.

Alternatively, in the **Total changes** list, select **Keep** or **Undo** for all edits made since the last time that you selected **Keep** or **Undo**.

## Revert edits

As you request code edits, you might want to revert some changes. To revert, select **Restore** next to the checkpoint before the prompt that includes changes you don't want.

:::image type="content" source="media/vs-2022/copilot-agent-mode/copilot-agent-checkpoint.png" alt-text="Screenshot that shows reverting edits." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-checkpoint.png":::

Currently, the Visual Studio Copilot agent doesn't support stepwise undo or redo.

## Interrupt an agent mode request

To interrupt an ongoing request, you can cancel it. Canceling a request stops all running tools and terminal commands.

To stop a build, select **Build** on the top toolbar, and then select **Cancel**. Or use the <kbd>Ctrl+Break</kbd> keyboard shortcut.

## Planning in agent mode (Preview)

> [!NOTE] 
> Planning is available in public preview with Visual Studio 2022 version 17.14. This feature is under active development and might evolve based on user feedback.

**Planning** in agent mode allows Copilot to break down complex or multistep requests into structured, trackable tasks before execution.

When Planning is active, Copilot:
- Creates a **user-facing markdown plan** that outlines goals and progress.  
- Maintains an internal **JSON plan** (`plan-{sessionId}.json`) that serves as an LLM-readable scratchpad for step tracking, reasoning, and coordination.  

This structure helps Copilot stay consistent, update its plan dynamically, and provide developers with visibility into what it’s doing.

### How it works

**Request analysis**
When a task requires multiple steps, Copilot enters planning mode.

**Plan creation**
- **Markdown plan**: Describes the task, steps, and progress in a readable format.
- **JSON plan**: A structured, LLM-readable format that captures the same plan in machine parsable form. This JSON file allows Copilot to update and interpret the plan consistently across turns.

**Execution and iteration**
Copilot executes each step in the plan, updating both files as it proceeds.

- The markdown plan updates visibly in the editor.
- The JSON plan evolves behind the scenes as Copilot refines, reorders, or adapts steps.

**Storage**
Both files are stored in `C:\Users\username\AppData\Local\Temp\VisualStudio\copilot-vs`.

### Tools used in Planning
When you enable Planning, a dedicated set of internal tools becomes active. These tools coordinate how Copilot creates, updates, and finalizes plans during execution.

| Tool | Description |
|------|--------------|
| **plan** | Generates the initial structured plan from the user request. |
| **adapt_plan** | Refines or adjusts the plan based on new context or feedback. |
| **update_plan_progress** | Updates step completion status and synchronizes plan state. |
| **record_observation** | Captures runtime results or insights that influence next actions. |
| **finish_plan** | Finalizes the plan once all steps are complete. |

> These tools allow Copilot to manage multi-step workflows incrementally, maintain execution state, and stay aligned with user intent.

### Enabling and managing Planning tools

To enable **Planning** in Visual Studio 2022 17.14 or later:

1. Go to to **Tools** > **Options** > **GitHub** > **Copilot**.
1. Select **Enable Planning**.
1. Once enabled, **Planning** tools appear in the **Tools** list in the chat window.

:::image type="content" source="media/vs-2022/copilot-agent-mode/planning-tools-list.png" alt-text="Screenshot that shows Planning tools group with all subtools enabled in agent mode." lightbox="media/vs-2022/copilot-agent-mode/copilot-agent-checkpoint.png":::

You can selectively disable the planning tool set directly in the Tools list in the chat window. If you need to disable planning tools, we recommend disabling all, not just one. Changes apply immediately to your current chat session.

> [!TIP]  
> Disabling individual tools allows you to experiment with different planning behaviors or debug specific steps during development.

### Limitations

- Plans are stored temporarily and deleted when the session ends unless saved manually.
- Slight latency overhead exists due to structured state tracking.
- Some specialized agents might not yet support planning.

### Give feedback

We’re actively improving Planning in agent mode. Share your feedback, report issues, or suggest improvements here: [Planning in Copilot Chat – Visual Studio Developer Community](https://developercommunity.visualstudio.com/)

## Frequently asked questions

### What visibility does agent mode have into my files?

Agent mode can manipulate only:

- Local files that are part of the solution.
- Local files that are in the open solution directory or its subdirectories.

Agent mode can't access files and directories excluded through file exclusion.

For terminal commands, agent mode has the same permissions as the running Visual Studio process and isn't limited to the preceding restrictions. Carefully review proposed terminal commands before you run them.

### I don't see ask mode and agent mode in the Copilot Chat window

Take the following troubleshooting steps in the specified order:

1. Make sure you're using Visual Studio 17.14 or later. Check the version at **Help** > **About Visual Studio**. If you're not using version 17.14 or later, open the Visual Studio Installer and update your build.

1. Make sure that you selected the **Enable agent mode in the chat pane** setting in **Tools** > **Options** > **GitHub** > **Copilot Chat**.

1. Try restarting Visual Studio.

### When should I use ask mode vs. agent mode?

- Ask mode is excellent when you want 100% confidence that no code edits are made unless you explicitly select **Apply** or copy and paste the code yourself.
- Agent mode can handle the same conceptual questions and generate code examples without applying them, along with its agent capabilities of editing code.
- If you want to use MCP capabilities, you must have agent mode selected.

### What happened to Copilot Edits in Visual Studio?

Agent mode is an evolution of Copilot Edits, with a greater ability to iterate on errors, use tools, and automatically apply code changes.

For the initial release of Visual Studio 2022 version 17.14, Copilot Edits is still available if you clear the **Enable agent mode in the chat pane** setting in **Tools** > **Options** > **GitHub** > **Copilot** > **Copilot Chat**.

### As an administrator, how do I control the use of agent mode for Visual Studio users?

Agent mode in Visual Studio is governed by the **Editor preview features** flag on the GitHub Copilot dashboard for administrators. If the administrator turns off this setting, users under that subscription can't use agent mode in Visual Studio.

For more information, see [Managing policies and features for GitHub Copilot in your enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#editor-preview-features).

## Related content

- [GitHub Copilot Edits](copilot-edits.md)
- [GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)
