---
title: Create a Git repo
description: Create a repo in Visual Studio by using Git, or browse to an Azure DevOps repo.
ms.date: 02/28/2023
ms.topic: how-to
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.custom: version-control
---
# Create a Git repository from Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

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

    :::image type="content" source="../get-started/media/vs-2022/git-create-repo-dialog.png" alt-text="Screenshot of the Create Git Repository dialog in Visual Studio with the GitHub selection highlighted.":::

1. In the **Create a new GitHub repository** section of the **Create a Git repository** dialog, enter the name of the repo you want to create.

    > [!TIP]
    > If you haven't yet signed in to your GitHub account, you can do so from this screen, too.

1. After you sign in and enter your repo info, select the **Create and Push** button to create your repo and add your app.

### Open an existing local repository

After you’ve created a repo or [cloned one](git-clone-repository.md), Visual Studio detects the Git repository and adds it to your list of **Local Repositories** in the Git menu. From there, you can quickly access and switch between your Git repositories.

## Create an Azure DevOps repo

1. Open Visual Studio, and then select **Create a new project**.

    > [!TIP]
    > If you don't already have a project in Visual Studio to add to a repo, you can quickly [create a new C# console app](../get-started/csharp/tutorial-console.md#create-a-project) and name it **MyNewApp**. Visual Studio populates your new app with default "*Hello, World!*" code.

1. From the **Git** menu, select **Create Git Repository**.

1. In the **Create a Git repository** dialog, under the **Push to a new remote** section, choose **Azure DevOps**.

1. In the **Create a new Azure DevOps repository** section, sign in to your Azure account, and then select a project from the **Project** drop-down list.

1. Select the **Create and Push** button to create your repo and add your app.

## Next steps

To continue your journey, visit the [Create a branch](git-create-branch.md) page.

## See also

- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo.md)
- [Work with GitHub accounts in Visual Studio](../ide/work-with-github-accounts.md)
