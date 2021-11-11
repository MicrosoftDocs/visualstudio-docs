---
title: Manage a repo in Visual Studio
titleSuffix: ""
description: Manage any Git repository in Visual Studio using the Git Repository window.
ms.date: 11/10/2021
ms.topic: how-to
author: Taysser-Gherfal
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
---
# Manage Git repositories in Visual Studio

The Git Repository window provides a full screen Git experience focused on helping you manage your Git repository and stay up to date with what your team is working on. For example, you might need to Reset, Revert, Cherry-Pick commits or just clean your commit history. The Git repository window is also a great place to visualize and manage your branches.

## Change the last commit (Amend)

Updating the last commit is referred to by Git as Amend and it is a very common use case. Sometimes you just need to update your commit message, or you might need to include a last-minute change.

You can Amend a commit in the command line by using the following command:

```bash
git commit --amend
```

The Git repository window makes it easy to update your commit message. Just open the commit details of the last commit by double clicking on it and click the **Edit** option next to the commit message.

:::image type="content" source="media/vs-2022/git-repository-edit-commit.png" alt-text="Screenshot of edit a commit message." lightbox="media/vs-2022/git-repository-edit-commit.png":::

When you are done editing your commit message, click **Amend**.

:::image type="content" source="media/vs-2022/git-repository-amend-commit.png" alt-text="Screenshot of save the edited message by clicking Amend." lightbox="media/vs-2022/git-repository-amend-commit.png":::

If you need to include code changes to your last commit, you can use the Git Changes window to do that by checking the **Amend checkbox** and committing your changes.

:::image type="content" source="media/vs-2022/git-changes-amend-commit.png" alt-text="Screenshot of Amend code changes using the Git Changes window." lightbox="media/vs-2022/git-changes-amend-commit.png":::

