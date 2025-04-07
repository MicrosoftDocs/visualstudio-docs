---
title: Push to a remote branch in Visual Studio
titleSuffix: ""
description: Push your local project directory to a remote in Visual Studio by using GitHub or Azure DevOps for a safe place to store your code in the cloud.
ms.date: 4/1/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
ms.manager: mijacobs
ms.subservice: general-ide
---
# Push from Visual Studio to a remote branch

After you've authenticated to GitHub, Visual Studio can improve your GitHub workflow. One of those improvements is the ability to push (also known as publish) a local project directly to GitHub with a single click. The final stage in a simple Git workflow is to push changes to your remote.

A remote is a reference to a Git repository hosted somewhere other than the local computer, called something like **origin/main** (or origin/master), where "origin" is the default name for a remote. For more information about this terminology, see the [Git Branching - Remote Branches](https://git-scm.com/book/en/v2/Git-Branching-Remote-Branches) page on the Git website.

While this article references GitHub repositories, you can work remotely with the Git provider of your choice, such as GitHub, GitLab, or Azure DevOps.

Here's how to push to a remote in Visual Studio.

1. Make sure you've got a file open to work on that's in a previously [created](git-create-repository.md) or [cloned](git-clone-repository.md) repo.

1. Make a change to the file, save it, select the **Git Changes** tab, and then [commit](git-make-commit.md) the change.

1. In the **Git Changes** window, notice the link text that includes the number of incoming and outgoing commits. In the following example, the link text reads **1 outgoing / 0 incoming**.

   :::image type="content" source="media/vs-2022/git-changes-window-outgoing-incoming.png" alt-text="The Git Changes window with the outgoing / incoming link text highlighted in Visual Studio 2022.":::

   The "outgoing" text represents the number of commits that haven't yet been pushed to the remote, while the "incoming" text represents the commits that have been fetched but not yet pulled from the remote.

1. To push to your remote, select **Push** button (the up arrow), or select **Push** from the **Git** menu.

## Related content

- [Create a pull request in Visual Studio](git-create-pull-request.md) or
- [Fetch, pull, and sync in Visual Studio](git-fetch-pull-sync.md)
- [Git experience in Visual Studio](git-with-visual-studio.md)
