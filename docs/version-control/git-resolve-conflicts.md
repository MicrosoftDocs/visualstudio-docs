---
title: Resolve merge conflicts in Visual Studio
titleSuffix: ""
description: Understanding, preventing, and resolving merge conflicts in Visual Studio.
ms.date: 11/14/2022
ms.topic: how-to
author: houghj16
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.custom: version-control
---
# Resolve merge conflicts in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

When you merge one branch into another, file changes from commits in one branch can conflict with the changes in the other. Git attempts to resolve these changes by using the history in your repo to determine what the merged files should look like. When it isn't clear how to merge changes, Git halts the merge and tells you which files conflict.

## Understand merge conflicts

The following image shows a basic example of how changes conflict in Git. In this example, the main branch and the bugfix branch make updates to the same lines of source code.

:::image type="content" source="media/vs-2022/git-conflicts-understand-1.png" alt-text="Diagram that shows a merge conflict.":::

If you try to merge the bugfix branch into main, Git can't determine which changes to use in the merged version. You might want to keep the changes in the main branch, the bugfix branch, or some combination of the two. Resolve this conflict with a merge commit in the main branch that reconciles the conflicting changes between the two branches.

:::image type="content" source="media/vs-2022/git-conflicts-understand-2.png" alt-text="Diagram that shows how a merge commit resolves a merge conflict.":::

The most common merge conflict scenario occurs when you pull updates from a remote branch to your local branch (for example, from origin/bugfix into your local bugfix branch). You can resolve these conflicts in the same way: create a commit on your local branch to reconcile the changes, and then complete the merge.

## Prevent merge conflicts

Git is good at automatically merging file changes in most circumstances, as long as the file contents don't change dramatically between commits. If your branch is far behind your main branch, consider rebasing your branches before you open a pull request. Rebased branches will merge into your main branch without conflicts.

## Resolve merge conflicts

- If you're collaborating with others in the same branch, you might see merge conflicts when you push your changes.

    :::image type="content" source="media/vs-2022/git-conflicts-push-link.png" alt-text="Screenshot of merge conflict after a push.":::

- Visual Studio detects if the local branch you've been working on is behind its remote tracking branch and then gives you options to choose from.

    :::image type="content" source="media/vs-2022/git-conflicts-pull-push-ui.png" alt-text="Screenshot of the options available when the local branch is behind the remote branch.":::

    > [!NOTE]
    > If your remote repository supports **Force Push**, you can enable it by using **Git** > **Settings**.

    In this example, select **Pull then Push** to include changes introduced to the remote repository. If there are any merge conflicts when you're pulling changes or trying to merge two branches, Visual Studio lets you know in the **Git Changes** window, in the **Git Repository** window, and on any files that have conflicts.

    :::image type="content" source="media/vs-2022/git-conflicts-notification-ui.png" alt-text="Screenshot of a merge conflict notification.":::

- The **Git Changes** window shows a list of files with conflicts under **Unmerged Changes**. To start resolving conflicts, double-click a file. Or if you have a file with conflicts opened in the editor, you can select **Open Merge Editor**.

    :::image type="content" source="media/vs-2022/git-conflicts-status-ui.png" alt-text="Screenshot of merge conflict status in the Git Changes window." lightbox="media/vs-2022/git-conflicts-status-ui.png":::

- In Merge Editor, start resolving your conflict by using any of the following methods (as depicted in the numbered screenshot):

    1. Go over your conflicts line by line, and choose between keeping the right or the left side by selecting the checkboxes.
    1. Keep or ignore all of your conflicting changes.
    1. Manually edit your code in the **Result** window.

    :::image type="content" source="media/vs-2022/git-conflicts-resolve-conflict.png" alt-text="Screenshot that shows how to resolve a merge conflict in Visual Studio 2022." lightbox="media/vs-2022/git-conflicts-resolve-conflict.png":::

    > [!TIP]
    > If you don't like the default layout in Merge Editor, feel free to change it by using the gear dropdown menu.
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-layout-options.png" alt-text="Screenshot of the Merge Editor layout options.":::
    >
    >For example, the following screenshot shows what the vertical view looks like:
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-vertical-view.png" alt-text="Screenshot of vertical view in the Merge Editor user interface." lightbox="media/vs-2022/git-conflicts-vertical-view.png":::

- When you're done resolving the merge conflicts, select **Accept Merge**. Repeat this process for all conflicting files.

    :::image type="content" source="media/vs-2022/git-conflicts-accept-merge.png" alt-text="Screenshot of the Accept Merge action in Visual Studio 2022.":::

- Use the **Git Changes** window to create a merge commit and resolve the conflict.

    :::image type="content" source="media/vs-2022/git-conflicts-merge-commit.png" alt-text="Screenshot of how to create a merge commit by using the Git Changes window.":::

    > [!NOTE]
    > If you need to keep all of your changes to a file, you can right-click it in the **Unmerged Changes** section and select **Keep Current (Local)** without having to open Merge Editor.
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-keep-changes.png" alt-text="Screenshot of the Keep Current menu option.":::

## Next steps

To continue your journey and learn more about resolving conflicts, see the [Git webpage for the merge command](https://git-scm.com/docs/git-merge).

## See also

- [The Git experience in Visual Studio](git-with-visual-studio.md)
- [Visual Studio and GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)
