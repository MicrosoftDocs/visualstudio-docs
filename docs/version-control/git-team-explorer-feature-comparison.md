---
title: Side-by-side comparison of Git and Team Explorer in Visual Studio 2019
titleSuffix: ""
description: Compare and contrast how to use the new Git experience versus Team Explorer in Visual Studio to manage source control.
ms.date: 11/08/2021
ms.topic: how-to
author: Taysser-Gherfal
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
monikerRange: "<=vs-2019"
---
# Side-by-side comparison of Git and Team Explorer

We launched the first version of a new Git experience in Visual Studio 2019 [version 16.8](/visualstudio/releases/2019/release-notes/). This new experience helps reduce context switching with a simple **Git Changes** window that includes common Git tasks. It also includes a screen-wide **Git Repository** window for more advanced Git operations, such as branch management and repository browsing.

If you’ve been using Team Explorer, here is a step-by-step guide that explains how you can use the new Git experience.

> [!NOTE]
> The following section includes screenshots sized to fit in the columns of a table. Click each screenshot to view a larger version of it. (If you're using a touchscreen device, tap each screenshot to view a larger version of it.)

## Get started

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Clone a repo** | :::image type="content" source="media/clone-repo-team-explorer-sml.png" alt-text="Screenshot of the Connect window for Team Explorer in Visual Studio 2019, with a 'clone a repo' procedure overlay." lightbox="media/clone-repo-team-explorer-lrg.png":::  </p>1. Open the **Connect** page. <br> 2. Expand **Manage Connections**. <br> 3. Select **Connect to Project**. | :::image type="content" source="media/clone-repo-new-git-sml.png" alt-text="Screenshot of the Git menu in Visual Studio 2019, with a 'clone a repo' procedure overlay." lightbox="media/clone-repo-new-git-lrg.png":::  </p> 1. Open the **Git** menu. <br>2. Select **Clone Repository**. <br><br> |
|**Switch between repos**  | :::image type="content" source="media/switch-repos-team-explorer-sml.png" alt-text="Screenshot of the Connect window for Team Explorer in Visual Studio 2019, with a 'switch between repos' procedure overlay." lightbox="media/switch-repos-team-explorer-lrg.png":::  </p>1. Open the **Connect** page. <br>2. Select a repository from the **Local Repositories** list. | :::image type="content" source="media/switch-repos-new-git-sml.png" alt-text="Screenshot of the Local Repositories menu item in Visual Studio 2019, with a 'clone a repo' procedure overlay." lightbox="media/switch-repos-new-git-lrg.png"::: </p> 1. Open the **Git** menu. <br>2. Select a repository from the **Local Repositories** list.  |
|**Open a solution**  |  :::image type="content" source="media/open-solution-team-explorer-sml.png" alt-text="Screenshot of the Home window for Team Explorer in Visual Studio 2019, with an 'open a solution' procedure overlay." lightbox="media/open-solution-team-explorer-lrg.png":::</p>1. Open the **Home** page in **Team Explorer**. <br>2. Select a solution from the solution list.  |  :::image type="content" source="media/open-solution-new-git-sml.png" alt-text="Screenshot of Solution Explorer in Visual Studio 2019, with an 'open a solution' procedure overlay." lightbox="media/open-solution-new-git-lrg.png":::</p>1. Open the **Switch Views** page in **Solution Explorer**. <br>2. Select a solution from the solution list.  |
|**Add a solution to source control and create a new repository**  | :::image type="content" source="media/source-control-team-explorer-sml.png" alt-text="Screenshot collage of Team Explorer options in Visual Studio 2019, with an Add to Source Control - Create Repo procedure overlay." lightbox="media/source-control-team-explorer-lrg.png":::</p>1. Select **Git** from the **Add to Source Control** status bar menu. <br>2. Select **Publish**.  | :::image type="content" source="media/source-control-new-git-sml.png" alt-text="Screenshot collage of Git options in Visual Studio 2019, with an 'add to source control - create repo' procedure overlay." lightbox="media/source-control-new-git-lrg.png":::</p>1. Select **Git** from the **Add to Source Control** status bar menu, or select **Git** > **Create Git Repository** from the top-level Visual Studio menu bar. <br>2. Select **Create and Push**. </p> **Note**: Use the existing remote option if you want to add your code to Azure DevOps. In this case, you must create an Azure DevOps repository first. |
> [!TIP]
> The [new Git experience](git-with-visual-studio.md) should automatically connect to the correct Azure DevOps repo based on the repository or solution you opened. However, if you need to manually connect to the repo, you can still do that by using Team Explorer. From the Visual Studio menu bar, select **View** > **Team Explorer** > **Manage Connections** > **Connect**.

## Git changes

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Commit and stage** | :::image type="content" source="media/commit-stage-team-explorer-sml.png" alt-text="Screenshot of the Changes window for Team Explorer in Visual Studio 2019, with a 'commit and stage' procedure overlay." lightbox="media/commit-stage-team-explorer-lrg.png":::  </p>1. Enter a commit message. <br>2. Select **Commit All**. <br>3. To stage specific files, right-click them, and then select **Stage**.  | :::image type="content" source="media/commit-stage-new-git-sml.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'commit and stage' procedure overlay." lightbox="media/commit-stage-new-git-lrg.png"::: </p>1. Enter a commit message. <br>2. Select **Commit All**. <br>3. To stage specific files, hover over them, and then click the “**+**” icon. |
|**Amend a commit** |  :::image type="content" source="media/amend-commit-team-explorer-sml.png" alt-text="Screenshot of the Changes window for Team Explorer in Visual Studio 2019, with an 'amend a commit' procedure overlay." lightbox="media/amend-commit-team-explorer-lrg.png":::</p>1. Click the **Actions** drop-down. <br>2. Select **Amend Previous Commit**. | :::image type="content" source="media/amend-commit-new-git-sml.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with an 'amend a commit' procedure overlay." lightbox="media/amend-commit-new-git-lrg.png"::: </p>1. Click the **Amend** checkbox. <br>2. Click **Commit All** to commit your updates.  |
|**Stash a change** | :::image type="content" source="media/stash-change-team-explorer-sml.png" alt-text="Screenshot of the Changes window for Team Explorer in Visual Studio 2019, with a 'stash a change' procedure overlay." lightbox="media/stash-change-team-explorer-lrg.png":::</p>1. Click the **Stash** drop-down. <br>2. Select the relevant **Stash** option. | :::image type="content" source="media/stash-change-new-git-sml.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'stash a change' procedure overlay." lightbox="media/stash-change-new-git-lrg.png":::</p>1. Click the **Commit All** drop-down. <br>2. Select the relevant **Stash** option. |

## Synchronization

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Fetch, pull, and push changes** | :::image type="content" source="media/fetch-pull-push-team-explorer-sml.png" alt-text="Screenshot of the Synchronization window for Team Explorer in Visual Studio 2019, with a 'fetch, pull, and push' procedure overlay." lightbox="media/fetch-pull-push-team-explorer-lrg.png":::</p>1. Navigate to the **Synchronization** page. <br>2. Click the network operation of your choice. | :::image type="content" source="media/fetch-pull-push-new-git-sml.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'fetch, pull, and push' procedure overlay." lightbox="media/fetch-pull-push-team-new-git-lrg.png"::: </p>1. Locate the fetch, pull, and push buttons in the **Git Changes** window. <br>2. Click the network operation of your choice.|
|**View Incoming and Outgoing commits** | :::image type="content" source="media/view-commits-team-explorer-sml.png" alt-text="Screenshot of the Synchronization window for Team Explorer in Visual Studio 2019, with a 'view incoming and outgoing commits' procedure overlay." lightbox="media/view-commits-team-explorer-lrg.png"::: </p>1. Navigate to the **Synchronization** page. <br>2. View your incoming and outgoing lists. | :::image type="content" source="media/view-commits-new-git-sml.png" alt-text="Screenshot of the Git Changes window and the Git Repository window in Visual Studio 2019, with a 'view incoming and outgoing commits' procedure overlay." lightbox="media/view-commits-new-git-lrg.png":::</p>1. Click the **outgoing / incoming** link in the **Git Changes** window. <br>2. View your incoming and outgoing commits by using the icons in the graph table at the top of the **Git Repository** window. |

## Branches

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Create a branch** |  :::image type="content" source="media/create-branch-team-explorer-sml.png" alt-text="Screenshot of the Branches window for Team Explorer in Visual Studio 2019, with a 'create a new branch' procedure overlay." lightbox="media/create-branch-team-explorer-lrg.png":::</p>1. Navigate to the **Branches** window. <br> 2. Click **New Branch**. | :::image type="content" source="media/create-branch-new-git-sml.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'create a new branch' procedure overlay." lightbox="media/create-branch-new-git-lrg.png"::: </p>1. On the **Git Changes** window, click the branch drop-down list. <br>2. Click **New Branch**. |
|**Get the latest changes from a remote branch** | :::image type="content" source="media/sync-remote-team-explorer-sml.png" alt-text="Screenshot of the Branches window for Team Explorer in Visual Studio 2019, with a 'get recent changes from remote branch' procedure overlay." lightbox="media/sync-remote-team-explorer-lrg.png"::: </p>1. Navigate to the **Branches page**. <br>2. Right-click the remote branch and select **Merge From** or **Rebase Onto**.  | :::image type="content" source="media/sync-remote-new-git-sml.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'get recent changes from remote branch' procedure overlay." lightbox="media/sync-remote-new-git-lrg.png":::</p>1. Click the branch drop-down list. <br>2. Under the **Remotes** tab, click the remote branch and select **Merge into Current Branch** or **Rebase Current Branch onto**.  |
|**Manage branches** | :::image type="content" source="media/manage-branches-team-explorer-sml.png" alt-text="Screenshot of the Branches window for Team Explorer in Visual Studio 2019, with a 'manage branches' procedure overlay." lightbox="media/manage-branches-team-explorer-lrg.png"::: </p>1. Navigate to the **Branches** window. <br>2. Right-click the branches that you would like to manage. <br>3. View **History** of branches to manage commits. | :::image type="content" source="media/manage-branches-new-git-sml.png" alt-text="Screenshot collage of how three UI options to use to manage branches in Visual Studio 2019." lightbox="media/manage-branches-new-git-lrg.png"::: </p>1. Navigate to the Git repository window by using one of the following entry points: <br><br>a. From the top-level Visual Studio menu, select **Git** > **Manage Branches**.<br> b. Select **Git changes** > **incoming/outgoing**. <br>c. From the status bar menu at the bottom-right, select **Manage Branches**.<br> <br> 2. From the top-level **Git** > **Manage Branches** menu, do either of the following actions: <br><br>A. Right-click the branches.<br>B. Multi-select the commits that you want to manage. |

## Conflict resolution

|         |Team Explorer  |The new Git experience |
|---------|---------|---------|
|**Access list of files with conflicts** | :::image type="content" source="media/resolve-conflicts-team-explorer-sml.png" alt-text="Screenshot collage of the Changes window and the Resolve Conflicts window for Team Explorer in Visual Studio 2019, with a procedure overlay." lightbox="media/resolve-conflicts-team-explorer-lrg.png":::</p>1. Navigate to the **Resolve Conflicts** window by clicking the **Conflicts** link. <br> 2. Use the **Conflicts** list to resolve your merge conflicts. | :::image type="content" source="media/resolve-conflicts-new-git-sml.png" alt-text="Screenshot of the Git Changes window in Visual Studio 2019, with a 'resolve conflicts' procedure overlay." lightbox="media/resolve-conflicts-new-git-lrg.png"::: </p>1. Verify that **Merge in progress with conflicts** appears. <br>2. The list of files with merge conflicts appears in the **Unmerged Changes** section of the **Git Changes** window. <br>Resolve the conflicts. |

## Next steps

For more information about the new Git experience, see the latest video, [Getting started with Git in Visual Studio 2019](https://www.youtube.com/watch?v=GCZ9x3yqkyc), on YouTube.

## See also

- [The new Git experience in Visual Studio 2019](git-with-visual-studio.md?view=vs-2019&preserve-view=true)
- [Get Started with Git and GitHub in Visual Studio](/learn/modules/visual-studio-github-push/)
- [Work with GitHub accounts in Visual Studio](../ide/work-with-github-accounts.md)