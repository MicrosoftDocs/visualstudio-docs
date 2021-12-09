---
title: Connect to projects in Team Explorer
description: Learn how to use Team Explorer in Visual Studio to work with team members to develop and manage projects.
ms.custom: SEO-VS-2020
ms.date: 11/11/2021
ms.topic: conceptual
ms.author: tglee
author: TerryGLee
ms.manager: jmartens
monikerRange: "<=vs-2019"
---
# Connect to projects in Team Explorer

::: moniker range="vs-2017"

Use the **Team Explorer** tool window to coordinate your code efforts with other team members to develop a project, and to manage work that's assigned to you, your team, or your projects. **Team Explorer** connects Visual Studio to Git and GitHub repositories, Team Foundation version control (TFVC) repositories, and projects hosted on [Azure DevOps Services](/azure/devops/user-guide/what-is-azure-devops-services) or an on-premises [Azure DevOps Server](/azure/devops/index-all) (formerly known as TFS). You can manage source code, work items, and builds.

::: moniker-end

::: moniker range="vs-2019"

Team Explorer connects Visual Studio 2019 and earlier to Team Foundation version control (TFVC) repositories, and to projects hosted on [Azure DevOps Services](/azure/devops/user-guide/what-is-azure-devops-services) or an on-premises [Azure DevOps Server](/azure/devops/user-guide/about-azure-devops-services-tfs?view=azure-devops&preserve-view=true) (formerly known as TFS). You can manage source code, work items, and builds.

> [!IMPORTANT]
> With the release of Visual Studio 2019 [**version 16.8**](/visualstudio/releases/2019/release-notes-history), the Git version control experience is on by default. If you'd like to learn more about how it compares with Team Explorer, see the [**Side-by-side comparison of Git and Team Explorer**](../version-control/git-team-explorer-feature-comparison.md) page.
>
> However, if you prefer to continue to use Team Explorer in Visual Studio 2019, go to **Tools** > **Options** > **Environment** > **Preview Features** and then toggle the **New Git user experience** checkbox. (This option is not available in Visual Studio 2022 and later.)

How you use Team Explorer to connect to a project depends on the version of Visual Studio 2019 you're using.

## In Visual Studio 2019 version 16.8 and later

1. Open Visual Studio 2019.

1. On the start window, select **Clone a repository**.

   ![Screenshot of the Clone a Repository dialog in Visual Studio 2019 version 16.8 and later, for Azure DevOps](../ide/media/vs-2019/clone-repository.png)

1. In the **Browse a repository** section, select **Azure DevOps**.

    ![Screenshot of the 'Browse a repository' section of the The 'Connect to a Project' dialog box in Visual Studio 2019 version 16.8 and and later](../ide/media/vs-2019/browse-repository-azure-devops.png)

1. If you see a sign-in window, sign in to your account.

