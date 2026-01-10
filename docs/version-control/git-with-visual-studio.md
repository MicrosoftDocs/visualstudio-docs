---
title: About Git in Visual Studio
titleSuffix: ""
description: Explore Git options for source control in Visual Studio and track the code changes you make over time or revert to specific versions.
ms.date: 11/25/2025
ms.topic: overview
author: ghogen
ms.author: ghogen
ms.manager: mijacobs
ms.subservice: general-ide
ms.custom: sfi-image-nochange
---
# About Git in Visual Studio

Visual Studio provides a user interface for [Git](https://git-scm.com/docs/git), a widely used modern version control system. Whether your source code is hosted in a GitHub repository, Azure DevOps, or another Git provider, you can do all the common version control tasks within the Visual Studio IDE. Or, you can work locally with no provider at all, with the option to back up your source later when you're ready to connect to a provider.

The source code you work with doesn't have to have been created with Visual Studio. You can work with any source folder in any Git repo, whether there's a Visual Studio project file or not. 

::: moniker range=">=vs-2022"

## Start with Git and GitHub in Visual Studio

To get started using Git with Visual Studio:

- If you have a Git repo hosted on a Git provider like GitHub, [clone the repository](git-clone-repository.md) to your local machine.

- Otherwise, easily [create a new Git repository and add your code](git-create-repository.md).  If you don't have a Git provider yet, we recommend you start with GitHub since the Git experience in Visual Studio is optimized for this provider. GitHub offers free and secured cloud code storage where you can store your code and access it from any device, anywhere.

Not only can you add both [GitHub and GitHub Enterprise accounts to your keychain](../ide/work-with-github-accounts.md), but you can also apply them just as you do with Microsoft accounts.  If you don’t have a GitHub account, follow these steps to [create a GitHub account to use with Visual Studio](git-create-github-account.md) now. Also, with Visual Studio 17.12 and later, you can add multiple GitHub accounts, and switch between them as needed. See [Add GitHub accounts to your Visual Studio keychain](../ide/work-with-github-accounts.md).

:::image type="content" source="media/vs-2022/git-source-control-create-repository.png" alt-text="Screenshot of the Create a Git Repository dialog box in Visual Studio." lightbox="media/vs-2022/git-source-control-create-repository.png":::

If you want to use git commands at the command line, you should also install [Git for Windows](https://git-scm.com/downloads/win) (not a Microsoft product).

## View files in Solution Explorer

When you clone a repository or open a local repository, Visual Studio switches to the Git context. Solution Explorer loads the folder at the root of the Git repository, and scans the directory tree for any viewable files like `CMakeLists.txt` or those with the `.sln` file extension.  For more information, see [View files in Solution Explorer](../get-started/tutorial-open-project-from-repo.md#view-files-in-solution-explorer).

## Branches and remote repositories

You can use branches to keep related changes separated from unrelated changes you're also working on. The recommended Git workflow uses a new branch for every feature or fix that you work on. Learn how to [create a branch](git-create-branch.md) from Visual Studio.

Once you create a new branch and switch to it, you can start working by changing existing files or by adding new ones and then committing your work to the repository. To learn more about making a commit in Visual Studio and to better understand file states in Git, refer to the [Make a commit](git-make-commit.md) page.

Git is a distributed version control system, meaning that all the changes made so far are local-only changes. To contribute these changes to a remote repository, you must [push those local commit(s) to a remote](git-push-remote.md).

If you're working in a team, or if you're using different machines, you might often need to fetch and pull new changes on the remote repository. To learn more about managing Git network operations in Visual Studio, refer to the [Fetch, pull, push, and sync](git-fetch-pull-sync.md) page.

:::image type="content" source="media/vs-2022/git-source-control-inner-loop.png" alt-text="Screenshot of Visual Studio IDE with the Git menu and the Git Changes tab in Solution Explorer showing." lightbox="media/vs-2022/git-source-control-inner-loop.png":::

## Repository management and collaboration

However, there are times when it makes more sense to focus on your Git repository. For example, you might need to get a good picture of what your team has been working on, or copy a commit from a different branch, or just clean-up your outgoing commits. Visual Studio includes powerful [repository browsing](git-browse-repository.md) and collaboration features that eliminate the need to use other tools.

To help you focus on your Git repository, Visual Studio has a **Git Repository** window, which is a consolidated view of all the details in your repository, including local and remote branches and commit history. You can access this window directly from either **Git** or **View** on the menu bar, or from the status bar.

:::moniker-end

::: moniker range="visualstudio"

:::image type="content" source="media/visualstudio/git-source-control-repository-management.png" alt-text="Screenshot showing the Visual Studio IDE. The Create a new branch window and the Git Changes tab in Solution Explorer are shown." lightbox="media/visualstudio/git-source-control-repository-management.png":::
 
::: moniker-end

::: moniker range="vs-2022"

:::image type="content" source="media/git-source-control-repository-management.png" alt-text="The Create a new branch window and the Git Changes tab in Solution Explorer.":::

::: moniker-end

:::moniker range=">=vs-2022"

### Browse and manage Git repositories

To learn more about how you can use the Git Repository window in Visual Studio to browse and manage your Git repository, refer to the following pages:

- [Browse a repo](git-browse-repository.md)
- [Manage a repo](git-manage-repository.md)

### Handle merge conflicts

Conflicts can occur during a merge if two developers modify the same lines in a file and Git doesn’t automatically know which one is correct. Git halts the merge and informs you that you are in a conflicted state.  Learn more in the [Resolve merge conflicts](git-resolve-conflicts.md) page.

### Personalize your Git settings

:::moniker-end

To personalize your Git settings at a repository level as well as at a global level, follow these steps:

:::moniker range="visualstudio"

1. On the menu bar, select **Git** > **Settings**, or open the **Tools** > **Options** pane and expand the **All Settings** > **Source Control** > **Git Settings** > **Git Global Config** section.

1. Choose the [options](git-settings.md) you want.

    :::image type="content" source="media/visualstudio/git-options-settings.png" alt-text="Screenshot of the Options pane where you can choose personalization and customization settings in the Visual Studio IDE." lightbox="media/visualstudio/git-options-settings.png":::
    
:::moniker-end
:::moniker range="vs-2022"

1. On the menu bar, select **Git** > **Settings**, or open the **Tools** > **Options** dialog and expand the **Source Control** > **Git Global Settings** section.

1. Choose the [options](git-settings.md) you want.

    :::image type="content" source="media/vs-2022/git-options-settings.png" alt-text="Screenshot of the Options dialog box where you can choose personalization and customization settings in Visual Studio IDE." lightbox="media/vs-2022/git-options-settings.png":::

:::moniker-end

:::moniker range=">=vs-2022"

## Productivity enhancements

In Visual Studio 2022 **version 17.12**, you can select any section of code, and then right-click, expand the Git submenu, and choose **Copy GitHub Permalink** (or **Copy AzureDevOps Permalink**) to generate a [GitHub Permalink](https://docs.github.com/repositories/working-with-files/using-files/getting-permanent-links-to-files) or Azure DevOps Permalink and copy it to the clipboard. From there, you can paste it anywhere a link might be used, in the browser, or share it over email, chat sessions, and documents. You can also do the same within the embedded commit details view in the **Git Repository** window. This feature allows you to reference specific code from previous commits without switching branches. You must be [signed in to Visual Studio](../ide/signing-in-to-visual-studio.md) with an account with the Git hosting provider, GitHub or Azure DevOps.

In Visual Studio 2022 [**version 17.6**](/visualstudio/releases/2022/release-notes-v17.6), you can [search](https://devblogs.microsoft.com/visualstudio/git-tooling-preview-features-to-enhance-productivity/#improved-search-for-related-github-issues-and-azure-devops-work-items) for and [link](https://devblogs.microsoft.com/visualstudio/reference-github-issues-and-pull-requests-in-visual-studio/) to GitHub Issues and Azure DevOps work items. See the [**Git Features to Enhance Productivity**](https://devblogs.microsoft.com/visualstudio/git-tooling-preview-features-to-enhance-productivity/) blog post.

:::moniker-end


## Next steps

>[!Tip]
> To learn about using Git and GitHub in Visual Studio, sign up for the [Git learning series](https://aka.ms/vsgitlearn-1-signup-docs).
