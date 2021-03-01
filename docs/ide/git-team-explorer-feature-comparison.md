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
|**Clone a repo** | :::image type="content" source="media/vs-2019/clone-repo-team-explorer.png" alt-text="Screenshot of the Connect window for Team Explorer in Visual Studio 2019, with a 'clone a repo' procedure overlay.":::  </p>1. Open the **Connect** page. <br> 2. Expand **Manage Connections**. <br> 3. Select **Connect to Project**. | :::image type="content" source="media/vs-2019/clone-repo-new-git.png" alt-text="Screenshot of the Git menu in Visual Studio 2019, with a 'clone a repo' procedure overlay.":::  </p> 1. Open the **Git** menu. <br>2. Select **Clone Repository**. <br><br>      |
|**Switch between repos**  | :::image type="content" source="media/vs-2019/switch-repos-team-explorer.png" alt-text="Screenshot of the Connect window for Team Explorer in Visual Studio 2019, with a 'switch between repos' procedure overlay."::: </p>1. Open the **Connect** page. <br>2. Select a repository from the **Local Repositories** list.       | </p>:::image type="content" source="media/vs-2019/switch-repos-new-git.png" alt-text="Screenshot of the Local Repositories menu item in Visual Studio 2019, with a 'clone a repo' procedure overlay.":::</p>1. Open the **Git** menu. <br>2. Select a repository from the **Local Repositories** list.  |
|**Open a solution**  |  :::image type="content" source="media/vs-2019/open-solution-team-explorer.png" alt-text="Screenshot of the Home window for Team Explorer in Visual Studio 2019, with an 'open a solution' procedure overlay.":::</p>1. Open the **Home** page in **Team Explorer**. <br>2. Select a solution from the solution list.  |  :::image type="content" source="media/vs-2019/open-solution-new-git.png" alt-text="Screenshot of Solution Explorer in Visual Studio 2019, with an 'open a solution' procedure overlay.":::</p>1. Open the **Switch Views** page in **Solution Explorer**. <br>2. Select a solution from the solution list.  |
|**Add a solution to source control and create a new repository**  | :::image type="content" source="media/vs-2019/source-control-team-explorer.png" alt-text="Screenshot collage of Team Explorer options in Visual Studio 2019, with an 'add to source control - create repo' procedure overlay.":::</p>1. Select **Git** from the **Add to Source Control** status bar menu. <br>2. Select **Publish**.  | :::image type="content" source="media/vs-2019/source-control-new-git.png" alt-text="Screenshot collage of Git options in Visual Studio 2019, with an 'add to source control - create repo' procedure overlay.":::</p>1. Select **Git** from the **Add to Source Control** status bar menu, or select **Git** > **Create Git Repository** from the top-level Visual Studio menu bar. <br>2. Select **Create and Push**. </p> **Note**: Use the existing remote option if you want to add your code to Azure DevOps. In this case, you must create an Azure DevOps repository first. |
> [!TIP]
> The [new Git experience](git-with-visual-studio.md) should automatically connect to the correct Azure DevOps repo based on the repository or solution you opened. However, if you need to manually connect to the repo, you can still do that by using Team Explorer. From the Visual Studio menu bar, select **View** > **Team Explorer** > **Manage Connections** > **Connect**.

## Git changes

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Commit and stage** | :::image type="content" source="media/vs-2019/commit-stage-team-explorer.png" alt-text="Screenshot of the Changes window for Team Explorer in Visual Studio 2019, with a 'commit and stage' procedure overlay.":::  </p>1. Enter a commit message. <br>2. Select **Commit All**. <br>3. To stage specific files, right-click them, and then select **Stage**.  | :::image type="content" source="media/vs-2019/commit-stage-new-git.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'commit and stage' procedure overlay."::: </p>1. Enter a commit message. <br>2. Select **Commit All**. <br>3. To stage specific files, hover over them, and then click the “**+**” icon.       |
|**Amend a commit** |  :::image type="content" source="media/vs-2019/amend-commit-team-explorer.png" alt-text="Screenshot of the Changes window for Team Explorer in Visual Studio 2019, with an 'amend a commit' procedure overlay.":::</p>1. Click the **Actions** drop-down. <br>2. Select **Amend Previous Commit**. | :::image type="content" source="media/vs-2019/amend-commit-new-git.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with an 'amend a commit' procedure overlay."::: </p>1. Click the **Amend** checkbox. <br>2. Click **Commit All** to commit your updates.        |
|**Stash a change** | :::image type="content" source="media/vs-2019/stash-change-team-explorer.png" alt-text="Screenshot of the Changes window for Team Explorer in Visual Studio 2019, with a 'stash a change' procedure overlay.":::</p>1. Click the **Stash** drop-down. <br>2. Select the relevant **Stash** option. | :::image type="content" source="media/vs-2019/stash-change-new-git.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'stash a change' procedure overlay.":::</p>1. Click the **Commit All** drop-down. <br>2. Select the relevant **Stash** option. |

## Synchronization

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Fetch, pull, and push changes** |  :::image type="content" source="media/vs-2019/fetch-pull-push-team-explorer.png" alt-text="Screenshot of the Synchronization window for Team Explorer in Visual Studio 2019, with a 'fetch, pull, and push' procedure overlay.":::</p>1. Navigate to the **Synchronization** page. <br>2. Click the network operation of your choice. | :::image type="content" source="media/vs-2019/fetch-pull-push-new-git.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'fetch, pull, and push' procedure overlay."::: </p>1. Locate the fetch, pull, and push buttons in the **Git Changes** window. <br>2. Click the network operation of your choice.|
|**View Incoming and Outgoing commits** | :::image type="content" source="media/vs-2019/view-commits-team-explorer.png" alt-text="Screenshot of the Synchronization window for Team Explorer in Visual Studio 2019, with a 'view incoming and outgoing commits' procedure overlay."::: </p>1. Navigate to the **Synchronization** page. <br>2. View your incoming and outgoing lists. | :::image type="content" source="media/vs-2019/view-commits-new-git.png" alt-text="Screenshot of the Git Changes window and the Git Repository window in Visual Studio 2019, with a 'view incoming and outgoing commits' procedure overlay.":::</p>1. Click the **outgoing / incoming** link in the **Git Changes** window. <br>2. View your incoming and outgoing commits at the top of the graph table in the **Git Repository** window. |

## Branches

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Create a branch** |  :::image type="content" source="media/vs-2019/create-branch-team-explorer.png" alt-text="Screenshot of the Branches window for Team Explorer in Visual Studio 2019, with a 'create a new branch' procedure overlay.":::</p>1. Navigate to the **Branches** window. <br> 2. Click **New Branch**. | :::image type="content" source="media/vs-2019/create-branch-new-git.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'create a new branch' procedure overlay."::: </p>1. On the **Git Changes** window, click the branch drop-down list. <br>2. Click **New Branch**.       |
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