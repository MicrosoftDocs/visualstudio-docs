---
title: Create a branch in Visual Studio
titleSuffix: ""
description: Create a branch in Visual Studio by using Git or Azure DevOps.
ms.date: 11/10/2021
ms.topic: how-to
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
---
# Create a branch in Visual Studio

It's easy to create a new branch in Visual Studio; all you have to do is base it off an existing branch.

Here's how.

1. To start, make sure you've got a previously [created](git-create-repository.md) or [cloned](git-clone-repository.md) repo open.

1. From the **Git** menu, select **New Branch**.

    :::image type="content" source="media/vs-2022/git-menu-new-branch.png" alt-text="Screenshot of the New Branch option in the Git menu.":::

1. In the **Create a new branch** dialog box, enter a branch name.

    :::image type="content" source="media/vs-2022/git-create-new-branch-dialog.png" alt-text="Screenshot of the Create a New Branch dialog box.":::

1. In the **Based on** section, use the drop-down list to choose whether you want to base your new branch off an existing local branch or a remote branch.

1. The **Checkout branch** checkbox, which is on by default, automatically switches to the newly created branch. Toggle this option if you want to remain in the current branch.

There you have it; you've created a new branch.

> [!TIP]
> The equivalent command for this action is `git checkout -b <new-branch> <existing-branch>`.

## Next steps

To continue your journey, visit the [Make a commit](git-make-commit.md) page.

## See also

- [Git experience in Visual Studio](git-with-visual-studio.md)
- [Visual Studio & GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)