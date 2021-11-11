---
title: Resolve merge conflicts in Visual Studio
titleSuffix: ""
description: Understanding, preventing and resolving merge conflicts in Visual Studio.
ms.date: 11/10/2021
ms.topic: how-to
author: Taysser-Gherfal
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
---
# Resolve merge conflicts in Visual Studio

When you merge one branch into another, file changes from commits in one branch can conflict with the changes in the other. Git attempts to resolve these changes by using the history in your repo to determine what the merged files should look like. When it isn't clear how to merge changes, Git halts the merge and tells you which files conflict.

## Understand merge conflicts

The following image shows a very basic example of how changes conflict in Git. Both the main and bugfix branch make updates to the same lines of source code.

:::image type="content" source="media/vs-2022/git-conflicts-understand-1.png" alt-text="Diagram that shows a merge conflict.":::

If you try to merge the bugfix branch into main, Git can't determine which changes to use in the merged version. You may want to keep the changes in the main branch, the bugfix branch, or some combination of the two. Resolve this conflict with a merge commit on the main branch that reconciles the conflicting changes between the two branches.

:::image type="content" source="media/vs-2022/git-conflicts-understand-2.png" alt-text="Diagram that shows how a merge commit resolves a merge conflict.":::

The most common merge conflict situation is when you pull updates from a remote branch to your local branch, for example from origin/bugfix into your local bugfix branch. Resolve these conflicts in the same way - create a merge commit on your local branch reconciling the changes and complete the merge.

## Prevent merge conflicts

Git is very good at automatically merging file changes in most circumstances, provided that the file contents don't change dramatically between commits. Consider rebasing branches before you open up a pull request if your branch is far behind your main branch. Rebased branches will merge into your main branch without conflicts.

## Resolve merge conflicts

- If you are collaborating with others on the same branch, you might also get merge conflicts when you push your changes.

    :::image type="content" source="media/vs-2022/git-conflicts-push-link.png" alt-text="Screenshot of merge conflict after a push.":::

- When you push your changes, Visual Studio detects if the local branch you've been working on is behind its remote tracking branch and then gives you a number of options to choose from.

    :::image type="content" source="media/vs-2022/git-conflicts-pull-push-ui.png" alt-text="Screenshot of the options available when the local branch is behind remote branch.":::

    > [!NOTE]
    > You can enable Force Push if your remote repository supports it by enabling it through **Git > Settings**.

- Let’s choose to **Pull then Push** to include changes introduced to the remote repository. If there are any merge conflict(s) when pulling changes or attempting to merge two branches, Visual Studio lets us know in the Git Changes window, the Git repository window and on any documents with conflicts.

    :::image type="content" source="media/vs-2022/git-conflicts-notification-ui.png" alt-text="Screenshot of merge conflict notification.":::

- The **Git Changes** window shows a list of documents with conflicts under Unmerged Changes. To start resolving conflicts, you can double-click on the document you would like to resolve or if you have a document with conflicts opened in the editor, you can select Open Merge Editor.

    :::image type="content" source="media/vs-2022/git-conflicts-status-ui.png" alt-text="Screenshot of merge conflict status in the Git Changes window." lightbox="media/vs-2022/git-conflicts-status-ui.png":::

- After you get the **Merge Editor** open, you can start resolving your conflict by using any of the following methods (as depicted in the numbered screenshot).

    1. Go over your conflicts line by line and choose between keeping the right or the left side by checking the checkboxes.
    1. Keep or ignore all of your conflicting changes.
    1. Manually edit your code in the Result window.

    :::image type="content" source="media/vs-2022/git-conflicts-resolve-conflict.png" alt-text="Screenshot that shows how to resolve a merge conflict in Visual Studio 2022." lightbox="media/vs-2022/git-conflicts-resolve-conflict.png":::

    > [!TIP]
    > If you don’t like the Merge Editor default layout, feel free to change it by using the gear dropdown menu.
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-layout-options.png" alt-text="Screenshot of the Merge Editor layout options.":::
    >
    >For example, the following screenshot shows what the Vertical View looks like:
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-vertical-view.png" alt-text="Screenshot of vertical view in the Merge Editor user interface." lightbox="media/vs-2022/git-conflicts-vertical-view.png":::

- When you're done resolving the merge conflicts, select **Accept Merge**. Repeat this for all conflicting files.

    :::image type="content" source="media/vs-2022/git-conflicts-accept-merge.png" alt-text="Screenshot of Accept Merge action in Visual Studio 2022.":::

- Use the **Git Changes** window to create a merge commit and resolve the conflict.

    :::image type="content" source="media/vs-2022/git-conflicts-merge-commit.png" alt-text="Screenshot of how to create a merge commit by using the Git Changes window.":::

    > [!NOTE]
    > If you need to keep all of your changes to a document, you can right-click it under the **Unmerged Changes** section and select **Keep Current (Local)** without having to open the Merge Editor.
    >
    > :::image type="content" source="media/vs-2022/git-conflicts-keep-changes.png" alt-text="Screenshot of the 'Keep Current and Take Incoming menu options.":::

## Next steps

To continue your journey, use the following link to learn more about merge and merge conflicts [Git merge and resolving conflicts](https://git-scm.com/docs/git-merge).

## See also

- [The Git experience in Visual Studio](../ide/git-with-visual-studio.md)
- [Visual Studio & GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)