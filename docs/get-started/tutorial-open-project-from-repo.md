---
title: "Tutorial: Open a project from a repo"
description: "Learn how to open a project in a Git or Azure DevOps repository by using Visual Studio."
ms.custom: "get-started"
ms.date: 01/05/2021
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: tutorial
author: TerryGLee
ms.author: tglee
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
  - "dotnetcore"
---
# Tutorial: Open a project from a repo

In this tutorial, you'll use Visual Studio to connect to a repository for the first time and then open a project from it.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range="vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

## Open a project from a GitHub repo

::: moniker range="vs-2017"

1. Open Visual Studio 2017.

1. From the top menu bar, select **File** > **Open** > **Open from Source Control**.

   The **Team Explorer - Connect** pane opens.

    ![The Team Explorer window within the Visual Studio IDE](./media/open-proj-repo-team-explorer.png)

1. In the **Local Git Repositories** section, select **Clone**.

    ![Choose Clone from the Local Git Repositories section](./media/open-proj-repo-local-git-repo-clone.png)

1. In the box that says ***Enter the URL of a Git repo to clone***, type or paste the URL for your repo, and then press **Enter**. (You might receive a prompt to sign in to GitHub; if so, do so.)

   After Visual Studio clones your repo, Team Explorer closes and Solution Explorer opens. A message appears that says *Click on Solutions and Folders above to view a list of Solutions*. Choose **Solutions and Folders**.

   ![Choose "Solutions and Folders" from the Solution Explorer](./media/open-proj-repo-github-solutions-folders.png)

1. If you have a solution file available, it will appear in the "Solutions and Folders" fly-out menu. Choose it, and Visual Studio opens your solution.

   ![Choose what you want to open from the Solution Explorer drop-down list](./media/open-proj-repo-github-solutions-folders-picker.png)

   If you do not have a solution file (specifically, a .sln file) in your repo, the fly-out menu will say "No Solutions Found." However, you can double-click any file from the folder menu to open it in the Visual Studio code editor.

### Review your work

View the following animation to check the work that you completed in the previous section.

   ![Animation of opening a project in a GitHub repo by using Visual Studio](./media/open-project-from-github.gif)

::: moniker-end

::: moniker range="vs-2019"

How you open a project from a GitHub repo by using Visual Studio 2019 depends on what version you have. Specifically, if you've installed version [**version 16.8**](/visualstudio/releases/2019/release-notes/) or later, there's a new, more fully integrated [Git experience in Visual Studio](../ide/git-with-visual-studio.md) available to you.

But no matter which version you have installed, you can always open a project from a GitHub repo with Visual Studio.

#### [16.8 and later](#tab/vs168+)

<!--- Content here  -->
You can open a project from a GitHub repo that you've cloned or one that you've stored locally. Here's how.

**Clone a GitHub repo and then open a project**

If you haven't yet cloned a repo where your project is located, you can do so by using the following procedure.

1. Open Visual Studio 2019.

1. On the start window, select **Clone a repository**.

   ![Screenshot of the Clone a Repository dialog](../ide/media/vs-2019/clone-repository.png "Screenshot of the Clone a Repository dialog.")

1. Enter or type the repository location, and then select **Clone**.

   ![Screenshot of the Clone a Repository dialog where you enter a Git repo URL](../ide/media/vs-2019/clone-repository-enter-location.png "Screenshot of the Clone a Repository dialog where you enter a Git repo URL.")

1. You might be asked for your user sign-in information in the **Git User Information** dialog box.

   ![Screenshot of the Git User Information dialog where you enter or edit your account info](../ide/media/vs-2019/git-user-information-dialog.png "Screenshot of the Git User Information dialog where you enter or edit your account info.")

    You can either add your information or edit the default information it provides. Then, select **Save** to add the info to your global .gitconfig file. (You can also choose to do this later by selecting **Cancel**.)

