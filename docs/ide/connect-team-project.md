---
title: Connect to projects in Team Explorer
description: Learn how to use Team Explorer in Visual Studio to work with team members to develop and manage projects.
ms.custom: SEO-VS-2020
ms.date: 03/31/2021
ms.topic: conceptual
ms.author: tglee
author: TerryGLee
ms.manager: jillfra
---
# Connect to projects in Team Explorer

::: moniker range="vs-2017"

Use the **Team Explorer** tool window to coordinate your code efforts with other team members to develop a project, and to manage work that's assigned to you, your team, or your projects. **Team Explorer** connects Visual Studio to Git and GitHub repositories, Team Foundation version control (TFVC) repositories, and projects hosted on [Azure DevOps Services](/azure/devops/user-guide/what-is-azure-devops-services) or an on-premises [Azure DevOps Server](/azure/devops/index-all) (formerly known as TFS). You can manage source code, work items, and builds.

::: moniker-end

::: moniker range="vs-2019"

You can use the **Team Explorer** tool window to coordinate your code efforts with other team members to develop a project, and to manage work that's assigned to you, your team, or your projects.

> [!IMPORTANT]
> With the recent release of Visual Studio 2019 [version 16.8](/visualstudio/releases/2019/release-notes/), the new Git version control experience is now on by default. However, if you prefer to continue to use Team Explorer, go to **Tools** > **Options** > **Environment** > **Preview Features** and then toggle the **New Git user experience** checkbox. For more information, see the [**Side-by-side comparison of Git and Team Explorer**](git-team-explorer-feature-comparison.md) page.

**Team Explorer** connects Visual Studio to Git and GitHub repositories, Team Foundation version control (TFVC) repositories, and projects hosted on [Azure DevOps Services](/azure/devops/user-guide/what-is-azure-devops-services) or an on-premises [Azure DevOps Server](/azure/devops/index-all) (formerly known as TFS). You can manage source code, work items, and builds.

::: moniker-end

![Team Explorer Home page in Visual Studio](media/team-explorer/team-explorer.png "The Team Explorer - Home page in Visual Studio.")

::: moniker range="vs-2017"

> [!TIP]
> If you open Visual Studio and **Team Explorer** doesn't appear, open it by choosing **View** > **Team Explorer** from the menu bar, or by pressing **Ctrl**+**&#92;**, **Ctrl**+**M**.

::: moniker-end

## Connect to a project or repository

Connect to a project or repository on the **Connect** page.

![Connect page in Team Explorer](media/team-explorer/connect.png "The Team Explorer - Connect page in Visual Studio")

To connect to a project:

1. Open the **Connect** page by choosing the **Manage Connections** icon.

   ![Manage Connections button in Team Explorer](media/team-explorer/manage-connections.png "The Team Explorer - Manage Connections button in Visual Studio.")

1. On the **Connect** page, choose **Manage Connections** > **Connect to a project**.

   ![Connect to a project in Team Explorer](media/team-explorer/connect-project.png "The Team Explorer - Connect to a Project option in Visual Studio.")

> [!TIP]
> If you want to open a project from a repo, see [Open a project from a repo](../get-started/tutorial-open-project-from-repo.md). If you want to create a new project or add users to a project, see [Create a project (Azure DevOps)](/azure/devops/organizations/projects/create-project) and [Add users to a project or team (Azure DevOps)](/azure/devops/organizations/security/add-users-team-project).

## See also

- [Compare Git and Team Explorer side-by-side](git-team-explorer-feature-comparison.md)
- [The new Git experience in Visual Studio](git-with-visual-studio.md)
- [Tutorial: Open a project from a repo](../get-started/tutorial-open-project-from-repo.md)
- [Team Explorer reference](reference/team-explorer-reference.md)
- [Connect to a project (Azure DevOps)](/azure/devops/organizations/projects/connect-to-projects)
- [Troubleshoot connecting to a project](/azure/devops/user-guide/troubleshoot-connection?view=azure-devops&preserve-view=true)
