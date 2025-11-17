---
title: Resolve merge conflicts in Visual Studio
titleSuffix: ""
description: Understand how Git works to resolve conflicting changes that cause merge conflicts in your code branches and project files in Visual Studio.
ms.date: 11/15/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs

ms.subservice: general-ide
---
# Resolve merge conflicts in Visual Studio

When you merge one branch into another, file changes from commits in one branch can conflict with the changes in the other. Git attempts to resolve these changes by using the history in your repo to determine what the merged files should look like. When it isn't clear how to merge changes, Git halts the merge and tells you which files conflict.

## Prevent merge conflicts

Git is good at automatically merging file changes in most circumstances, as long as the file contents don't change dramatically between commits. If your branch is far behind your main branch, consider rebasing your branches before you open a pull request. Rebased branches will merge into your main branch without conflicts.

## Resolve merge conflicts

- If you're collaborating with others in the same branch, you might see merge conflicts when you push your changes.

:::moniker range="visualstudio"

:::image type="content" source="media/visualstudio/git-conflicts-push-link.png" alt-text="Screenshot that shows a merge conflict after a push.":::

:::moniker-end

:::moniker range="<=vs-2022"

:::image type="content" source="media/vs-2022/git-conflicts-push-link.png" alt-text="Screenshot of merge conflict after a push.":::

:::moniker-end

- Visual Studio detects if the local branch you've been working on is behind its remote tracking branch and then gives you options to choose from.

    :::image type="content" source="media/vs-2022/git-conflicts-pull-push-ui.png" alt-text="Screenshot of the options available when the local branch is behind the remote branch.":::

    > [!NOTE]
    > If your remote repository supports **Force Push**, you can enable it by using **Git** > **Settings**.

    In this example, select **Pull then Push** to include changes introduced to the remote repository. If there are any merge conflicts when you're pulling changes or trying to merge two branches, Visual Studio lets you know in the **Git Changes** window, in the **Git Repository** window, and on any files that have conflicts.

    :::image type="content" source="media/vs-2022/git-conflicts-notification-ui.png" alt-text="Screenshot of a merge conflict notification.":::

- The **Git Changes** window shows a list of files with conflicts under **Unmerged Changes**. To start resolving conflicts, double-click a file. Or if you have a file with conflicts opened in the editor, you can select **Open Merge Editor**.

:::moniker range="visualstudio"

:::image type="content" source="media/visualstudio/git-conflicts-status-ui.png" alt-text="Screenshot that shows merge conflict status in the Git Changes window." lightbox="media/visualstudio/git-conflicts-status-ui.png":::
    
:::moniker-end

:::moniker range="vs-2022"

:::image type="content" source="media/vs-2022/git-conflicts-status-ui.png" alt-text="Screenshot of merge conflict status in the Git Changes window." lightbox="media/vs-2022/git-conflicts-status-ui.png":::

:::moniker-end

- In Merge Editor, start resolving your conflict by using any of the following methods (as depicted in the numbered screenshot):

    1. Go over your conflicts line by line, and choose between keeping the right or the left side by selecting the checkboxes.

       \- or -

    1. Select the **Take Incoming** button (or press **F10**) to accept all the incoming changes, or **Take Current** button (or press F11) to keep your current version of all conflicting changes. You can do the same thing by selecting one of the checkboxes at the top of either side-by-side frame.

       \- or -

    1. Manually edit your code in the **Result** window.
    
    :::moniker range="visualstudio"
    
    :::image type="content" source="media/visualstudio/git-conflicts-resolve-conflict.png" alt-text="Screenshot that shows how to resolve a merge conflict in Visual Studio." lightbox="media/visualstudio/git-conflicts-resolve-conflict.png":::

    :::moniker-end

    :::moniker range="<=vs-2022"

    :::image type="content" source="media/vs-2022/git-conflicts-resolve-conflict.png" alt-text="Screenshot that shows how to resolve a merge conflict in Visual Studio 2022." lightbox="media/vs-2022/git-conflicts-resolve-conflict.png":::

    :::moniker-end

    :::moniker range="visualstudio"

    > [!TIP]
    > If you don't like the default layout in Merge Editor, you can change it by using the gear menu.
    >
    > :::image type="content" source="media/visualstudio/git-conflicts-layout-options.png" alt-text="Screenshot that shows the Merge Editor layout options.":::
    >
    >For example, the following screenshot shows what the vertical view looks like:
    >
    > :::image type="content" source="media/visualstudio/git-conflicts-vertical-view.png" alt-text="Screenshot that shows the vertical view of the Merge Editor." lightbox="media/visualstudio/git-conflicts-vertical-view.png":::

    :::moniker-end

    :::moniker range="<=vs-2022"

    > [!TIP]
    > If you don't like the default layout in Merge Editor, feel free to change it by using the gear dropdown menu.
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-layout-options.png" alt-text="Screenshot of the Merge Editor layout options.":::
    >
    >For example, the following screenshot shows what the vertical view looks like:
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-vertical-view.png" alt-text="Screenshot of vertical view in the Merge Editor user interface." lightbox="media/vs-2022/git-conflicts-vertical-view.png":::

    :::moniker-end

- When you're done resolving the merge conflicts, select **Accept Merge**. Repeat this process for all conflicting files.

    :::image type="content" source="media/vs-2022/git-conflicts-accept-merge.png" alt-text="Screenshot of the Accept Merge action in Visual Studio 2022.":::

- Use the **Git Changes** window to create a merge commit and resolve the conflict.

    :::moniker range="visualstudio"

    :::image type="content" source="media/visualstudio/git-conflicts-merge-commit.png" alt-text="Screenshot that shows how to create a merge commit by using the Git Changes window.":::
  
    :::moniker-end

    :::moniker range="<=vs-2022"

    :::image type="content" source="media/vs-2022/git-conflicts-merge-commit.png" alt-text="Screenshot of how to create a merge commit by using the Git Changes window.":::
  
    :::moniker-end

    :::moniker range="visualstudio"

    > [!NOTE]
    > If you want to keep all of your changes to a file, you can right-click it in the **Unmerged Changes** section and select **Keep Current (Local)** without having to open Merge Editor.
    >
    > :::image type="content" source="media/visualstudio/git-conflicts-keep-changes.png" alt-text="Screenshot that shows the Keep Current menu option.":::

    :::moniker-end

    :::moniker range="<=vs-2022"

    > [!NOTE]
    > If you want to keep all of your changes to a file, you can right-click it in the **Unmerged Changes** section and select **Keep Current (Local)** without having to open Merge Editor.
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-keep-changes.png" alt-text="Screenshot of the Keep Current menu option.":::

    :::moniker-end

> [!TIP]
> To learn more about the accessibility options available to you, see the [Git keyboard shortcuts](../ide/reference/accessibility-tips-and-tricks.md#git-keyboard-shortcuts) section of the [Accessibility tips and tricks for Visual Studio](../ide/reference/accessibility-tips-and-tricks.md) page.

## Configure your diff tool

If you set your [`.gitconfig` file](https://git-scm.com/docs/git-config) to use a third-party diff tool such as BeyondCompare or KDiff3, Visual Studio respects it. Whenever Visual Studio would normally display a diff, a separate window is opened in the tool of your choice. For an example, see this [Stack Overflow](https://stackoverflow.com/questions/4466238/how-to-configure-visual-studio-to-use-beyond-compare) question.

## Related content

- [Git webpage for the merge command](https://git-scm.com/docs/git-merge)
- [The Git experience in Visual Studio](git-with-visual-studio.md)
