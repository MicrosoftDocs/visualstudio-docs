---
title: Browse a repo & compare commits
description: Browse any Git repository in Visual Studio by using the Git Repository window.
ms.date: 01/21/2022
ms.topic: how-to
author: Taysser-Gherfal
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
---
# Browse Git repositories & compare commits in Visual Studio

The **Git Changes** window provides a seamless way to interact with Git while coding without having to switch away from your code. But there are times when it makes more sense to focus on your Git repository. For example, you might need to get a good picture of what your team has been working on or maybe compare two commits to investigate a bug.

## Browse through local and remote branches

To get started, open the **Git Repository** window by selecting **Git Repository** on the **View** menu. You can also access the **Git Repository** window by selecting the **outgoing/incoming** links in the **Git Changes** window and on the status bar.

:::image type="content" source="media/vs-2022/git-repository-browse-ui.png" alt-text="Screenshot that shows the anatomy of the Git Repository window." lightbox="media/vs-2022/git-repository-browse-ui.png":::

The **Git Repository** window contains three main sections, as numbered in the preceding screenshot:

1. **Branches**: Git empowers users to multitask and experiment with their code through branches. If you're working on multiple features at the same time or if you want to explore ideas without affecting your working code, branching can be helpful.
1. **Graph**: This section visualizes the state of your branch. It has three subsections:

   - **Incoming** shows incoming commits that your team has been contributing.
   - **Outgoing** shows your local commits that you still haven't pushed.
   - **Local History** shows the rest of commits tracked by your local repository.
1. **Commit**: Selecting any commit in the **Graph** section opens its details. You can check the changes that a commit has introduced by selecting them, which shows a difference. For example, the previous screenshot shows the changes that one commit introduced to the *Files.csproj* file.

You can browse though any local or remote branch without having to switch your branch. When you find a commit that you want to focus on, select the **Open in New Tab** button to open the commit on a different tab.

:::image type="content" source="media/vs-2022/git-repository-open-new-tab.png" alt-text="Screenshot of how to open a commit on a new tab." lightbox="media/vs-2022/git-repository-open-new-tab.png":::

:::image type="content" source="media/vs-2022/git-repository-details-tab.png" alt-text="Screenshot of the tab for commit details." lightbox="media/vs-2022/git-repository-details-tab.png":::

> [!TIP]
> To display your commit in full screen, detach your **Commit** tab and maximize the **Commit** window by using the **Maximize** button. You can also select your favorite diff configuration by selecting **Diff Configuration** (the gear icon).
>
>:::image type="content" source="media/vs-2022/git-repository-commit-details-full-screen.png" alt-text="Screenshot of full-screen commit details with diff configurations." lightbox="media/vs-2022/git-repository-commit-details-full-screen.png":::

## Compare commits

To compare any two commits in your branch, use the **Ctrl** key to select the two commits that you want to compare. Then right-click one of them and select **Compare Commits**.

:::image type="content" source="media/vs-2022/git-repository-compare-commits-option.png" alt-text="Screenshot of how to compare two commits." lightbox="media/vs-2022/git-repository-compare-commits-option.png":::

:::image type="content" source="media/vs-2022/git-repository-compare-commits-ui.png" alt-text="Screenshot of compared commits." lightbox="media/vs-2022/git-repository-compare-commits-ui.png":::

> [!TIP]
>Similar to **Commit Details**, you can use the **Open in New Tab** button to open the comparison on a different tab or maximize it on the screen.

## Create a branch from a commit

In Visual Studio, you can use the **Git Graph** pane in the **Git Repository** window to create branches from previous commits. To do so, right-click the commit you would like to create a new branch from, and then select **[New Branch](git-create-branch.md)**.

:::image type="content" source="media/vs-2022/git-create-branch-from-commit.png" alt-text="Screenshot of the Git Graph pane of the Git Repository window.":::

> [!NOTE]
> The equivalent command for this action is `git branch <branchname> [<commit-id>]`.

> [!TIP]
> To learn how the [Preview](/visualstudio/releases/2022/release-notes-preview) version of Visual Studio 2022 makes it easy to checkout commits, see the "Checkout commits" section of the [Introducing new Git features to Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/introducing-new-git-features-to-visual-studio-2022/#checkout-commits) blog post.

## Next steps

To continue your journey, see [Manage Git repositories in Visual Studio](git-manage-repository.md).

## See also

- [The Git experience in Visual Studio](git-with-visual-studio.md)
- [Visual Studio and GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)
