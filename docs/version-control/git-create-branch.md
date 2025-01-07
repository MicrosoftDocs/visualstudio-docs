---
title: Create a branch to track code changes
description: Create a branch for source code control in Visual Studio with Git based off an existing branch for your project or solution.
ms.date: 1/07/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs

ms.subservice: general-ide
---
# Create a Git branch in Visual Studio

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
1. The **Track remote branch** checkbox, which only appears if you select **Remote** in the **Based on** section, is selected by default if the remote has a matching branch name. If the branch is intended to be a local version of the remote branch, this should be selected; otherwise, clear the checkbox. See [Remote branches](https://git-scm.com/book/en/v2/Git-Branching-Remote-Branches).

There you have it; you've created a new branch.

> [!TIP]
> The equivalent command for this action is `git checkout -b <new-branch> <existing-branch>`.

> [!NOTE]
> For more information about the latest updates that improve branch switching, see the [Visual Studio 2022 Performance Enhancements: Git Branch Switching](https://devblogs.microsoft.com/visualstudio/vs2022-performance-enhancements-git-branch-switching/) blog post.

## Related content

- [Make a commit](git-make-commit.md) 
- [Merge and rebase branches](git-manage-repository.md#merge-and-rebase-branches).
