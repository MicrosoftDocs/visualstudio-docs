---
title: 'GitHub Copilot Agent in Visual Studio'
description: Use GitHub Copilot Agent iterates on code by making code edits, running commands, and reading error/build context
ms.date: 5/8/2025
ms.topic: overview
author: aayim
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# What is GitHub Copilot Edits?

With GitHub Copilot's agent mode in Visual Studio, you can use natural language to specify a high-level task, and let AI autonomously reason about the request, plan the work needed, and apply the changes to your codebase. Agent mode uses a combination of code editing and tool invocation to accomplish the task you specified. As it processes your request, it monitors the outcome of edits and tools, and iterates to resolve any issues that arise.

## Prerequisites
+ [Visual Studio 2022 version 17.14](/visualstudio/releases/2022/release-history) and later offer Copilot Agent.
    + In the initial 17.14 release, you will need to first enable 'Agent Mode' in Tools > Options > GitHub > Copilot.
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot). <br/>
    + You can use [GitHub Copilot for Free](copilot-free-plan.md). Sign up and leverage AI to code faster and more efficiently.


## How to use Copilot Agent

In agent mode, Copilot operates autonomously and determines the relevant context for your prompt.

Follow these steps to get started:

1. Make sure that agent mode is enabled by clicking Tools > Options > GitHub > Copilot and ensuring the "Agent mode" setting is checked.

2. Enable agent mode by opening the GitHub Copilot window, clicking the mode dropdown that says "Ask", then select "Agent".

3. Enter your prompt for making edits in the chat input field and select Send (Enter) to submit it. You can specify a high-level requirement, and you don't have to specify which files to work on. In agent mode, Copilot determines the relevant context and files to edit autonomously.

4. Agent mode might invoke multiple tools to accomplish different tasks. Optionally, select the Tools icon to configure which tools can be used for responding to your request.

5. Confirm tool invocations and terminal commands. Before running a terminal command or non-builtin tool, Copilot requests confirmation to continue. This is because tools might run locally on your machine and perform actions that modify files or data.

6. Copilot detects issues and problems in code edits and terminal commands and will iterate and perform additional actions to resolve them. For example, agent mode might run unit tests as a result of a code edit. If the tests fail, it uses the test outcome to resolve the issue. Copilot Edits agent mode iterates multiple times to resolve issues and problems.

7. As Copilot processes your request, notice that Copilot streams the suggested code edits directly in the editor. The Chat view shows the list of files that were edited in bold text. The editor overlay controls enable you to navigate between the suggested edits.

8. Review the suggested edits and accept or discard the suggested edits.

9. Continue to iterate on the code changes to refine the edits or implement additional features.

## Agent mode tools

Agent mode can use the following tools:

* Built-in tools
* MCP tools

You can view and manage the tools that can be used for responding to a request. Select the Tools icon in the Chat view to view and manage the tools that are available in agent mode.

Based on the outcome of a tool, Copilot might invoke other tools to accomplish the overall request. For example, if a code edit results in syntax errors in the file, Copilot might explore another approach and suggest different code changes.

## Manage tool approvals

When a tool is invoked, Copilot requests confirmation to run the tool. This is because tools might run locally on your machine and perform actions that modify files or data.

In the Chat view, after a tool invocation, use the Continue button dropdown options to automatically confirm the specific tool for the current session, workspace, or all future invocations.

You can reset the tool confirmations by using the Chat: Reset Tool Confirmations command in the Command Palette.

GitHub Copilot Agent currently does not support automatic approval of all tools.

## Accept or discard edits

Copilot lists the files that were edited in the list of the changed files in the Chat view.

Use the Keep or Undo button to accept or reject the edits for a given file.

Use the Keep or Undo controls in the editor or Chat view to accept or reject individual or all suggested edits.

>>>> I DON'T THINK THIS IS TRUE When you close VS Code, the status of the pending edits is remembered. When you reopen VS Code, the pending edits are restored, and you can still accept or discard the edits.

## Revert edits
As you're sending requests to make edits to your code, you might want to roll back some of these changes, for example, because you want to use another implementation strategy or because Copilot starts walking down the wrong path when generating edits.

>>>> You can use the Undo Last Edit control in the Chat view title bar to revert the last edits and return to the state before sending the last request. After you perform an undo of the last edit, you can redo those edits again by using the Redo Last Edit control in the Chat view title bar.

## Interrupt an agent mode request
To interrupt an ongoing request, you can either Pause it or Cancel it. When you pause a request, Copilot stops processing the request and waits for your input.

When you pause a request, you can either choose to enter a new prompt, which cancels the current request, or you can choose to resume the current request.

When you cancel a request, Copilot interrupts and ends the active request. You can still review and accept or reject the changes that were made up to that point.

## Frequently Asked Questions

### 


## When to use Copilot Edits vs. Copilot Chat


|   Functionality   | Copilot Chat | Copilot Edits |
| ------------- | ------------- | ------------- |
| Primary use case | **General purpose** conversational interface for understanding programming concepts, asking questions about code, and generating code. | **Focused multi-file editing** interface with code review, in-file preview, and rollback experience to make iterating on code across multiple files easier. |
| Previewing proposed code | **Manually apply** each code block to each file in your solution to evaluate code-diff. | **Automatically applies** proposed code diff in each code file, making comprehension of the proposed changes easier.|
| Code review experience | Accept or reject a **file worth of changes** at once. | Accept or reject **individual chunks of code** within a file. |
| Versioning | Can use existing version control. | Adds a **rollback experience** to reset edited files to a previous state. Tracks all changes - proposed, accepted, dismissed, and manual edits made to the file. These checkpoints are retained until the user closes Visual Studio. |

