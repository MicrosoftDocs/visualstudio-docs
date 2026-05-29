---
title: Use the GitHub Copilot plan agent
description: Create and refine implementation plans with GitHub Copilot in Visual Studio before making code changes.
ms.date: 05/20/2026
ms.update-cycle: 180-days
ms.topic: how-to
author: RoseHJM
ms.author: rosemalcolm

ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
ms.custom: awp-ai
monikerRange: 'visualstudio'
---
# Use the GitHub Copilot plan agent

By using the GitHub Copilot plan agent in Visual Studio, you can create and iterate on an implementation plan before making code changes. The plan agent explores your codebase by using read-only tools, asks clarifying questions when needed, and drafts a plan that you can review and refine by using Copilot.

Unlike agent mode, the plan agent doesn't edit files or run implementation steps while you're planning. When you're satisfied with the plan, you can hand it off to agent mode to execute it.

## Prerequisites

- Install the latest version of [Visual Studio](/visualstudio/releases/2026/release-notes).
- [Sign in to Visual Studio by using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot).

## When to use the plan agent

The plan agent is useful when you want to align on an approach before you start implementation.

- **Big features**: Break down complex work into clear, reviewable steps before code changes start.
- **Unfamiliar codebases**: Let Copilot inspect the solution and explain likely touch points before it edits anything.
- **Team collaboration**: Share the saved markdown plan for review before handing it off for implementation.

## Start a plan

1. Open the Copilot Chat window.

1. In the agent picker, select **Plan**.

   :::image type="content" source="media/visualstudio/copilot-plan-agent/copilot-plan-mode-selected.png" alt-text="Screenshot of Copilot Chat with Plan selected in the mode dropdown." lightbox="media/visualstudio/copilot-plan-agent/copilot-plan-mode-selected.png":::

1. Enter a prompt that describes what you want to build, refactor, or investigate.

1. Copilot explores your codebase with read-only tools. If the task is ambiguous, it asks clarifying questions before it drafts a plan.

## Review and refine the plan

After it gathers enough context, Copilot creates an implementation plan that you can review together in chat.

:::image type="content" source="media/visualstudio/copilot-plan-agent/copilot-plan-created.png" alt-text="Screenshot of Copilot Chat showing an implementation plan created by the plan agent." lightbox="media/visualstudio/copilot-plan-agent/copilot-plan-created.png":::

As you review the draft, you can ask Copilot to:

- Split a large step into smaller tasks.
- Add edge cases or validation steps.
- Reconsider which files or components to change.
- Revise the order of implementation.

You can also edit the plan directly by selecting **Edit markdown** in the plan view, or by manually editing the saved plan file in your repository.

For straightforward requests, Copilot might draft the plan immediately without asking follow-up questions.

## Work with saved plans

By default, Copilot saves each plan as a markdown file at `.copilot/plans/plan-{title}.md`. You can change the save location in **Tools** > **Options** > **GitHub** > **Copilot** > **Copilot Chat** under **Plan output directory**.

This plan file is the source of truth for the task. You can:

- Edit the markdown file directly in the editor.
- Continue refining the plan through chat.
- Share the plan with teammates before implementation starts.

When you edit the plan file manually, Copilot detects the changes and keeps the chat state in sync with the updated plan.

## Implement the plan with agent mode

When you're ready to move from planning to execution, select **Implement plan**.

:::image type="content" source="media/visualstudio/copilot-plan-agent/copilot-plan-implementation-in-progress.png" alt-text="Screenshot of Copilot Chat showing agent mode implementing a saved plan." lightbox="media/visualstudio/copilot-plan-agent/copilot-plan-implementation-in-progress.png":::

Copilot hands the plan off to agent mode, which works through the steps and starts making code changes. No implementation changes happen until you explicitly choose to implement the plan.

## Plan agent versus Planning in agent mode

The **Plan agent** and **Planning in agent mode** are related, but they aren't the same feature.

| Feature | Best used when | Behavior |
| ------- | -------------- | -------- |
| Plan agent | You want to align on an approach before implementation starts. | Runs as a separate chat mode, explores by using read-only tools, saves plan files in `.copilot/plans/`, and hands off by using **Implement plan**. |
| Planning in agent mode | You're already running agent mode and agent mode automatically leverages in-session structured planning for complex tasks. | Runs inside agent mode and tracks execution planning state during that session. |

For details about planning inside agent mode, see [Planning in agent mode](copilot-agent-mode.md#planning-in-agent-mode).

## Related content

- [Get started with GitHub Copilot](visual-studio-github-copilot-get-started.md)
- [Get started with GitHub Copilot agent mode](copilot-agent-mode.md)
- [What is GitHub Copilot Edits?](copilot-edits.md)
- [Customize chat responses and set context](copilot-chat-context.md)