> [!TIP]
> Feel free to use the following link to learn more about Amend and Rewriting History: [Git Tools - Rewriting History](https://git-scm.com/book/en/v2/Git-Tools-Rewriting-History)

## Merge commits (Squash)

To merge a series of commits, Git provides an option to squash commits down into a single commit. This can be helpful if you make frequent commits and end up with a long list of commits that you would like to clean up before pushing to a remote repository.

You can squash two commits in the command line by using the following command:

```bash
git rebase -i HEAD~2
```

Then update **pick** to **squash**, save, and update the commit message as shown here:

:::image type="content" source="media/vs-2022/git-repository-squash-cmd.png" alt-text="Screenshot of update pick to squash." lightbox="media/vs-2022/git-repository-squash-cmd.png":::

To merge commits in Visual Studio, use the **Ctrl** key and multi-select the commits you would like to merge. Then right click and select **Squash Commits**. Visual Studio automatically combines your commit messages, but sometimes it is better to provide an updated message. Once you review and update your commit message, click the **Squash button**.

:::image type="content" source="media/vs-2022/git-repository-squash-visual-studio.png" alt-text="Screenshot of squash commits in Visual Studio." lightbox="media/vs-2022/git-repository-squash-visual-studio.png":::

> [!TIP]
> Feel free to use the following link to learn more about Squash and Rewriting History: [Git Tools - Rewriting History](https://git-scm.com/book/en/v2/Git-Tools-Rewriting-History)

## Merge and rebase branches

If you are using Git branches to work on different features, at some point you will need to include updates introduced to other branches. This can happen while you are still working on your feature branch or when you are done working on your feature branch and need to keep your changes by adding them to a different branch. In Git you can do this by merging or rebasing branches.

To merge the main branch into the New_Feature branch in the command line, use the following commands:

```bash
git checkout New_Feature
git merge main
```

To do the same in Visual Studio, checkout New_Feature branch by double clicking it in the branch list. Then right click on main and select **Merge ‘main’ into ‘New_Feature’**

:::image type="content" source="media/vs-2022/git-repository-merge-ui.png" alt-text="Screenshot of merge branches in Visual Studio.":::

To rebase the main branch into the New_Feature branch in the command line, use the following commands:

```bash
git checkout New_Feature
git rebase main
```

To do the same in Visual Studio, checkout New_Feature branch by double clicking on it in the branch list. Then right click on main and select **Rebase ‘New_Feature’ onto ‘main’**

:::image type="content" source="media/vs-2022/git-repository-rebase-ui.png" alt-text="Screenshot of rebase branches in Visual Studio.":::

> [!TIP]
> Feel free to use the following link to learn more about Merge, Rebase, and Branching in general: [Git Branching](https://git-scm.com/book/en/v2/Git-Branching-Branches-in-a-Nutshell)

## Copy commits (Cherry-Pick)

Copy commits from one branch to another using cherry-pick. Unlike a merge or rebase, cherry-pick only brings the changes from the commits you select, instead of all the changes in a branch. Cherry-pick is a great way to tackle these common problems:

- Accidentally committing on the wrong branch. Cherry-pick the change(s) over to the correct branch and then reset the original branch to the previous commit.
- Pulling out a set of commits made in a feature branch, so you merge them back to your main branch sooner.
- Porting in specific commits from the main branch without rebasing your branch.

To copy changes from a commit to your current branch using the command line, use the following commands:

```bash
git cherry-pick 7599e530
```

To do the same in Visual Studio, preview the branch you would like to cherry-pick a commit from by selecting it with a single click. Then right click on the targeted commit and choose **cherry-pick**.

:::image type="content" source="media/vs-2022/git-repository-cherry-pick-ui.png" alt-text="Screenshot of cherry-pick in Visual Studio." lightbox="media/vs-2022/git-repository-cherry-pick-ui.png":::

Once the operation is complete, Visual Studio shows a success message and the commit you cherry-picked shows in the outgoing section.

> [!TIP]
> Feel free to use the following link to learn more about Cherry-picking commits: [Git Cherry-pick](https://git-scm.com/docs/git-cherry-pick)

## Revert changes

Use Revert to undo the changes made in commits pushed to shared branches. The revert command creates a new commit that undoes the changes on a previous commit. Revert does not rewrite the repository history, making it safe to use when working with others.

To Revert changes made in a commit using the command line, use the following commands:

```bash
git revert 53333305
git commit
```

These commands will undo the changes made in commit 53333305 and create a new commit on the branch. The original commit at commit_id is still in the Git history. To do the same in Visual Studio, right-click the commit that you would like to Revert and select **Revert** from the context menu. Once you confirm your action and the operation is complete, Visual Studio shows a success message and a new commit shows in the outgoing section.

:::image type="content" source="media/vs-2022/git-repository-revert-ui.png" alt-text="Screenshot of revert in Visual Studio." lightbox="media/vs-2022/git-repository-revert-ui.png":::

Click on the new commit to confirm that it undoes the changes of the commit we reverted.

:::image type="content" source="media/vs-2022/git-repository-revert-confirmation.png" alt-text="Screenshot of confirm revert operation." lightbox="media/vs-2022/git-repository-revert-confirmation.png":::

> [!TIP]
> Feel free to use the following link to learn more about Reverting changes: [Git Revert](https://git-scm.com/docs/git-revert)

## Reset a branch to a previous state

Use reset to bring a branch in your local repository back to the contents of a previous commit. This will simply discard all changes since the commit you are resetting your branch to.
> [!WARNING]
> Don't use Reset on branches shared with others. Use Revert instead.

To Reset a branch to a previous state using the command line, use the following command:

```bash
git reset --hard 53333305
```

The **--hard** part of the command tells Git to reset the files to the state of the previous commit and discard any staged changes. To do the same in Visual Studio, right-click the commit that you would like to reset your branch to and select **Reset > Delete Changes (--hard)** from the context menu.

:::image type="content" source="media/vs-2022/git-repository-reset-ui.png" alt-text="Reset a branch in Visual Studio." lightbox="media/vs-2022/git-repository-reset-ui.png":::

> [!TIP]
> Feel free to use the following link to learn more about Resetting branches: [Git Reset](https://git-scm.com/docs/git-reset)

## Next steps

To continue your journey, visit the [Resolve merge conflicts in Visual Studio](git-resolve-conflicts.md) page.

## See also

- [The Git experience in Visual Studio](../ide/git-with-visual-studio.md)
- [Visual Studio & GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)