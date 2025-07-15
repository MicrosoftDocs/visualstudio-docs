---
ms.date: 12/04/2024
ms.subservice: general-ide
ms.author: ghogen
author: ghogen
manager: mijacobs
ms.topic: include
ms.custom:
  - vs-get-started
  - devdivchpfy22
  - sfi-image-nochange
---

## Add Git source control

Now that you have an application, you might want to add it to a Git repository. Visual Studio makes that process easy with Git tools you can use directly from the IDE.

> [!TIP]
> Git is the most widely used modern version control system. Whether you're a professional developer or you're learning how to code, Git can be very useful. If you're new to Git, the [`https://git-scm.com/`](https://git-scm.com/) website is a good place to start. You can find cheat sheets, a popular online book, and Git Basics videos.

To associate your code with Git, start by creating a new Git repository where your code is located:

1. In the status bar at the bottom-right of Visual Studio, select **Add to Source Control**, and then select **Git**.

   :::image type="content" source="../media/vs-2022/git-add-source-control.png" alt-text="Screenshot that shows how to access the Git source control action from Add to Source Control in Visual Studio.":::

1. In the **Create a Git repository** dialog box, sign in to GitHub:

   :::image type="content" source="../media/vs-2022/git-create-repo-dialog.png" alt-text="Screenshot of the Create a Git Repository dialog window where you can sign in to GitHub.":::

   The repository name autopopulates based on your folder location. Your new repository is private by default, which means you're the only one who can access it.

   > [!TIP]
   > Whether your repository is public or private, it's best to have a remote backup of your code stored securely on GitHub. Even if you aren't working with a team, a remote repository makes your code available to you from any computer.

1. Select **Create and Push**. After you create your repository, you see status details in the status bar:

   :::image type="content" source="../media/vs-2022/git-new-private-repo-status-details-git-changes.png" alt-text="Screenshot of the repo status bar below the Solution Explorer pane in Visual Studio.":::

## Use Git actions in Visual Studio

Here's a brief summary of Git actions available in the Visual Studio status bar:

- The **Up/Down** arrows show how many outgoing/incoming commits are in your current branch. You can use this icon to pull any incoming commits or push any outgoing commits.

- To view a specific commit, select the **Up/Down** arrow, and then select **View Outgoing/Incoming**.

- The **Pencil** shows the number of uncommitted changes to your code. You can select this icon to view those changes in the **Git Changes** window.

The **Git** menu provides tools for repository actions on your files. You can [use git fetch, pull, push, and sync for version control in Visual Studio](../../version-control/git-fetch-pull-sync.md).

For more information about how to use Git with your app, see [About Git in Visual Studio](../../version-control/git-with-visual-studio.md).
