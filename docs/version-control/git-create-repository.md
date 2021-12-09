---
title: Create a repo in Visual Studio
titleSuffix: ""
description: Create a repo in Visual Studio by using Git, or browse to an Azure DevOps repo.
ms.date: 11/10/2021
ms.topic: how-to
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
---
# Create a repo in Visual Studio

Visual Studio makes it easy to clone a repo right from the IDE. Here's how.

## Create a GitHub repo

1. Open Visual Studio, and then select **Create a new project**.

    > [!TIP]
    > If don't already have a project in Visual Studio to add to a repo, you can quickly [create a new C# console app](../get-started/csharp/tutorial-console.md#create-a-project) and name it **MyNewApp**. Visual Studio populates your new app with default "*Hello, World!*" code.

1. From the **Git** menu, select **Create Git Repository**.

    :::image type="content" source="media/vs-2022/git-menu-create-git-repository.png" alt-text="Screenshot of the Create Git Repository option from the Git menu in Visual Studio.":::

1. In the **Create a Git repository** dialog, under the **Push to a new remote** section, choose **GitHub**.

    :::image type="content" source="media/vs-2022/git-menu-create-github-repo-dialog.png" alt-text="Screenshot of the Create Git Repository option from the Git menu in Visual Studio with the GitHub selection highlighted.":::

1. In the **Create a new GitHub repository** section of the **Create a Git repository** dialog, enter the name of the repo you want to create.

    > [!TIP]
    > If you haven't yet signed in to your GitHub account, you can do so from this screen, too.

1. After you sign in and enter your repo info, select the **Create and Push** button to create your repo and add your app.

    :::image type="content" source="media/vs-2022/git-menu-create-git-repo-push-code.png" alt-text="Screenshot of a user's GitHub info entered by using the Create Git Repository window.":::

### Open an existing local repository

After you’ve created a repo or [cloned one](git-clone-repository.md), Visual Studio detects the Git repository and adds it to your list of **Local Repositories** in the Git menu. From there, you can quickly access and switch between your Git repositories.

## Create an Azure DevOps repo

1. Open Visual Studio, and then select **Create a new project**.

    > [!TIP]
    > If don't already have a project in Visual Studio to add to a repo, you can quickly [create a new C# console app](../get-started/csharp/tutorial-console.md#create-a-project) and name it **MyNewApp**. Visual Studio populates your new app with default "*Hello, World!*" code.

1. From the **Git** menu, select **Create Git Repository**.

1. In the **Create a Git repository** dialog, under the **Push to a new remote** section, choose **Azure DevOps**.

1. In the **Create a new Azure DevOps repository** section, sign in to your Azure account, and then select a project from the **Project** drop-down list.

1. Select the **Create and Push** button to create your repo and add your app.

    :::image type="content" source="media/vs-2022/git-menu-publish-azure-devops.png" alt-text="Screenshot of the Create and Push function of the Create a Git repository dialog, which you can use to publish code with a single action.":::

## Next steps

To continue your journey, visit the [Create a branch](git-create-branch.md) page.

## See also

- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo.md)
- [Work with GitHub accounts in Visual Studio](../ide/work-with-github-accounts.md)
- [Work with multiple user accounts](../ide/work-with-multiple-user-accounts.md)
- [Sign in to Visual Studio](../ide/signing-in-to-visual-studio.md)
- [Visual Studio & GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)