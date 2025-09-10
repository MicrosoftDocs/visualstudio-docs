---
title: Work with multiple repositories
titleSuffix: ""
description: View, manage, and debug your code across 10 active repos at the same time by using the Git tooling within Visual Studio.
ms.date: 03/14/2025
ms.topic: conceptual
author: ghogen
ms.author: ghogen
ms.manager: mijacobs

ms.subservice: general-ide
monikerRange: ">=vs-2022"
ms.custom: sfi-image-nochange
---
# Work with multiple repos

As one of our most [highly requested features in the Developer Community](https://developercommunity.visualstudio.com/t/allow-multiple-git-repositories-to-be-active-at-on/351156), we've added multi-repository support to Visual Studio 2022, starting with [version 17.4](/visualstudio/releases/2022/release-notes-v17.4).

Now, you can have up to 25 active Git repositories at one time in Visual Studio. Multi-repo support means that you can work with a solution that spans more than one repository, and apply Git operations across several repositories at the same time. For example, in a large web project, you might need different repositories to manage work done on the frontend, the API, the database, the documentation, along with various libraries and dependencies. Before multi-repo support, you might have had to open multiple instances of Visual Studio to work between repos. Starting with [version 17.4](/visualstudio/releases/2022/release-notes-v17.4), you can manage, view, and debug them all with one instance of Visual Studio.

> [!NOTE]
> To see multi-repository support in action, view the [Use multiple Git repositories in Visual Studio](https://www.youtube.com/watch?v=ctnlQzX2YwI&t=34s) video on YouTube.

If you have more than one GitHub account, you can easily switch between them. See [Add your GitHub accounts to your keychain](../ide/work-with-github-accounts.md). You might have access to different repos when you're signed in with a different account. Visual Studio automatically updates the git configuration to track which account is used for each repo, so you don't have to worry about this while you're working.

## Branch management and track changes

Multi-repository support extends the capabilities of the **Git Changes** and **Git Repository** windows. You can manage your multi-repo scenarios the same way as you would in working with a single repository.

:::image type="content" source="media/vs-2022/multi-repo-new-branch-button.png" alt-text="Screenshot of the New Branch button in Visual Studio.":::

You can create your branches across several repositories at one time by using the extended branch creation dialog.

:::image type="content" source="media/vs-2022/multi-repo-create-new-branch.png" alt-text="Screenshot of the 'Create a new branch' dialog in Visual Studio.":::

Then, as you make changes, the **Git Changes** window tracks your work separated by repository. You can stage and commit as you typically would.

:::image type="content" source="media/vs-2022/multi-repo-track-changes.png" alt-text="Screenshot of the Git Changes window that tracks changes to your work.":::

You can use the branch pickers in the status bar and the **Git Changes** tool window to switch branches. All you need to do is select the branch you’d like to check out. Also, you can perform inner loop branching operations like merging, rebasing, renaming, deleting, and comparing branches by right-clicking the branch to open the context menu.

:::image type="content" source="media/vs-2022/multi-repo-branch-picker.png" alt-text="Screenshot of the branch picker functionality in the Git Changes tool window.":::

And, you can perform more advanced repository and branch management operations in the **Git Repository** window.

:::image type="content" source="media/vs-2022/multi-repo-git-repository-tool-window.png" alt-text="Screenshot of the branch picker functionality in the Git Repository tool window.":::

## Network operations

Once you’re ready to commit, the network operations dialog makes it easy to specify the exact branch you’re pushing to and reorder your pushes. This same dialog allows you to exercise more control over other network operations, like [fetch and pull](git-fetch-pull-sync.md).

:::image type="content" source="media/vs-2022/multi-repo-push-network-operation.png" alt-text="Screenshot showing a push action in the network operations dialog.":::

## Repository settings

You can use the **Git Repository Settings** page to specify your options for each repository. For example, you can specify whether to prune remote branches during fetch.

:::image type="content" source="media/vs-2022/multi-repo-git-repository-settings.png" alt-text="Screenshot of the Git Repository Settings option in Visual Studio.":::

## Activate multiple repos from a solution or a folder

You can activate multiple repositories from either a solution or a folder.

### Use a solution

Here's how to create a solution with multiple repositories:

1. Open one of your existing solutions that already has a repository initialized.

1. Right-click the solution in **Solution Explorer**, and then select **Add** > **[Existing Project](../ide/use-solution-explorer.md#the-add-menu)**.

1. Select the .csproj file for another project that has a repository initialized.

   After the project's added, Visual Studio detects and activates the second repo. Then, you can adjust the Project References as necessary.

If you create a new project in an existing solution with other projects that already have local or remote repos, you must initialize the new project with Git [`git init`](https://git-scm.com/docs/git-init) before it shows as an additional repo in the solution.

### Use a folder

If the repositories you want to use are independent of each other and don't need to be part of the same solution, you might want to use a folder to open them.

To do so, you can place the local repo directories in the same parent folder and then use the **Open a local folder** option from the Visual Studio launch page to open the parent folder. Visual Studio detects and activates each repo, and then tracks changes by repo (as shown in the following screenshot).

:::image type="content" source="media/vs-2022/multi-repo-open-folder-solution.png" alt-text="Screenshot showing how you can activate multiple repositories from a folder in Visual Studio.":::

## Related content

Want to know more about how we'll develop further Git functionality within Visual Studio 2022, or to share your feedback with us on the multi-repo feature? See the "Building with your feedback", "What's next", and "Let us know what you think" sections of the [Multi-repository support released](https://devblogs.microsoft.com/visualstudio/multi-repository-support-released/) blog post.

Next, to continue your journey with repo management, see [Resolve merge conflicts in Visual Studio](git-resolve-conflicts.md).
