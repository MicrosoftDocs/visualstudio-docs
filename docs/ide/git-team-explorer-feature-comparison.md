---
title: Side-by-side comparison of Git and Team Explorer in Visual Studio
titleSuffix: ""
description: Learn how the new integrated Git experience in Visual Studio 2019 can help you be more productive.
ms.date: 03/02/2021
ms.topic: how-to
ms.author: tglee
author: TerryGLee
ms.manager: jmartens
monikerRange: vs-2019
---
# Side-by-side comparison of Git and Team Explorer

We launched the first version of a new Git experience in Visual Studio 2019 [version 16.8](/visualstudio/releases/2019/release-notes/). This new experience helps reduce context switching with a simple **Git Changes** window that includes common Git tasks. It also includes a screen-wide **Git Repository** window for more advanced Git operations, such as branch management and repository browsing.

If you’ve been using Team Explorer, here is a step-by-step guide that explains how you can use the new Git experience.

## Get started

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Clone a repo**     | :::image type="content" source="media/vs-2019/clone-repo-team-explorer.png" alt-text="Screenshot of the Connect window for Team Explorer in Visual Studio 2019, with a 'clone a repo' procedure overlay.":::  </p>1. Open the **Connect** page. <br> 2. Expand **Manage Connections**. <br> 3. Select **Connect to Project**.      | :::image type="content" source="media/vs-2019/clone-repo-new-git.png" alt-text="Screenshot of the Git menu in Visual Studio 2019, with a 'clone a repo' procedure overlay.":::  </p> 1. Open the **Git** menu. <br>2. Select **Clone Repository**. <br><br>      |
|**Switch between repos**     | :::image type="content" source="media/vs-2019/switch-repos-team-explorer.png" alt-text="Screenshot of the Connect window for Team Explorer in Visual Studio 2019, with a 'switch between repos' procedure overlay."::: </p>1. Open the **Connect** page. <br>2. Select a repository from the **Local Repositories** list.       | </p>:::image type="content" source="media/vs-2019/switch-repos-new-git.png" alt-text="Screenshot of the Local Repositories menu item in Visual Studio 2019, with a 'clone a repo' procedure overlay.":::</p>1. Open the **Git** menu. <br>2. Select a repository from the **Local Repositories** list.  |
|**Open a solution**     |  :::image type="content" source="media/vs-2019/open-solution-team-explorer.png" alt-text="Screenshot of the Home window for Team Explorer in Visual Studio 2019, with an 'open a solution' procedure overlay.":::</p>1. Open the **Home** page in **Team Explorer**. <br>2. Select a solution from the solution list.       |  :::image type="content" source="media/vs-2019/open-solution-new-git.png" alt-text="Screenshot of Solution Explorer in Visual Studio 2019, with an 'open a solution' procedure overlay.":::</p>1. Open the **Switch Views** page in **Solution Explorer**. <br>2. Select a solution from the solution list.       |
|**Add a solution to source control and create a new repository**     | :::image type="content" source="media/vs-2019/source-control-team-explorer.png" alt-text="Screenshot collage of Team Explorer options in Visual Studio 2019, with an 'add to source control - create repo' procedure overlay.":::</p>1. Select **Git** from the **Add to Source Control** status bar menu. <br>2. Select **Publish**.        | :::image type="content" source="media/vs-2019/source-control-new-git.png" alt-text="Screenshot collage of Git options in Visual Studio 2019, with an 'add to source control - create repo' procedure overlay.":::</p>1. Select **Git** from the **Add to Source Control** status bar menu, or select **Git** > **Create Git Repository** from the Visual Studio menu bar. <br>2. Select **Create and Push**. </p> **Note**: Use the existing remote option if you want to add your code to Azure DevOps. In this case, you must create an Azure DevOps repository first.        |
> [!TIP]
> The [new Git experience](git-with-visual-studio.md) should automatically connect to the correct Azure DevOps repo based on the repository or solution you opened. However, if you need to manually connect to the repo, you can still do that by using Team Explorer. From the Visual Studio menu bar, select **View** > **Team Explorer** > **Manage Connections** > **Connect**.

## Git changes

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Commit and stage** | :::image type="content" source="media/vs-2019/commit-stage-team-explorer.png" alt-text="Screenshot of the Synchronization window for Team Explorer in Visual Studio 2019, with an 'add to source control - create repo' procedure overlay.":::  </p>1. Enter a commit message. <br>2. Select **Commit All**. <br>3. To stage specific files, right-click them, and then select **Stage**.      | :::image type="content" source="media/vs-2019/commit-stage-new-git.png" alt-text="Screenshot of three ways to add to source control or create a repo in Visual Studio 2019, with an 'add to source control - create repo' procedure overlay."::: </p>1. Enter a commit message. <br>2. Select **Commit All**. <br>3. To stage specific files, hover over them, and then click the “**+**” icon.       |
|**Amend a commit**     |         |         |
|**Stash a change**     |         |         |

## Synchronization

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Fetch, pull, and push changes** |         |         |
|**View Incoming and Outgoing commits** |         |         |

## Branches

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Create a branch** |         |         |
|**Get the latest changes from a remote branch** |         |         |
|**Manage branches** |         |         |

## Conflict resolution

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Access list of files with conflicts** |         |         |

## See also
- [The new Git experience in Visual Studio](git-with-visual-studio.md)
- [Open a project from a repo in Visual Studio](../get-started/tutorial-open-project-from-repo-visual-studio-2019)
- [Work with GitHub accounts in Visual Studio](work-with-github-accounts.md)