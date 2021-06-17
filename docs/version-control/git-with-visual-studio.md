---
title: The Git experience in Visual Studio 2019
titleSuffix: ""
description: Learn how the new integrated Git experience in Visual Studio 2019 can help you be more productive.
ms.date: 06/17/2021
ms.topic: overview
ms.author: tglee
author: TerryGLee
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.manager: jmartens
---
# Git experience in Visual Studio

Git is now the default version control experience in Visual Studio 2019. Since [version 16.6](/visualstudio/releases/2019/release-notes-v16.6), we've worked on building out the feature set and iterating on it based on your feedback. The new Git experience is turned on by default for everyone with the release of [version 16.8](/visualstudio/releases/2019/release-notes/).

> [!TIP]
> Git is the most widely used modern version control system, so whether you’re a professional developer or if you’re learning how to code, Git can be very useful to you. If you are new to Git, the https://git-scm.com/ website is a good place to start. There, you’ll find cheat sheets, a popular online book, and Git Basics videos.

## How to use Git in Visual Studio

We'll walk you through how to use the new Git experience in Visual Studio 2019, but if you'd like to take a quick tour first, check out the following video: <br><br>*Video length: 5.27 minutes*

> [!VIDEO https://www.youtube.com/embed/UHrAg3iKoe0]

There are three ways to start using Git with Visual Studio to be more productive:

- [Open an existing Git repository](#open-an-existing-local-repository). If your code is already on your machine, you can open it by using **File** > **Open** > **Project/Solution** (or **Folder**) and Visual Studio automatically detects if it has an initialized Git repository.
- [Create a new Git repository](#create-a-new-git-repository). If your code is not associated with Git, you can create a new Git repository.
- [Clone an existing Git repository](#clone-an-existing-git-repository). If the code that you would like to work on is not on your machine, you can clone any existing remote repositories.

> [!NOTE]
> Starting also with [version 16.8](/visualstudio/releases/2019/release-notes/), Visual Studio 2019 includes a fully integrated GitHub account experience. You can now add both GitHub and GitHub Enterprise accounts to your keychain. You’ll be able to add and leverage them just as you do with Microsoft accounts, which means that you’ll have an easier time accessing your GitHub resources across Visual Studio. For more information, see the [Work with GitHub accounts in Visual Studio](../ide/work-with-github-accounts.md) page.

## Create a new Git repository

If your code is not associated with Git, you can start by creating a new Git repository. To do so, select **Git** > **Create Git Repository** from the menu bar. Then, in the **Create a Git repository** dialog box, enter your information.

:::image type="content" source="media/git-create-repository.png" alt-text="The Create a Git Repository dialog box in Visual Studio.":::

The **Create a Git repository** dialog box makes it easy to push your new repository to GitHub. By default, your new repository is private, which means that you are the only one who can access it. If you uncheck the box, your repository will be public, which means that anyone on GitHub can view it.

> [!TIP]
> Whether your repository is public or private, it's best to have a remote backup of your code stored securely on GitHub even if you are not working with a team. This also makes your code available to you no matter what computer you're using.

You can choose to create a local-only Git repository by using the **Local only** option. Or, you can link your local project with an existing empty remote repository on Azure DevOps or any other Git provider by using the **Existing Remote** option.

## Clone an existing Git repository

Visual Studio includes a straightforward clone experience. If you know the URL of the repository that you would like to clone, you can paste the URL in the **Repository location** section and then choose the disk location you would like Visual Studio to clone to.

:::image type="content" source="media/git-clone-repository.png" alt-text="The Clone a Git Repository dialog box in Visual Studio.":::

If you don’t know the repository URL, Visual Studio makes it easy to browse to and then clone your existing GitHub or Azure DevOps repository.

### Open an existing local repository

After you’ve cloned a repository or created one, Visual Studio detects the Git repository and adds it to your list of **Local Repositories** in the Git menu. From here, you can quickly access and switch between your Git repositories.

:::image type="content" source="media/git-local-repositories.png" alt-text="The Local Repositories option from the Git menu in Visual Studio ":::

## View files in Solution Explorer

When you clone a repository or open a local repository, Visual Studio switches you into that Git context by saving and closing any previously open solutions and projects. Solution Explorer loads the folder at the root of the Git repository and scans the directory tree for any View files. These include files such as CMakeLists.txt or those with the .sln file extension.

Visual Studio adjusts its View based on which View file you load in Solution Explorer:

- If you clone a repository that contains a single .sln file, then Solution Explorer directly loads that solution for you.
- If Solution Explorer doesn’t detect any .sln files in your repository, then by default it loads Folder View.
- If your repository has more than one .sln file, then Solution Explorer shows you the list of available Views for you to choose from.

You can toggle between the currently open View and the list of Views by using the **Switch Views** button in the Solution Explorer toolbar.

:::image type="content" source="media/git-solution-explorer-views.png" alt-text="Solution Explorer with the Switch Views button selected in Visual Studio.":::

## Git Changes window

Git tracks file changes in your repo as you work, and separates the files in your repo into three categories. These changes are equivalent to what you would see when you enter the `git status` command in the command line:

- **Unmodified files**: These files haven't changed since your last commit.
- **Modified files**: These files have changes since your last commit, but you haven't yet staged them for the next commit.
- **Staged files**: These files have changes that will be added to the next commit.

As you do your work, Visual Studio keeps track of the file changes to your project in the **Changes** section of the **Git Changes** window.

:::image type="content" source="media/git-changes-window.png" alt-text="The Git Changes window in Visual Studio.":::

When you are ready to stage changes, click the **+** (plus) button on each file you want to stage, or right-click a file and then select **Stage**. You can also stage all your modified files with one click by using the stage all **+** (plus) button at the top of the **Changes** section.

When you stage a change, Visual Studio creates a **Staged Changes** section. Only changes in the **Staged Changes** section are added to the next commit, which you can do by selecting **Commit Staged**. The equivalent command for this action is `git commit -m "Your commit message"`. Changes can also be unstaged by clicking the **–** (minus) button. The equivalent command for this action is `git reset <file_path>` to unstage a single file or `git reset <directory_path>` to unstage all the files in a directory.

You can also choose not to stage your modified files by skipping the staging area. In this case, Visual Studio allows you to commit your changes directly without having to stage them. Just enter your commit message and then select **Commit All**. The equivalent command for this action is `git commit -a`.

Visual Studio also makes it easy to commit and sync with one click by using the **Commit All and Push** and **Commit All and Sync** shortcuts. When you double-click any file in the **Changes** and the **Staged changes** sections, you can see a line-by-line comparison with the unmodified version of the file.

:::image type="content" source="media/git-file-version-compare.png" alt-text="The line-by-line comparison of file versions in Visual Studio ":::

> [!TIP]
> You can associate an Azure DevOps work item with a commit by using the "#" character if you are connected to the Azure DevOps repository. You can connect your Azure DevOps repository through **Team Explorer** > **Manage Connections**.

### Select an existing branch

Visual Studio displays the current branch in the selector at the top of the **Git Changes** window.

:::image type="content" source="media/git-changes-current-branch-selector.png" alt-text="The current branches that you can view by using the selector at the top of the Git Changes selector in Visual Studio ":::

The current branch is also available in the status bar on the bottom-right corner of the Visual Studio IDE.

:::image type="content" source="media/git-changes-current-branch-status-bar.png" alt-text="The current branches that you can view by using the status bar at the bottom-right corner in the Visual Studio IDE ":::

From both locations, you can switch between existing branches.

### Create a new branch

You can also create a new branch. The equivalent command for this action is `git checkout -b <branchname>`.

Creating a new branch is as simple as entering the branch name and basing it off an existing branch.

:::image type="content" source="media/git-changes-create-new-branch.png" alt-text="The Create a New Branch dialog box in Visual Studio ":::

You can choose an existing local or remote branch as the base. The **Checkout branch** checkbox automatically switches you to the newly created branch. The equivalent command for this action is `git checkout -b <new-branch><existing-branch>`.

## Git Repository window

Visual Studio has a new **Git Repository** window, which is a consolidated view of all the details in your repository, including all of the branches, remotes, and commit histories. You can access this window directly from either **Git** or **View** on the menu bar or from the status bar.

### Manage branches

When you select **Manage Branches** from the **Git** menu, you’ll see the branches tree-view in the **Git Repository** window. From the left pane, you can use the right-click context menu to checkout branches, create new branches, merge, rebase, cherry-pick, and more. When you click the branch, you can see a preview of its commit history in the right pane.

### Incoming and outgoing commits

When you fetch a branch, the **Git Changes** window has an indicator under the branch drop-down, which displays the number of unpulled commits from the remote branch. This indicator also shows you the number of unpushed local commits.

:::image type="content" source="media/git-repo-drop-down-indicator.png" alt-text="The Git Changes window that shows the indicator drop-down UI element in Visual Studio ":::

The indicator also functions as a link to take you to the commit history of that branch in the **Git Repository** window. The top of the history now displays the details of these incoming and outgoing commits. From here, you can also decide to Pull or Push the commits.

:::image type="content" source="media/git-branch-commit-history.png" alt-text="The Git Repository window that shows the commit history of a branch in Visual Studio ":::

#### Commit Details

When you double-click a **Commit**, Visual Studio opens its details in a separate tool window. From here you can revert the commit, reset the commit, amend the commit message, or create a tag on the commit. When you click a changed file in the commit, Visual Studio opens the side-by-side **Diff** view of the commit and its parent.

:::image type="content" source="media/git-branch-commit-details.png" alt-text="The Commit Details dialog box in Visual Studio ":::

## Handle merge conflicts

Conflicts can occur during a merge if two developers modify the same lines in a file and Git doesn’t automatically know which is correct. Git halts the merge and informs you that you are in a conflicted state.

Visual Studio makes it easy to identify and resolve a merge conflict. First, the **Git Repository** window shows a gold info bar at the top of the window.

:::image type="content" source="media/git-merge-conflict-gold-bar.png" alt-text="The 'Merge completed with conflicts' message in Visual Studio ":::

The **Git Changes** window also displays a ‘*Merge is in progress with conflicts*’ message, with the unmerged files in their separate section below it.

:::image type="content" source="media/git-merge-progress-conflicts-message.png" alt-text="The 'Merge in progress with conflicts' message in Visual Studio ":::

But if you have neither of these windows open, and instead you go to the file that has merge conflicts, you won’t have to search for the following text:

```bash
    <<<<<<< HEAD
    =======
    >>>>>>> main
```

Instead, Visual Studio displays a gold info bar on the top of the page that indicates that the opened file has conflicts. Then, you can click the link to open the **Merge Editor**.

:::image type="content" source="media/git-merge-conflict-gold-info-bar.png" alt-text="Screenshot of 'File contains merge conflicts' message in Visual Studio ":::

### The Merge Editor

The Merge Editor in Visual Studio is a three-way merge tool that displays the incoming changes, your current changes, and the result of the merge. You can use the tool bar at the top level of the **Merge Editor** to navigate between conflicts and auto-merged differences in the file.

:::image type="content" source="media/git-merge-editor.png" alt-text="The Merge Editor in Visual Studio ":::

You can also use the toggles to show/hide differences, show/hide word differences, and customize the layout. There are checkboxes on the top of each side that you can use to take all the changes from one side or the other. But to take individual changes, you can click the checkboxes to the left of the conflicting lines on either side. Finally, when you finish resolving the conflicts, you can select the **Accept Merge** button in the Merge Editor. You then write a commit message and commit the changes to complete the resolution.

## Personalize your Git settings

To personalize and customize your Git settings at a repository level as well as at a global level, go to either **Git** > **Settings** on the menu bar, or to **Tools** > **Options** > **Source Control** on the menu bar. Then, choose the [options](git-settings.md) you want.

:::image type="content" source="media/git-options-settings.png" alt-text="The Options dialog box where you can choose personalization and customization settings in Visual Studio IDE ":::

::: moniker range="vs-2019"

## How to use the full Team Explorer experience in Visual Studio

The new Git experience is the default version control system in Visual Studio 2019 from [version 16.8](/visualstudio/releases/2019/release-notes/) onwards. However, if you want to turn it off, you can. Go to **Tools** > **Options** > **Environment** > **Preview Features** and then toggle the **New Git user experience** checkbox, which will switch you back to Team Explorer for Git.

:::image type="content" source="media/git-opt-new-user-experience.png" alt-text="The Preview Features section of the Options dialog box in Visual Studio ":::

::: moniker-end

## What's next

While the new Git experience is now on by default in Visual Studio 2019 [version 16.8](/visualstudio/releases/2019/release-notes/), we continue to add new features to enhance the experience. If you'd like to check out new updates to the Git experience in a Preview release, you can download and install it from the [Visual Studio Preview](https://aka.ms/vspreview/) page.

> [!IMPORTANT]
> If you have a suggestion for us, please let us know! We appreciate the opportunity to engage with you on design decisions via the [**Developer Community**](https://aka.ms/vs-suggest) portal.

## See also

- [Get Started with Git and GitHub in Visual Studio](/learn/modules/visual-studio-github-push/) tutorial on Microsoft Learn
- [Getting started with Git in Visual Studio](https://www.youtube.com/watch?v=GCZ9x3yqkyc) video on YouTube
- [Announcing the Release of the Git Experience in Visual Studio](https://devblogs.microsoft.com/visualstudio/announcing-the-release-of-the-git-experience-in-visual-studio/) blog post
- [The launch of the new Git experience](https://www.youtube.com/watch?v=UHrAg3iKoe0&t) video on YouTube
- [The Visual Studio Toolbox series presents: The new Git experience](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/The-New-Git-Experience) video on Channel 9 and on [YouTube](https://www.youtube.com/watch?v=ZiQ2LXtAJ6I&feature=youtu.be)
- [Exciting new updates to the Git experience in Visual Studio](https://devblogs.microsoft.com/visualstudio/exciting-new-updates-to-the-git-experience-in-visual-studio/) blog post
- [Improved Git Experience in Visual Studio 2019](https://devblogs.microsoft.com/visualstudio/improved-git-experience-in-visual-studio-2019/) blog post
- [Work with GitHub accounts in Visual Studio](../ide/work-with-github-accounts.md)
- [Visual Studio 2019 release notes](/visualstudio/releases/2019/release-notes)
