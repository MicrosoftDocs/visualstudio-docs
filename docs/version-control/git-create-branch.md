---
title: Create a branch
description: Create a branch for source control in Visual Studio with Git.
ms.date: 11/23/2022
ms.topic: how-to
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.custom: version-control
---
# Create a Git branch in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

It's easy to create a new branch in Visual Studio; all you have to do is base it off an existing branch.

Here's how.

1. To start, make sure you've got a previously [created](git-create-repository.md) or [cloned](git-clone-repository.md) repo open.

1. From the **Git** menu, select **New Branch**.

    :::image type="content" source="media/vs-2022/git-menu-new-branch.png" alt-text="Screenshot of the New Branch option in the Git menu.":::

1. In the **Create a new branch** dialog box, enter a branch name.

    > [!TIP]
    > For branch naming details, see [Special characters in branch and tag names](https://docs.github.com/get-started/using-git/dealing-with-special-characters-in-branch-and-tag-names).

    :::image type="content" source="media/vs-2022/git-create-new-branch-dialog.png" alt-text="Screenshot of the Create a New Branch dialog box.":::

1. In the **Based on** section, use the drop-down list to choose whether you want to base your new branch off an existing local branch or a remote branch.

1. The **Checkout branch** checkbox, which is on by default, automatically switches to the newly created branch. Toggle this option if you want to remain in the current branch.

There you have it; you've created a new branch.

> [!TIP]
> The equivalent command for this action is `git checkout -b <new-branch> <existing-branch>`.

> [!NOTE]
> For more information about the latest updates that improve branch switching, see the [Visual Studio 2022 Performance Enhancements: Git Branch Switching](https://devblogs.microsoft.com/visualstudio/vs2022-performance-enhancements-git-branch-switching/) blog post.

## Next steps

To continue your journey, visit the [Make a commit](git-make-commit.md) page. And to learn more about how to manage branches in Visual Studio, see [Merge and rebase branches](git-manage-repository.md#merge-and-rebase-branches).