### What happened to GitHub Copilot Edits in Visual Studio

### How do I control availability ofAgent Mode for my organization?

Agent mode uses tools to accomplish specialized tasks while processing a user request. Examples of such tasks are listing the files in a directory, editing a file in your workspace, running a terminal command, getting the output from the terminal, and more.

#####################

Use the Continue button dropdown options to automatically confirm the specific tool for the current session, workspace, or all future invocations. Learn how to manage tool approvals and approve all tool invocations.

In Visual Studio, open the GitHub Copilot window, click the mode dropdown that says "Ask", select "Agent", then enter your prompt.

Copilot agent mode can create apps from scratch, perform refactorings across multiple files, write and run tests, and migrate legacy code to modern frameworks. It can automatically generate documentation, integrate new libraries, or help answer questions about a complex codebase. Copilot agent mode helps you be super-productive by having an AI collaborator that understands the workspace. It can orchestrate your inner development flow while keeping you in control.

In an ideal world, you would just care about the final output of Copilot agent mode, but it can sometimes make mistakes and go off track. To easily intervene and undo in those situations, every tool invocation is transparently displayed in the UI, terminal tool requires approval. Should you need to re

Copilot agent mode operates in a more autonomous and dynamic manner to achieve the desired outcome. To process a request, Copilot loops over the following steps and iterates multiple times as needed:

Determines the relevant context and files to edit autonomously.
Offers both code changes and terminal commands to complete the task. For example, Copilot might compile code, install packages, run tests, and more.
Monitors the correctness of code edits and terminal command output and iterates to remediate issues.
Copilot agent mode uses a set of tools to accomplish these tasks.



:::image type="content" source="media/vs-2022/copilot-edits/getting-started-with-edits.gif" alt-text="Animated screenshot that shows starting a Copilot Edits thread and getting a response." lightbox="media/vs-2022/copilot-edits/getting-started-with-edits.gif":::

1.	Select **View** > **GitHub Copilot Chat** to launch GitHub Copilot Chat. You can also launch it from the GitHub Copilot status icon.
2.	Select **Create new Edit session** to create a new Edits thread.
3.	Enter a chat prompt using natural language about the specific edit you want to make. To help Copilot Edits provide better code suggestions, you can also add relevant context to your prompt. [Reference context](copilot-chat-context.md#reference) by typing the `#` commands to refer to a file, your solution, errors, or a symbol specifically or [attach images](copilot-chat-context.md#attach-images) to provide additional context.

> [!TIP]
> We suggest you ask for one commit’s worth of changes at a time. The more you can break down a problem, the better the result.

### Accept or discard edits

After Copilot Edits proposes a code iteration, you can preview these suggestions in your code files. You can then **Accept** to commit the proposed changes.

#### Review each proposed change

:::image type="content" source="media/vs-2022/copilot-edits/accept-by-chunk.gif" alt-text="Animated screenshot that shows applying edits to file and accepting by chunk." lightbox="media/vs-2022/copilot-edits/accept-by-chunk.gif":::

+ Start by clicking on a filename.
+ The file opens and proposed changes are displayed as a diff in the code editor.

+ Use `TAB` to accept a proposal, `Alt+Del` to reject a proposal, or `F8` to go to the next proposal.

+ If you accept or reject a proposal, the cursor will automatically move to the next proposal.

#### Accept all proposed changes in a file

:::image type="content" source="media/vs-2022/copilot-edits/accept-file.gif" alt-text="Animated screenshot that shows accepting edits to a specific file." lightbox="media/vs-2022/copilot-edits/accept-file.gif":::


Click the checkbox next to a filename to accept all proposed changes specific to a file.

#### Accept all proposed changes in all files

:::image type="content" source="media/vs-2022/copilot-edits/accept-all.gif" alt-text="Animated screenshot that shows accepting all edits on all files." lightbox="media/vs-2022/copilot-edits/accept-all.gif":::

Select **Accept all** to accept the proposed code changes across all files where changes are available. Files with proposed changes are bolded.

### Revert edits

#### Revert to the original state

:::image type="content" source="media/vs-2022/copilot-edits/reset-iteration.png" alt-text="Screenshot that shows reverting file to the original state before any edits." lightbox="media/vs-2022/copilot-edits/reset-iteration.png":::

While reviewing file changes, if you accept or reject a code proposal you didn't mean to, select **Reset changes** to reset the listed files to their state before the iteration was generated.

Reset changes also resets any manual changes made to the files.
A popup dialog confirms the action before reverting file states

### Revert to a previous iteration

:::image type="content" source="media/vs-2022/copilot-edits/reset-to-previous-iteration.png" alt-text="Screenshot that shows reverting file to a previous iteration." lightbox="media/vs-2022/copilot-edits/reset-to-previous-iteration.png":::


At any time, you can select the **Reset to Iteration** on a previous iteration to reset all proposed and manual changes made to the listed files.
A popup dialog confirms the action before reverting file states.

## Related content

- [Install and manage GitHub Copilot in Visual Studio](visual-studio-github-copilot-install-and-states.md)
- [GitHub Copilot experience for Visual Studio](visual-studio-github-copilot-extension.md)
- [GitHub Copilot Chat experience for Visual Studio](visual-studio-github-copilot-chat.md)
- [About GitHub Copilot Free](https://aka.ms/ghdocscopilotfreepage)
