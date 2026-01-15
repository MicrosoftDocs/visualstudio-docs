---
title: "Tutorial: Open project from repo in Visual Studio"
description: In this tutorial, learn how to open a cloned project in a Git or Azure DevOps repository by using Visual Studio and view files in Solution Explorer.
ms.date: 12/19/2024
ms.subservice: general-ide
ms.topic: tutorial
author: anandmeg
ms.author: meghaanand
manager: mijacobs
dev_langs:
  - CSharp
ms.custom:
  - vs-acquisition
  - sfi-image-nochange
#customer intent: As a developer who works on projects in remote repositories, I want to learn how to integrate Visual Studio seamlessly with Git and Azure DevOps repositories.
---
# Tutorial: Open a project from a repo

In this tutorial, you use Visual Studio to connect to a repository, or *repo*, for the first time, clone it, and then open a project from it.

In this tutorial, you learn how to:

> [!div class="checklist"]
> - Open a project from a GitHub repo
> - Browse to an Azure DevOps repo

## Prerequisites

- If you don't have Visual Studio yet, go to [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta) to install it for free.

::: moniker range=">=vs-2022"

## Open a project from a GitHub repo

Visual Studio makes it easy to open a project from a repo. You can do so when you start Visual Studio, or you can do so directly from within the [Visual Studio IDE](visual-studio-ide.md).

Here's how.

### Use the start window

1. Open Visual Studio.

1. On the start window, select **Clone a repository**.

   :::image type="content" source="../ide/media/vs-2022/clone-repository.png" alt-text="Screenshot of the Clone a Repository dialog in Visual Studio." lightbox="../ide/media/vs-2022/clone-repository.png":::

1. Enter or type the repository location, and then select **Clone**.

   :::image type="content" source="../ide/media/vs-2022/clone-repository-enter-location.png" alt-text="Screenshot of the Clone a Repository dialog in Visual Studio where you enter a Git repo URL." lightbox="../ide/media/vs-2022/clone-repository-enter-location.png":::

1. If you're not already signed in, you might be prompted to sign into Visual Studio or your GitHub account.

   > [!TIP]
   > For more information about signing in to Visual Studio, see [Sign in or switch Visual Studio user accounts](../ide/signing-in-to-visual-studio.md?view=vs-2022&preserve-view=true). For specific information about how to use your GitHub account to sign in, see [Add your GitHub accounts to your Visual Studio keychain](../ide/work-with-github-accounts.md?view=vs-2022&preserve-view=true). You might receive a trust notification. For more information, see [Configure trust settings for files and folders](../ide/reference/trust-settings.md?view=vs-2022&preserve-view=true).

### View files in Solution Explorer

Visual Studio loads the solutions from the repository by using the **Folder View** in [**Solution Explorer**](../ide/use-solution-explorer.md?view=vs-2022&preserve-view=true).

:::image type="content" source="./media/vs-2022/tutorial-open-project-from-repo/git-solution-explorer-folder-view.png" alt-text="Screenshot of the Folder View in Solution Explorer in Visual Studio 2022.":::

You can view a solution in **Solution View** by double-clicking its `.sln` file.

You can select **Switch Views** to switch between folder view and solution view.

:::image type="content" source="./media/vs-2022/tutorial-open-project-from-repo/git-solution-explorer-switch-views.png" alt-text="Screenshot of a C# project in Git that's open in Solution Explorer":::

> [!TIP]
> You can change from the default Folder View to Solution View from the **Git** menu. Select **Settings** > **Source Control** > **Git Global Settings** > **Automatically load the solution when opening a Git repository**.

#### Open a project locally from a previously cloned GitHub repo

1. Open Visual Studio.

1. On the start window, select **Open a project or solution**.

   Visual Studio opens an instance of File Explorer, where you can browse to your solution or project, and then select it to open it.

   :::image type="content" source="../ide/media/vs-2022/open-local-project-from-cloned-repo.png" alt-text="Screenshot of the 'Open a project or solution' window in Visual Studio 2022.":::

   > [!TIP]
   > If you opened the project or solution recently, select it from the **Open recent** section.

   Start coding!

### Use the IDE

You can also use the **Git** menu or the **Select Repository** control in the Visual Studio IDE to interact with a repository's folders and files.

Here's how.

#### To clone a repo and open a project

1. In the Visual Studio IDE, select the **Git** menu, and then select **Clone Repository**.

   :::image type="content" source="../ide/media/vs-2022/git-menu-clone-repository.png" alt-text="Screenshot of the Git menu in Visual Studio 2022 with Clone Repository selected.":::

1. Follow the prompts to connect to the Git repository that includes the files that you're looking for.

#### To open local folders and files

1. In the Visual Studio IDE, select the **Git** menu, select **Local Repositories**, and then select **Open Local Repository**.

   :::image type="content" source="../ide/media/vs-2022/git-menu-local-repositories.png" alt-text="Screenshot of the Git menu in Visual Studio 2022 with the Local Repository and Open Local Repository showing.":::

1. Follow the prompts to connect to the Git repository that has the files that you're looking for.

## Browse to an Azure DevOps repo

Here's how to browse to and clone an Azure DevOps repo by using Visual Studio.

1. Open Visual Studio.

1. On the start window, select **Clone a repository**.

   :::image type="content" source="../ide/media/vs-2022/clone-repository.png" alt-text="Screenshot of the Clone a Repository dialog in Visual Studio, for Azure DevOps." lightbox="../ide/media/vs-2022/clone-repository.png":::

1. In the **Browse a repository** section, select **Azure DevOps**.

   :::image type="content" source="../ide/media/vs-2022/browse-repository-azure-devops.png" alt-text="Screenshot of 'Browse a repository' in the 'Clone a repository' dialog in Visual Studio, Azure DevOps highlighted.":::

1. Follow the prompts to clone an Azure DevOps repo that includes the files that you're looking for, and then open your project.

::: moniker-end


## Related content

Feel free to dive into any of the following language-specific tutorials:

- [Visual Studio tutorials | **C#**](./csharp/index.yml)
- [Visual Studio tutorials | **Visual Basic**](./visual-basic/index.yml)
- [Visual Studio tutorials | **C++**](/cpp/get-started/tutorial-console-cpp)
- [Visual Studio tutorials | **Python**](../python/index.yml)
- [Visual Studio tutorials | **JavaScript**, **TypeScript**, and **Node.js**](../javascript/index.yml)

For more information, see:


::: moniker range=">=vs-2022"

- [About Git in Visual Studio](../version-control/git-with-visual-studio.md)
- [Brpwse a repo](../version-control/git-browse-repository.md)
- [Manage a repo](../version-control/git-manage-repository.md)

::: moniker-end
