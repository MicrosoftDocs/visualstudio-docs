---
title: Version Control
description: Using Git and Subversion in Visual Studio for Mac.
ms.topic: overview
author: heiligerdankgesang 
ms.author: dominicn
manager: dominicn
ms.date: 06/30/2022
ms.assetid: 49917483-28AA-4598-A847-71F1F2E0DCB5
---
# Version control & source control with Git

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

Version control is a system for managing files over many different versions, and - in software development - is generally contributed to by many developers. The principal purpose of any version control system (_VCS_) is to find a solution that enables all users to work on the codebase at the same time.

At the core of any version control system is a _repository_, which acts as the central data store for all the different files - similar to a file server. However, unlike a file server, the repository contains the entire history of the project and all revisions that have been made.

If the repository is the central data store, it is logical for each user to have a local store of the data, allowing them to work on it. This is called a _working copy_. In Visual Studio for Mac your working copy will appear just as any other local directory on your machine, allowing you to read from and write to any of the files.

Visual Studio for Mac includes built-in support for Git repositories. If you're new to Git, the https://git-scm.com/ website is a good place to start. Git is a distributed version control system that allows teams to work on the same documents simultaneously. With Git there might be a single server that contains all the files, but the entire repository is cloned locally to your machine whenever a repository is checked out from this central source.

## Basic Concepts

::: moniker range=">=vsmac-2022"
To learn more about the Git tooling in Visual Studio for Mac, the following articles explore setting up Git repositories through Visual Studio for Mac, as well as simple functionality such as reviewing, committing, and pushing changes.

* [Setting Up a Git Repository](set-up-git-repository.md)
* [Working with Git](working-with-git.md)
::: moniker-end


## See also

* [Version control in Visual Studio (on Windows)](/visualstudio/version-control/)