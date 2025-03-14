---
title: Create a Git repo or work remotely with a provider
description: Create a repo in Visual Studio by using Git, browse to an Azure DevOps repo, or work remotely with the Git provider of your choice.
ms.date: 02/13/2024
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs

ms.subservice: general-ide
---
# Create a Git repository from Visual Studio

Visual Studio makes it easy to create a repo right from the IDE. Repository creation from Visual Studio is optimized for GitHub, but you can work remotely with the Git provider of your choice.  Here's how.

## Prerequisites

To follow this article, you'll need:
+ [Visual Studio installed](../install/install-visual-studio.md)
+ [A GitHub user account](git-create-github-account.md)

## Create a GitHub repo

1. Open Visual Studio, and then select **Create a new project**.

    > [!TIP]
    > If you don't already have a project in Visual Studio to add to a repo, you can quickly [create a new C# console app](../get-started/csharp/tutorial-console.md#create-a-project) and name it **MyNewApp**. Visual Studio populates your new app with default "*Hello, World!*" code.

1. From the **Git** menu, select **Create Git Repository**.

    :::image type="content" source="media/vs-2022/git-menu-create-git-repository.png" alt-text="Screenshot of the Create Git Repository option from the Git menu in Visual Studio.":::

1. In the **Create a Git repository** dialog, under the **Push to a new remote** section, choose **GitHub**.

1. In the **Create a new GitHub repository** section of the **Create a Git repository** dialog, enter the name of the repo you want to create. (If you haven't yet signed in to your GitHub account, you can do so from this screen, too.)

   Visual Studio 17.12 and later support multiple GitHub accounts, so you can also use the **Account** dropdown to switch to another GitHub account if your current active account is the one you want to use for the new repo.

    :::image type="content" source="../get-started/media/vs-2022/git-create-repo-dialog.png" alt-text="Screenshot of the Create Git Repository dialog in Visual Studio with the GitHub selection highlighted.":::

    With Visual Studio 2022 version 17.12 and later, you can choose the visibility of the new repo. Next to **Visibility**, choose **public**, **private**, or **internal** (see [About internal repositories](https://docs.github.com/enterprise-cloud@latest/repositories/creating-and-managing-repositories/about-repositories#about-internal-repositories)). To create an internal repo, you must be signed in with a [GitHub Enterprise](https://enterprise.github.com/login) account. With earlier versions, select the checkbox if you want a private repo.

1. Under **Initialize a local Git Repository**, you can use the **.gitignore template** option to specify any intentionally untracked files that you want Git to ignore. To learn more about .gitignore, see [Ignoring files](https://docs.github.com/get-started/getting-started-with-git/ignoring-files). And to learn more about licensing, see [Licensing a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository).

    > [!TIP]
    > You can update and change these settings whenever you want to. For detailed instructions, see [Git settings in Visual Studio](git-settings.md).

1. After you sign in and enter your repo info, select the **Create and Push** button to create your repo and add your app.

## Create an Azure DevOps repo

1. Open Visual Studio, and then select **Create a new project**.

    > [!TIP]
    > If you don't already have a project in Visual Studio to add to a repo, you can quickly [create a new C# console app](../get-started/csharp/tutorial-console.md#create-a-project) and name it **MyNewApp**. Visual Studio populates your new app with default "*Hello, World!*" code.

1. From the **Git** menu, select **Create Git Repository**.

1. In the **Create a Git repository** dialog, under the **Push to a new remote** section, choose **Azure DevOps**.

1. In the **Create a new Azure DevOps repository** section, sign in to your Azure account, and then select a project from the **Project** drop-down list.

1. Select the **Create and Push** button to create your repo and add your app.

## Work with local repos

To create a local repo:

1. From the **Git** menu, select **Create Git Repository**.

1. In the **Create a Git repository** dialog, under **Other**, choose **Local only**.

   :::image type="content" source="media/vs-2022/git-repository-create-local.png" alt-text="Screenshot of the Create Git Repository screen, showing the Local only option.":::

1. Under **Initialize a local Git repository**, check the local path to the project, and modify any other settings if needed.

1. Select the **Create and Push** button to create your repo.

After you’ve created a repo or [cloned one](git-clone-repository.md), Visual Studio detects the Git repository and adds it to your list of **Local Repositories** in the Git menu. From there, you can quickly access and switch between your Git repositories.

## Add another repo to a solution

When you add a new project to an existing multi-repo solution, you might want to track that project in its own repository. To do so, follow these steps:

1. Add the project to the solution.
1. Close the solution.
1. Use **Open a local folder** to open the new project by itself.
1. Create a new repository using the methods described earlier in this article in GitHub, Azure DevOps, another Git hosting provider, or locally (the equivalent of `git init` from the command line).
1. Reopen the parent solution. The new project's repo will be included.

## Related content

- [Create a branch](git-create-branch.md)
- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo.md)
- [Work with GitHub accounts in Visual Studio](../ide/work-with-github-accounts.md)
