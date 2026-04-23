---
title: Work with Multiple Repositories
titleSuffix: ""
description: View, manage, and debug your code across 10 active repos at the same time by using the Git tooling within Visual Studio.
ms.date: 01/14/2026
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs

ms.subservice: general-ide
monikerRange: ">=vs-2022"
ms.custom: sfi-image-nochange
---
# Work with multiple repos

Multi-repository support is available in Visual Studio 2022 [version 17.4](/visualstudio/releases/2022/release-notes-v17.4) and later. It's one of the most [highly requested features in the Developer Community](https://developercommunity.visualstudio.com/t/allow-multiple-git-repositories-to-be-active-at-on/351156). You can have up to 25 active Git repositories at one time in Visual Studio. 

Multi-repo support means you can work with a solution that spans more than one repository, and apply Git operations across several repositories at the same time. For example, in a large web project, you might need different repositories to manage work done on the frontend, the API, the database, the documentation, along with various libraries and dependencies. Before multi-repo support, you might have multiple instances of Visual Studio open to work between repos. Now you can manage, view, and debug all your open repos with one instance of Visual Studio.

> [!NOTE]
> To see multi-repository support in action, view the [Use multiple Git repositories in Visual Studio](https://www.youtube.com/watch?v=ctnlQzX2YwI&t=34s) video on YouTube.

If you have more than one GitHub account, you can easily switch between them. For more information, see [Add your GitHub accounts to your keychain](../ide/work-with-github-accounts.md). You might have access to different repos when you're signed in with a different account. Visual Studio automatically updates the git configuration to track which account is used for each repo.

## Branch management and track changes

Multi-repository support extends the capabilities of the **Git Changes** and **Git Repository** windows. You can manage your multi-repo scenarios the same way as you would in working with a single repository.

:::image type="content" source="media/vs-2022/multi-repo-new-branch-button.png" alt-text="Screenshot of the New Branch button in Visual Studio.":::

You can create your branches across several repositories at one time by using the extended branch creation dialog.

:::image type="content" source="media/vs-2022/multi-repo-create-new-branch.png" alt-text="Screenshot of the 'Create a new branch' dialog in Visual Studio.":::

Then, as you make changes, the **Git Changes** window tracks your work separated by repository. You can stage and commit as you typically would.

:::image type="content" source="media/vs-2022/multi-repo-track-changes.png" alt-text="Screenshot of the Git Changes window that tracks changes to your work.":::

You can use the branch pickers in the status bar and the **Git Changes** tool window to switch branches. All you need to do is select the branch you'd like to check out. Also, you can perform inner loop branching operations like merging, rebasing, renaming, deleting, and comparing branches by right-clicking the branch to open the context menu.

:::image type="content" source="media/vs-2022/multi-repo-branch-picker.png" alt-text="Screenshot of the branch picker functionality in the Git Changes tool window.":::

And, you can perform more advanced repository and branch management operations in the **Git Repository** window.

:::image type="content" source="media/vs-2022/multi-repo-git-repository-tool-window.png" alt-text="Screenshot of the branch picker functionality in the Git Repository tool window.":::

## Network operations

After you're ready to commit your changes, the network operations dialog makes it easy to specify the exact branch you're pushing to and reorder your pushes. This same dialog allows you to exercise more control over other network operations, like [fetch and pull](git-fetch-pull-sync.md).

:::image type="content" source="media/vs-2022/multi-repo-push-network-operation.png" alt-text="Screenshot showing a push action in the network operations dialog.":::

## Repository settings

::: moniker range="visualstudio"

You can use the **Git Repository Config** options to configure a specific repository. For example, you can specify whether to prune remote branches during fetch.

In the **Tools** > **Options** pane, expand the **All Settings** > **Source Control** > **Git Settings** > **Git Repository Config** section. Use the **Repository**  dropdown list to select the repo to configure.

:::image type="content" source="media/visualstudio/multi-repo-git-repository-settings.png" alt-text="Screenshot of the Git Repository Config options in Visual Studio.":::

You can also configure the same options for all repositories in the **Git Settings** > **Git Global Config** section.

::: moniker-end
::: moniker range="vs-2022"

You can use the **Git Repository Settings** options to configure the repo that's currently open in Visual Studio. For example, you can specify whether to prune remote branches during fetch.

In the **Tools** > **Options** dialog, expand the **Source Control** > **Git Repository Settings** > **General** section.

:::image type="content" source="media/vs-2022/multi-repo-git-repository-settings.png" alt-text="Screenshot of the Git Repository Settings, General options in Visual Studio.":::

You can configure some of the same options for all repositories in the **Source Control** > **Git Global Settings** section.

::: moniker-end

## Activate multiple repos from a solution or a folder

You can activate multiple repositories from either a solution or a folder.

### Use a solution

Here's how to create a solution with multiple repositories:

1. Open one of your existing solutions that already has a repository initialized.

1. Right-click the solution in **Solution Explorer**, and then select **Add** > **[Existing Project](../ide/use-solution-explorer.md#the-add-menu)**.

1. Select the _.csproj_ file for another project that has a repository initialized.

   After the project's added, Visual Studio detects and activates the second repo. Then, you can adjust the Project References as necessary.

If you create a new project in an existing solution with other projects that have local or remote repos, you must initialize the new project with [git init](https://git-scm.com/docs/git-init). After you initialize the new project, you can see the repos used by the other projects in the solution.

### Use a folder

If the repositories you need are independent and don't need to be in the same solution, you can use a folder to open them.

Place the local repo directories in the same parent folder. Use the **Open a local folder** option from the Visual Studio launch page to open the parent folder. Visual Studio detects and activates each repo, and then tracks changes by repo (as shown in the following screenshot).

:::image type="content" source="media/vs-2022/multi-repo-open-folder-solution.png" alt-text="Screenshot showing how you can activate multiple repositories from a folder in Visual Studio.":::

## Related content

- [Multi-repository support released](https://devblogs.microsoft.com/visualstudio/multi-repository-support-released/)
- [Resolve merge conflicts in Visual Studio](git-resolve-conflicts.md)
