---
title: Make a commit in Visual Studio
titleSuffix: ""
description: Make a commit in Visual Studio by using Git or Azure DevOps.
ms.date: 11/10/2021
ms.topic: how-to
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
---
# Make a commit in Visual Studio

The core part of any Git workflow is modifying files and committing the changes in those files.

Git tracks file changes in your repo as you work, and separates the files in your repo into three categories. These changes are equivalent to what you would see when you enter the `git status` command in the command line:

- **Unmodified files**: These files haven't changed since your last commit.
- **Modified files**: These files have changes since your last commit, but you haven't yet staged them for the next commit.
- **Staged files**: These files have changes that will be added to the next commit.

As you do your work, Visual Studio keeps track of the file changes to your project in the **Changes** section of the **Git Changes** window.

:::image type="content" source="media/vs-2022/git-changes-window.png" alt-text="The Git Changes window in Visual Studio 2022.":::

To stage changes when you're ready, select the **+** (plus) button on each file you want to stage, or right-click a file and then select **Stage**. You can also stage all your modified files with one click by using the stage all **+** (plus) button at the top of the **Changes** section.

When you stage a change, Visual Studio creates a **Staged Changes** section. Only changes in the **Staged Changes** section are added to the next commit, which you can do by selecting **Commit Staged**. The equivalent command for this action is `git commit -m "Your commit message"`.

:::image type="content" source="media/vs-2022/git-commit-message.png" alt-text="The Git commit dialog in Visual Studio 2022.":::

Changes can also be unstaged by clicking the **–** (minus) button. The equivalent command for this action is `git reset <file_path>` to unstage a single file or `git reset <directory_path>` to unstage all the files in a directory.

You can also choose not to stage your modified files by skipping the staging area. In this case, Visual Studio allows you to commit your changes directly without having to stage them. Just enter your commit message and then select **Commit All**. The equivalent command for this action is `git commit -a`.

Visual Studio also makes it easy to commit and sync with one click by using the **Commit All and Push** and **Commit All and Sync** shortcuts. When you double-click any file in the **Changes** and the **Staged changes** sections, you can see a line-by-line comparison with the unmodified version of the file.

:::image type="content" source="media/vs-2022/git-file-version-compare.png" alt-text="The line-by-line comparison of file versions in Visual Studio 2022.":::

When you double-click a **Commit**, Visual Studio opens its details in a separate tool window. From here you can revert the commit, reset the commit, amend the commit message, or create a tag on the commit. When you click a changed file in the commit, Visual Studio opens the side-by-side **Diff** view of the commit and its parent.

:::image type="content" source="media/vs-2022/git-branch-commit-details.png" alt-text="The Commit Details dialog in Visual Studio 2022.":::

## Next steps

To continue your journey, visit the [Push to remote](git-push-remote.md) page.

## See also

- [Git experience in Visual Studio](git-with-visual-studio.md)
- [Visual Studio & GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)
