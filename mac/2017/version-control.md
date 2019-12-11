---
title: Version Control
description: Using Git and Subversion in Visual Studio for Mac.
author: heiligerdankgesang
ms.author: dominicn
ms.date: 05/06/2018
ms.assetid: 49917483-28AA-4598-A847-71F1F2E0DCB5
---

# Version control

Version control is a system for managing files over many different versions, and - in software development - is generally contributed to by many developers. The principal purpose of any version control system (_VCS_) is to find a solution that enables all users to work on the codebase at the same time.

At the core of any version control system is a _repository_, which acts as the central data store for all the different files - similar to a file server. However, unlike a file server, the repository contains the entire history of the project and all revisions that have been made.

If the repository is the central data store, it is logical for each user to have a local store of the data, allowing them to work on it. This is called a _working copy_. In Visual Studio for Mac your working copy will appear just as any other local directory on your machine, allowing you to read from and write to any of the files. However, because Visual Studio for Mac has Version control system integration, you can use Subversion and Git without leaving the IDE.

Subversion is a centralized version control system, which means that there is a single server that contains all files and revisions from which users can check out any version of any file. When files are checked out from a remote Subversion repository, the user gets a snapshot of the repository at that point in time.

Git is a distributed version control system that allows teams to work on the same documents simultaneously. With Git there might be a single server that contains all the files, but the entire repository is cloned locally to your machine whenever a repository is checked out from this central source.

## Basic Concepts

Visual Studio for Mac provides support for both Git and Subversion version control systems. The following articles explore setting up Git and Subversion repositories through Visual Studio for Mac, as well as simple functionality such as reviewing, committing, and pushing changes.

* [Setting Up a Git Repository](set-up-git-repository.md)
* [Working with Git](working-with-git.md)
* [Setting Up a Subversion Repository](set-up-subversion-repository.md)
* [Working with Subversion](working-with-subversion.md)

## See also

* [Version control in Visual Studio (on Windows)](/visualstudio/version-control/)