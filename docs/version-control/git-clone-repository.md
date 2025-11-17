---
title: Clone a repo in Visual Studio
titleSuffix: ""
description: Clone a repo in Visual Studio by using the Git Clone Repository option or browse to and then clone an Azure DevOps repo.
ms.date: 11/17/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs
ms.subservice: general-ide
ms.custom: sfi-image-nochange
---
# Clone a Git repository in Visual Studio

Visual Studio makes it easy to clone a repository right from the IDE. You can work remotely with the Git provider of your choice, such as GitHub or Azure DevOps. If you need to create a new repository instead of cloning an existing one, see [Create a repository from Visual Studio](git-create-repository.md).

## Prerequisites

To follow this article, you'll need:
+ [Visual Studio installed](../install/install-visual-studio.md)
+ [A GitHub user account](git-create-github-account.md)

## Clone a GitHub repo and sign in

1. Open Visual Studio.

1. From the **Git** menu, select **Clone Repository**.

:::moniker range="visualstudio"

    :::image type="content" source="media/visualstudio/git-menu-clone-repository.png" alt-text="Screenshot that shows the Clone Repository option from the Git menu in Visual Studio.":::

:::moniker-end

:::moniker range="<=vs-2022"

    :::image type="content" source="../ide/media/vs-2022/git-menu-clone-repository.png" alt-text="Screenshot of the Clone Repository option from the Git menu in Visual Studio.":::

:::moniker-end

    > [!NOTE]
    > If you haven't interacted with the **Git** menu before, you might see **Clone** instead of **Clone Repository**. If so, select **Clone**.
    >
    > And, if **Git** isn't on the menu bar, go to **Tools** > **Options** > **Source Control** > **Plug-in Selection**, and then select **Git** from the **Current source control plug-in** dropdown list.

1. In the **Clone a repository** window, under the **Enter a Git repository URL** section, add your repo info in the **Repository location** box.

    Next, in the **Path** section, you can choose to accept the default path to your local source files, or you can browse to a different location.

    Then, in the **Browse a repository** section, select **GitHub**.

    :::image type="content" source="media/vs-2022/git-menu-clone-repo-dialog.png" alt-text="Screenshot of the Clone a Repository dialog box with GitHub highlighted.":::

1. In the **Open from GitHub** window, you can either verify your GitHub account information or you can add it. To do so, select **Sign in** from the drop-down menu.

    :::image type="content" source="media/vs-2022/git-menu-clone-repo-dialog-github-account.png" alt-text="Screenshot of the Sign in drop-down section of the Open from GitHub window.":::

    If you're signing in to GitHub from Visual Studio for the first time, an **Authorize Visual Studio** notice appears. Choose the options you want, and then select **Authorize github**.

    :::image type="content" source="media/vs-2022/git-menu-github-authorize-visual-studio-sml.png" alt-text="Screenshot of the authorization dialog box." lightbox="media/vs-2022/git-menu-github-authorize-visual-studio-lrg.png":::

    Next, you'll see an authorization confirmation window. Enter your password, and then select **Confirm password**.

    :::image type="content" source="media/vs-2022/git-menu-github-authorize-confirm-access-sml.png" alt-text="Screenshot of the confirm access dialog box." lightbox="media/vs-2022/git-menu-github-authorize-confirm-access-lrg.png":::

    After you link your GitHub account with Visual Studio, a Success notification appears.

    :::image type="content" source="../ide/media/github-success-signin.png" alt-text="Screenshot of the Success notification you receive after you link your GitHub account with Visual Studio.":::

    If you have more than one GitHub account, you can sign in with any of your accounts. If you're already signed in with one account, you can use the account dropdown to switch to a different account.

1. After you sign in, Visual Studio returns to the **Clone a repository** dialog, where the **Open from GitHub** window lists all the repositories that you have access to. Select the one you want, and then select **Clone**.

    If a list of repositories doesn't appear, enter the location of your repo, and then select **Clone**.

    :::image type="content" source="media/vs-2022/git-menu-clone-repo-dialog-open-from-github-location-sml.png" alt-text="Screenshot of the Open from GitHub window where you can select a repo or add one." lightbox="media/vs-2022/git-menu-clone-repo-dialog-open-from-github-location-lrg.png":::

1. Next, Visual Studio presents a list of solution(s) in the repository. Choose the solution you would like to load or open the **Folder View** in [**Solution Explorer**](../ide/use-solution-explorer.md).

:::moniker range="visualstudio"

    :::image type="content" source="media/visualstudio/git-solution-explorer-folder-view.png" alt-text="Screenshot of the Folder View in Solution Explorer in Visual Studio.":::

:::moniker-end

:::moniker range="<=vs-2022"

    :::image type="content" source="../ide/media/vs-2022/git-solution-explorer-folder-view.png" alt-text="Screenshot of the Folder View in Solution Explorer in Visual Studio 2022.":::

:::moniker-end

    > [!TIP]
    > You can change the default Folder View to Solution View from the **Git** menu. Select **Settings** > **Source Control** > **Git Global Settings** > **Automatically load the solution when opening a Git repository** to do so.

### Open an existing local repository

After you’ve cloned a repo or [created one](git-create-repository.md), Visual Studio detects the Git repository and adds it to your list of **Local Repositories** in the Git menu. From there, you can quickly access and switch between your Git repositories.

## Browse to and then clone an Azure DevOps repo

1. Open Visual Studio.

1. From the **Git** menu, select **Clone Repository**.

:::moniker range="visualstudio"

    :::image type="content" source="media/visualstudio/git-menu-clone-repository-2.png" alt-text="Screenshot that shows the full Clone Repository option from the Git menu in Visual Studio.":::

:::moniker-end

:::moniker range="<=vs-2022"

    :::image type="content" source="media/vs-2022/git-menu-clone-repository.png" alt-text="Screenshot of the full Clone Repository option from the Git menu in Visual Studio.":::

:::moniker-end

1. In the **Browse a repository** section of the **Clone a repository** dialog box, select **Azure DevOps**.

    :::image type="content" source="../ide/media/vs-2022/browse-repository-azure-devops.png" alt-text="Screenshot of the 'Browse a repository' section of the 'Clone a repository' dialog box in Visual Studio, Azure DevOps highlighted.":::

1. A **Connect to a Project** dialog box appears. Follow the prompts to sign in to your Azure account, and then browse to Azure DevOps Server that hosts the files you're looking for.

## Related content

- [Create a repo](git-create-repository.md)
