---
title: git fetch, pull, push, & sync
description: Fetch, pull, push, and sync in Visual Studio to accomplish version control for your projects by using Git or Azure DevOps.
ms.date: 08/13/2024
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs

ms.subservice: general-ide
---
# Use git fetch, pull, push and sync for version control in Visual Studio

Visual Studio helps you keep your local branch synchronized with your remote branch through download (fetch and pull) and upload (push) operations.

You can fetch, pull, and sync in Visual Studio 2022 by using the **Git** menu.

:::image type="content" source="media/vs-2022/git-menu-fetch.png" alt-text="The Git menu with the Fetch option highlighted in Visual Studio 2022.":::

In the preceding screenshot, the **Fetch** option is highlighted. The Git menu also includes the following additional options:

- **Pull**
- **Push**
- **Sync (Pull then Push)**

You can also use the button controls in the **Git Changes** window to perform these operations, too.

:::image type="content" source="media/vs-2022/git-changes-window-options.png" alt-text="The Git Changes window with the Fetch, Pull, Push, and Sync button controls highlighted in Visual Studio 2022.":::

From left to right, the button controls include **Fetch**, **Pull**, **Push**, and **Sync**.

Additionally, there's also an **ellipsis** (**...**) button control for more operations. When you select it, a context menu appears. You can use it to fine-tune your fetch, pull, push, and sync operations.

:::image type="content" source="media/vs-2022/git-changes-window-ellipsis.png" alt-text="The context menu that appears after you select the ellipsis button control in the Git Changes window in Visual Studio 2022.":::

## Fetch

It's important to fetch and pull before you push. Fetching checks if there are any remote commits that you should incorporate into your local changes. If you see any, pull first to prevent any upstream merge conflicts.

When you fetch a branch, the **Git Changes** window has an indicator under the branch drop-down, which displays the number of unpulled commits from the remote branch. This indicator also shows you the number of unpushed local commits.

The indicator also functions as a link to take you to the commit history of that branch in the **Git Repository** window. The top of the history now displays the details of these incoming and outgoing commits. From here, you can also decide to Pull or Push the commits.

## Pull

Always pull before you push. When you pull first, you can prevent upstream [merge conflicts](git-resolve-conflicts.md).

## Push

When you create commits, you've inherently saved local snapshots of your code. Use **Push** to push the commits to GitHub, where you can store them as backups or share your code with others.

But, as previously mentioned, always pull before you push. As a safe guard, Visual Studio doesn't allow you to push commits if your local branch is behind the remote branch. If you try to push, a dialog prompts you to pull before pushing.

## Sync

Use this operation to both pull, then push, sequentially.

## Related content

- [Browse Git repositories](git-browse-repository.md)
- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo.md)
