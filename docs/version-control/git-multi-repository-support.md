---
title: Work with multiple repoistories
titleSuffix: ""
description: Use Git tooling to work with up to 10 active Git repos at the same time from directly within Visual Studio.
ms.date: 11/18/2022
ms.topic: conceptual
author: houghj16
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.custom: version-control
monikerRange: vs-2022
---
# Work with multiple repos

As one of our most [highly requested features in the Developer Community](https://developercommunity.visualstudio.com/t/allow-multiple-git-repositories-to-be-active-at-on/351156), we've added multi-repository support to Visual Studio 2022, starting with [version 17.4](/visualstudio/releases/2022/release-notes-v17.4).

Now, you can have up to 10 active Git repositories at one time in Visual Studio. Multi-repo support means that you can work with a solution that spans more than one repository, and apply Git operations across several repositories at the same time. For example, in a large web project, you might need different repositories to manage work done on the frontend, the API, the database, the documentation, along with various libraries and dependencies. Before multi-repo support, you might have had to open multiple instances of Visual Studio to work between repos. Starting with [version 17.4](/visualstudio/releases/2022/release-notes-v17.4), you can manage, view, and debug them all with one instance of Visual Studio.

## Branch Management and Tracking Changes

Multi-repository support extends the capabilities of the **Git Changes** and **Git Repository** windows. You can manage your multi-repo scenarios the same way as you would in working with a single repository. You can create your branches across several repositories at one time by using the extended branch creation dialog.

Screenshot
Screenshot

Then, as you make changes, the **Git Changes** window tracks your work separated by repository. You can stage and commit as you typically would.

Screenshot

You can use the branch pickers in the status bar and the **Git Changes** tool window to switch branches. All you need do is select the branch you’d like to checkout. Also, you can perform innerloop branching operations like merging, rebasing, renaming, deleting, and comparing branches by right-clicking the branch. And, you can perform more advanced repository and branch management operations in the **Git Repository** window.

Screenshot
Screenshot

## Network operations

Once you’re ready to commit, the network operations dialog makes it easy to specify the exact branch you’re pushing to and reorder your pushes. This same dialog allows you to exercise more control over other network operations, like [fetch and pull](git-fetch-pull-sync.md).

Screenshot

## Repository settings

You can use the **Git Repository Settings** page to specify your options for each repository. For example, you can specify whether to prune remote branches during fetch.

Screenshot

## Open folder

Additionally, you can activate multiple repositories from a folder as well as from a solution.

NOTE:

## Next steps

Want to know more about how we'll develop further Git functionality within Visual Studio 2022, or to share your feedback with us on the feature? See both the "Building with your feedback", "What's next", and "Let us know what you think" sections of the [Multi-repository Support Released!](https://devblogs.microsoft.com/visualstudio/multi-repository-support-released/) blog post.