1. Next, Visual Studio opens the project from the repo.

   ![Screenshot of a project in Git that's open in Solution Explorer](../ide/media/vs-2019/git-solution-explorer.png "Screenshot of a project in Git that's open in Solution Explorer.")

1. If you have a solution file available, you can view it specifically by selecting the **Switch Views** button in Solution Explorer.

   ![Screenshot of a project in Git that's open in Solution Explorer, with the Switch Views button highlighted](../ide/media/vs-2019/git-solution-explorer-switch-views.png "Screenshot of a project in Git that's open in Solution Explorer, with the Switch Views button highlighted.")

   The Solution Explorer in Visual Studio switches to the solution view.

   ![Screenshot of the .sln file in Git that's open in Solution Explorer, after you've selected the Switch Views button](../ide/media/vs-2019/git-solution-explorer-view-solution.png "Screenshot of the .sln file in Git that's open in Solution Explorer, after you've selected the Switch Views button.")

**Open a project locally from a previously cloned GitHub repo**

If you've already cloned the GitHub repo where your project is located, here's how to open it:

1. Step One

1. Step Two

1. Etc.

#### [16.7 and earlier](#tab/vs167-)

<!--- Content here  -->
1. Open Visual Studio 2019.

1. On the start window, select **Clone or check out code**.

   ![View the 'Create a new project' window](../get-started/media/vs-2019/clone-checkout-code-dark.png)

1. Enter or type the repository location, and then select **Clone**.

   ![View the 'Clone or checkout code' window](../get-started/media/vs-2019/clone-checkout-code-git-repo-dark.png)

   Visual Studio opens the project from the repo.

1. If you have a solution file available, it will appear in the "Solutions and Folders" fly-out menu. Choose it, and Visual Studio opens your solution.

   ![Choose what you want to open from the Solution Explorer drop-down list](./media/open-proj-repo-github-solutions-folders-picker.png)

   If you do not have a solution file (specifically, a .sln file) in your repo, the fly-out menu will say "No Solutions Found." However, you can double-click any file from the folder menu to open it in the Visual Studio code editor.

---

::: moniker-end

## Open a project from an Azure DevOps repo

::: moniker range="vs-2017"

1. Open Visual Studio 2017.

1. From the top menu bar, select **File** > **Open** > **Open from Source Control**.

   The **Team Explorer - Connect** pane opens.

    ![The Team Explorer window within the Visual Studio IDE](./media/open-proj-repo-team-explorer.png)

1. Here are two ways to connect to your Azure DevOps repo:

      - In the **Hosted Service Providers** section, select **Connect...**.

        ![The Hosted Service Providers section of the Team Explorer window within the Visual Studio IDE](./media/open-proj-repo-azure-devops.png)

      - In the **Manage Connections** drop-down list, select **Connect to a Project...**.

        ![The Manage Connections section of the Team Explorer window within the Visual Studio IDE](./media/open-proj-repo-azuredevops-manage-connections.png)

1. In the **Connect to a Project** dialog box, choose the repo that you want to connect to, and then select **Clone**.

      ![The 'Connect to a Project' dialog box that's generated from Visual Studio](./media/open-proj-azure-devops-connect-cloud-clone.png)

    > [!NOTE]
    > What you see in the list box depends on the Azure DevOps repositories that you have access to.

1. After Visual Studio clones your repo, Team Explorer closes and Solution Explorer opens. A message appears that says *Click on Solutions and Folders above to view a list of Solutions*. Choose **Solutions and Folders**.

      ![The "Solutions and Folders" notification from Team Explorer in Visual Studio](./media/open-proj-repo-solutions-folders.png)

   A solution file (specifically, a .sln file), will appear in the "Solutions and Folders" fly-out menu. Choose it, and Visual Studio opens your solution.

   If you do not have a solution file in your repo, the fly-out menu will say "No Solutions Found". However, you can double-click any file from the folder menu to open it in the Visual Studio code editor.

::: moniker-end

::: moniker range="vs-2019"

The user interface (UI) that you see when you open an Azure DevOps project by using Visual Studio 2019 depends on what version you have. Specifically, if you've installed version [**version 16.8**](/visualstudio/releases/2019/release-notes/) or later, we've changed the UI to accommodate a new, more fully integrated [Git experience in Visual Studio](../ide/git-with-visual-studio.md) in Visual Studio.

But no matter which version you have installed, you can always open a project from an Azure DevOps repo with Visual Studio.

### In Visual Studio 2019 version 16.8 or later

You can either clone an Azure DevOps repo and open a project, or open a project locally from a previously cloned repo. Here's how.

#### Clone an Azure DevOps repo and then open a project

1. Open Visual Studio 2019.

1. On the start window, select **Clone a repository**.

#### Open a project locally from a previously cloned Azure DevOps repo

1. Open Visual Studio 2019.

1. On the start window, select **Open a Project or Solution**.

### In Visual Studio 2019 version 16.7 or earlier

1. Open Visual Studio 2019.

1. On the start window, select **Clone or check out code**.

   ![View the 'Create a new project' window](../get-started/media/vs-2019/clone-checkout-code-dark.png)

1. In the **Browse a repository** section, select **Azure DevOps**.

   ![View the 'Clone or check out code' window](../get-started/media/vs-2019/clone-checkout-code-git-repo-dark.png)

   If you see a sign-in window, sign in to your account.

1. In the **Connect to a Project** dialog box, choose the repo that you want to connect to, and then select **Clone**.

      ![The "Connect to a Project" dialog box that's generated from Visual Studio](./media/open-proj-azure-devops-connect-cloud-clone.png)

    > [!NOTE]
    > What you see in the list box depends on the Azure DevOps repositories that you have access to.

   Visual Studio opens **Team Explorer** and a notification appears when the clone is complete.

     ![The Team Explorer window in Visual Studio after clone is complete](./media/vs-2019/clone-complete-azure-devops.png)

1. To view your folders and files, select the **Show Folder View** link.

     ![The Solutions section of the Team Explorer window in Visual Studio after clone is complete](./media/vs-2019/show-folder-view-azure-devops.png)

     Visual Studio opens **Solution Explorer**.

1. Choose the **Solutions and Folders** link to search for a solution file  (specifically, a .sln file) to open.

      ![The "Solutions and Folders" notification from Team Explorer in Visual Studio](./media/open-proj-repo-solutions-folders.png)

   If you do not have a solution file in your repo, a "No Solutions Found" message appears. However, you can double-click any file from the folder menu to open it in the Visual Studio code editor.

::: moniker-end

## Next steps

If you're ready to code with Visual Studio, dive into any of the following language-specific tutorials:

- [Visual Studio tutorials | **C#**](./csharp/index.yml)
- [Visual Studio tutorials | **Visual Basic**](./visual-basic/index.yml)
- [Visual Studio tutorials | **C++**](/cpp/get-started/tutorial-console-cpp)
- [Visual Studio tutorials | **Python**](../python/index.yml)
- [Visual Studio tutorials | **JavaScript**, **TypeScript**, and **Node.js**](../javascript/index.yml)

## See also

::: moniker range="vs-2017"

- [Azure DevOps Services: Get started with Azure Repos and Visual Studio](/azure/devops/repos/git/gitquickstart/)
- [Microsoft Learn: Get started with Azure DevOps](/learn/modules/get-started-with-devops/)
- [New Git experience in Visual Studio 2019](../ide/git-with-visual-studio.md?view=vs-2019&preserve-view=true)

::: moniker-end

::: moniker range="vs-2019"

- [New Git experience in Visual Studio](../ide/git-with-visual-studio.md)
- [Azure DevOps Services: Get started with Azure Repos and Visual Studio](/azure/devops/repos/git/gitquickstart/)
- [Microsoft Learn: Get started with Azure DevOps](/learn/modules/get-started-with-devops/)

::: moniker-end
