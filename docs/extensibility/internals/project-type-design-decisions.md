---
title: Project Type Design Decisions
description: Learn about the item, project file persistence, and commitment mechanic design decisions to make before you extend Visual Studio by creating a new project type.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- project types, project file persistence
- project types, commitment mechanics
- project types, items
- project types, design decisions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Type Design Decisions

Before you create a new project type, you must make several design decisions regarding your project type. You must decide what types of items your projects will contain, how project files will be persisted, and what commitment model you will use.

## Project Items
 Will your project use files or abstract objects? If you use files, will they be reference-based or directory-based files? Are the files or abstract objects going to be local or remote?

 The items in a project can be files, or they can be more abstract objects such as objects in a database repository or data connections across the Internet. If the items are files, the project can be either a reference-based or a directory-based project.

 In reference-based projects, items can appear in more than one project. However, the actual file that an item represents is located in one directory only. In directory-based projects, all project items exist in the directory structure.

 Local items are stored on the same computer where the application is installed. Remote items can be stored on a separate server in a local network, or elsewhere on the Internet.

## Project File Persistence
 Will data be stored in common flat file systems, or in structured storage? Will files be opened by using a standard editor, or a project-specific editor?

 To persist their data, most applications save their data in a file, and then read it back when a user must review or change the information.

 Structured storage, also called compound files, is ordinarily used when several Component Object Model (COM) objects need to store their persisted data in a single file. With structured storage, several different software components can share a single disk file.

 You have several options to consider regarding persistence for the items in your project. You can perform any one of the following options:

- Save each file individually when it has been changed.

- Capture many transactions in a single **Save** operation.

- Save files locally, and then publish to a server or use another approach to saving project items when the item represents a data connection to a remote object.

  For more information about persistence, see [Project Persistence](../../extensibility/internals/project-persistence.md) and [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md).

## Project Commitment Model
 Will persisted data objects be opened in direct mode or transacted mode?

 When data objects are opened in direct mode, changes that were made to the data are incorporated immediately or when the user manually saves the file.

 When data objects are opened by using transacted mode, changes are saved to a temporary location in memory and are not committed until the user manually chooses to save the file. At that time, all changes must occur together or no changes will be made.

## Related content
- [Checklist: Creating New Project Types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md)
- [Project Persistence](../../extensibility/internals/project-persistence.md)
- [Elements of a Project Model](../../extensibility/internals/elements-of-a-project-model.md)
- [Project Model Core Components](../../extensibility/internals/project-model-core-components.md)
- [Creating Project Types](../../extensibility/internals/creating-project-types.md)
