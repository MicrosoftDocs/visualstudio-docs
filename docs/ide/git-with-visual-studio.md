---
title: New Git experience in Visual Studio (Preview)
titleSuffix: ""
Description: Learn about the new Git experience in Visual Studio 2019
ms.date: 09/21/2020
ms.topic: conceptual
ms.author: tglee
author: prnadago
ms.manager: jillfra
monikerRange: vs-2019
---
# New Git experience in Visual Studio (Preview)

Beginning with [version 16.6](/visualstudio/releases/2019/release-notes-v16.6), Visual Studio 2019 now includes a new Git experience that makes it easy to use Git from the IDE. Git is the most widely used modern version control system, so no matter whether you’re a professional developer or if you’re learning how to code, Git can be very useful to you.

> [!TIP]
> If you are new to Git, the https://git-scm.com/ website is a good place to start. There, you’ll find a popular online book, Git Basics videos, and cheat sheets.

## How to start using Git in Visual Studio

To toggle the new Git experience, go to **Tools** > **Options** > **Environment** > **Preview Features** and then select the **New Git user experience** checkbox.

:::image type="content" source="media/git-opt-new-user-experience.png" alt-text="Screenshot of the Preview Features section of the Options dialog box in Visual Studio ":::

There are three ways to use Git in Visual Studio 2019:

- Connect to your Git files. If your code is already on your machine, you can open it by using **File** > **Open** > **Project/Solution** (or **Folder**) and Visual Studio will automatically detect if it has an initialized Git repository.
- [Create a new Git repository](#create-a-new-git-repository). If your code is not associated with Git, you can create a new Git repository.
- [Clone an existing Git repository](#clone-an-existing-git-repository). If the code that you would like to work on is not on your machine, you can clone any existing remote repositories.

## Create a new Git repository

If your code is not associated with Git, you can start by creating a new Git repository. To do so, select **Git** > **Create Git Repository** from the menu bar. Then, in the **Create a Git repository** dialog box, enter your information.

:::image type="content" source="media/git-create-repository.png" alt-text="Screenshot of the Create a Git Repository dialog box in Visual Studio ":::

The **Create a Git repository** dialog box makes it easy to push your new repository to GitHub. By default, your new repository is private, which means that you are the only one who can access it. If you uncheck the box, your repository will be public, which means that anyone on GitHub can view it.

> [!TIP]
> Whether your repository is public or private, it's best to have a remote backup of your code stored securely on GitHub even if you are not working with a team. This also makes your code available to you no matter what computer you're using.

You can choose to create a local-only Git repository by using the **Local only** option. Or, you can link your repository with any existing empty remote repository on any other Git provider by using the **Existing remote** option.

## Clone an existing Git repository

Visual Studio includes a straightforward clone experience. If you know the URL of the repository that you would like to clone, you can paste the URL in the **Repository location** section and then choose the disk location you would like Visual Studio to clone to.

:::image type="content" source="media/git-clone-repository.png" alt-text="Screenshot of the Clone a Git Repository dialog box in Visual Studio ":::

If you don’t know the repository URL, Visual Studio makes it easy to browse to and then clone your existing GitHub or Azure DevOps repository.

### Open an existing local repository

After you’ve cloned a repository or created one, Visual Studio detects the Git repository and adds it to your list of **Local Repositories** in the Git menu. From here you can quickly access and switch between your Git repositories.

:::image type="content" source="media/git-local-repositories.png" alt-text="Screenshot of the Local Repositories option from the Git menu in Visual Studio ":::

### View your files in Solution Explorer

When you clone a repository or open a local repository, Visual Studio switches you into that Git context by saving and closing any previously open solutions and projects. Solution Explorer loads the folder at the root of the Git repository and scans the directory tree for any View files. These include files such as CMakeLists.txt or those with the .sln file extension.

Visual Studio adjusts its View based on which View file you load in Solution Explorer:

- If you clone a repository that contains a single .sln file, then Solution Explorer directly loads that solution for you.
- If Solution Explorer doesn’t detect any .sln files in your repository, then by default it loads Folder View.
- If your repository has more than one .sln file, then Solution Explorer shows you the list of available Views for you to choose from.

You can toggle between the currently open View and the list of Views by using the **Switch Views** button in the Solution Explorer toolbar.

:::image type="content" source="media/git-solution-explorer-views.png" alt-text="Screenshot of Solution Explorer with the Switch Views button selected in Visual Studio ":::

## See also

- [The new Git experience](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/The-New-Git-Experience) video on Channel 9 and [YouTube](https://www.youtube.com/watch?v=ZiQ2LXtAJ6I&feature=youtu.be)
- [Exciting new updates to the Git experience in Visual Studio](https://devblogs.microsoft.com/visualstudio/exciting-new-updates-to-the-git-experience-in-visual-studio/) blog post
- [Improved Git Experience in Visual Studio 2019](https://devblogs.microsoft.com/visualstudio/improved-git-experience-in-visual-studio-2019/) blog post
- [Visual Studio 2019 release notes](/visualstudio/releases/2019/release-notes)
