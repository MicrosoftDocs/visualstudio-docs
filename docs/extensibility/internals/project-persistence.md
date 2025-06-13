---
title: Project Persistence
description: Learn about persistence in the design of your project, including the use of IPersistFileFormat to persist both file and non-file-based project objects.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- persistence, projects
- projects [Visual Studio SDK], persistance
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Persistence

Persistence is a key design consideration for your project. Most projects use project items that represent files; Visual Studio also supports projects whose data is non-file-based. Both the files owned by the project and the project file must be persisted. The IDE instructs the project to save itself or a project item.

 Templates for projects are passed to the project factory. The templates should support the initialization of all project items according to the requirements of the specific project type. These templates can later be saved as project files and managed by the IDE through the solution. For more information, see [Creating Project Instances By Using Project Factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md) and [Solutions](../../extensibility/internals/solutions-overview.md).

 Project items can be file-based or non-file-based:

- File-based items can be local or remote. In Web projects in C#, for example, connections to files on a remote system persist locally, whereas the files themselves persist on the remote system.

- Non-file-based items can save items to a database or repository.

## Commit Models
 After deciding where the project items are located, you must choose the appropriate commit model. For example, in a file-based model with local files, each project can be saved autonomously. In a repository model, you can save several items in one transaction. For more information, see [Project Type Design Decisions](../../extensibility/internals/project-type-design-decisions.md).

 To determine file name extensions, projects implement the <xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat> interface, which provides information enabling the client of an object to implement the **Save As** dialog box—that is, to fill in the **Save As Type** drop-down list and manage the initial file name extension.

 The IDE calls the `IPersistFileFormat` interface on the project to indicate that the project should persist its project items as appropriate. Therefore, the object owns all aspects of its file and format. This includes the name of the format of the object.

 In the case where items are not files, `IPersistFileFormat` is still how non-file-based items are persisted. Project files, such as .vbp files for Visual Basic projects or .vcproj files for Visual C++ projects, must also be persisted.

 For save actions, the IDE examines the running document table (RDT) and the hierarchy passes the commands to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem> and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2> interfaces. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem.IsItemDirty%2A> method is implemented to determine whether the item has been modified. If the item has, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem.SaveItem%2A> method is implemented to save the modified item.

 The methods on the `IVsPersistHierarchyItem2` interface are used to determine whether an item can be reloaded and, if the item can be, to reload it. Additionally, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2.IgnoreItemFileChanges%2A> method can be implemented to cause changed items to be discarded without being saved.

## See also
- [Checklist: Creating New Project Types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Creating Project Instances By Using Project Factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md)
