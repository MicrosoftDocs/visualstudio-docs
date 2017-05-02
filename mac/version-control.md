---
title: Version Control
description: Using Git and Subversion in Visual Studio for Mac.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 49917483-28AA-4598-A847-71F1F2E0DCB5
---

# Version Control

Version control is a system of managing files over many different versions, and – in software development – is generally contributed to by many developers. The principal purpose of any version control system (_VCS_) is to find a solution that enables all users to read and write to files simultaneously.

At the core of any version control system is a _repository_, which acts as the central data store for all the different files – similar to a file server. However, unlike a file server, the repository contains the entire history of the project and all revisions that have been made.

If the repository is the central data store, it is logical for each user to have a local store of the data, allowing them to work on it. This is called a _working copy_. In Visual Studio for Mac your working copy will appear just as any other local directory on your machine, allowing you to read and write from any of the files. However, because Visual Studio for Mac has Version control system integration, you can leverage the power of Subversion and Git without leaving the IDE.

Subversion is a centralized version control system. This means that there is a single server that contains all files and revisions from which users can check out any version of any file. When files are checked out from a remote Subversion repository, the user will get a snapshot of the repo at that particular point in time.

Git is a distributed version control system that allows teams to work on the same documents simultaneously. This means that there is a single server that contains all the files, but whenever a repository is checked out from this central source, the entire repository is cloned locally to your machine.

# Basic Concepts 

Visual Studio for Mac provides support for both Git and Subversion version control systems. The guides linked below explore setting up Git and Subversion repositories through Visual Studio for Mac, and also simple functionality such as reviewing, committing, and pushing changes.

* [Setting Up a Git Repository](~/set-up-git-repository.md) 
* [Working with Git](~/working-with-git.md)
* [Setting Up a Subversion Repository](~/set-up-subversion-repository.md)
* [Working with Subversion](~/working-with-subversion.md)