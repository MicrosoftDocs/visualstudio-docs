---
title: 'GitHub Copilot Edits in Visual Studio'
description: Use GitHub Copilot Edits to iterate quickly on code changes across multiple files in Visual Studio version 17.13 and later.
ms.date: 2/11/2025
ms.update-cycle: 180-days
ms.topic: overview
author: anandmeg
ms.author: meghaanand
ms.manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= vs-2022'
---
# What is GitHub Copilot Edits?

GitHub Copilot Edits, a feature of GitHub Copilot Chat, is designed to help iterating across multiple files more efficient. This feature is available with the release of Visual Studio 2022 version 17.13.

Edits combines the conversational flow of chat and an inline review experience, offering the following benefits:
- **Preview with clarity**: Know exactly what's being modified with a summary of the affected files and the proposed changes.
- **Review with flow**: View code diffs inline, directly in your editor. Use the `TAB` key to accept or the `Alt+Del` key to reject individual changes, or apply/dismiss all at once.
- **Iterate with confidence**: Use checkpoints to revisit earlier iterations of a code file or try an alternative approach anytime for new ideas.

## Prerequisites
+ [Visual Studio 2022 version 17.13](/visualstudio/releases/2022/release-history) and later offer Copilot Edits.
+ [Sign in to Visual Studio using a GitHub account](work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot). <br/>
    + You can use [GitHub Copilot for Free](copilot-free-plan.md). Sign up and leverage AI to code faster and more efficiently.

## When to use Copilot Edits vs. Copilot Chat


|   Functionality   | Copilot Chat | Copilot Edits |
| ------------- | ------------- | ------------- |
| Primary use case | **General purpose** conversational interface for understanding programming concepts, asking questions about code, and generating code. | **Focused multi-file editing** interface with code review, in-file preview, and rollback experience to make iterating on code across multiple files easier. |
| Previewing proposed code | **Manually apply** each code block to each file in your solution to evaluate code-diff. | **Automatically applies** proposed code diff in each code file, making comprehension of the proposed changes easier.|
| Code review experience | Accept or reject a **file worth of changes** at once. | Accept or reject **individual chunks of code** within a file. |
| Versioning | Can use existing version control. | Adds a **rollback experience** to reset edited files to a previous state. Tracks all changes - proposed, accepted, dismissed, and manual edits made to the file. These checkpoints are retained until the user closes Visual Studio. |

## Using Copilot Edits

### Start an Edits thread

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
