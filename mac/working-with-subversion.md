---
title: Working with Subversion
description: Using Subversion in Visual Studio for Mac.
author: jmatthiesen
ms.author: jomatthi
ms.date: 05/06/2018
ms.assetid: 2400ED9C-6236-4C0A-A3AB-9D7CBE1F0CF4
---

# Working with Subversion

Subversion is the centralized version control system that enables you to check out a single master copy of the centralized data. In contrast to Git, checking out a Subversion repository does not clone the entire repository, it only takes a snapshot at that point in time.

Subversion uses a copy-modify-merge model to allow users to work on the same repository simultaneously. This means that each user creates a local, or working, copy of the centralized data, which they work on independently. The changes to users working copies are merged in a chronological fashion.

For example, imagine that User A and User B both check out a copy from the remote repository and they each modify files. User A finishes the modifications and commits them remotely. Before User B commits their work, they must update their working copy with changes from the remote, merging in User A's changes.

The following sections explore how Subversion can be used for version control in Visual Studio for Mac.

The following image illustrates the options provided by Visual Studio for Mac by the Version Control menu item:

![Version Control menu items](media/version-control-svnVersionControlMenu.png)

## Checkout...

Before starting to use a remote Subversion repository, check out the repo to create a working copy of that directory on your local machine.

To find out about using the **Checkout** feature in Visual Studio for Mac, follow the steps in the [Setting up a Subversion repository](set-up-subversion-repository.md) section.

## Update solution

When using a remote repository, it's important to remember that other users may be modifying files, making your working copy outdated. In anticipation of conflicts, it's always recommended to pull any changes from the repository into your solution before starting work, and before committing. To do pull changes, select the **Version Control > Update Solution** menu item.

## Review solution and commit

To review changes in files, use the Changes, Blame, Log, and Merge tabs on each document, as illustrated in the following image:

![Version Control Tabs](media/version-control-vcTabs.png)

Review all changes in a project by browsing the **Version Control > Review Solution and Commit** menu item:

![Review Solution](media/version-control-vcStatus.png)

This allows viewing all the changes in each file of a project with the option to Revert, Create Patch, or Commit.

To commit a file to the remote repository, press Commit..., enter a commit message, and confirm with the Commit Button:

![Committing a file](media/version-control-svnCommit.png)

This will send the changes to the repository where they create the new revision of all your modifications.

## See also

- [Set up a Subversion repository](set-up-subversion-repository.md)