1. In the **Connect to a Project** dialog box, choose the repo that you want to connect to, and then select **Clone**.

      ![Screenshot of the 'Connect to a Project' dialog box that's generated from Visual Studio 2019 version 16.8 and later](../ide/media/vs-2019/connect-project-azure-devops.png)

      > [!TIP]
      > If you don't see a pre-populated list of repos to connect to, select **Add Azure DevOps Server** to enter a server URL. (Alternatively, you might see a "No servers found" prompt that includes links to add an existing Azure DevOps Server or to create an Azure DevOps account.)

   Next, Visual Studio opens **Solution Explorer** that shows the folders and files.

1. Select the **Team Explorer** tab to view the Azure DevOps actions.

      ![Screenshot of the 'Team Explorer' dialog box that's generated from Visual Studio 2019 version 16.8 and later](../ide/media/vs-2019/team-explorer-azure-devops.png)

## In Visual Studio 2019 version 16.7 and earlier

1. Open Visual Studio 2019.

1. On the start window, select **Clone or check out code**.

   ![Screenshot of the 'Create a new project' window in Visual Studio 2019 version 16.7 and earlier](../get-started/media/vs-2019/clone-checkout-code-dark.png)

1. In the **Browse a repository** section, select **Azure DevOps**.

   ![Screenshot of the 'Clone or check out code' window with the 'Browse a repository' section that lists Azure DevOps in Visual Studio 2019 version 16.7 and earlier](../get-started/media/vs-2019/clone-checkout-code-git-repo-dark.png)

   If you see a sign-in window, sign in to your account.

1. In the **Connect to a Project** dialog box, choose the repo that you want to connect to, and then select **Clone**.

      ![Screenshot of the 'Connect to a Project' dialog box that's generated from Visual Studio 2019 version 16.7 and earlier](../get-started/media/open-proj-azure-devops-connect-cloud-clone.png)

    > [!NOTE]
    > What you see in the list box depends on the Azure DevOps repositories that you have access to.

   Visual Studio opens **Team Explorer** and a notification appears when the clone is complete.

     ![Screenshot of the Team Explorer window in Visual Studio 2019 version 16.7 and earlier, after clone is complete](../get-started/media/vs-2019/clone-complete-azure-devops.png)

1. To view your folders and files, select the **Show Folder View** link.

     ![Screenshot of the Solutions section of the Team Explorer window in Visual Studio 2019 version 16.7 and earlier, after clone is complete](../get-started/media/vs-2019/show-folder-view-azure-devops.png)

     Visual Studio opens **Solution Explorer**.

1. Choose the **Solutions and Folders** link to search for a solution file  (specifically, an .sln file) to open.

      ![Screenshot of the 'Solutions and Folders' notification from Team Explorer in Visual Studio 2019 version 16.7 and earlier](../get-started/media/open-proj-repo-solutions-folders.png)

   If you do not have a solution file in your repo, a 'No Solutions Found' message appears. However, you can double-click any file from the folder menu to open it in the Visual Studio code editor.

::: moniker-end

::: moniker range="vs-2017"

![Team Explorer Home page in Visual Studio](media/team-explorer/team-explorer.png "The Team Explorer - Home page in Visual Studio.")

> [!TIP]
> If you open Visual Studio and **Team Explorer** doesn't appear, open it by choosing **View** > **Team Explorer** from the menu bar, or by pressing **Ctrl**+**&#92;**, **Ctrl**+**M**.

## Connect to a project or repository

Connect to a project or repository on the **Connect** page.

![Connect page in Team Explorer](media/team-explorer/connect.png "The Team Explorer - Connect page in Visual Studio")

To connect to a project:

1. Open the **Connect** page by choosing the **Manage Connections** icon.

   ![Manage Connections button in Team Explorer](media/team-explorer/manage-connections.png "The Team Explorer - Manage Connections button in Visual Studio.")

1. On the **Connect** page, choose **Manage Connections** > **Connect to a project**.

   ![Connect to a project in Team Explorer](media/team-explorer/connect-project.png "The Team Explorer - Connect to a Project option in Visual Studio.")

> [!TIP]
> If you want to open a project from a repo, see [Open a project from a repo](../get-started/tutorial-open-project-from-repo-visual-studio-2017.md). If you want to create a new project or add users to a project, see [Create a project (Azure DevOps)](/azure/devops/organizations/projects/create-project) and [Add users to a project or team (Azure DevOps)](/azure/devops/organizations/security/add-users-team-project).

::: moniker-end

## See also

- [Compare Git and Team Explorer side-by-side](git-team-explorer-feature-comparison.md)
- [Visual Studio version control documentation](../version-control/index.yml)
- [Team Explorer reference](reference/team-explorer-reference.md)
- [Connect to a project (Azure DevOps)](/azure/devops/organizations/projects/connect-to-projects)
- [Troubleshoot connecting to a project](/azure/devops/user-guide/troubleshoot-connection?view=azure-devops&preserve-view=true)
