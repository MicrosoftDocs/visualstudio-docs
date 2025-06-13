---
title: Source Control Plug-in Glossary
description: This article includes helpful terms and definitions that pertain to the Source Control Plug-in SDK documentation.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- glossary [Visual Studio SDK]
- source control plug-ins, glossary
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Source Control Plug-in Glossary

The following helpful terms and definitions pertain to the Source Control Plug-in SDK documentation.

## Definitions
 Checkin
 When a user makes changes to a working copy, a user must send changes from the working copy into the central source control repository. This creates a new revision of the file that is available to other users. This process is called a checkin.

 Checkout
 The act of requesting a working copy from the repository, informing the repository of your intent to modify it. A working copy reflects the state of the project as of the moment it is checked out.

 Client
 A program that uses the source code control system. For the purpose of this documentation, it is the Visual Studio IDE.

 Comment
 A message describing the changes that a user can attach to a revision when a source control operation is performed.

 Conflict
 A situation when two users try to check in changes to the same region of the same file. Typically, a merge must be performed.

 Directory
 A client-side local folder is referred to as a directory. This is the copy in which a user actually makes changes. There can be many working copies of a given project; generally each developer has his or her own copy.

 Get
 A get operation brings the user's working copy up to date with the repository copy. Unlike a checkout, a get is performed when the user simply needs the latest copy but intends to make no changes.

 History
 It is typically a summary of all checkouts, checkins, updates, tags, and releases done in the source control repository.

 IDE
 Generally refers to the Visual Studio Integrated Development Environment. However, it could also refer to other client environments that recognize the Source Control Plug-in API.

 Merge
 The process during which two or more source code files are combined to form a new file that incorporates all features from previous files. This concept is vital in version control where two or more developers work on files concurrently.

 Project
 A source control folder is often referred to as a project. This does not have any relationship with projects or solutions in Visual Studio.

 Plug-in
 A DLL that provides source control functionality by implementing the Source Control Plug-in API.

 Repository
 The master copy where a source control system stores a project's full revision history. Each project has exactly one repository.

 Revision
 A committed change in the history of a file or set of files. A revision is one snapshot in a continuously changing project.

## See also
- [Source Control Plug-ins](../extensibility/source-control-plug-ins.md)
